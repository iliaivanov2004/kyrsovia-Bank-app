namespace WindowsFormsApp2
{
    partial class DataBase_deposit_181_year
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NameFieldDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PercentField = new System.Windows.Forms.TextBox();
            this.StatusField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(12, 450);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(149, 36);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 403);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(149, 36);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(12, 250);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(149, 36);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введите имя:";
            
            // 
            // NameFieldDelete
            // 
            this.NameFieldDelete.Location = new System.Drawing.Point(12, 354);
            this.NameFieldDelete.Multiline = true;
            this.NameFieldDelete.Name = "NameFieldDelete";
            this.NameFieldDelete.Size = new System.Drawing.Size(242, 33);
            this.NameFieldDelete.TabIndex = 9;
            this.NameFieldDelete.TextChanged += new System.EventHandler(this.NameFieldDelete_TextChanged);
            this.NameFieldDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameFieldDelete_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите процент:";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите статус:";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите имя:";
            
            // 
            // PercentField
            // 
            this.PercentField.Location = new System.Drawing.Point(12, 199);
            this.PercentField.Multiline = true;
            this.PercentField.Name = "PercentField";
            this.PercentField.Size = new System.Drawing.Size(242, 33);
            this.PercentField.TabIndex = 5;
            this.PercentField.TextChanged += new System.EventHandler(this.PercentField_TextChanged);
            this.PercentField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentField_KeyPress);
            // 
            // StatusField
            // 
            this.StatusField.Location = new System.Drawing.Point(13, 138);
            this.StatusField.Multiline = true;
            this.StatusField.Name = "StatusField";
            this.StatusField.Size = new System.Drawing.Size(242, 33);
            this.StatusField.TabIndex = 4;
            this.StatusField.TextChanged += new System.EventHandler(this.StatusField_TextChanged);
            this.StatusField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StatusField_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Удалить элемент";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить элемент";
            
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(12, 76);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(242, 33);
            this.NameField.TabIndex = 1;
            this.NameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            this.NameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameField_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(2, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(590, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Редактировние базы данных \"deposit_181_year\" ";
            
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.Location = new System.Drawing.Point(769, -1);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(165, 44);
            this.Exit_Button.TabIndex = 19;
            this.Exit_Button.Text = "< назад";
            this.Exit_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NameFieldDelete);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PercentField);
            this.panel1.Controls.Add(this.StatusField);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameField);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 498);
            this.panel1.TabIndex = 17;
            
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Status,
            this.Percent});
            this.dataGridView1.Location = new System.Drawing.Point(276, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 498);
            this.dataGridView1.TabIndex = 0;
            
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "Percent";
            this.Percent.MinimumWidth = 6;
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 125;
            // 
            // DataBase_deposit_181_year
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 542);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBase_deposit_181_year";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameFieldDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PercentField;
        private System.Windows.Forms.TextBox StatusField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
    }
}