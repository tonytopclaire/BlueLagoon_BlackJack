namespace BlueLagoonBlackJack
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDecks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2Decks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu4Decks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu6Decks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu8Decks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNoAI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1AI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2AI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu3AI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu4AI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu5AI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu6AI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHowTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.picDealer1 = new System.Windows.Forms.PictureBox();
            this.picDealer2 = new System.Windows.Forms.PictureBox();
            this.picHuman1 = new System.Windows.Forms.PictureBox();
            this.picHuman2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnStand = new System.Windows.Forms.Button();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHuman1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHuman2)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuOptions,
            this.mnuHelp});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(860, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.Size = new System.Drawing.Size(180, 22);
            this.mnuNewGame.Text = "&New Game";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDecks,
            this.mnuPlayers});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "&Options";
            // 
            // mnuDecks
            // 
            this.mnuDecks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu2Decks,
            this.mnu4Decks,
            this.mnu6Decks,
            this.mnu8Decks});
            this.mnuDecks.Name = "mnuDecks";
            this.mnuDecks.Size = new System.Drawing.Size(180, 22);
            this.mnuDecks.Text = "&Decks";
            // 
            // mnu2Decks
            // 
            this.mnu2Decks.Checked = true;
            this.mnu2Decks.CheckOnClick = true;
            this.mnu2Decks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu2Decks.Name = "mnu2Decks";
            this.mnu2Decks.Size = new System.Drawing.Size(180, 22);
            this.mnu2Decks.Text = "2";
            this.mnu2Decks.Click += new System.EventHandler(this.mnu2Decks_Click);
            // 
            // mnu4Decks
            // 
            this.mnu4Decks.CheckOnClick = true;
            this.mnu4Decks.Name = "mnu4Decks";
            this.mnu4Decks.Size = new System.Drawing.Size(180, 22);
            this.mnu4Decks.Text = "4";
            this.mnu4Decks.Click += new System.EventHandler(this.mnu4Decks_Click);
            // 
            // mnu6Decks
            // 
            this.mnu6Decks.CheckOnClick = true;
            this.mnu6Decks.Name = "mnu6Decks";
            this.mnu6Decks.Size = new System.Drawing.Size(180, 22);
            this.mnu6Decks.Text = "6";
            this.mnu6Decks.Click += new System.EventHandler(this.mnu6Decks_Click);
            // 
            // mnu8Decks
            // 
            this.mnu8Decks.CheckOnClick = true;
            this.mnu8Decks.Name = "mnu8Decks";
            this.mnu8Decks.Size = new System.Drawing.Size(180, 22);
            this.mnu8Decks.Text = "8";
            this.mnu8Decks.Click += new System.EventHandler(this.mnu8Decks_Click);
            // 
            // mnuPlayers
            // 
            this.mnuPlayers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNoAI,
            this.mnu1AI,
            this.mnu2AI,
            this.mnu3AI,
            this.mnu4AI,
            this.mnu5AI,
            this.mnu6AI});
            this.mnuPlayers.Name = "mnuPlayers";
            this.mnuPlayers.Size = new System.Drawing.Size(180, 22);
            this.mnuPlayers.Text = "&Players";
            // 
            // mnuNoAI
            // 
            this.mnuNoAI.Checked = true;
            this.mnuNoAI.CheckOnClick = true;
            this.mnuNoAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuNoAI.Name = "mnuNoAI";
            this.mnuNoAI.Size = new System.Drawing.Size(180, 22);
            this.mnuNoAI.Text = "&None";
            this.mnuNoAI.Click += new System.EventHandler(this.mnuNoAI_Click);
            // 
            // mnu1AI
            // 
            this.mnu1AI.CheckOnClick = true;
            this.mnu1AI.Name = "mnu1AI";
            this.mnu1AI.Size = new System.Drawing.Size(180, 22);
            this.mnu1AI.Text = "1";
            this.mnu1AI.Click += new System.EventHandler(this.mnu1AI_Click);
            // 
            // mnu2AI
            // 
            this.mnu2AI.CheckOnClick = true;
            this.mnu2AI.Name = "mnu2AI";
            this.mnu2AI.Size = new System.Drawing.Size(180, 22);
            this.mnu2AI.Text = "2";
            this.mnu2AI.Click += new System.EventHandler(this.mnu2AI_Click);
            // 
            // mnu3AI
            // 
            this.mnu3AI.CheckOnClick = true;
            this.mnu3AI.Name = "mnu3AI";
            this.mnu3AI.Size = new System.Drawing.Size(180, 22);
            this.mnu3AI.Text = "3";
            this.mnu3AI.Click += new System.EventHandler(this.mnu3AI_Click);
            // 
            // mnu4AI
            // 
            this.mnu4AI.CheckOnClick = true;
            this.mnu4AI.Name = "mnu4AI";
            this.mnu4AI.Size = new System.Drawing.Size(180, 22);
            this.mnu4AI.Text = "4";
            this.mnu4AI.Click += new System.EventHandler(this.mnu4AI_Click);
            // 
            // mnu5AI
            // 
            this.mnu5AI.CheckOnClick = true;
            this.mnu5AI.Name = "mnu5AI";
            this.mnu5AI.Size = new System.Drawing.Size(180, 22);
            this.mnu5AI.Text = "5";
            this.mnu5AI.Click += new System.EventHandler(this.mnu5AI_Click);
            // 
            // mnu6AI
            // 
            this.mnu6AI.CheckOnClick = true;
            this.mnu6AI.Name = "mnu6AI";
            this.mnu6AI.Size = new System.Drawing.Size(180, 22);
            this.mnu6AI.Text = "6";
            this.mnu6AI.Click += new System.EventHandler(this.mnu6AI_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHowTo,
            this.toolStripMenuItem3,
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHowTo
            // 
            this.mnuHowTo.Name = "mnuHowTo";
            this.mnuHowTo.Size = new System.Drawing.Size(232, 22);
            this.mnuHowTo.Text = "How to &Play";
            this.mnuHowTo.Click += new System.EventHandler(this.mnuHowTo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(229, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(232, 22);
            this.mnuAbout.Text = "&About Blue Lagoon Black Jack";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // picDealer1
            // 
            this.picDealer1.Image = global::BlueLagoonBlackJack.Properties.Resources.redvert;
            this.picDealer1.Location = new System.Drawing.Point(48, 180);
            this.picDealer1.Name = "picDealer1";
            this.picDealer1.Size = new System.Drawing.Size(72, 96);
            this.picDealer1.TabIndex = 1;
            this.picDealer1.TabStop = false;
            this.picDealer1.Visible = false;
            // 
            // picDealer2
            // 
            this.picDealer2.Image = global::BlueLagoonBlackJack.Properties.Resources.redvert;
            this.picDealer2.Location = new System.Drawing.Point(177, 223);
            this.picDealer2.Name = "picDealer2";
            this.picDealer2.Size = new System.Drawing.Size(72, 96);
            this.picDealer2.TabIndex = 2;
            this.picDealer2.TabStop = false;
            this.picDealer2.Visible = false;
            // 
            // picHuman1
            // 
            this.picHuman1.Image = global::BlueLagoonBlackJack.Properties.Resources.redvert;
            this.picHuman1.Location = new System.Drawing.Point(12, 340);
            this.picHuman1.Name = "picHuman1";
            this.picHuman1.Size = new System.Drawing.Size(72, 96);
            this.picHuman1.TabIndex = 3;
            this.picHuman1.TabStop = false;
            this.picHuman1.Visible = false;
            // 
            // picHuman2
            // 
            this.picHuman2.Image = global::BlueLagoonBlackJack.Properties.Resources.redvert;
            this.picHuman2.Location = new System.Drawing.Point(48, 340);
            this.picHuman2.Name = "picHuman2";
            this.picHuman2.Size = new System.Drawing.Size(72, 96);
            this.picHuman2.TabIndex = 4;
            this.picHuman2.TabStop = false;
            this.picHuman2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(314, 413);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 6;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(674, 391);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(487, 413);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 8;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnHit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlueLagoonBlackJack.Properties.Resources.bg01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 468);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.picHuman2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDealer2);
            this.Controls.Add(this.picDealer1);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.picHuman1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lagoon Black Jack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHuman1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHuman2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuDecks;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayers;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnu2Decks;
        private System.Windows.Forms.ToolStripMenuItem mnu4Decks;
        private System.Windows.Forms.ToolStripMenuItem mnu6Decks;
        private System.Windows.Forms.ToolStripMenuItem mnu8Decks;
        private System.Windows.Forms.ToolStripMenuItem mnuNoAI;
        private System.Windows.Forms.ToolStripMenuItem mnu1AI;
        private System.Windows.Forms.ToolStripMenuItem mnu2AI;
        private System.Windows.Forms.ToolStripMenuItem mnu3AI;
        private System.Windows.Forms.ToolStripMenuItem mnu4AI;
        private System.Windows.Forms.ToolStripMenuItem mnu5AI;
        private System.Windows.Forms.ToolStripMenuItem mnu6AI;
        private System.Windows.Forms.ToolStripMenuItem mnuHowTo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.PictureBox picDealer1;
        private System.Windows.Forms.PictureBox picDealer2;
        private System.Windows.Forms.PictureBox picHuman1;
        private System.Windows.Forms.PictureBox picHuman2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnStand;
    }
}