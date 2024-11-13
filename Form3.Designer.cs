namespace prj_HeartspingAdventure
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            video_intro = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)video_intro).BeginInit();
            SuspendLayout();
            // 
            // video_intro
            // 
            video_intro.Enabled = true;
            video_intro.Location = new System.Drawing.Point(-3, 0);
            video_intro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            video_intro.Name = "video_intro";
            video_intro.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("video_intro.OcxState");
            video_intro.Size = new System.Drawing.Size(1126, 630);
            video_intro.TabIndex = 1;
            video_intro.PlayStateChange += MediaPlayer_PlayStateChange;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1440, 840);
            Controls.Add(video_intro);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "Form3";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "하츄핑의 모험!";
            ((System.ComponentModel.ISupportInitialize)video_intro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer video_intro;
    }
}