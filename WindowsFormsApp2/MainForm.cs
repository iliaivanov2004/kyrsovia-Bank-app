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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Form1 userform = new User_Form1();
            userform.Show();
        }

        private void Admin_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login adminform = new Admin_login();
            adminform.Show();
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение помогает подобрать российские банки с наибольшими ставками по разным видам вкладов. " +
                             "Над приложением работал: Иванов Илья ИС-22/2024 год");
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
