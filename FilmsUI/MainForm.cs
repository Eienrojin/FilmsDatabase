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
            string[] tables = { "Film", "Actors", "Authors", "Person", "DataCarrier", "Register" };
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

        private void UpdateDGV(DataGridView dgv, string table)
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
                UpdateDGV(MainDGV, "Film");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void FilmYearTextBox_KeyPress(object sender, KeyPressEventArgs e) => EnterOnlyDigits(e);

        private void EnterOnlyDigits(KeyPressEventArgs e) => e.Handled = !Char.IsDigit(e.KeyChar);

        private void FilmDataCarrierTextBox_TextChanged(object sender, EventArgs e) { }
    }

    public enum UserRoles
    {
        ADMIN, READONLY_USER, REDACTOR
    }
}