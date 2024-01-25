using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class User_Form1 : Form
    {
        public User_Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //нажатие кнопки (до 90 дней (краткосрочный))
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306;username = root; password = root;database = banks"); //соедениние с БД
            MySqlCommand command = new MySqlCommand("SELECT Name FROM deposit_before_90_day WHERE Percent = (SELECT MAX(Percent) FROM deposit_before_90_day)", connection);
            MySqlCommand command_percent = new MySqlCommand("SELECT MAX(percent) FROM deposit_before_90_day", connection);
            textBox1.Clear();
            connection.Open();
            object percent = command_percent.ExecuteScalar();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    textBox1.Text += name + Environment.NewLine;
                }
            }
            connection.Close();
            textBox2.Text = percent.ToString();
        }
        private void button2_Click(object sender, EventArgs e) //нажатие кнопки (от 90 до 180 дней)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306;username = root; password = root;database = banks");
            MySqlCommand command = new MySqlCommand("SELECT Name FROM deposit_91_180_day WHERE Percent = (SELECT MAX(Percent) FROM deposit_91_180_day)", connection);
            MySqlCommand command_percent = new MySqlCommand("SELECT MAX(percent) FROM deposit_91_180_day", connection);
            textBox1.Clear();
            connection.Open();
            object percent = command_percent.ExecuteScalar();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    textBox1.Text += name + Environment.NewLine;
                }
            }
            connection.Close();
            textBox2.Text = percent.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //нажатие кнопки (от 181 дня до года)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306;username = root; password = root;database = banks");
            MySqlCommand command = new MySqlCommand("SELECT Name FROM deposit_181_year WHERE Percent = (SELECT MAX(Percent) FROM deposit_181_year)", connection);
            MySqlCommand command_percent = new MySqlCommand("SELECT MAX(percent) FROM deposit_181_year", connection);
            textBox1.Clear();
            connection.Open();
            object percent = command_percent.ExecuteScalar();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    textBox1.Text += name + Environment.NewLine;
                }
            }
            connection.Close();
            textBox2.Text = percent.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //нажатие кнопки (Более года (долгий срок))
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306;username = root; password = root;database = banks");
            MySqlCommand command = new MySqlCommand("SELECT Name FROM deposit_more_than_a_year WHERE Percent = (SELECT MAX(Percent) FROM deposit_more_than_a_year)", connection);
            MySqlCommand command_percent = new MySqlCommand("SELECT MAX(percent) FROM deposit_more_than_a_year", connection);
            textBox1.Clear();
            connection.Open();
            object percent = command_percent.ExecuteScalar();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    textBox1.Text += name + Environment.NewLine;
                }
            }
            connection.Close();
            textBox2.Text = percent.ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //блокируем ввод недопустимых символов
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //блокируем ввод недопустимых символов
        {
            e.Handled = true;
        }
    }
}
