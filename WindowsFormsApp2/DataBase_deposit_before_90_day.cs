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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp2
{
    public partial class DataBase_deposit_before_90_day : Form
    {
        public DataBase_deposit_before_90_day()
        {
            InitializeComponent();
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            LoadData();
        }

        private void LoadData() // вывод базы данных в DataGridView 
        {
            MySqlConnection myConnection = new MySqlConnection("server = localhost; port = 3306;username = root; password = root;database = banks");
            myConnection.Open();
            string query = "SELECT * FROM deposit_before_90_day ORDER BY percent";
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection("server = localhost; port = 3306;username = root; password = root;database = banks");
            MySqlCommand command_delete = new MySqlCommand("DELETE FROM `deposit_before_90_day` WHERE `Name` = @Name", myConnection);
            command_delete.Parameters.Add("@Name", MySqlDbType.VarChar).Value = NameFieldDelete.Text;
            myConnection.Open();
            if (command_delete.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Элемент был удален");
            }
            else
            {
                MessageBox.Show("Элемент не был удалён");
            }
            myConnection.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("Percent", "Percent");
            LoadData();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Form form = new Admin_Form();
            form.Show();
        }

        private void PercentField_KeyPress(object sender, KeyPressEventArgs e) //блокируем ввод недопустимых символов
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Отменяем ввод недопустимого символа
            }

            // Проверяем наличие только одной запятой
            if (e.KeyChar == ',' && (sender as System.Windows.Forms.TextBox).Text.Contains(','))
            {
                e.Handled = true; // Отменяем ввод второй запятой
            }
        }

        private void NameField_KeyPress(object sender, KeyPressEventArgs e) //блокируем ввод недопустимых символов
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void StatusField_KeyPress(object sender, KeyPressEventArgs e) //блокируем ввод недопустимых символов
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void CheckTextBoxes() //разблокривка кнопки "Добавить" (AddButton)
        {
            if (string.IsNullOrEmpty(NameField.Text) || string.IsNullOrEmpty(StatusField.Text) || string.IsNullOrEmpty(PercentField.Text))
            {
                AddButton.Enabled = false; // заблокировать кнопку
            }
            else
            {
                AddButton.Enabled = true; // разблокировать кнопку
            }
        }

        private void DeleteButton_CheckTextBoxes()  //разблокривка кнопки "удалить" (DeleteButton)
        {
            if (string.IsNullOrEmpty(NameFieldDelete.Text))
            {
                DeleteButton.Enabled = false; // заблокировать кнопку
            }
            else
            {
                DeleteButton.Enabled = true; // разблокировать кнопку
            }
        }


        private void NameFieldDelete_TextChanged(object sender, EventArgs e) //проверка введен ли текст в поле
        {
            DeleteButton_CheckTextBoxes();
        }

        private void PercentField_TextChanged(object sender, EventArgs e) //проверка введен ли текст в поле
        {
            CheckTextBoxes();
        }


        private void NameField_TextChanged(object sender, EventArgs e) //проверка введен ли текст в поле
        {
            CheckTextBoxes();
        }

        private void StatusField_TextChanged(object sender, EventArgs e) //проверка введен ли текст в поле
        {
            CheckTextBoxes();
        }

        private void NameFieldDelete_KeyPress(object sender, KeyPressEventArgs e) //блокируем ввод недопустимых символов
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection("server = localhost; port = 3306;username = root; password = root;database = banks");
            MySqlCommand command = new MySqlCommand("INSERT INTO `deposit_before_90_day` (`Name`, `Status`, `Percent`) VALUES (@Name, @Status, @Percent)", myConnection);
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = NameField.Text;
            command.Parameters.Add("@Status", MySqlDbType.VarChar).Value = StatusField.Text;
            command.Parameters.Add("@Percent", MySqlDbType.Float).Value = PercentField.Text;
            myConnection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Элемент был создан");
            }
            else
            {
                MessageBox.Show("Элемент не был создан");
            }
            myConnection.Close();
        }
    }
}
