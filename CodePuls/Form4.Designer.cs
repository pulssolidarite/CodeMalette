namespace CodePuls
{
    partial class Form4
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
            this.tmrVideo = new System.Windows.Forms.Timer(this.components);
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.carousel2 = new System.Windows.Forms.Panel();
            this.carousel1 = new System.Windows.Forms.Panel();
            this.tmrThumb = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlVideo
            // 
            this.pnlVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlVideo.BackColor = System.Drawing.Color.Transparent;
            this.pnlVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlVideo.Location = new System.Drawing.Point(288, 202);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(385, 244);
            this.pnlVideo.TabIndex = 0;
            this.pnlVideo.UseWaitCursor = true;
            // 
            // pnlPlay
            // 
            this.pnlPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPlay.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPlay.Location = new System.Drawing.Point(524, 133);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(582, 372);
            this.pnlPlay.TabIndex = 1;
            this.pnlPlay.UseWaitCursor = true;
            // 
            // carousel2
            // 
            this.carousel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carousel2.BackColor = System.Drawing.Color.Transparent;
            this.carousel2.BackgroundImage = global::CodePuls.Properties.Resources.petit_cercle;
            this.carousel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.carousel2.Location = new System.Drawing.Point(801, 511);
            this.carousel2.Name = "carousel2";
            this.carousel2.Size = new System.Drawing.Size(25, 25);
            this.carousel2.TabIndex = 1;
            this.carousel2.UseWaitCursor = true;
            // 
            // carousel1
            // 
            this.carousel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carousel1.BackColor = System.Drawing.Color.Transparent;
            this.carousel1.BackgroundImage = global::CodePuls.Properties.Resources.grand_cercle;
            this.carousel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.carousel1.Location = new System.Drawing.Point(770, 511);
            this.carousel1.Name = "carousel1";
            this.carousel1.Size = new System.Drawing.Size(25, 25);
            this.carousel1.TabIndex = 0;
            this.carousel1.UseWaitCursor = true;
            // 
            // tmrThumb
            // 
            this.tmrThumb.Tick += new System.EventHandler(this.TmrThumb_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CodePuls.Properties.Resources.texte;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 321);
            this.panel1.TabIndex = 2;
            this.panel1.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::CodePuls.Properties.Resources.logo_entrepreneur_du_monde;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(693, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 72);
            this.panel2.TabIndex = 3;
            this.panel2.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::CodePuls.Properties.Resources.fleche_bleu;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(30, 478);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 68);
            this.panel3.TabIndex = 4;
            this.panel3.UseWaitCursor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodePuls.Properties.Resources.fond_bleu2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1433, 1084);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPlay);
            this.Controls.Add(this.carousel2);
            this.Controls.Add(this.carousel1);
            this.Controls.Add(this.pnlVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoPlayer";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrVideo;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Panel carousel1;
        private System.Windows.Forms.Panel carousel2;
        private System.Windows.Forms.Timer tmrThumb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}