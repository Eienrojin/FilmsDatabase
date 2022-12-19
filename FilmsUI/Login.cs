using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) =>
            PasswordTextBox.UseSystemPasswordChar = !checkBox1.Checked;

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            var adapter = new SqlDataAdapter();
            var table = new DataTable();

            var queryString = $"SELECT login, password FROM Register WHERE login = '{login}' AND password = '{password}'";
            var command = new SqlCommand(queryString, Database._sqlConnection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Поменять на соответствие данных из базы
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Принято", "Успешный вход", MessageBoxButtons.OK);
                var form1 = new MainForm();
                form1.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Неправильный логин или пароль", "Вход не выполнен", MessageBoxButtons.OK);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e) => 
            Application.Exit();

        private void Login_Load(object sender, EventArgs e) {}

        private void PasswordTextBox_TextChanged(object sender, EventArgs e) { }

    }
}
