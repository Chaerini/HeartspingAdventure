namespace prj_HeartspingAdventure
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            btn_HOME = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(55, 260);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(200, 200);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(325, 260);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(200, 200);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Location = new System.Drawing.Point(595, 260);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(200, 200);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Transparent;
            button4.BackgroundImage = (System.Drawing.Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Location = new System.Drawing.Point(865, 260);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(200, 200);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn_HOME
            // 
            btn_HOME.BackColor = System.Drawing.Color.Transparent;
            btn_HOME.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_HOME.BackgroundImage");
            btn_HOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_HOME.Font = new System.Drawing.Font("Cafe24 ClassicType", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_HOME.ForeColor = System.Drawing.Color.Black;
            btn_HOME.Location = new System.Drawing.Point(480, 477);
            btn_HOME.Name = "btn_HOME";
            btn_HOME.Size = new System.Drawing.Size(160, 60);
            btn_HOME.TabIndex = 4;
            btn_HOME.Text = "HOME";
            btn_HOME.UseVisualStyleBackColor = false;
            btn_HOME.Click += btn_HOME_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1120, 630);
            Controls.Add(btn_HOME);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "전투";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_HOME;
    }
}