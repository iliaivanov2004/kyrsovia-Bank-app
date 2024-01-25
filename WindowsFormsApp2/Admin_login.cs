using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
            buttonLogin.Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection("server = localhost; port = 3306;username = root; password = root;database = ilia25");
            myConnection.Open();
            String loginUser = loginField.Text;
            String passUser = passField.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM `users` WHERE `login` = @uL AND `password` = @uP", myConnection);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин и пароль введены успешно! Вы вошли, как администратор.");
                this.Hide();
                Admin_Form form = new Admin_Form();
                form.Show();
            }
            else
            {
                MessageBox.Show("Ошибка! Логин или пароль введены не правильно.");
            }
            myConnection.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
        private void CheckTextBoxes() //разблокировка кнопки "Войти" (buttonLogin)
        {
            if (string.IsNullOrEmpty(loginField.Text) || string.IsNullOrEmpty(passField.Text))
            {
                buttonLogin.Enabled = false; // заблокировать кнопку
            }
            else
            {
                buttonLogin.Enabled = true; // разблокировать кнопку
            }
        }

        private void loginField_TextChanged(object sender, EventArgs e) //проверка введен ли текст в поле loginField
        {
            CheckTextBoxes();
        }

        private void passField_TextChanged(object sender, EventArgs e) //проверка введен ли текст в поле passField
        {
            CheckTextBoxes();
        }
    }
}
