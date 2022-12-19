namespace FilmsUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainDGV = new System.Windows.Forms.DataGridView();
            this.DGVTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FilmInsertButton = new System.Windows.Forms.Button();
            this.FilmDataCarrierTextBox = new System.Windows.Forms.TextBox();
            this.FilmTitleTextBox = new System.Windows.Forms.TextBox();
            this.FilmGenreTextBox = new System.Windows.Forms.TextBox();
            this.FilmYearTextBox = new System.Windows.Forms.TextBox();
            this.FilmDurationTextBox = new System.Windows.Forms.TextBox();
            this.FilmProducerTextBox = new System.Windows.Forms.TextBox();
            this.FilmSubgenreTextBox = new System.Windows.Forms.TextBox();
            this.FilmSummaryTextBox = new System.Windows.Forms.TextBox();
            this.FilmCountryTextBox = new System.Windows.Forms.TextBox();
            this.FilmStudioTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ActorInsertButton = new System.Windows.Forms.Button();
            this.ActorRoleTextBox = new System.Windows.Forms.TextBox();
            this.ActorPersonIdTextBox = new System.Windows.Forms.TextBox();
            this.ActorFilmIdTextBox = new System.Windows.Forms.TextBox();
            this.ActorsDGV = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.AuthorsDGV = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PersonDGV = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DataCarrierDGV = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.UsersDGV = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FindOrDeleteTab = new System.Windows.Forms.TabPage();
            this.FindOrDeleteCurrentTableLabel = new System.Windows.Forms.Label();
            this.FindOrDeleteLabel = new System.Windows.Forms.Label();
            this.DeleteByIdButton = new System.Windows.Forms.Button();
            this.FindByIdButton = new System.Windows.Forms.Button();
            this.FindOrDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.FindOrDeleteTextBox = new System.Windows.Forms.TextBox();
            this.FindOrDeleteResultDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).BeginInit();
            this.DGVTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorsDGV)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDGV)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonDGV)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCarrierDGV)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.FindOrDeleteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindOrDeleteResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDGV
            // 
            this.MainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDGV.Location = new System.Drawing.Point(6, 6);
            this.MainDGV.Name = "MainDGV";
            this.MainDGV.RowHeadersWidth = 51;
            this.MainDGV.RowTemplate.Height = 29;
            this.MainDGV.Size = new System.Drawing.Size(748, 826);
            this.MainDGV.TabIndex = 0;
            // 
            // DGVTabControl
            // 
            this.DGVTabControl.Controls.Add(this.tabPage1);
            this.DGVTabControl.Controls.Add(this.tabPage2);
            this.DGVTabControl.Controls.Add(this.tabPage7);
            this.DGVTabControl.Controls.Add(this.tabPage4);
            this.DGVTabControl.Controls.Add(this.tabPage5);
            this.DGVTabControl.Controls.Add(this.tabPage6);
            this.DGVTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGVTabControl.Location = new System.Drawing.Point(0, 0);
            this.DGVTabControl.Name = "DGVTabControl";
            this.DGVTabControl.SelectedIndex = 0;
            this.DGVTabControl.Size = new System.Drawing.Size(1169, 873);
            this.DGVTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FilmInsertButton);
            this.tabPage1.Controls.Add(this.FilmDataCarrierTextBox);
            this.tabPage1.Controls.Add(this.MainDGV);
            this.tabPage1.Controls.Add(this.FilmTitleTextBox);
            this.tabPage1.Controls.Add(this.FilmGenreTextBox);
            this.tabPage1.Controls.Add(this.FilmYearTextBox);
            this.tabPage1.Controls.Add(this.FilmDurationTextBox);
            this.tabPage1.Controls.Add(this.FilmProducerTextBox);
            this.tabPage1.Controls.Add(this.FilmSubgenreTextBox);
            this.tabPage1.Controls.Add(this.FilmSummaryTextBox);
            this.tabPage1.Controls.Add(this.FilmCountryTextBox);
            this.tabPage1.Controls.Add(this.FilmStudioTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 840);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильмы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FilmInsertButton
            // 
            this.FilmInsertButton.BackColor = System.Drawing.Color.Green;
            this.FilmInsertButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmInsertButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilmInsertButton.Location = new System.Drawing.Point(760, 758);
            this.FilmInsertButton.Name = "FilmInsertButton";
            this.FilmInsertButton.Size = new System.Drawing.Size(392, 75);
            this.FilmInsertButton.TabIndex = 11;
            this.FilmInsertButton.Text = "Вставить";
            this.FilmInsertButton.UseVisualStyleBackColor = false;
            this.FilmInsertButton.Click += new System.EventHandler(this.FilmInsertButton_Click);
            // 
            // FilmDataCarrierTextBox
            // 
            this.FilmDataCarrierTextBox.Location = new System.Drawing.Point(760, 271);
            this.FilmDataCarrierTextBox.Name = "FilmDataCarrierTextBox";
            this.FilmDataCarrierTextBox.PlaceholderText = "ID Носитель информации";
            this.FilmDataCarrierTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmDataCarrierTextBox.TabIndex = 10;
            this.FilmDataCarrierTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilmYearTextBox_KeyPress);
            // 
            // FilmTitleTextBox
            // 
            this.FilmTitleTextBox.Location = new System.Drawing.Point(760, 7);
            this.FilmTitleTextBox.MaxLength = 30;
            this.FilmTitleTextBox.Name = "FilmTitleTextBox";
            this.FilmTitleTextBox.PlaceholderText = "Название";
            this.FilmTitleTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmTitleTextBox.TabIndex = 1;
            // 
            // FilmGenreTextBox
            // 
            this.FilmGenreTextBox.Location = new System.Drawing.Point(760, 139);
            this.FilmGenreTextBox.MaxLength = 20;
            this.FilmGenreTextBox.Name = "FilmGenreTextBox";
            this.FilmGenreTextBox.PlaceholderText = "Жанр";
            this.FilmGenreTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmGenreTextBox.TabIndex = 5;
            // 
            // FilmYearTextBox
            // 
            this.FilmYearTextBox.Location = new System.Drawing.Point(760, 73);
            this.FilmYearTextBox.MaxLength = 4;
            this.FilmYearTextBox.Name = "FilmYearTextBox";
            this.FilmYearTextBox.PlaceholderText = "Год выпуска";
            this.FilmYearTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmYearTextBox.TabIndex = 3;
            this.FilmYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilmYearTextBox_KeyPress);
            // 
            // FilmDurationTextBox
            // 
            this.FilmDurationTextBox.Location = new System.Drawing.Point(760, 238);
            this.FilmDurationTextBox.MaxLength = 3;
            this.FilmDurationTextBox.Name = "FilmDurationTextBox";
            this.FilmDurationTextBox.PlaceholderText = "Длительность в минутах";
            this.FilmDurationTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmDurationTextBox.TabIndex = 9;
            this.FilmDurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilmYearTextBox_KeyPress);
            // 
            // FilmProducerTextBox
            // 
            this.FilmProducerTextBox.Location = new System.Drawing.Point(760, 205);
            this.FilmProducerTextBox.MaxLength = 50;
            this.FilmProducerTextBox.Name = "FilmProducerTextBox";
            this.FilmProducerTextBox.PlaceholderText = "Продюссер";
            this.FilmProducerTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmProducerTextBox.TabIndex = 7;
            // 
            // FilmSubgenreTextBox
            // 
            this.FilmSubgenreTextBox.Location = new System.Drawing.Point(760, 172);
            this.FilmSubgenreTextBox.MaxLength = 20;
            this.FilmSubgenreTextBox.Name = "FilmSubgenreTextBox";
            this.FilmSubgenreTextBox.PlaceholderText = "Поджанр";
            this.FilmSubgenreTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmSubgenreTextBox.TabIndex = 6;
            // 
            // FilmSummaryTextBox
            // 
            this.FilmSummaryTextBox.Location = new System.Drawing.Point(760, 304);
            this.FilmSummaryTextBox.MaxLength = 300;
            this.FilmSummaryTextBox.Multiline = true;
            this.FilmSummaryTextBox.Name = "FilmSummaryTextBox";
            this.FilmSummaryTextBox.PlaceholderText = "Краткое описание";
            this.FilmSummaryTextBox.Size = new System.Drawing.Size(392, 168);
            this.FilmSummaryTextBox.TabIndex = 8;
            // 
            // FilmCountryTextBox
            // 
            this.FilmCountryTextBox.Location = new System.Drawing.Point(760, 40);
            this.FilmCountryTextBox.MaxLength = 30;
            this.FilmCountryTextBox.Name = "FilmCountryTextBox";
            this.FilmCountryTextBox.PlaceholderText = "Страна производитель";
            this.FilmCountryTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmCountryTextBox.TabIndex = 2;
            // 
            // FilmStudioTextBox
            // 
            this.FilmStudioTextBox.Location = new System.Drawing.Point(760, 106);
            this.FilmStudioTextBox.MaxLength = 50;
            this.FilmStudioTextBox.Name = "FilmStudioTextBox";
            this.FilmStudioTextBox.PlaceholderText = "Студия";
            this.FilmStudioTextBox.Size = new System.Drawing.Size(392, 27);
            this.FilmStudioTextBox.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ActorInsertButton);
            this.tabPage2.Controls.Add(this.ActorRoleTextBox);
            this.tabPage2.Controls.Add(this.ActorPersonIdTextBox);
            this.tabPage2.Controls.Add(this.ActorFilmIdTextBox);
            this.tabPage2.Controls.Add(this.ActorsDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 840);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Актёры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ActorInsertButton
            // 
            this.ActorInsertButton.BackColor = System.Drawing.Color.Green;
            this.ActorInsertButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActorInsertButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActorInsertButton.Location = new System.Drawing.Point(760, 758);
            this.ActorInsertButton.Name = "ActorInsertButton";
            this.ActorInsertButton.Size = new System.Drawing.Size(392, 75);
            this.ActorInsertButton.TabIndex = 12;
            this.ActorInsertButton.Text = "Вставить";
            this.ActorInsertButton.UseVisualStyleBackColor = false;
            this.ActorInsertButton.Click += new System.EventHandler(this.ActorInsertButton_Click);
            // 
            // ActorRoleTextBox
            // 
            this.ActorRoleTextBox.Location = new System.Drawing.Point(760, 73);
            this.ActorRoleTextBox.MaxLength = 40;
            this.ActorRoleTextBox.Name = "ActorRoleTextBox";
            this.ActorRoleTextBox.PlaceholderText = "Роль (ФИО, кличка и т.п.)";
            this.ActorRoleTextBox.Size = new System.Drawing.Size(395, 27);
            this.ActorRoleTextBox.TabIndex = 4;
            // 
            // ActorPersonIdTextBox
            // 
            this.ActorPersonIdTextBox.Location = new System.Drawing.Point(760, 40);
            this.ActorPersonIdTextBox.Name = "ActorPersonIdTextBox";
            this.ActorPersonIdTextBox.PlaceholderText = "ID человека";
            this.ActorPersonIdTextBox.Size = new System.Drawing.Size(395, 27);
            this.ActorPersonIdTextBox.TabIndex = 3;
            this.ActorPersonIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilmYearTextBox_KeyPress);
            // 
            // ActorFilmIdTextBox
            // 
            this.ActorFilmIdTextBox.Location = new System.Drawing.Point(760, 7);
            this.ActorFilmIdTextBox.Name = "ActorFilmIdTextBox";
            this.ActorFilmIdTextBox.PlaceholderText = "ID фильма";
            this.ActorFilmIdTextBox.Size = new System.Drawing.Size(395, 27);
            this.ActorFilmIdTextBox.TabIndex = 2;
            this.ActorFilmIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilmYearTextBox_KeyPress);
            // 
            // ActorsDGV
            // 
            this.ActorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActorsDGV.Location = new System.Drawing.Point(6, 6);
            this.ActorsDGV.Name = "ActorsDGV";
            this.ActorsDGV.RowHeadersWidth = 51;
            this.ActorsDGV.RowTemplate.Height = 29;
            this.ActorsDGV.Size = new System.Drawing.Size(748, 826);
            this.ActorsDGV.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.AuthorsDGV);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1161, 840);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Авторы сценария";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // AuthorsDGV
            // 
            this.AuthorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsDGV.Location = new System.Drawing.Point(6, 6);
            this.AuthorsDGV.Name = "AuthorsDGV";
            this.AuthorsDGV.RowHeadersWidth = 51;
            this.AuthorsDGV.RowTemplate.Height = 29;
            this.AuthorsDGV.Size = new System.Drawing.Size(748, 826);
            this.AuthorsDGV.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.PersonDGV);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1161, 840);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Люди";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // PersonDGV
            // 
            this.PersonDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonDGV.Location = new System.Drawing.Point(6, 6);
            this.PersonDGV.Name = "PersonDGV";
            this.PersonDGV.RowHeadersWidth = 51;
            this.PersonDGV.RowTemplate.Height = 29;
            this.PersonDGV.Size = new System.Drawing.Size(748, 826);
            this.PersonDGV.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DataCarrierDGV);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1161, 840);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Вид носителя";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DataCarrierDGV
            // 
            this.DataCarrierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCarrierDGV.Location = new System.Drawing.Point(6, 6);
            this.DataCarrierDGV.Name = "DataCarrierDGV";
            this.DataCarrierDGV.RowHeadersWidth = 51;
            this.DataCarrierDGV.RowTemplate.Height = 29;
            this.DataCarrierDGV.Size = new System.Drawing.Size(748, 826);
            this.DataCarrierDGV.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.UsersDGV);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1161, 840);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Пользователи";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // UsersDGV
            // 
            this.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDGV.Location = new System.Drawing.Point(6, 6);
            this.UsersDGV.Name = "UsersDGV";
            this.UsersDGV.RowHeadersWidth = 51;
            this.UsersDGV.RowTemplate.Height = 29;
            this.UsersDGV.Size = new System.Drawing.Size(748, 826);
            this.UsersDGV.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FindOrDeleteTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(1169, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 873);
            this.tabControl1.TabIndex = 2;
            // 
            // FindOrDeleteTab
            // 
            this.FindOrDeleteTab.Controls.Add(this.FindOrDeleteCurrentTableLabel);
            this.FindOrDeleteTab.Controls.Add(this.FindOrDeleteLabel);
            this.FindOrDeleteTab.Controls.Add(this.DeleteByIdButton);
            this.FindOrDeleteTab.Controls.Add(this.FindByIdButton);
            this.FindOrDeleteTab.Controls.Add(this.FindOrDeleteComboBox);
            this.FindOrDeleteTab.Controls.Add(this.FindOrDeleteTextBox);
            this.FindOrDeleteTab.Controls.Add(this.FindOrDeleteResultDGV);
            this.FindOrDeleteTab.Location = new System.Drawing.Point(4, 29);
            this.FindOrDeleteTab.Name = "FindOrDeleteTab";
            this.FindOrDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.FindOrDeleteTab.Size = new System.Drawing.Size(612, 840);
            this.FindOrDeleteTab.TabIndex = 0;
            this.FindOrDeleteTab.Text = "Найти или удалить по ID";
            this.FindOrDeleteTab.UseVisualStyleBackColor = true;
            // 
            // FindOrDeleteCurrentTableLabel
            // 
            this.FindOrDeleteCurrentTableLabel.AutoSize = true;
            this.FindOrDeleteCurrentTableLabel.Location = new System.Drawing.Point(163, 9);
            this.FindOrDeleteCurrentTableLabel.Name = "FindOrDeleteCurrentTableLabel";
            this.FindOrDeleteCurrentTableLabel.Size = new System.Drawing.Size(136, 20);
            this.FindOrDeleteCurrentTableLabel.TabIndex = 16;
            this.FindOrDeleteCurrentTableLabel.Text = "- текущая таблица";
            // 
            // FindOrDeleteLabel
            // 
            this.FindOrDeleteLabel.AutoSize = true;
            this.FindOrDeleteLabel.Location = new System.Drawing.Point(163, 144);
            this.FindOrDeleteLabel.Name = "FindOrDeleteLabel";
            this.FindOrDeleteLabel.Size = new System.Drawing.Size(91, 20);
            this.FindOrDeleteLabel.TabIndex = 15;
            this.FindOrDeleteLabel.Text = "ошибок нет";
            // 
            // DeleteByIdButton
            // 
            this.DeleteByIdButton.BackColor = System.Drawing.Color.Firebrick;
            this.DeleteByIdButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteByIdButton.Location = new System.Drawing.Point(6, 140);
            this.DeleteByIdButton.Name = "DeleteByIdButton";
            this.DeleteByIdButton.Size = new System.Drawing.Size(151, 29);
            this.DeleteByIdButton.TabIndex = 14;
            this.DeleteByIdButton.Text = "Удалить";
            this.DeleteByIdButton.UseVisualStyleBackColor = false;
            // 
            // FindByIdButton
            // 
            this.FindByIdButton.BackColor = System.Drawing.Color.Green;
            this.FindByIdButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FindByIdButton.Location = new System.Drawing.Point(6, 105);
            this.FindByIdButton.Name = "FindByIdButton";
            this.FindByIdButton.Size = new System.Drawing.Size(151, 29);
            this.FindByIdButton.TabIndex = 13;
            this.FindByIdButton.Text = "Найти";
            this.FindByIdButton.UseVisualStyleBackColor = false;
            // 
            // FindOrDeleteComboBox
            // 
            this.FindOrDeleteComboBox.FormattingEnabled = true;
            this.FindOrDeleteComboBox.Items.AddRange(new object[] {
            "Фильмы",
            "Актёры",
            "Авторы сценария",
            "Люди",
            "Вид носителя",
            "Пользователи"});
            this.FindOrDeleteComboBox.Location = new System.Drawing.Point(6, 6);
            this.FindOrDeleteComboBox.Name = "FindOrDeleteComboBox";
            this.FindOrDeleteComboBox.Size = new System.Drawing.Size(151, 28);
            this.FindOrDeleteComboBox.TabIndex = 12;
            // 
            // FindOrDeleteTextBox
            // 
            this.FindOrDeleteTextBox.Location = new System.Drawing.Point(6, 40);
            this.FindOrDeleteTextBox.MaxLength = 11;
            this.FindOrDeleteTextBox.Name = "FindOrDeleteTextBox";
            this.FindOrDeleteTextBox.PlaceholderText = "ID";
            this.FindOrDeleteTextBox.Size = new System.Drawing.Size(151, 27);
            this.FindOrDeleteTextBox.TabIndex = 11;
            this.FindOrDeleteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilmYearTextBox_KeyPress);
            // 
            // FindOrDeleteResultDGV
            // 
            this.FindOrDeleteResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindOrDeleteResultDGV.Location = new System.Drawing.Point(6, 175);
            this.FindOrDeleteResultDGV.Name = "FindOrDeleteResultDGV";
            this.FindOrDeleteResultDGV.RowHeadersWidth = 51;
            this.FindOrDeleteResultDGV.RowTemplate.Height = 29;
            this.FindOrDeleteResultDGV.Size = new System.Drawing.Size(598, 657);
            this.FindOrDeleteResultDGV.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 873);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DGVTabControl);
            this.Name = "MainForm";
            this.Text = "Форма заполнения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).EndInit();
            this.DGVTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorsDGV)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDGV)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonDGV)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataCarrierDGV)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.FindOrDeleteTab.ResumeLayout(false);
            this.FindOrDeleteTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindOrDeleteResultDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView MainDGV;
        private TabControl DGVTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView ActorsDGV;
        private TabPage tabPage4;
        private DataGridView PersonDGV;
        private TabPage tabPage5;
        private DataGridView DataCarrierDGV;
        private TabPage tabPage6;
        private DataGridView UsersDGV;
        private TabPage tabPage7;
        private DataGridView AuthorsDGV;
        private TextBox FilmDataCarrierTextBox;
        private TextBox FilmTitleTextBox;
        private TextBox FilmGenreTextBox;
        private TextBox FilmYearTextBox;
        private TextBox FilmDurationTextBox;
        private TextBox FilmProducerTextBox;
        private TextBox FilmSubgenreTextBox;
        private TextBox FilmSummaryTextBox;
        private TextBox FilmCountryTextBox;
        private TextBox FilmStudioTextBox;
        private TabControl tabControl1;
        private TabPage FindOrDeleteTab;
        private DataGridView FindOrDeleteResultDGV;
        private Label FindOrDeleteLabel;
        private Button DeleteByIdButton;
        private Button FindByIdButton;
        private ComboBox FindOrDeleteComboBox;
        private TextBox FindOrDeleteTextBox;
        private Button FilmInsertButton;
        private Label FindOrDeleteCurrentTableLabel;
        private TextBox ActorPersonIdTextBox;
        private TextBox ActorFilmIdTextBox;
        private Button ActorInsertButton;
        private TextBox ActorRoleTextBox;
    }
}