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
    public partial class frmIntro : Form
    {
        //Class wide declarations
        protected String hoverLocation = "Form";

        public frmIntro()
        {
            InitializeComponent();
        }

        private void imgIntroBackground_MouseMove(object sender, MouseEventArgs e)
        {
            //Start button co-ordinates
            const int START_BUTTON_LEFT = 325;
            const int START_BUTTON_RIGHT = 435;
            const int START_BUTTON_TOP = 190;
            const int START_BUTTON_BOTTOM = 245;

            //Quit button co-ordinates
            const int QUIT_BUTTON_LEFT = 35;
            const int QUIT_BUTTON_RIGHT = 135;
            const int QUIT_BUTTON_TOP = 265;
            const int QUIT_BUTTON_BOTTOM = 315;

            //Check if mouse is over start or quit buttons - change image accordingly
            if ((e.X >= START_BUTTON_LEFT && e.X <= START_BUTTON_RIGHT) && (e.Y >= START_BUTTON_TOP && e.Y <= START_BUTTON_BOTTOM))
            {
                //Change to highlighted start button image
                imgIntroBackground.BackgroundImage = BlueLagoonBlackJack.Properties.Resources.logo5;
                hoverLocation = "Start";
            }
            else if ((e.X >= QUIT_BUTTON_LEFT && e.X <= QUIT_BUTTON_RIGHT) && (e.Y >= QUIT_BUTTON_TOP && e.Y <= QUIT_BUTTON_BOTTOM))
            {
                //Change to highlighted quit button image
                imgIntroBackground.BackgroundImage = BlueLagoonBlackJack.Properties.Resources.logo6;
                hoverLocation = "Quit";
            }
            else
            {
                //Change to default image
                imgIntroBackground.BackgroundImage = BlueLagoonBlackJack.Properties.Resources.logo2;
                hoverLocation = "Form";
            }
        }

        private void imgIntroBackground_Click(object sender, EventArgs e)
        {
            //Check if mouse is over start or quit buttons - change image accordingly
            if (hoverLocation == "Start")
            {
                //Create form objects
                frmMain frmOpenMain = new frmMain();
                frmIntro frmCloseIntro = new frmIntro();

                //Open main form and close this one
                frmCloseIntro.Close();
                frmOpenMain.ShowDialog();
            }
            else if (hoverLocation == "Quit")
            {
                //End application
                Close();
            }
        }
    }
}
