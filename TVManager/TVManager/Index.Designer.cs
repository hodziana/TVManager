using System.Drawing;
using System.Windows.Forms;

namespace TVManager
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rasporedTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emisijeTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.emisijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaTVManagerDataSet1 = new TVManager.BazaTVManagerDataSet1();
            this.dodajEmisijuTab = new System.Windows.Forms.TabPage();
            this.filmoviTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.filmoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodajFilmTab = new System.Windows.Forms.TabPage();
            this.reklameTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reklameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodajReklamuTab = new System.Windows.Forms.TabPage();
            this.reklameTableAdapter = new TVManager.BazaTVManagerDataSet1TableAdapters.ReklameTableAdapter();
            this.tableAdapterManager = new TVManager.BazaTVManagerDataSet1TableAdapters.TableAdapterManager();
            this.emisijeTableAdapter = new TVManager.BazaTVManagerDataSet1TableAdapters.EmisijeTableAdapter();
            this.filmoviTableAdapter = new TVManager.BazaTVManagerDataSet1TableAdapters.FilmoviTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daniPrikazivanjaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtkaziEmisiju = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePocetkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danPrikazivanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtkaziFilm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.rasporedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.emisijeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emisijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaTVManagerDataSet1)).BeginInit();
            this.filmoviTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmoviBindingSource)).BeginInit();
            this.reklameTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.rasporedTab);
            this.tabControl1.Controls.Add(this.emisijeTab);
            this.tabControl1.Controls.Add(this.dodajEmisijuTab);
            this.tabControl1.Controls.Add(this.filmoviTab);
            this.tabControl1.Controls.Add(this.dodajFilmTab);
            this.tabControl1.Controls.Add(this.reklameTab);
            this.tabControl1.Controls.Add(this.dodajReklamuTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // rasporedTab
            // 
            this.rasporedTab.Controls.Add(this.dataGridView1);
            this.rasporedTab.Controls.Add(this.dateTimePicker1);
            this.rasporedTab.Location = new System.Drawing.Point(4, 25);
            this.rasporedTab.Margin = new System.Windows.Forms.Padding(4);
            this.rasporedTab.Name = "rasporedTab";
            this.rasporedTab.Padding = new System.Windows.Forms.Padding(4);
            this.rasporedTab.Size = new System.Drawing.Size(1059, 525);
            this.rasporedTab.TabIndex = 0;
            this.rasporedTab.Text = "Raspored";
            this.rasporedTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 465);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // emisijeTab
            // 
            this.emisijeTab.Controls.Add(this.dataGridView2);
            this.emisijeTab.Location = new System.Drawing.Point(4, 25);
            this.emisijeTab.Margin = new System.Windows.Forms.Padding(4);
            this.emisijeTab.Name = "emisijeTab";
            this.emisijeTab.Padding = new System.Windows.Forms.Padding(4);
            this.emisijeTab.Size = new System.Drawing.Size(1059, 525);
            this.emisijeTab.TabIndex = 1;
            this.emisijeTab.Text = "Emisije";
            this.emisijeTab.UseVisualStyleBackColor = true;
            this.emisijeTab.Click += new System.EventHandler(this.emisijaTab_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.trajanjeDataGridViewTextBoxColumn,
            this.vrijemePocetkaDataGridViewTextBoxColumn,
            this.daniPrikazivanjaDataGridViewCheckBoxColumn,
            this.prioritetDataGridViewTextBoxColumn,
            this.OtkaziEmisiju});
            this.dataGridView2.DataSource = this.emisijeBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1051, 517);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // emisijeBindingSource
            // 
            this.emisijeBindingSource.DataMember = "Emisije";
            this.emisijeBindingSource.DataSource = this.bazaTVManagerDataSet1;
            // 
            // bazaTVManagerDataSet1
            // 
            this.bazaTVManagerDataSet1.DataSetName = "BazaTVManagerDataSet1";
            this.bazaTVManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dodajEmisijuTab
            // 
            this.dodajEmisijuTab.Location = new System.Drawing.Point(4, 25);
            this.dodajEmisijuTab.Margin = new System.Windows.Forms.Padding(4);
            this.dodajEmisijuTab.Name = "dodajEmisijuTab";
            this.dodajEmisijuTab.Padding = new System.Windows.Forms.Padding(4);
            this.dodajEmisijuTab.Size = new System.Drawing.Size(1059, 525);
            this.dodajEmisijuTab.TabIndex = 2;
            this.dodajEmisijuTab.Text = "Dodaj emisiju";
            this.dodajEmisijuTab.UseVisualStyleBackColor = true;
            // 
            // filmoviTab
            // 
            this.filmoviTab.Controls.Add(this.dataGridView3);
            this.filmoviTab.Location = new System.Drawing.Point(4, 25);
            this.filmoviTab.Margin = new System.Windows.Forms.Padding(4);
            this.filmoviTab.Name = "filmoviTab";
            this.filmoviTab.Padding = new System.Windows.Forms.Padding(4);
            this.filmoviTab.Size = new System.Drawing.Size(1059, 525);
            this.filmoviTab.TabIndex = 3;
            this.filmoviTab.Text = "Filmovi";
            this.filmoviTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nazivDataGridViewTextBoxColumn2,
            this.trajanjeDataGridViewTextBoxColumn1,
            this.vrijemePocetkaDataGridViewTextBoxColumn1,
            this.danPrikazivanjaDataGridViewTextBoxColumn,
            this.prioritetDataGridViewTextBoxColumn1,
            this.OtkaziFilm});
            this.dataGridView3.DataSource = this.filmoviBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(4, 4);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(1051, 517);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // filmoviBindingSource
            // 
            this.filmoviBindingSource.DataMember = "Filmovi";
            this.filmoviBindingSource.DataSource = this.bazaTVManagerDataSet1;
            // 
            // dodajFilmTab
            // 
            this.dodajFilmTab.Location = new System.Drawing.Point(4, 25);
            this.dodajFilmTab.Margin = new System.Windows.Forms.Padding(4);
            this.dodajFilmTab.Name = "dodajFilmTab";
            this.dodajFilmTab.Padding = new System.Windows.Forms.Padding(4);
            this.dodajFilmTab.Size = new System.Drawing.Size(1059, 525);
            this.dodajFilmTab.TabIndex = 4;
            this.dodajFilmTab.Text = "Dodaj film";
            this.dodajFilmTab.UseVisualStyleBackColor = true;
            // 
            // reklameTab
            // 
            this.reklameTab.Controls.Add(this.panel1);
            this.reklameTab.Location = new System.Drawing.Point(4, 25);
            this.reklameTab.Margin = new System.Windows.Forms.Padding(4);
            this.reklameTab.Name = "reklameTab";
            this.reklameTab.Padding = new System.Windows.Forms.Padding(4);
            this.reklameTab.Size = new System.Drawing.Size(1059, 525);
            this.reklameTab.TabIndex = 5;
            this.reklameTab.Text = "Reklame";
            this.reklameTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 517);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.terminDataGridViewTextBoxColumn,
            this.Otkazi});
            this.dataGridView4.DataSource = this.reklameBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1051, 517);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminDataGridViewTextBoxColumn
            // 
            this.terminDataGridViewTextBoxColumn.DataPropertyName = "Termin";
            this.terminDataGridViewTextBoxColumn.HeaderText = "Termin";
            this.terminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminDataGridViewTextBoxColumn.Name = "terminDataGridViewTextBoxColumn";
            this.terminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Otkazi
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            this.Otkazi.DefaultCellStyle = dataGridViewCellStyle3;
            this.Otkazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Otkazi.HeaderText = "Otkaži";
            this.Otkazi.MinimumWidth = 6;
            this.Otkazi.Name = "Otkazi";
            this.Otkazi.Text = "Otkaži";
            this.Otkazi.UseColumnTextForButtonValue = true;
            // 
            // reklameBindingSource
            // 
            this.reklameBindingSource.DataMember = "Reklame";
            this.reklameBindingSource.DataSource = this.bazaTVManagerDataSet1;
            // 
            // dodajReklamuTab
            // 
            this.dodajReklamuTab.Location = new System.Drawing.Point(4, 25);
            this.dodajReklamuTab.Margin = new System.Windows.Forms.Padding(4);
            this.dodajReklamuTab.Name = "dodajReklamuTab";
            this.dodajReklamuTab.Padding = new System.Windows.Forms.Padding(4);
            this.dodajReklamuTab.Size = new System.Drawing.Size(1059, 525);
            this.dodajReklamuTab.TabIndex = 6;
            this.dodajReklamuTab.Text = "Dodaj reklamu";
            this.dodajReklamuTab.UseVisualStyleBackColor = true;
            // 
            // reklameTableAdapter
            // 
            this.reklameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmisijeTableAdapter = null;
            this.tableAdapterManager.FilmoviTableAdapter = null;
            this.tableAdapterManager.ReklameTableAdapter = this.reklameTableAdapter;
            this.tableAdapterManager.UpdateOrder = TVManager.BazaTVManagerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // emisijeTableAdapter
            // 
            this.emisijeTableAdapter.ClearBeforeFill = true;
            // 
            // filmoviTableAdapter
            // 
            this.filmoviTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemePocetkaDataGridViewTextBoxColumn
            // 
            this.vrijemePocetkaDataGridViewTextBoxColumn.DataPropertyName = "Vrijeme_Pocetka";
            this.vrijemePocetkaDataGridViewTextBoxColumn.HeaderText = "Vrijeme_Pocetka";
            this.vrijemePocetkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrijemePocetkaDataGridViewTextBoxColumn.Name = "vrijemePocetkaDataGridViewTextBoxColumn";
            this.vrijemePocetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daniPrikazivanjaDataGridViewCheckBoxColumn
            // 
            this.daniPrikazivanjaDataGridViewCheckBoxColumn.DataPropertyName = "Dani_Prikazivanja";
            this.daniPrikazivanjaDataGridViewCheckBoxColumn.HeaderText = "Dani_Prikazivanja";
            this.daniPrikazivanjaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.daniPrikazivanjaDataGridViewCheckBoxColumn.Name = "daniPrikazivanjaDataGridViewCheckBoxColumn";
            this.daniPrikazivanjaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.daniPrikazivanjaDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.daniPrikazivanjaDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prioritetDataGridViewTextBoxColumn
            // 
            this.prioritetDataGridViewTextBoxColumn.DataPropertyName = "Prioritet";
            this.prioritetDataGridViewTextBoxColumn.HeaderText = "Prioritet";
            this.prioritetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prioritetDataGridViewTextBoxColumn.Name = "prioritetDataGridViewTextBoxColumn";
            this.prioritetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OtkaziEmisiju
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.OtkaziEmisiju.DefaultCellStyle = dataGridViewCellStyle1;
            this.OtkaziEmisiju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OtkaziEmisiju.HeaderText = "Otkaži";
            this.OtkaziEmisiju.MinimumWidth = 6;
            this.OtkaziEmisiju.Name = "OtkaziEmisiju";
            this.OtkaziEmisiju.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OtkaziEmisiju.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OtkaziEmisiju.Text = "Otkaži";
            this.OtkaziEmisiju.UseColumnTextForButtonValue = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nazivDataGridViewTextBoxColumn2
            // 
            this.nazivDataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn2.Name = "nazivDataGridViewTextBoxColumn2";
            // 
            // trajanjeDataGridViewTextBoxColumn1
            // 
            this.trajanjeDataGridViewTextBoxColumn1.DataPropertyName = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn1.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.trajanjeDataGridViewTextBoxColumn1.Name = "trajanjeDataGridViewTextBoxColumn1";
            // 
            // vrijemePocetkaDataGridViewTextBoxColumn1
            // 
            this.vrijemePocetkaDataGridViewTextBoxColumn1.DataPropertyName = "Vrijeme_Pocetka";
            this.vrijemePocetkaDataGridViewTextBoxColumn1.HeaderText = "Vrijeme_Pocetka";
            this.vrijemePocetkaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.vrijemePocetkaDataGridViewTextBoxColumn1.Name = "vrijemePocetkaDataGridViewTextBoxColumn1";
            // 
            // danPrikazivanjaDataGridViewTextBoxColumn
            // 
            this.danPrikazivanjaDataGridViewTextBoxColumn.DataPropertyName = "Dan_Prikazivanja";
            this.danPrikazivanjaDataGridViewTextBoxColumn.HeaderText = "Dan_Prikazivanja";
            this.danPrikazivanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.danPrikazivanjaDataGridViewTextBoxColumn.Name = "danPrikazivanjaDataGridViewTextBoxColumn";
            // 
            // prioritetDataGridViewTextBoxColumn1
            // 
            this.prioritetDataGridViewTextBoxColumn1.DataPropertyName = "Prioritet";
            this.prioritetDataGridViewTextBoxColumn1.HeaderText = "Prioritet";
            this.prioritetDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prioritetDataGridViewTextBoxColumn1.Name = "prioritetDataGridViewTextBoxColumn1";
            // 
            // OtkaziFilm
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.OtkaziFilm.DefaultCellStyle = dataGridViewCellStyle2;
            this.OtkaziFilm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OtkaziFilm.HeaderText = "Otkaži";
            this.OtkaziFilm.MinimumWidth = 6;
            this.OtkaziFilm.Name = "OtkaziFilm";
            this.OtkaziFilm.Text = "Otkaži";
            this.OtkaziFilm.UseColumnTextForButtonValue = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Index";
            this.Text = "TV Manager";
            this.Load += new System.EventHandler(this.Index_Load);
            this.tabControl1.ResumeLayout(false);
            this.rasporedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.emisijeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emisijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaTVManagerDataSet1)).EndInit();
            this.filmoviTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmoviBindingSource)).EndInit();
            this.reklameTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage rasporedTab;
        private System.Windows.Forms.TabPage emisijeTab;
        private System.Windows.Forms.TabPage dodajEmisijuTab;
        private System.Windows.Forms.TabPage filmoviTab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage dodajFilmTab;
        private System.Windows.Forms.TabPage reklameTab;
        private System.Windows.Forms.TabPage dodajReklamuTab;
        private System.Windows.Forms.DataGridView dataGridView3;
        private BazaTVManagerDataSet1 bazaTVManagerDataSet1;
        private System.Windows.Forms.BindingSource reklameBindingSource;
        private BazaTVManagerDataSet1TableAdapters.ReklameTableAdapter reklameTableAdapter;
        private BazaTVManagerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private DataGridView dataGridView4;
        private BindingSource emisijeBindingSource;
        private BazaTVManagerDataSet1TableAdapters.EmisijeTableAdapter emisijeTableAdapter;
        private BindingSource filmoviBindingSource;
        private BazaTVManagerDataSet1TableAdapters.FilmoviTableAdapter filmoviTableAdapter;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terminDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn blokDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn nazivBlokaDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Otkazi;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrijemePocetkaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn daniPrikazivanjaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn prioritetDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn OtkaziEmisiju;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn vrijemePocetkaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn danPrikazivanjaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prioritetDataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn OtkaziFilm;
    }
}

