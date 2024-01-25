namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Admin_Button = new System.Windows.Forms.Button();
            this.User_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.help_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.help_button);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Controls.Add(this.Admin_Button);
            this.panel1.Controls.Add(this.User_Button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 422);
            this.panel1.TabIndex = 0;
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Close_Button.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Button.Location = new System.Drawing.Point(301, 311);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(227, 43);
            this.Close_Button.TabIndex = 6;
            this.Close_Button.Text = "Выйти";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Admin_Button
            // 
            this.Admin_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Admin_Button.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_Button.Location = new System.Drawing.Point(218, 176);
            this.Admin_Button.Name = "Admin_Button";
            this.Admin_Button.Size = new System.Drawing.Size(395, 43);
            this.Admin_Button.TabIndex = 5;
            this.Admin_Button.Text = "Войти (как администратор)";
            this.Admin_Button.UseVisualStyleBackColor = false;
            this.Admin_Button.Click += new System.EventHandler(this.Admin_Button_Click);
            // 
            // User_Button
            // 
            this.User_Button.BackColor = System.Drawing.SystemColors.Control;
            this.User_Button.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Button.Location = new System.Drawing.Point(218, 108);
            this.User_Button.Name = "User_Button";
            this.User_Button.Size = new System.Drawing.Size(395, 43);
            this.User_Button.TabIndex = 4;
            this.User_Button.Text = "Войти (как пользователь)";
            this.User_Button.UseVisualStyleBackColor = false;
            this.User_Button.Click += new System.EventHandler(this.User_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(294, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Главное меню";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вклад консультант";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.ruble;
            this.pictureBox2.Location = new System.Drawing.Point(449, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.SystemColors.Control;
            this.help_button.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_button.Location = new System.Drawing.Point(301, 245);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(227, 43);
            this.help_button.TabIndex = 7;
            this.help_button.Text = "Информация";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 492);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button User_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Admin_Button;
        private System.Windows.Forms.Button help_button;
    }
}