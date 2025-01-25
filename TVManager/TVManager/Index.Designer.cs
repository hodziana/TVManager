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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rasporedTab = new System.Windows.Forms.TabPage();
            this.rasporedButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emisijeTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daniPrikazivanjaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtkaziEmisiju = new System.Windows.Forms.DataGridViewButtonColumn();
            this.emisijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaTVManagerDataSet1 = new TVManager.BazaTVManagerDataSet1();
            this.dodajEmisijuTab = new System.Windows.Forms.TabPage();
            this.groupBoxDodajEmisiju = new System.Windows.Forms.GroupBox();
            this.buttonDodajEmisiju = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonDodajEmisijuNe = new System.Windows.Forms.RadioButton();
            this.radioButtonDodajEmisijuDa = new System.Windows.Forms.RadioButton();
            this.comboBoxDodajEmisiju = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxDodajEmisiju = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDodajEmisiju = new System.Windows.Forms.DateTimePicker();
            this.textBoxDodajEmisijuTrajanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDodajEmisijuNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filmoviTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePocetkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danPrikazivanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtkaziFilm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.filmoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodajFilmTab = new System.Windows.Forms.TabPage();
            this.groupBoxDodajFilm = new System.Windows.Forms.GroupBox();
            this.buttonDodajFilm = new System.Windows.Forms.Button();
            this.radioButtonDodajFilmNe = new System.Windows.Forms.RadioButton();
            this.radioButtonDodajFilmDa = new System.Windows.Forms.RadioButton();
            this.comboBoxDodajFilm = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBoxDodajFilm = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerDodajFilm = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDodajFilmTrajanje = new System.Windows.Forms.TextBox();
            this.textBoxDodajFilmNaziv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBoxDodajReklamu = new System.Windows.Forms.GroupBox();
            this.comboBoxDodajReklamu = new System.Windows.Forms.ComboBox();
            this.textBoxDodajReklamuTrajanje = new System.Windows.Forms.TextBox();
            this.textBoxDodajReklamuCijena = new System.Windows.Forms.TextBox();
            this.buttonDodajReklamu = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxDodajReklamuNaziv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.reklameTableAdapter = new TVManager.BazaTVManagerDataSet1TableAdapters.ReklameTableAdapter();
            this.tableAdapterManager = new TVManager.BazaTVManagerDataSet1TableAdapters.TableAdapterManager();
            this.emisijeTableAdapter = new TVManager.BazaTVManagerDataSet1TableAdapters.EmisijeTableAdapter();
            this.filmoviTableAdapter = new TVManager.BazaTVManagerDataSet1TableAdapters.FilmoviTableAdapter();
            this.tabControl1.SuspendLayout();
            this.rasporedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.emisijeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emisijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaTVManagerDataSet1)).BeginInit();
            this.dodajEmisijuTab.SuspendLayout();
            this.groupBoxDodajEmisiju.SuspendLayout();
            this.filmoviTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmoviBindingSource)).BeginInit();
            this.dodajFilmTab.SuspendLayout();
            this.groupBoxDodajFilm.SuspendLayout();
            this.reklameTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklameBindingSource)).BeginInit();
            this.dodajReklamuTab.SuspendLayout();
            this.groupBoxDodajReklamu.SuspendLayout();
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // rasporedTab
            // 
            this.rasporedTab.Controls.Add(this.rasporedButton);
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
            // rasporedButton
            // 
            this.rasporedButton.Location = new System.Drawing.Point(307, 8);
            this.rasporedButton.Name = "rasporedButton";
            this.rasporedButton.Size = new System.Drawing.Size(155, 32);
            this.rasporedButton.TabIndex = 2;
            this.rasporedButton.Text = "Generiraj raspored";
            this.rasporedButton.UseVisualStyleBackColor = true;
            this.rasporedButton.Click += new System.EventHandler(this.button1_Click_2);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 8);
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
            this.dodajEmisijuTab.Controls.Add(this.groupBoxDodajEmisiju);
            this.dodajEmisijuTab.Location = new System.Drawing.Point(4, 25);
            this.dodajEmisijuTab.Margin = new System.Windows.Forms.Padding(4);
            this.dodajEmisijuTab.Name = "dodajEmisijuTab";
            this.dodajEmisijuTab.Padding = new System.Windows.Forms.Padding(4);
            this.dodajEmisijuTab.Size = new System.Drawing.Size(1059, 525);
            this.dodajEmisijuTab.TabIndex = 2;
            this.dodajEmisijuTab.Text = "Dodaj emisiju";
            this.dodajEmisijuTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxDodajEmisiju
            // 
            this.groupBoxDodajEmisiju.Controls.Add(this.buttonDodajEmisiju);
            this.groupBoxDodajEmisiju.Controls.Add(this.label6);
            this.groupBoxDodajEmisiju.Controls.Add(this.radioButtonDodajEmisijuNe);
            this.groupBoxDodajEmisiju.Controls.Add(this.radioButtonDodajEmisijuDa);
            this.groupBoxDodajEmisiju.Controls.Add(this.comboBoxDodajEmisiju);
            this.groupBoxDodajEmisiju.Controls.Add(this.label5);
            this.groupBoxDodajEmisiju.Controls.Add(this.checkedListBoxDodajEmisiju);
            this.groupBoxDodajEmisiju.Controls.Add(this.label4);
            this.groupBoxDodajEmisiju.Controls.Add(this.label3);
            this.groupBoxDodajEmisiju.Controls.Add(this.dateTimePickerDodajEmisiju);
            this.groupBoxDodajEmisiju.Controls.Add(this.textBoxDodajEmisijuTrajanje);
            this.groupBoxDodajEmisiju.Controls.Add(this.label2);
            this.groupBoxDodajEmisiju.Controls.Add(this.textBoxDodajEmisijuNaziv);
            this.groupBoxDodajEmisiju.Controls.Add(this.label1);
            this.groupBoxDodajEmisiju.Location = new System.Drawing.Point(182, 22);
            this.groupBoxDodajEmisiju.Name = "groupBoxDodajEmisiju";
            this.groupBoxDodajEmisiju.Size = new System.Drawing.Size(530, 373);
            this.groupBoxDodajEmisiju.TabIndex = 0;
            this.groupBoxDodajEmisiju.TabStop = false;
            this.groupBoxDodajEmisiju.Text = "Dodaj emisiju";
            // 
            // buttonDodajEmisiju
            // 
            this.buttonDodajEmisiju.Location = new System.Drawing.Point(377, 335);
            this.buttonDodajEmisiju.Name = "buttonDodajEmisiju";
            this.buttonDodajEmisiju.Size = new System.Drawing.Size(111, 32);
            this.buttonDodajEmisiju.TabIndex = 13;
            this.buttonDodajEmisiju.Text = "Dodaj emisiju!";
            this.buttonDodajEmisiju.UseVisualStyleBackColor = true;
            this.buttonDodajEmisiju.Click += new System.EventHandler(this.buttonDodajEmisiju_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rezervna:";
            // 
            // radioButtonDodajEmisijuNe
            // 
            this.radioButtonDodajEmisijuNe.AutoSize = true;
            this.radioButtonDodajEmisijuNe.Location = new System.Drawing.Point(210, 318);
            this.radioButtonDodajEmisijuNe.Name = "radioButtonDodajEmisijuNe";
            this.radioButtonDodajEmisijuNe.Size = new System.Drawing.Size(46, 20);
            this.radioButtonDodajEmisijuNe.TabIndex = 11;
            this.radioButtonDodajEmisijuNe.TabStop = true;
            this.radioButtonDodajEmisijuNe.Text = "Ne";
            this.radioButtonDodajEmisijuNe.UseVisualStyleBackColor = true;
            // 
            // radioButtonDodajEmisijuDa
            // 
            this.radioButtonDodajEmisijuDa.AutoSize = true;
            this.radioButtonDodajEmisijuDa.Location = new System.Drawing.Point(142, 319);
            this.radioButtonDodajEmisijuDa.Name = "radioButtonDodajEmisijuDa";
            this.radioButtonDodajEmisijuDa.Size = new System.Drawing.Size(46, 20);
            this.radioButtonDodajEmisijuDa.TabIndex = 10;
            this.radioButtonDodajEmisijuDa.TabStop = true;
            this.radioButtonDodajEmisijuDa.Text = "Da";
            this.radioButtonDodajEmisijuDa.UseVisualStyleBackColor = true;
            // 
            // comboBoxDodajEmisiju
            // 
            this.comboBoxDodajEmisiju.FormattingEnabled = true;
            this.comboBoxDodajEmisiju.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxDodajEmisiju.Location = new System.Drawing.Point(139, 275);
            this.comboBoxDodajEmisiju.Name = "comboBoxDodajEmisiju";
            this.comboBoxDodajEmisiju.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDodajEmisiju.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prioritet:";
            // 
            // checkedListBoxDodajEmisiju
            // 
            this.checkedListBoxDodajEmisiju.FormattingEnabled = true;
            this.checkedListBoxDodajEmisiju.Items.AddRange(new object[] {
            "Ponedjeljak",
            "Utorak",
            "Srijeda",
            "Cetvrtak",
            "Petak",
            "Subota",
            "Nedjelja"});
            this.checkedListBoxDodajEmisiju.Location = new System.Drawing.Point(139, 151);
            this.checkedListBoxDodajEmisiju.Name = "checkedListBoxDodajEmisiju";
            this.checkedListBoxDodajEmisiju.Size = new System.Drawing.Size(134, 106);
            this.checkedListBoxDodajEmisiju.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dani u tjednu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrijeme početka:";
            // 
            // dateTimePickerDodajEmisiju
            // 
            this.dateTimePickerDodajEmisiju.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDodajEmisiju.Location = new System.Drawing.Point(152, 110);
            this.dateTimePickerDodajEmisiju.Name = "dateTimePickerDodajEmisiju";
            this.dateTimePickerDodajEmisiju.ShowUpDown = true;
            this.dateTimePickerDodajEmisiju.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDodajEmisiju.TabIndex = 4;
            // 
            // textBoxDodajEmisijuTrajanje
            // 
            this.textBoxDodajEmisijuTrajanje.Location = new System.Drawing.Point(182, 71);
            this.textBoxDodajEmisijuTrajanje.Name = "textBoxDodajEmisijuTrajanje";
            this.textBoxDodajEmisijuTrajanje.Size = new System.Drawing.Size(306, 22);
            this.textBoxDodajEmisijuTrajanje.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trajanje (u minutama):";
            // 
            // textBoxDodajEmisijuNaziv
            // 
            this.textBoxDodajEmisijuNaziv.Location = new System.Drawing.Point(78, 31);
            this.textBoxDodajEmisijuNaziv.Name = "textBoxDodajEmisijuNaziv";
            this.textBoxDodajEmisijuNaziv.Size = new System.Drawing.Size(410, 22);
            this.textBoxDodajEmisijuNaziv.TabIndex = 1;
            this.textBoxDodajEmisijuNaziv.TextChanged += new System.EventHandler(this.textBoxDodajEmisijuNaziv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // filmoviBindingSource
            // 
            this.filmoviBindingSource.DataMember = "Filmovi";
            this.filmoviBindingSource.DataSource = this.bazaTVManagerDataSet1;
            // 
            // dodajFilmTab
            // 
            this.dodajFilmTab.Controls.Add(this.groupBoxDodajFilm);
            this.dodajFilmTab.Location = new System.Drawing.Point(4, 25);
            this.dodajFilmTab.Margin = new System.Windows.Forms.Padding(4);
            this.dodajFilmTab.Name = "dodajFilmTab";
            this.dodajFilmTab.Padding = new System.Windows.Forms.Padding(4);
            this.dodajFilmTab.Size = new System.Drawing.Size(1059, 525);
            this.dodajFilmTab.TabIndex = 4;
            this.dodajFilmTab.Text = "Dodaj film";
            this.dodajFilmTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxDodajFilm
            // 
            this.groupBoxDodajFilm.Controls.Add(this.buttonDodajFilm);
            this.groupBoxDodajFilm.Controls.Add(this.radioButtonDodajFilmNe);
            this.groupBoxDodajFilm.Controls.Add(this.radioButtonDodajFilmDa);
            this.groupBoxDodajFilm.Controls.Add(this.comboBoxDodajFilm);
            this.groupBoxDodajFilm.Controls.Add(this.label12);
            this.groupBoxDodajFilm.Controls.Add(this.label11);
            this.groupBoxDodajFilm.Controls.Add(this.checkedListBoxDodajFilm);
            this.groupBoxDodajFilm.Controls.Add(this.label10);
            this.groupBoxDodajFilm.Controls.Add(this.dateTimePickerDodajFilm);
            this.groupBoxDodajFilm.Controls.Add(this.label9);
            this.groupBoxDodajFilm.Controls.Add(this.label8);
            this.groupBoxDodajFilm.Controls.Add(this.textBoxDodajFilmTrajanje);
            this.groupBoxDodajFilm.Controls.Add(this.textBoxDodajFilmNaziv);
            this.groupBoxDodajFilm.Controls.Add(this.label7);
            this.groupBoxDodajFilm.Location = new System.Drawing.Point(253, 17);
            this.groupBoxDodajFilm.Name = "groupBoxDodajFilm";
            this.groupBoxDodajFilm.Size = new System.Drawing.Size(487, 376);
            this.groupBoxDodajFilm.TabIndex = 0;
            this.groupBoxDodajFilm.TabStop = false;
            this.groupBoxDodajFilm.Text = "Dodaj film";
            // 
            // buttonDodajFilm
            // 
            this.buttonDodajFilm.Location = new System.Drawing.Point(330, 323);
            this.buttonDodajFilm.Name = "buttonDodajFilm";
            this.buttonDodajFilm.Size = new System.Drawing.Size(111, 35);
            this.buttonDodajFilm.TabIndex = 13;
            this.buttonDodajFilm.Text = "Dodaj Film!";
            this.buttonDodajFilm.UseVisualStyleBackColor = true;
            this.buttonDodajFilm.Click += new System.EventHandler(this.buttonDodajFilm_Click);
            // 
            // radioButtonDodajFilmNe
            // 
            this.radioButtonDodajFilmNe.AutoSize = true;
            this.radioButtonDodajFilmNe.Location = new System.Drawing.Point(227, 319);
            this.radioButtonDodajFilmNe.Name = "radioButtonDodajFilmNe";
            this.radioButtonDodajFilmNe.Size = new System.Drawing.Size(46, 20);
            this.radioButtonDodajFilmNe.TabIndex = 12;
            this.radioButtonDodajFilmNe.TabStop = true;
            this.radioButtonDodajFilmNe.Text = "Ne";
            this.radioButtonDodajFilmNe.UseVisualStyleBackColor = true;
            // 
            // radioButtonDodajFilmDa
            // 
            this.radioButtonDodajFilmDa.AutoSize = true;
            this.radioButtonDodajFilmDa.Location = new System.Drawing.Point(118, 319);
            this.radioButtonDodajFilmDa.Name = "radioButtonDodajFilmDa";
            this.radioButtonDodajFilmDa.Size = new System.Drawing.Size(46, 20);
            this.radioButtonDodajFilmDa.TabIndex = 11;
            this.radioButtonDodajFilmDa.TabStop = true;
            this.radioButtonDodajFilmDa.Text = "Da";
            this.radioButtonDodajFilmDa.UseVisualStyleBackColor = true;
            // 
            // comboBoxDodajFilm
            // 
            this.comboBoxDodajFilm.FormattingEnabled = true;
            this.comboBoxDodajFilm.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxDodajFilm.Location = new System.Drawing.Point(118, 272);
            this.comboBoxDodajFilm.Name = "comboBoxDodajFilm";
            this.comboBoxDodajFilm.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDodajFilm.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Rezervan:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Prioritet:";
            // 
            // checkedListBoxDodajFilm
            // 
            this.checkedListBoxDodajFilm.FormattingEnabled = true;
            this.checkedListBoxDodajFilm.Items.AddRange(new object[] {
            "Ponedjeljak",
            "Utorak",
            "Srijeda",
            "Cetvrtak",
            "Petak",
            "Subota",
            "Nedjelja"});
            this.checkedListBoxDodajFilm.Location = new System.Drawing.Point(172, 153);
            this.checkedListBoxDodajFilm.Name = "checkedListBoxDodajFilm";
            this.checkedListBoxDodajFilm.Size = new System.Drawing.Size(120, 89);
            this.checkedListBoxDodajFilm.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Dan prikazivanja:";
            // 
            // dateTimePickerDodajFilm
            // 
            this.dateTimePickerDodajFilm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDodajFilm.Location = new System.Drawing.Point(158, 111);
            this.dateTimePickerDodajFilm.Name = "dateTimePickerDodajFilm";
            this.dateTimePickerDodajFilm.ShowUpDown = true;
            this.dateTimePickerDodajFilm.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDodajFilm.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Vrijeme početka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Trajanje:";
            // 
            // textBoxDodajFilmTrajanje
            // 
            this.textBoxDodajFilmTrajanje.Location = new System.Drawing.Point(103, 69);
            this.textBoxDodajFilmTrajanje.Name = "textBoxDodajFilmTrajanje";
            this.textBoxDodajFilmTrajanje.Size = new System.Drawing.Size(351, 22);
            this.textBoxDodajFilmTrajanje.TabIndex = 2;
            // 
            // textBoxDodajFilmNaziv
            // 
            this.textBoxDodajFilmNaziv.Location = new System.Drawing.Point(71, 31);
            this.textBoxDodajFilmNaziv.Name = "textBoxDodajFilmNaziv";
            this.textBoxDodajFilmNaziv.Size = new System.Drawing.Size(383, 22);
            this.textBoxDodajFilmNaziv.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Naziv:";
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
            this.dodajReklamuTab.Controls.Add(this.groupBoxDodajReklamu);
            this.dodajReklamuTab.Location = new System.Drawing.Point(4, 25);
            this.dodajReklamuTab.Margin = new System.Windows.Forms.Padding(4);
            this.dodajReklamuTab.Name = "dodajReklamuTab";
            this.dodajReklamuTab.Padding = new System.Windows.Forms.Padding(4);
            this.dodajReklamuTab.Size = new System.Drawing.Size(1059, 525);
            this.dodajReklamuTab.TabIndex = 6;
            this.dodajReklamuTab.Text = "Dodaj reklamu";
            this.dodajReklamuTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxDodajReklamu
            // 
            this.groupBoxDodajReklamu.Controls.Add(this.comboBoxDodajReklamu);
            this.groupBoxDodajReklamu.Controls.Add(this.textBoxDodajReklamuTrajanje);
            this.groupBoxDodajReklamu.Controls.Add(this.textBoxDodajReklamuCijena);
            this.groupBoxDodajReklamu.Controls.Add(this.buttonDodajReklamu);
            this.groupBoxDodajReklamu.Controls.Add(this.label16);
            this.groupBoxDodajReklamu.Controls.Add(this.label15);
            this.groupBoxDodajReklamu.Controls.Add(this.label14);
            this.groupBoxDodajReklamu.Controls.Add(this.textBoxDodajReklamuNaziv);
            this.groupBoxDodajReklamu.Controls.Add(this.label13);
            this.groupBoxDodajReklamu.Location = new System.Drawing.Point(262, 17);
            this.groupBoxDodajReklamu.Name = "groupBoxDodajReklamu";
            this.groupBoxDodajReklamu.Size = new System.Drawing.Size(421, 377);
            this.groupBoxDodajReklamu.TabIndex = 0;
            this.groupBoxDodajReklamu.TabStop = false;
            this.groupBoxDodajReklamu.Text = "Dodaj reklamu";
            // 
            // comboBoxDodajReklamu
            // 
            this.comboBoxDodajReklamu.FormattingEnabled = true;
            this.comboBoxDodajReklamu.Items.AddRange(new object[] {
            "prije",
            "tijekom"});
            this.comboBoxDodajReklamu.Location = new System.Drawing.Point(110, 175);
            this.comboBoxDodajReklamu.Name = "comboBoxDodajReklamu";
            this.comboBoxDodajReklamu.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDodajReklamu.TabIndex = 8;
            // 
            // textBoxDodajReklamuTrajanje
            // 
            this.textBoxDodajReklamuTrajanje.Location = new System.Drawing.Point(175, 233);
            this.textBoxDodajReklamuTrajanje.Name = "textBoxDodajReklamuTrajanje";
            this.textBoxDodajReklamuTrajanje.Size = new System.Drawing.Size(215, 22);
            this.textBoxDodajReklamuTrajanje.TabIndex = 7;
            // 
            // textBoxDodajReklamuCijena
            // 
            this.textBoxDodajReklamuCijena.Location = new System.Drawing.Point(150, 110);
            this.textBoxDodajReklamuCijena.Name = "textBoxDodajReklamuCijena";
            this.textBoxDodajReklamuCijena.Size = new System.Drawing.Size(240, 22);
            this.textBoxDodajReklamuCijena.TabIndex = 6;
            // 
            // buttonDodajReklamu
            // 
            this.buttonDodajReklamu.Location = new System.Drawing.Point(268, 325);
            this.buttonDodajReklamu.Name = "buttonDodajReklamu";
            this.buttonDodajReklamu.Size = new System.Drawing.Size(122, 30);
            this.buttonDodajReklamu.TabIndex = 5;
            this.buttonDodajReklamu.Text = "Dodaj reklamu!";
            this.buttonDodajReklamu.UseVisualStyleBackColor = true;
            this.buttonDodajReklamu.Click += new System.EventHandler(this.buttonDodajReklamu_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Trajanje (u minutama):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Termin:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cijena (u eurima):";
            // 
            // textBoxDodajReklamuNaziv
            // 
            this.textBoxDodajReklamuNaziv.Location = new System.Drawing.Point(83, 47);
            this.textBoxDodajReklamuNaziv.Name = "textBoxDodajReklamuNaziv";
            this.textBoxDodajReklamuNaziv.Size = new System.Drawing.Size(307, 22);
            this.textBoxDodajReklamuNaziv.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Naziv:";
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
            this.dodajEmisijuTab.ResumeLayout(false);
            this.groupBoxDodajEmisiju.ResumeLayout(false);
            this.groupBoxDodajEmisiju.PerformLayout();
            this.filmoviTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmoviBindingSource)).EndInit();
            this.dodajFilmTab.ResumeLayout(false);
            this.groupBoxDodajFilm.ResumeLayout(false);
            this.groupBoxDodajFilm.PerformLayout();
            this.reklameTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklameBindingSource)).EndInit();
            this.dodajReklamuTab.ResumeLayout(false);
            this.groupBoxDodajReklamu.ResumeLayout(false);
            this.groupBoxDodajReklamu.PerformLayout();
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
        private GroupBox groupBoxDodajEmisiju;
        private TextBox textBoxDodajEmisijuTrajanje;
        private Label label2;
        private TextBox textBoxDodajEmisijuNaziv;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePickerDodajEmisiju;
        private CheckedListBox checkedListBoxDodajEmisiju;
        private Label label4;
        private ComboBox comboBoxDodajEmisiju;
        private Label label5;
        private Button buttonDodajEmisiju;
        private Label label6;
        private RadioButton radioButtonDodajEmisijuNe;
        private RadioButton radioButtonDodajEmisijuDa;
        private GroupBox groupBoxDodajFilm;
        private DateTimePicker dateTimePickerDodajFilm;
        private Label label9;
        private Label label8;
        private TextBox textBoxDodajFilmTrajanje;
        private TextBox textBoxDodajFilmNaziv;
        private Label label7;
        private Label label12;
        private Label label11;
        private CheckedListBox checkedListBoxDodajFilm;
        private Label label10;
        private ComboBox comboBoxDodajFilm;
        private Button buttonDodajFilm;
        private RadioButton radioButtonDodajFilmNe;
        private RadioButton radioButtonDodajFilmDa;
        private GroupBox groupBoxDodajReklamu;
        private Button buttonDodajReklamu;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox textBoxDodajReklamuNaziv;
        private Label label13;
        private TextBox textBoxDodajReklamuCijena;
        private TextBox textBoxDodajReklamuTrajanje;
        private ComboBox comboBoxDodajReklamu;
        private Button rasporedButton;
    }
}

