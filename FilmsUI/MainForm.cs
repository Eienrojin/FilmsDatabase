using FilmsUI.FilmsDataSetTableAdapters;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

/*
 * TODO
 * Блокировать разные поля под разными профилями
 * Добавить поле добавления юзеров
 * 
 */

namespace FilmsUI
{
    public partial class MainForm : Form
    {
        private static UserRoles _currentUser;

        struct Table
        {
            public const string film = "Film";
            public const string actor = "Actors";
            public const string author = "Authors";
            public const string person = "Person";
            public const string dataCarrier = "DataCarrier";
            public const string register = "Register";
        }

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private DataGridView[] InitDGVArray()
        {
            DataGridView[]? DGVs = new DataGridView[DGVTabControl.TabCount];

            DGVs[0] = MainDGV;
            DGVs[1] = ActorsDGV;
            DGVs[2] = AuthorsDGV;
            DGVs[3] = PersonDGV;
            DGVs[4] = DataCarrierDGV;
            DGVs[5] = UsersDGV;

            return DGVs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tables = { Table.film, Table.actor, Table.author, Table.person, Table.dataCarrier, Table.register };
            DataGridView[]? DGVs = InitDGVArray();
            DataTable[] dataTables = new DataTable[DGVs.Length];

            Database._sqlConnection.Open();

            for (int i = 0; i < DGVs.Length; i++)
            {
                dataTables[i] = new DataTable();
                var dataAdapter = new SqlDataAdapter($"SELECT * FROM {tables[i]}", Database._sqlConnection);
                dataAdapter.Fill(dataTables[i]);
                DGVs[i].DataSource = dataTables[i];
            }

            Database._sqlConnection.Close();
        }

        private static void UpdateDGV(DataGridView dgv, string table)
        {
            var dataTables = new DataTable();

            Database._sqlConnection.Open();
            var dataAdapter = new SqlDataAdapter($"SELECT * FROM {table}", Database._sqlConnection);
            Database._sqlConnection.Close();

            dataAdapter.Fill(dataTables);

            dgv.DataSource = dataTables;
        }

        private void FilmInsertButton_Click(object sender, EventArgs e)
        {
            var adapter = new FilmTableAdapter();
            var isCorrect = true;

            try
            {
                adapter.Insert(FilmTitleTextBox.Text,
                               int.Parse(FilmYearTextBox.Text),
                               FilmCountryTextBox.Text,
                               FilmStudioTextBox.Text,
                               FilmGenreTextBox.Text,
                               FilmSubgenreTextBox.Text,
                               FilmProducerTextBox.Text,
                               FilmSummaryTextBox.Text,
                               int.Parse(FilmDataCarrierTextBox.Text),
                               short.Parse(FilmDurationTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неправильно");
                isCorrect = false;
            }

            if (isCorrect)
            {
                UpdateDGV(MainDGV, Table.film);
            }
        }

        private void ActorInsertButton_Click(object sender, EventArgs e)
        {
            var adapter = new ActorsTableAdapter();
            var isCorrect = true;

            try
            {
                adapter.Insert(int.Parse(ActorFilmIdTextBox.Text), int.Parse(ActorPersonIdTextBox.Text), ActorRoleTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неправильно");
                isCorrect = false;
            }

            if (isCorrect)
            {
                UpdateDGV(ActorsDGV, Table.actor);
            }
        }


        private void FilmYearTextBox_KeyPress(object sender, KeyPressEventArgs e) => EnterOnlyDigits(e);

        private static void EnterOnlyDigits(KeyPressEventArgs e) => e.Handled = !Char.IsDigit(e.KeyChar);

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }

    public enum UserRoles
    {
        ADMIN, READONLY_USER, REDACTOR
    }
}