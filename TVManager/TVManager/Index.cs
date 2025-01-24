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

namespace TVManager
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void emisijaTab_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            // implementirat da se refresa raspored i prikaze za novi odabrani datum
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);

                DialogResult result = MessageBox.Show($"Jeste li sigurni da želite otkazati reklamu s id-em {selectedId}?",
                                                      "Confirm Cancellation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    OtkaziReklamu(selectedId);
                    RefreshReklame();
                }
            }
        }

        private void OtkaziReklamu(int reklameId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ivana\\source\\repos\\TVManager\\TVManager\\TVManager\\BazaTVManager.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "DELETE FROM Reklame WHERE Id = @ReklameId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReklameId", reklameId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Reklama je otkazana", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Doslo je do greske: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshReklame()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ivana\\source\\repos\\TVManager\\TVManager\\TVManager\\BazaTVManager.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Reklame";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable reklameTable = new DataTable();
                        adapter.Fill(reklameTable);
                        dataGridView4.DataSource = reklameTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Doslo je do greske pri osvjezavanju: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Index_Load(object sender, EventArgs e)
        {
            this.filmoviTableAdapter.Fill(this.bazaTVManagerDataSet1.Filmovi);
            // TODO: This line of code loads data into the 'bazaTVManagerDataSet1.Emisije' table. You can move, or remove it, as needed.
            this.emisijeTableAdapter.Fill(this.bazaTVManagerDataSet1.Emisije);
            this.reklameTableAdapter.Fill(this.bazaTVManagerDataSet1.Reklame);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn1"].Value);

                DialogResult result = MessageBox.Show($"Jeste li sigurni da želite otkazati emisiju s id-em {selectedId}?",
                                                      "Confirm Cancellation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ObrisiEmisiju(selectedId);
                    RefreshEmisije();
                }
            }
        }

        private void ObrisiEmisiju(int emisijaId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ivana\\source\\repos\\TVManager\\TVManager\\TVManager\\BazaTVManager.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "DELETE FROM Emisije WHERE Id = @EmisijeId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmisijeId", emisijaId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Emisija je otkazana", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Doslo je do greske: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshEmisije()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ivana\\source\\repos\\TVManager\\TVManager\\TVManager\\BazaTVManager.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Emisije";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable emisijeTable = new DataTable();
                        adapter.Fill(emisijeTable);
                        dataGridView2.DataSource = emisijeTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Doslo je do greske pri osvjezavanju: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn2"].Value);

                DialogResult result = MessageBox.Show($"Jeste li sigurni da želite otkazati film s id-em {selectedId}?",
                                                      "Confirm Cancellation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ObrisiFilm(selectedId);
                    RefreshFilmovi();
                }
            }
        }

        private void ObrisiFilm(int filmId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ivana\\source\\repos\\TVManager\\TVManager\\TVManager\\BazaTVManager.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "DELETE FROM Filmovi WHERE Id = @FilmId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FilmId", filmId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Film je otkazan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Doslo je do greske: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshFilmovi()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ivana\\source\\repos\\TVManager\\TVManager\\TVManager\\BazaTVManager.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Filmovi";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable filmoviTable = new DataTable();
                        adapter.Fill(filmoviTable);
                        dataGridView3.DataSource = filmoviTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Doslo je do greske pri osvjezavanju: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
