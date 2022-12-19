using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsUI
{
    public partial class SqlConnectionForm : Form
    {
        public SqlConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionEnter_Click(object sender, EventArgs e)
        {
            Database.SetDataSource(ConnectionTextBox.Text);

            if (Database.TestConnection())
            {
                MessageBox.Show("Подключение успешно установлено");

                var login = new Login();
                login.Show();

                Hide();
            }
            else
                MessageBox.Show("Ошибка при подключении");
        }
    }
}
