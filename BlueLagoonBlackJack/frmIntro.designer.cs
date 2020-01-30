namespace BlueLagoonBlackJack
{
    partial class frmIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntro));
            this.imgIntroBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgIntroBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // imgIntroBackground
            // 
            this.imgIntroBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imgIntroBackground.BackgroundImage = global::BlueLagoonBlackJack.Properties.Resources.logo2;
            this.imgIntroBackground.Location = new System.Drawing.Point(0, 1);
            this.imgIntroBackground.Name = "imgIntroBackground";
            this.imgIntroBackground.Size = new System.Drawing.Size(504, 337);
            this.imgIntroBackground.TabIndex = 0;
            this.imgIntroBackground.TabStop = false;
            this.imgIntroBackground.Click += new System.EventHandler(this.imgIntroBackground_Click);
            this.imgIntroBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgIntroBackground_MouseMove);
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 339);
            this.Controls.Add(this.imgIntroBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lagoon Black Jack";
            ((System.ComponentModel.ISupportInitialize)(this.imgIntroBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIntroBackground;
    }
}

