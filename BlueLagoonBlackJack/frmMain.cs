using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlueLagoonBlackJack
{
    public partial class frmMain : Form
    {
        //Global declarations
        protected int deckSize = 2;                 //Set to 2 decks by default
        protected int numberOfComputerUsers = 0;    //Set to 0 by default
        List<int> human = new List<int>();          //New Player
        List<int> dealer = new List<int>();
        List<PictureBox> newCardList = new List<PictureBox>();
        Deck deck = new Deck(DEFAULT_DECK_SIZE);
        bool playerStop = false;
        bool playerBust = false;
        bool dealerStay = false;
        string hitCheck;
        int cardIndex = 0;
        int[] cardsIssued = new int[8];             //Counts how many cards each player has been issued (dealer, human, any AI players)

        const int BLACKJACK = 21;                   //Winning score
        const int DEALER_HIT = 17;                  //Score dealer will stop hitting on
        const int DEFAULT_DECK_SIZE = 2;            //Default deck size on load

        //Used to calculate location of new picturebox objects
        protected int previousDealerCards = 2;
        protected int previousDealerCardLeft = 0;
        protected int previousDealerCardTop = 0;
        protected int previousHumanCards = 2;
        protected int previousHumanCardLeft = 0;
        protected int previousHumanCardTop = 0;
        protected int cardHeight = 0;
        protected int cardWidth = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuHowTo_Click(object sender, EventArgs e)
        {
            //Show frmHelp
            frmHelp frmShowHelp = new frmHelp();
            frmShowHelp.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //Show frmAbout
            frmAbout frmShowAbout = new frmAbout();
            frmShowAbout.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Exit program
            Application.Exit();
        }

        private void mnu2Decks_Click(object sender, EventArgs e)
        {
            if (mnu2Decks.Checked == true)
            {
                deckSize = 2;   //Set deck size to 2 decks

                //Uncheck any other deck options
                mnu4Decks.Checked = false;
                mnu6Decks.Checked = false;
                mnu8Decks.Checked = false;
            }
        }

        private void mnu4Decks_Click(object sender, EventArgs e)
        {
            if (mnu4Decks.Checked == true)
            {
                deckSize = 4;   //Set deck size to 4 decks

                //Uncheck any other deck options
                mnu2Decks.Checked = false;
                mnu6Decks.Checked = false;
                mnu8Decks.Checked = false;
            }
        }

        private void mnu6Decks_Click(object sender, EventArgs e)
        {
            if (mnu6Decks.Checked == true)
            {
                deckSize = 6;   //Set deck size to 6 decks

                //Uncheck any other deck options
                mnu2Decks.Checked = false;
                mnu4Decks.Checked = false;
                mnu8Decks.Checked = false;
            }
        }

        private void mnu8Decks_Click(object sender, EventArgs e)
        {
            if (mnu8Decks.Checked == true)
            {
                deckSize = 8;   //Set deck size to 8 decks

                //Uncheck any other deck options
                mnu2Decks.Checked = false;
                mnu4Decks.Checked = false;
                mnu6Decks.Checked = false;
            }
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            //Local Declarations
            const int PAUSE_BETWEEN_CARDS = 100;

            //Clear the table - if not clear already
            if (picDealer1.Visible)
            {
                picDealer1.Visible = false;
                picDealer2.Visible = false;
                picHuman1.Visible = false;
                picHuman2.Visible = false;
                btnHit.Visible = false;
                lblMessage.Text = "";
                label1.Text = "";
               

                //Remove any picture controls created during gameplay
                for (int resetCardImages = 0; resetCardImages < newCardList.Count; resetCardImages++)
                {
                    this.Controls.Remove(newCardList[resetCardImages]);
                }

                //Reset newCardList
                newCardList.Clear();

                for (int resetCardsIssued = 0; resetCardsIssued < cardsIssued.Length; resetCardsIssued++)
                {
                    cardsIssued[resetCardsIssued] = 0;
                }

                System.Threading.Thread.Sleep(PAUSE_BETWEEN_CARDS);
            }

            //Create/Shuffle new deck using deckSize settings
            deck = new Deck(deckSize);
            deck.Shuffle();

            //Deal 2 cards to dealer
            dealer.Add(cardIndex);
            cardIndex++;
            dealer.Add(cardIndex);
            cardIndex++;
            cardsIssued[0] = 1;             //1st Card = 0, 2nd = 1, etc

            //Display card image for Dealer cards
            displayCard(picDealer1);
            displayCard(picDealer2, deck.GetCard(dealer[1]).suit.ToString(), deck.GetCard(dealer[1]).rank.ToString());



            //Deal 2 cards to human player
            human.Add(cardIndex);
            cardIndex++;
            human.Add(cardIndex);
            cardIndex++;
            cardsIssued[1] = 1;             //1st Card = 0, 2nd = 1, etc

            //Display card image for 1st human card
            displayCard(picHuman1, deck.GetCard(human[0]).suit.ToString(), deck.GetCard(human[0]).rank.ToString());
            //Display card image for 2nd human card
            displayCard(picHuman2, deck.GetCard(human[1]).suit.ToString(), deck.GetCard(human[1]).rank.ToString());


            //Make dealer's hand visable
            picDealer1.Visible = true;
            System.Threading.Thread.Sleep(PAUSE_BETWEEN_CARDS);
            picDealer2.Visible = true;
            System.Threading.Thread.Sleep(PAUSE_BETWEEN_CARDS);

            //Make human player's hand visable
            picHuman1.Visible = true;
            System.Threading.Thread.Sleep(PAUSE_BETWEEN_CARDS);
            picHuman2.Visible = true;
            System.Threading.Thread.Sleep(PAUSE_BETWEEN_CARDS);

            //Used to calculate where to place next card object if user "Hits"
            previousDealerCardLeft = picDealer2.Left;
            previousDealerCardTop = picDealer2.Top;
            previousHumanCardLeft = picHuman2.Left;
            previousHumanCardTop = picHuman2.Top;
            cardHeight = picHuman2.Height;
            cardWidth = picHuman2.Width;

            //Show player options
            btnHit.Visible = true;
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            btnStand.Visible = true;
            // btnHit.Top = previousHumanCardTop + cardHeight + 26;

        }

        private void mnuNoAI_Click(object sender, EventArgs e)
        {
            //Set number of AI users to 0
            numberOfComputerUsers = 0;

            //Uncheck any other AI player options in menu
            mnu1AI.Checked = false;
            mnu2AI.Checked = false;
            mnu3AI.Checked = false;
            mnu4AI.Checked = false;
            mnu5AI.Checked = false;
            mnu6AI.Checked = false;
        }

        private void mnu1AI_Click(object sender, EventArgs e)
        {
            //Set number of AI users to 1
            numberOfComputerUsers = 1;

            //Uncheck any other AI player options in menu
            mnuNoAI.Checked = false;
            mnu2AI.Checked = false;
            mnu3AI.Checked = false;
            mnu4AI.Checked = false;
            mnu5AI.Checked = false;
            mnu6AI.Checked = false;
        }

        private void mnu2AI_Click(object sender, EventArgs e)
        {
            //Set number of AI users to 2
            numberOfComputerUsers = 2;

            //Uncheck any other AI player options in menu
            mnuNoAI.Checked = false;
            mnu1AI.Checked = false;
            mnu3AI.Checked = false;
            mnu4AI.Checked = false;
            mnu5AI.Checked = false;
            mnu6AI.Checked = false;
        }

        private void mnu3AI_Click(object sender, EventArgs e)
        {
            //Set number of AI users to 3
            numberOfComputerUsers = 3;

            //Uncheck any other AI player options in menu
            mnuNoAI.Checked = false;
            mnu1AI.Checked = false;
            mnu2AI.Checked = false;
            mnu4AI.Checked = false;
            mnu5AI.Checked = false;
            mnu6AI.Checked = false;
        }

        private void mnu4AI_Click(object sender, EventArgs e)
        {
            //Set number of AI users to 4
            numberOfComputerUsers = 4;

            //Uncheck any other AI player options in menu
            mnuNoAI.Checked = false;
            mnu1AI.Checked = false;
            mnu2AI.Checked = false;
            mnu3AI.Checked = false;
            mnu5AI.Checked = false;
            mnu6AI.Checked = false;
        }

        private void mnu5AI_Click(object sender, EventArgs e)
        {
            //Set number of AI users to 5
            numberOfComputerUsers = 5;

            //Uncheck any other AI player options in menu
            mnuNoAI.Checked = false;
            mnu1AI.Checked = false;
            mnu2AI.Checked = false;
            mnu3AI.Checked = false;
            mnu4AI.Checked = false;
            mnu6AI.Checked = false;
        }

        private void mnu6AI_Click(object sender, EventArgs e)
        {
            //Set number of AI users to 6
            numberOfComputerUsers = 6;

            //Uncheck any other AI player options in menu
            mnuNoAI.Checked = false;
            mnu1AI.Checked = false;
            mnu2AI.Checked = false;
            mnu3AI.Checked = false;
            mnu4AI.Checked = false;
            mnu5AI.Checked = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Make sure program ends when this form is closed
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnStand.Visible = false;
        }

        //Function to display card image - uses picturebox name, suit, and rank
        private void displayCard(PictureBox picCard, String suit, String rank)
        {
            //Local declarations
            const String IMAGE_PATH = "..\\..\\Resources\\";
            const String IMAGE_EXTENSION = ".png";

            //Display card image
            String cardImage = IMAGE_PATH + suit + rank + IMAGE_EXTENSION;
            picCard.Image = Image.FromFile(cardImage);
        }

        //Function to display card backing image
        private void displayCard(PictureBox picCard)
        {
            //Local declarations
            const String IMAGE_NAME = "..\\..\\Resources\\redvert.png";

            //Display card image
            String cardImage = IMAGE_NAME;
            picCard.Image = Image.FromFile(cardImage);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            const int BLACKJACK = 21;
            const String JACK = "Jack";
            const String QUEEN = "Queen";
            const String KING = "King";
            const String MESSAGE_BLACKJACK = "BlackJack!";
            const String MESSAGE_21 = "21!";
            const String MESSAGE_BUST = "Bust!";

            String cardOne = deck.GetCard(human[0]).rank.ToString();
            String cardTwo = deck.GetCard(human[1]).rank.ToString();

            //Add another card to the player's hand
            human.Add(cardIndex);
            cardIndex++;
            cardsIssued[1]++;

            //Increment counter for new card's Left property
            previousHumanCardLeft = previousHumanCardLeft + 26;

            //Create a new picturebox object
            PictureBox picNewCard = new PictureBox
            {
                Name = "picNewCard" + cardIndex,
                Size = new Size(cardWidth, cardHeight),
                Location = new Point(previousHumanCardLeft, previousHumanCardTop),
                BorderStyle = BorderStyle.None,
                SizeMode = PictureBoxSizeMode.Normal
            };

            //Add new picture object to list
            newCardList.Add(picNewCard);

            //TESTING:
            label1.Text = deck.GetCard(human[cardsIssued[1]]).suit.ToString() + deck.GetCard(human[cardsIssued[1]]).rank.ToString();

            //Display card image
            displayCard(newCardList[newCardList.Count - 1], deck.GetCard(human[cardsIssued[1]]).suit.ToString(), deck.GetCard(human[cardsIssued[1]]).rank.ToString());

            //Add picture object to the form and bring to front
            this.Controls.Add(newCardList[newCardList.Count - 1]);
            newCardList[newCardList.Count - 1].BringToFront();

            //Check hand value - if player busts no more cards issued  
            if (isBlackJack(cardsIssued[1] + 1, deck.getValue(ref human)))
            {                                                   //If score = 21 & 2 cards issued (BlackJack)
                btnHit.Enabled = false;
                //if split == no: payout 3:2 / if split = yes: payout 1:1
                lblMessage.Text = MESSAGE_BLACKJACK;
            }
            else if (deck.getValue(ref human) == BLACKJACK)     //Check for score of 21 (A win but not technical blackjack)
            {
                btnHit.Enabled = false;
                //payout 1:1
                lblMessage.Text = MESSAGE_21;
            }
            else if (isHandBust(deck.getValue(ref human)))
            {
                btnHit.Enabled = false;
                btnStand.Enabled = false;
                //payout 0
                lblMessage.Text = MESSAGE_BUST;
            }
        }

        private Boolean isHandBust(int score)
        {
            const int MAX_POINTS = 21;

            return (score > MAX_POINTS);
        }

        private Boolean isWin(int playerScore, int dealerScore)
        {
            return (playerScore > dealerScore && !isHandBust(playerScore)) ? true : false;
        }

        private Boolean isPush(int playerScore, int dealerScore)
        {
            return (playerScore == dealerScore && !isHandBust(playerScore)) ? true : false;
        }

        private Boolean isBlackJack(int cardsInHand, int score)
        {
            const int MIN_CARDS_IN_HAND = 2;
            const int WINNING_SCORE = 21;

            return (cardsInHand == MIN_CARDS_IN_HAND && score == WINNING_SCORE) ? true : false;
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            //Disable hand options for this hand
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            //Allow the dealer to finish hand
            dealerHand();
        }

        private Boolean dealerStand(int score)
        {
            const int DEALER_HIT = 17;

            return ((deck.getValue(ref dealer) >= DEALER_HIT) && !deck.isSoft(ref dealer)) ? true : false;
        }

        private void dealerHand()
        {
            //Local declarations
            const String DEALER_BLACKJACK = "Dealer BlackJack!";
            const int PAUSE_BETWEEN_CARDS = 500;


            //Display image for dealer's first card
            displayCard(picDealer1, deck.GetCard(dealer[0]).suit.ToString(), deck.GetCard(dealer[0]).rank.ToString());

            //Check for blackjack 
            if (isBlackJack(cardsIssued[0] + 1, deck.getValue(ref dealer)))
            {                                                   //If score = 21 & 2 cards issued (BlackJack)
                dealerStay = true;
                //will not effect payout for players with BlackJack - otherwise everyone loses
                lblMessage.Text = DEALER_BLACKJACK;
            }

            //TESTING:
            label1.Text = (dealerStand(deck.getValue(ref dealer))).ToString();

            //Dealer hits until hard 17 or higher
            while (!dealerStand(deck.getValue(ref dealer)))
            {
                //Add a new card to the dealer's hand
                dealer.Add(cardIndex);
                cardIndex++;

                //Testing:
                label1.Text = "New card added to dealer hand";

                //Create a new picturebox object
                PictureBox picNewCard = new PictureBox
                {
                    Name = "picNewCard" + cardIndex,
                    Size = new Size(cardWidth, cardHeight),
                    Location = new Point(previousDealerCardLeft, previousDealerCardTop),
                    BorderStyle = BorderStyle.None,
                    SizeMode = PictureBoxSizeMode.Normal
                };

                //Testing:
                label1.Text = "New picture object created";

                //Add new picture object to list
                newCardList.Add(picNewCard);

                //Set card image
                displayCard(newCardList[newCardList.Count - 1], deck.GetCard(dealer[cardsIssued[0]]).suit.ToString(), deck.GetCard(dealer[cardsIssued[0]]).rank.ToString());

                //Add picture object to the form and bring to front
                this.Controls.Add(newCardList[newCardList.Count - 1]);
                newCardList[newCardList.Count - 1].BringToFront();

                //Testing:
                label1.Text = "New card picture should be on screen";

                //Pause between cards for dramatic effect
                //System.Threading.Thread.Sleep(PAUSE_BETWEEN_CARDS);

            }

        }
    }
}