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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)  //нажатие кнопки (БД до 90 дней)
        {
            this.Hide();
            DataBase_deposit_before_90_day form = new DataBase_deposit_before_90_day();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e) //нажатие кнопки (БД от 90 до 180 дней)
        {
            this.Hide();
            DataBase_deposit_91_180_days form = new DataBase_deposit_91_180_days();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e) //нажатие кнопки (БД от 180 дней до года)
        {
            this.Hide();
            DataBase_deposit_181_year form = new DataBase_deposit_181_year();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e) //нажатие кнопки (БД более года)
        {
            this.Hide();
            DataBase_deposit_more_than_a_year form = new DataBase_deposit_more_than_a_year();
            form.Show();
        }
    }
}
