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
            FillFindOrDeleteComboBox();
        }

        private void FillFindOrDeleteComboBox()
        {
            FindOrDeleteComboBox.Items.Clear();
            FindOrDeleteComboBox.Items.Add(Table.film);
            FindOrDeleteComboBox.Items.Add(Table.actor);
            FindOrDeleteComboBox.Items.Add(Table.author);
            FindOrDeleteComboBox.Items.Add(Table.person);
            FindOrDeleteComboBox.Items.Add(Table.dataCarrier);
            FindOrDeleteComboBox.Items.Add(Table.register);
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
                UpdateDGV(MainDGV, Table.film);

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
                UpdateDGV(ActorsDGV, Table.actor);
        }
        private void AuthorsInsertButton_Click(object sender, EventArgs e)
        {
            var adapter = new AuthorsTableAdapter();
            var isCorrect = true;

            try
            {
                adapter.Insert(int.Parse(AuthorFilmIdTextBox.Text), int.Parse(AuthorPersonIdTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неправильно");
                isCorrect = false;
            }

            if (isCorrect)
                UpdateDGV(AuthorsDGV, Table.author);
        }
        private void PersonInsertButton_Click(object sender, EventArgs e)
        {
            var adapter = new PersonTableAdapter();
            var isCorrect = true;

            try
            {
                adapter.Insert(PersonNameTextBox.Text, PersonSurnameTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неправильно");
                isCorrect = false;
            }

            if (isCorrect)
                UpdateDGV(AuthorsDGV, Table.author);
        }
        private void DataCarrierInsertButton_Click(object sender, EventArgs e)
        {
            var adapter = new DataCarrierTableAdapter();
            var isCorrect = true;

            try
            {
                adapter.Insert(DataCarrierNameTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неправильно");
                isCorrect = false;
            }

            if (isCorrect)
                UpdateDGV(DataCarrierDGV, Table.dataCarrier);
        }
        private void RegisterInsertButton_Click(object sender, EventArgs e)
        {
            var adapter = new RegisterTableAdapter();
            var isCorrect = true;

            try
            {
                adapter.Insert(UserLoginTextBox.Text, UserPasswordTextBox.Text, int.Parse(UserRoleTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неправильно");
                isCorrect = false;
            }

            if (isCorrect)
                UpdateDGV(DataCarrierDGV, Table.register);
        }

        private void FilmYearTextBox_KeyPress(object sender, KeyPressEventArgs e) => EnterOnlyDigits(e);

        private static void EnterOnlyDigits(KeyPressEventArgs e) => e.Handled = !Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void FindByIdButton_Click(object sender, EventArgs e)
        {
            int findId = int.Parse(FindOrDeleteTextBox.Text);

            Database._sqlConnection.Open();

            switch (FindOrDeleteComboBox.Text)
            {
                case Table.film:
                    FindOrDeleteResultDGV.DataSource = new FilmTableAdapter().FindById(findId);
                    break;
                case Table.author:
                    FindOrDeleteResultDGV.DataSource = new AuthorsTableAdapter().FindById(findId);
                    break;
                case Table.person:
                    FindOrDeleteResultDGV.DataSource = new PersonTableAdapter().FindById(findId);
                    break;
                case Table.actor:
                    FindOrDeleteResultDGV.DataSource = new ActorsTableAdapter().FindById(findId);
                    break;
                case Table.dataCarrier:
                    FindOrDeleteResultDGV.DataSource = new DataCarrierTableAdapter().FindById(findId);
                    break;
                case Table.register:
                    FindOrDeleteResultDGV.DataSource = new RegisterTableAdapter().FindById(findId);
                    break;
                default:
                    MessageBox.Show("Ошибка в выборе таблицы!");
                    Database._sqlConnection.Close();
                    return;
            }

            MessageBox.Show("Ведется поиск...");
            Database._sqlConnection.Close();
        }

        private void DeleteByIdButton_Click(object sender, EventArgs e)
        {
            int findId = int.Parse(FindOrDeleteTextBox.Text);

            switch (FindOrDeleteComboBox.Text)
            {
                case Table.film:
                    new FilmTableAdapter().DeleteQuery(findId);
                    UpdateDGV(MainDGV, Table.film);
                    break;
                case Table.author:
                    new AuthorsTableAdapter().DeleteQuery(findId);
                    UpdateDGV(AuthorsDGV, Table.author);
                    break;
                case Table.person:
                    new PersonTableAdapter().DeleteQuery(findId);
                    UpdateDGV(PersonDGV, Table.person);
                    break;
                case Table.actor:
                    new ActorsTableAdapter().DeleteQuery(findId);
                    UpdateDGV(ActorsDGV, Table.actor);
                    break;
                case Table.dataCarrier:
                    new DataCarrierTableAdapter().DeleteQuery(findId);
                    UpdateDGV(DataCarrierDGV, Table.dataCarrier);
                    break;
                case Table.register:
                    new RegisterTableAdapter().DeleteQuery(findId);
                    UpdateDGV(UsersDGV, Table.register);
                    break;
                default:
                    MessageBox.Show("Ошибка в выборе таблицы!");
                    Database._sqlConnection.Close();
                    return;
            }

            MessageBox.Show("Успешно удалено!");
        }
    }

    public enum UserRoles
    {
        ADMIN, READONLY_USER, REDACTOR
    }
}