namespace s1131527_wordcards
{
    partial class frmWordCards
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
            this.components = new System.ComponentModel.Container();
            this.timPlayer = new System.Windows.Forms.Timer(this.components);
            this.sssWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.palMain = new System.Windows.Forms.Panel();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.sssWord.SuspendLayout();
            this.palMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timPlayer
            // 
            this.timPlayer.Interval = 2000;
            // 
            // sssWord
            // 
            this.sssWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(221)))), ((int)(((byte)(239)))));
            this.sssWord.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.sssWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.sssWord.Location = new System.Drawing.Point(0, 619);
            this.sssWord.Name = "sssWord";
            this.sssWord.Size = new System.Drawing.Size(1421, 40);
            this.sssWord.TabIndex = 0;
            this.sssWord.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.ForeColor = System.Drawing.Color.Red;
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(115, 30);
            this.tsslMessage.Text = "Messege";
            // 
            // lstWordList
            // 
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 37;
            this.lstWordList.Location = new System.Drawing.Point(0, 0);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(288, 619);
            this.lstWordList.TabIndex = 1;
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.palMain.Controls.Add(this.btnAutoPlay);
            this.palMain.Controls.Add(this.picLogo);
            this.palMain.Controls.Add(this.txtHelp);
            this.palMain.Controls.Add(this.txtExplain);
            this.palMain.Controls.Add(this.txtPhonogram);
            this.palMain.Controls.Add(this.txtWord);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(288, 0);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(1133, 619);
            this.palMain.TabIndex = 2;
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Font = new System.Drawing.Font("Microsoft JhengHei", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtWord.Location = new System.Drawing.Point(28, 37);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(487, 100);
            this.txtWord.TabIndex = 0;
            this.txtWord.Text = "abacus";
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonogram.Font = new System.Drawing.Font("Microsoft JhengHei", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhonogram.ForeColor = System.Drawing.Color.Green;
            this.txtPhonogram.Location = new System.Drawing.Point(28, 143);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(487, 50);
            this.txtPhonogram.TabIndex = 1;
            this.txtPhonogram.Text = "ˋæbəkəs";
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExplain.Location = new System.Drawing.Point(28, 208);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(825, 371);
            this.txtExplain.TabIndex = 2;
            this.txtExplain.Text = "<aba-=abax-:一種計算工具>+<-us: calculus 小圓石>\r\n\r\n\r\n";
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.ForeColor = System.Drawing.Color.Red;
            this.txtHelp.Location = new System.Drawing.Point(888, 480);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(221, 99);
            this.txtHelp.TabIndex = 3;
            this.txtHelp.Text = "Enter 下一個\r\nSpace 重複";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::s1131527_wordcards.Properties.Resources.WordCards_Logo;
            this.picLogo.Location = new System.Drawing.Point(888, 28);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(201, 244);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPlay.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoPlay.Location = new System.Drawing.Point(888, 302);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(200, 56);
            this.btnAutoPlay.TabIndex = 5;
            this.btnAutoPlay.Text = "Play";
            this.btnAutoPlay.UseVisualStyleBackColor = true;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // frmWordCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 659);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.lstWordList);
            this.Controls.Add(this.sssWord);
            this.KeyPreview = true;
            this.Name = "frmWordCards";
            this.Text = "單字卡";
            this.sssWord.ResumeLayout(false);
            this.sssWord.PerformLayout();
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timPlayer;
        private System.Windows.Forms.StatusStrip sssWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.ListBox lstWordList;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Button btnAutoPlay;
    }
}

