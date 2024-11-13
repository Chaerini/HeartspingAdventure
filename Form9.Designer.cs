namespace prj_HeartspingAdventure
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            btn_save = new System.Windows.Forms.Button();
            btn_Exit = new System.Windows.Forms.Button();
            btn_Main = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = System.Drawing.Color.Transparent;
            btn_save.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_save.BackgroundImage");
            btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_save.Location = new System.Drawing.Point(70, 233);
            btn_save.Name = "btn_save";
            btn_save.Size = new System.Drawing.Size(290, 163);
            btn_save.TabIndex = 0;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.Transparent;
            btn_Exit.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Exit.BackgroundImage");
            btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Exit.Location = new System.Drawing.Point(415, 233);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(290, 163);
            btn_Exit.TabIndex = 1;
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Main
            // 
            btn_Main.BackColor = System.Drawing.Color.Transparent;
            btn_Main.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Main.BackgroundImage");
            btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Main.Location = new System.Drawing.Point(760, 233);
            btn_Main.Name = "btn_Main";
            btn_Main.Size = new System.Drawing.Size(290, 163);
            btn_Main.TabIndex = 2;
            btn_Main.UseVisualStyleBackColor = false;
            btn_Main.Click += btn_Main_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1120, 630);
            Controls.Add(btn_Main);
            Controls.Add(btn_Exit);
            Controls.Add(btn_save);
            ForeColor = System.Drawing.Color.FromArgb(237, 140, 174);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form9";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "메뉴";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Main;
    }
}