namespace prj_HeartspingAdventure
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Exit = new System.Windows.Forms.Button();
            btn_load = new System.Windows.Forms.Button();
            btn_Newgame = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.Transparent;
            btn_Exit.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Exit.BackgroundImage");
            btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Exit.Font = new System.Drawing.Font("Cafe24 ClassicType", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Exit.ForeColor = System.Drawing.Color.FromArgb(228, 80, 142);
            btn_Exit.Location = new System.Drawing.Point(798, 470);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(135, 70);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "종료";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += button3_Click;
            // 
            // btn_load
            // 
            btn_load.BackColor = System.Drawing.Color.Transparent;
            btn_load.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_load.BackgroundImage");
            btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_load.Font = new System.Drawing.Font("Cafe24 ClassicType", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_load.ForeColor = System.Drawing.Color.FromArgb(228, 80, 142);
            btn_load.Location = new System.Drawing.Point(188, 470);
            btn_load.Name = "btn_load";
            btn_load.Size = new System.Drawing.Size(135, 70);
            btn_load.TabIndex = 1;
            btn_load.Text = "불러오기";
            btn_load.UseVisualStyleBackColor = false;
            btn_load.Click += button2_Click;
            // 
            // btn_Newgame
            // 
            btn_Newgame.BackColor = System.Drawing.Color.Transparent;
            btn_Newgame.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Newgame.BackgroundImage");
            btn_Newgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Newgame.Font = new System.Drawing.Font("Cafe24 ClassicType", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Newgame.ForeColor = System.Drawing.Color.FromArgb(228, 80, 142);
            btn_Newgame.Location = new System.Drawing.Point(493, 470);
            btn_Newgame.Name = "btn_Newgame";
            btn_Newgame.Size = new System.Drawing.Size(135, 70);
            btn_Newgame.TabIndex = 0;
            btn_Newgame.Text = "새 게임";
            btn_Newgame.UseVisualStyleBackColor = false;
            btn_Newgame.Click += btn_Newgame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1120, 631);
            Controls.Add(btn_Exit);
            Controls.Add(btn_load);
            Controls.Add(btn_Newgame);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "하츄핑의 모험!";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_Newgame;
    }
}
