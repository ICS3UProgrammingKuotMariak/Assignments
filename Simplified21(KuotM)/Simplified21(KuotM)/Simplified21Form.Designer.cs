namespace Simplified21_KuotM_
{
    partial class frmSimplified21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimplified21));
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.mnuBlackJack = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniJazzy = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCasinoNight = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblDealerCard1 = new System.Windows.Forms.Label();
            this.lblDealerCard2 = new System.Windows.Forms.Label();
            this.lblDealerCard3 = new System.Windows.Forms.Label();
            this.lblUserCard2 = new System.Windows.Forms.Label();
            this.lblUserCard3 = new System.Windows.Forms.Label();
            this.lblUserCard1 = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picMusic = new System.Windows.Forms.PictureBox();
            this.mnuBlackJack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHit.Location = new System.Drawing.Point(59, 184);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(101, 44);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStay.Location = new System.Drawing.Point(438, 185);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(103, 43);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // mnuBlackJack
            // 
            this.mnuBlackJack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniMusic});
            this.mnuBlackJack.Location = new System.Drawing.Point(0, 0);
            this.mnuBlackJack.Name = "mnuBlackJack";
            this.mnuBlackJack.Size = new System.Drawing.Size(604, 24);
            this.mnuBlackJack.TabIndex = 2;
            this.mnuBlackJack.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(132, 22);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.mniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(132, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniMusic
            // 
            this.mniMusic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniJazzy,
            this.mniCasinoNight});
            this.mniMusic.Name = "mniMusic";
            this.mniMusic.Size = new System.Drawing.Size(48, 20);
            this.mniMusic.Text = "Musc";
            // 
            // mniJazzy
            // 
            this.mniJazzy.Name = "mniJazzy";
            this.mniJazzy.Size = new System.Drawing.Size(176, 22);
            this.mniJazzy.Text = "OldSchool Jazzy";
            this.mniJazzy.Click += new System.EventHandler(this.mniJazzy_Click);
            // 
            // mniCasinoNight
            // 
            this.mniCasinoNight.Name = "mniCasinoNight";
            this.mniCasinoNight.Size = new System.Drawing.Size(176, 22);
            this.mniCasinoNight.Text = "Night at the Casino";
            this.mniCasinoNight.Click += new System.EventHandler(this.mniCasinoNight_Click);
            // 
            // lblUserScore
            // 
            this.lblUserScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserScore.BackColor = System.Drawing.Color.Transparent;
            this.lblUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.Location = new System.Drawing.Point(251, 220);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(116, 26);
            this.lblUserScore.TabIndex = 3;
            this.lblUserScore.Text = "You:";
            this.lblUserScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.Location = new System.Drawing.Point(251, 167);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(98, 27);
            this.lblDealerScore.TabIndex = 4;
            this.lblDealerScore.Text = "Dealer:";
            this.lblDealerScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDealerCard1
            // 
            this.lblDealerCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDealerCard1.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard1.Location = new System.Drawing.Point(176, 111);
            this.lblDealerCard1.Name = "lblDealerCard1";
            this.lblDealerCard1.Size = new System.Drawing.Size(60, 57);
            this.lblDealerCard1.TabIndex = 5;
            this.lblDealerCard1.Text = "21";
            this.lblDealerCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDealerCard2
            // 
            this.lblDealerCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDealerCard2.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard2.Location = new System.Drawing.Point(273, 92);
            this.lblDealerCard2.Name = "lblDealerCard2";
            this.lblDealerCard2.Size = new System.Drawing.Size(59, 61);
            this.lblDealerCard2.TabIndex = 6;
            this.lblDealerCard2.Text = "21";
            this.lblDealerCard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDealerCard3
            // 
            this.lblDealerCard3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDealerCard3.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard3.Location = new System.Drawing.Point(375, 111);
            this.lblDealerCard3.Name = "lblDealerCard3";
            this.lblDealerCard3.Size = new System.Drawing.Size(60, 57);
            this.lblDealerCard3.TabIndex = 7;
            this.lblDealerCard3.Text = "21";
            this.lblDealerCard3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserCard2
            // 
            this.lblUserCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserCard2.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCard2.Location = new System.Drawing.Point(273, 263);
            this.lblUserCard2.Name = "lblUserCard2";
            this.lblUserCard2.Size = new System.Drawing.Size(62, 76);
            this.lblUserCard2.TabIndex = 8;
            this.lblUserCard2.Text = "21";
            this.lblUserCard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserCard3
            // 
            this.lblUserCard3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserCard3.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCard3.Location = new System.Drawing.Point(373, 239);
            this.lblUserCard3.Name = "lblUserCard3";
            this.lblUserCard3.Size = new System.Drawing.Size(62, 76);
            this.lblUserCard3.TabIndex = 9;
            this.lblUserCard3.Text = "21";
            this.lblUserCard3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserCard1
            // 
            this.lblUserCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserCard1.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCard1.Location = new System.Drawing.Point(174, 239);
            this.lblUserCard1.Name = "lblUserCard1";
            this.lblUserCard1.Size = new System.Drawing.Size(62, 76);
            this.lblUserCard1.TabIndex = 10;
            this.lblUserCard1.Text = "21";
            this.lblUserCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBet
            // 
            this.txtBet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBet.Location = new System.Drawing.Point(242, 197);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(144, 20);
            this.txtBet.TabIndex = 12;
            // 
            // btnBet
            // 
            this.btnBet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(174, 189);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(62, 33);
            this.btnBet.TabIndex = 13;
            this.btnBet.Text = "Bet:";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(59, 135);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(101, 43);
            this.btnPlay.TabIndex = 14;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // picMusic
            // 
            this.picMusic.BackColor = System.Drawing.Color.Transparent;
            this.picMusic.Image = global::Simplified21_KuotM_.Properties.Resources.mute;
            this.picMusic.Location = new System.Drawing.Point(494, 40);
            this.picMusic.Name = "picMusic";
            this.picMusic.Size = new System.Drawing.Size(66, 49);
            this.picMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMusic.TabIndex = 15;
            this.picMusic.TabStop = false;
            this.picMusic.Click += new System.EventHandler(this.picMusic_Click);
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simplified21_KuotM_.Properties.Resources.BlackJack_Table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.picMusic);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblUserCard1);
            this.Controls.Add(this.lblUserCard3);
            this.Controls.Add(this.lblUserCard2);
            this.Controls.Add(this.lblDealerCard3);
            this.Controls.Add(this.lblDealerCard2);
            this.Controls.Add(this.lblDealerCard1);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.mnuBlackJack);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuBlackJack;
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21";
            this.Load += new System.EventHandler(this.frmSimplified21_Load);
            this.mnuBlackJack.ResumeLayout(false);
            this.mnuBlackJack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.MenuStrip mnuBlackJack;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblDealerCard1;
        private System.Windows.Forms.Label lblDealerCard2;
        private System.Windows.Forms.Label lblDealerCard3;
        private System.Windows.Forms.Label lblUserCard2;
        private System.Windows.Forms.Label lblUserCard3;
        private System.Windows.Forms.Label lblUserCard1;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ToolStripMenuItem mniMusic;
        private System.Windows.Forms.ToolStripMenuItem mniJazzy;
        private System.Windows.Forms.ToolStripMenuItem mniCasinoNight;
        private System.Windows.Forms.PictureBox picMusic;
    }
}

