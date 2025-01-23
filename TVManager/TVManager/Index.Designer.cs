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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rasporedTab = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emisijeTab = new System.Windows.Forms.TabPage();
            this.dodajEmisijuTab = new System.Windows.Forms.TabPage();
            this.filmoviTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dodajFilmTab = new System.Windows.Forms.TabPage();
            this.reklameTab = new System.Windows.Forms.TabPage();
            this.dodajReklamuTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.rasporedTab.SuspendLayout();
            this.emisijeTab.SuspendLayout();
            this.filmoviTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.reklameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // rasporedTab
            // 
            this.rasporedTab.Controls.Add(this.dataGridView1);
            this.rasporedTab.Controls.Add(this.dateTimePicker1);
            this.rasporedTab.Location = new System.Drawing.Point(4, 22);
            this.rasporedTab.Name = "rasporedTab";
            this.rasporedTab.Padding = new System.Windows.Forms.Padding(3);
            this.rasporedTab.Size = new System.Drawing.Size(792, 424);
            this.rasporedTab.TabIndex = 0;
            this.rasporedTab.Text = "Raspored";
            this.rasporedTab.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // emisijeTab
            // 
            this.emisijeTab.Controls.Add(this.dataGridView2);
            this.emisijeTab.Location = new System.Drawing.Point(4, 22);
            this.emisijeTab.Name = "emisijeTab";
            this.emisijeTab.Padding = new System.Windows.Forms.Padding(3);
            this.emisijeTab.Size = new System.Drawing.Size(792, 424);
            this.emisijeTab.TabIndex = 1;
            this.emisijeTab.Text = "Emisije";
            this.emisijeTab.UseVisualStyleBackColor = true;
            this.emisijeTab.Click += new System.EventHandler(this.emisijaTab_Click);
            // 
            // dodajEmisijuTab
            // 
            this.dodajEmisijuTab.Location = new System.Drawing.Point(4, 22);
            this.dodajEmisijuTab.Name = "dodajEmisijuTab";
            this.dodajEmisijuTab.Padding = new System.Windows.Forms.Padding(3);
            this.dodajEmisijuTab.Size = new System.Drawing.Size(792, 424);
            this.dodajEmisijuTab.TabIndex = 2;
            this.dodajEmisijuTab.Text = "Dodaj emisiju";
            this.dodajEmisijuTab.UseVisualStyleBackColor = true;
            // 
            // filmoviTab
            // 
            this.filmoviTab.Controls.Add(this.dataGridView3);
            this.filmoviTab.Location = new System.Drawing.Point(4, 22);
            this.filmoviTab.Name = "filmoviTab";
            this.filmoviTab.Padding = new System.Windows.Forms.Padding(3);
            this.filmoviTab.Size = new System.Drawing.Size(792, 424);
            this.filmoviTab.TabIndex = 3;
            this.filmoviTab.Text = "Filmovi";
            this.filmoviTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(789, 378);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(786, 418);
            this.dataGridView2.TabIndex = 1;
            // 
            // dodajFilmTab
            // 
            this.dodajFilmTab.Location = new System.Drawing.Point(4, 22);
            this.dodajFilmTab.Name = "dodajFilmTab";
            this.dodajFilmTab.Padding = new System.Windows.Forms.Padding(3);
            this.dodajFilmTab.Size = new System.Drawing.Size(792, 424);
            this.dodajFilmTab.TabIndex = 4;
            this.dodajFilmTab.Text = "Dodaj film";
            this.dodajFilmTab.UseVisualStyleBackColor = true;
            // 
            // reklameTab
            // 
            this.reklameTab.Controls.Add(this.dataGridView4);
            this.reklameTab.Location = new System.Drawing.Point(4, 22);
            this.reklameTab.Name = "reklameTab";
            this.reklameTab.Padding = new System.Windows.Forms.Padding(3);
            this.reklameTab.Size = new System.Drawing.Size(792, 424);
            this.reklameTab.TabIndex = 5;
            this.reklameTab.Text = "Reklame";
            this.reklameTab.UseVisualStyleBackColor = true;
            // 
            // dodajReklamuTab
            // 
            this.dodajReklamuTab.Location = new System.Drawing.Point(4, 22);
            this.dodajReklamuTab.Name = "dodajReklamuTab";
            this.dodajReklamuTab.Padding = new System.Windows.Forms.Padding(3);
            this.dodajReklamuTab.Size = new System.Drawing.Size(792, 424);
            this.dodajReklamuTab.TabIndex = 6;
            this.dodajReklamuTab.Text = "Dodaj reklamu";
            this.dodajReklamuTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(786, 418);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(786, 418);
            this.dataGridView4.TabIndex = 1;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Index";
            this.Text = "TV Manager";
            this.tabControl1.ResumeLayout(false);
            this.rasporedTab.ResumeLayout(false);
            this.emisijeTab.ResumeLayout(false);
            this.filmoviTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.reklameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}

