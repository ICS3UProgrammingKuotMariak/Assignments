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
            this.mnuBlackJack.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(36, 156);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(121, 44);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(515, 156);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(126, 44);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            // 
            // mnuBlackJack
            // 
            this.mnuBlackJack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuBlackJack.Location = new System.Drawing.Point(0, 0);
            this.mnuBlackJack.Name = "mnuBlackJack";
            this.mnuBlackJack.Size = new System.Drawing.Size(685, 24);
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
            this.mniNewGame.Size = new System.Drawing.Size(152, 22);
            this.mniNewGame.Text = "New Game";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 419);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.mnuBlackJack);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuBlackJack;
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21";
            this.mnuBlackJack.ResumeLayout(false);
            this.mnuBlackJack.PerformLayout();
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
    }
}

