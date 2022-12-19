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
        public static Database Db { get; } = new Database();
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

        private void FilmInsertButton_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    enum UserRoles
    {
        ADMIN, READONLY_USER, REDACTOR
    }
}