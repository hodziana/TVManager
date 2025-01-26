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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivana\source\repos\TVManager\TVManager\TVManager\BazaTVManager.mdf;Integrated Security=True";
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
                using (SqlConnection conn = new SqlConnection(connectionString))
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
                using (SqlConnection conn = new SqlConnection(connectionString))
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
                using (SqlConnection conn = new SqlConnection(connectionString))
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
                using (SqlConnection conn = new SqlConnection(connectionString))
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
                using (SqlConnection conn = new SqlConnection(connectionString))
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
                using (SqlConnection conn = new SqlConnection(connectionString))
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

        private void buttonDodajEmisiju_Click(object sender, EventArgs e)
        {
            string naziv = textBoxDodajEmisijuNaziv.Text.Trim();
            int trajanje;
            if (!int.TryParse(textBoxDodajEmisijuTrajanje.Text, out trajanje))
            {
                MessageBox.Show("Molimo unesite ispravno trajanje u minutama.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int prioritet = int.Parse(comboBoxDodajEmisiju.SelectedItem?.ToString() ?? "0");
            string vrijemePocetka = dateTimePickerDodajEmisiju.Value.ToString("HH:mm");
            var daniPrikazivanja = string.Join(",", checkedListBoxDodajEmisiju.CheckedItems.Cast<string>());
            bool rezervna = radioButtonDodajEmisijuDa.Checked;

            if (string.IsNullOrEmpty(naziv))
            {
                MessageBox.Show("Molimo unesite naziv emisije.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL upit za unos
                    string query = @"INSERT INTO Emisije (Naziv, Trajanje, Prioritet, Vrijeme_Pocetka, Dani_Prikazivanja, Rezervna) 
                             VALUES (@naziv, @trajanje, @prioritet, @vrijemePocetka, @daniPrikazivanja, @rezervna)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dodavanje parametara u upit
                        command.Parameters.AddWithValue("@naziv", naziv);
                        command.Parameters.AddWithValue("@trajanje", trajanje);
                        command.Parameters.AddWithValue("@prioritet", prioritet);
                        command.Parameters.AddWithValue("@vrijemePocetka", vrijemePocetka);
                        command.Parameters.AddWithValue("@daniPrikazivanja", daniPrikazivanja);
                        command.Parameters.AddWithValue("@rezervna", rezervna);

                        // Izvršavanje upita
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Emisija je uspješno dodana u bazu!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Očistite polja na formi
                            textBoxDodajEmisijuNaziv.Clear();
                            textBoxDodajEmisijuTrajanje.Clear();
                            comboBoxDodajEmisiju.SelectedIndex = -1;
                            checkedListBoxDodajEmisiju.ClearSelected();
                            radioButtonDodajEmisijuDa.Checked = false;
                            radioButtonDodajEmisijuNe.Checked = false;
                            RefreshEmisije();
                        }
                        else
                        {
                            MessageBox.Show("Došlo je do pogreške prilikom dodavanja emisije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška prilikom spajanja s bazom: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDodajEmisijuNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDodajFilm_Click(object sender, EventArgs e)
        {
            string naziv = textBoxDodajFilmNaziv.Text.Trim();
            int trajanje;
            if (!int.TryParse(textBoxDodajFilmTrajanje.Text, out trajanje))
            {
                MessageBox.Show("Molimo unesite ispravno trajanje u minutama.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int prioritet = int.Parse(comboBoxDodajFilm.SelectedItem?.ToString() ?? "0");
            string vrijemePocetka = dateTimePickerDodajFilm.Value.ToString("HH:mm");
            var danPrikazivanja = string.Join(",", checkedListBoxDodajFilm.CheckedItems.Cast<string>());
            bool rezervan = radioButtonDodajFilmDa.Checked;

            if (string.IsNullOrEmpty(naziv))
            {
                MessageBox.Show("Molimo unesite naziv filma.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL upit za unos
                    string query = @"INSERT INTO Filmovi (Naziv, Trajanje, Prioritet, Vrijeme_Pocetka, Dan_Prikazivanja, Rezervan) 
                             VALUES (@naziv, @trajanje, @prioritet, @vrijemePocetka, @danPrikazivanja, @rezervan)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dodavanje parametara u upit
                        command.Parameters.AddWithValue("@naziv", naziv);
                        command.Parameters.AddWithValue("@trajanje", trajanje);
                        command.Parameters.AddWithValue("@prioritet", prioritet);
                        command.Parameters.AddWithValue("@vrijemePocetka", vrijemePocetka);
                        command.Parameters.AddWithValue("@danPrikazivanja", danPrikazivanja);
                        command.Parameters.AddWithValue("@rezervan", rezervan);

                        // Izvršavanje upita
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Film je uspješno dodan u bazu!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Očistite polja na formi
                            textBoxDodajFilmNaziv.Clear();
                            textBoxDodajFilmTrajanje.Clear();
                            comboBoxDodajFilm.SelectedIndex = -1;
                            checkedListBoxDodajFilm.ClearSelected();
                            radioButtonDodajFilmDa.Checked = false;
                            radioButtonDodajFilmNe.Checked = false;

                            RefreshFilmovi();
                        }
                        else
                        {
                            MessageBox.Show("Došlo je do pogreške prilikom dodavanja filma.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška prilikom spajanja s bazom: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDodajReklamu_Click(object sender, EventArgs e)
        {
            string naziv = textBoxDodajReklamuNaziv.Text.Trim();
            int trajanje;
            if (!int.TryParse(textBoxDodajReklamuTrajanje.Text, out trajanje))
            {
                MessageBox.Show("Molimo unesite ispravno trajanje u minutama.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            float cijena;
            if (!float.TryParse(textBoxDodajReklamuCijena.Text, out cijena))
            {
                MessageBox.Show("Molimo unesite ispravno cijenu u eurima.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string termin = comboBoxDodajReklamu.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(termin))
            {
                MessageBox.Show("Molimo odaberite opciju iz padajućeg izbornika.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(naziv))
            {
                MessageBox.Show("Molimo unesite naziv reklame.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL upit za unos
                    string query = @"INSERT INTO Reklame (Naziv, Trajanje, Cijena, Termin) 
                             VALUES (@naziv, @trajanje, @cijena, @termin)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dodavanje parametara u upit
                        command.Parameters.AddWithValue("@naziv", naziv);
                        command.Parameters.AddWithValue("@trajanje", trajanje);
                        command.Parameters.AddWithValue("@cijena", cijena);
                        command.Parameters.AddWithValue("@termin", termin);

                        // Izvršavanje upita
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reklama je uspješno dodana u bazu!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Očistite polja na formi
                            textBoxDodajReklamuNaziv.Clear();
                            textBoxDodajReklamuTrajanje.Clear();
                            textBoxDodajReklamuCijena.Clear();
                            comboBoxDodajReklamu.SelectedIndex = -1;

                            RefreshReklame();
                        }
                        else
                        {
                            MessageBox.Show("Došlo je do pogreške prilikom dodavanja reklame.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška prilikom spajanja s bazom: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrikaziRaspored(List<RasporedBlok> raspored)
        {
            dataGridView1.DataSource = null; // Očisti prethodne podatke
            var sortiraniRaspored = raspored.OrderBy(r => r.VrijemePocetka).ToList();

            // Postavljanje sortiranih podataka
            dataGridView1.DataSource = sortiraniRaspored;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            string odabraniDan = dateTimePicker1.Value.Date.ToString("dddd", new System.Globalization.CultureInfo("hr-HR"));

            odabraniDan = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(odabraniDan);
            if (odabraniDan == "Četvrtak")
            {
                odabraniDan = "Cetvrtak";
            }

            if (!string.IsNullOrEmpty(odabraniDan))
            {
                PrikaziRaspored(GenerirajRaspored(odabraniDan));
            }
            else
            {
                MessageBox.Show("Molimo odaberite dan za generiranje rasporeda.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<Emisija> UcitajEmisije()
        {
            var emisije = new List<Emisija>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Naziv, Trajanje, Vrijeme_Pocetka, Dani_Prikazivanja, Prioritet, Rezervna FROM Emisije";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var emisija = new Emisija
                        {
                            Id = reader.GetInt32(0),
                            Naziv = reader.GetString(1),
                            Trajanje = reader.GetInt32(2),
                            VrijemePocetka = reader.GetTimeSpan(3),
                            DaniPrikazivanja = new List<string>(reader.GetString(4).Split(',')),
                            Prioritet = reader.GetInt32(5),
                            Rezervna = reader.GetBoolean(6)
                        };
                        emisije.Add(emisija);
                    }
                }
            }

            return emisije;
        }

        public List<Film> UcitajFilmove()
        {
            var filmovi = new List<Film>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Naziv, Trajanje, Vrijeme_Pocetka, Dan_Prikazivanja, Prioritet, Rezervan FROM Filmovi";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var film = new Film
                        {
                            Id = reader.GetInt32(0),
                            Naziv = reader.GetString(1),
                            Trajanje = reader.GetInt32(2),
                            VrijemePocetka = reader.GetTimeSpan(3),
                            DanPrikazivanja = reader.GetString(4),
                            Prioritet = reader.GetInt32(5),
                            Rezervan = reader.GetBoolean(6)
                        };
                        filmovi.Add(film);
                    }
                }
            }

            return filmovi;
        }

        public List<Reklama> UcitajReklame()
        {
            var reklame = new List<Reklama>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Naziv, Cijena, Termin, Trajanje FROM Reklame";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var reklama = new Reklama
                        {
                            Id = reader.GetInt32(0),
                            Naziv = reader.GetString(1),
                            Cijena = Convert.ToInt32(reader.GetValue(2)),
                            Termin = reader.GetString(3),
                            Trajanje = reader.GetInt32(4)
                        };
                        reklame.Add(reklama);
                    }
                }
            }

            return reklame;
        }
        // ----------------------------------------------------------
        private bool ImaKoliziju(List<RasporedBlok> raspored, TimeSpan pocetak, TimeSpan kraj)
        {
            foreach (var stavka in raspored)
            {
                if ((stavka.VrijemePocetka < pocetak && stavka.VrijemeZavrsetka > pocetak) || (stavka.VrijemePocetka < kraj && stavka.VrijemeZavrsetka > kraj)
                    || (pocetak < stavka.VrijemePocetka && kraj > stavka.VrijemeZavrsetka) || (stavka.VrijemePocetka < pocetak && stavka.VrijemeZavrsetka > kraj))
                {
                    return true;
                }
            }
            return false;
        }
        // ----------------------------------------------------------
        public List<RasporedBlok> GenerirajRaspored(string odabraniDan)
        {
            var raspored = new List<RasporedBlok>();

            var reklame = UcitajReklame();
            var filmovi = UcitajFilmove();
            var emisije = UcitajEmisije();

            var reklameTijekomSortirane = reklame.Where(e => e.Termin == "tijekom").OrderByDescending(e => e.Cijena).ToList();
            var reklameOstaleSortirane = reklame.Where(e => e.Termin != "tijekom").OrderByDescending(e => e.Cijena).ToList();

            var emisijeZaDan = emisije.Where(e => e.DaniPrikazivanja.Contains(odabraniDan) && !e.Rezervna).ToList();
            emisijeZaDan.OrderByDescending(e => e.Prioritet);
            var filmoviZaDan = filmovi.Where(f => f.DanPrikazivanja == odabraniDan && !f.Rezervan).ToList();

            foreach (var emisija in emisijeZaDan.Where(e => !e.Rezervna))
            {
                if (emisija.Trajanje >= 60 && !ImaKoliziju(raspored, emisija.VrijemePocetka, emisija.VrijemePocetka.Add(TimeSpan.FromMinutes(10)).Add(TimeSpan.FromMinutes(emisija.Trajanje))))
                {
                    if (!reklameTijekomSortirane.Any())
                    {
                        reklameTijekomSortirane = reklame.Where(e => e.Termin == "tijekom").ToList();
                    }
                    TimeSpan reklameVrijeme = emisija.VrijemePocetka.Add(TimeSpan.FromMinutes(emisija.Trajanje / 2));
                    int ukupnoVrijemeReklama = 0;
                    List<Reklama> odabraneReklameTijekom = new List<Reklama>();
                    while (ukupnoVrijemeReklama < 9 * 60)
                    {
                        Reklama prviKandidat;
                        try
                        {
                            prviKandidat = reklameTijekomSortirane.First();
                        }
                        catch (InvalidOperationException e)
                        {
                            break;
                        }
                        if (ukupnoVrijemeReklama + prviKandidat.Trajanje > 10 * 60)
                        {
                            break;
                        }

                        ukupnoVrijemeReklama += prviKandidat.Trajanje;
                        odabraneReklameTijekom.Add(prviKandidat);
                        reklameTijekomSortirane.Remove(prviKandidat);
                    }
                    //MessageBox.Show(odabraneReklameTijekom.First().Naziv);
                    //MessageBox.Show(emisija.Naziv);

                    var prethodnoVrijeme = reklameVrijeme;
                    foreach (var odabranaReklama in odabraneReklameTijekom)
                    {
                        var sadasnjeVrijeme = prethodnoVrijeme.Add(TimeSpan.FromMinutes(odabranaReklama.Trajanje));
                        raspored.Add(new RasporedBlok
                        {
                            VrijemePocetka = prethodnoVrijeme,
                            VrijemeZavrsetka = sadasnjeVrijeme,
                            Tip = "Reklame (tijekom)",
                            Naziv = odabranaReklama.Naziv
                        });

                        prethodnoVrijeme = sadasnjeVrijeme;
                    }
                    raspored.Add(new RasporedBlok
                    {
                        VrijemePocetka = emisija.VrijemePocetka,
                        VrijemeZavrsetka = reklameVrijeme,
                        Tip = emisija.Rezervna ? "Rezervni program" : "Emisija",
                        Naziv = emisija.Naziv
                    });
                    raspored.Add(new RasporedBlok
                    {
                        VrijemePocetka = prethodnoVrijeme,
                        VrijemeZavrsetka = prethodnoVrijeme.Add(TimeSpan.FromMinutes(emisija.Trajanje / 2)),
                        Tip = emisija.Rezervna ? "Rezervni program" : "Emisija",
                        Naziv = emisija.Naziv
                    });
                }
                else if (!ImaKoliziju(raspored, emisija.VrijemePocetka, emisija.VrijemePocetka.Add(TimeSpan.FromMinutes(emisija.Trajanje))))
                {
                    raspored.Add(new RasporedBlok
                    {
                        VrijemePocetka = emisija.VrijemePocetka,
                        VrijemeZavrsetka = emisija.VrijemePocetka.Add(TimeSpan.FromMinutes(emisija.Trajanje)),
                        Tip = "Emisija",
                        Naziv = emisija.Naziv
                    });
                }
            }

            // Filtriranje i dodavanje filmova u raspored
            filmoviZaDan
            .OrderByDescending(f => f.Prioritet)
            .ThenBy(f => f.VrijemePocetka)
            .ToList();

            foreach (var film in filmoviZaDan)
            {
                // Dodaj film u raspored
                TimeSpan vrijemePocetka = film.VrijemePocetka;
                TimeSpan vrijemeZavrsetka = vrijemePocetka.Add(TimeSpan.FromMinutes(film.Trajanje));

                if (!ImaKoliziju(raspored, vrijemePocetka, vrijemeZavrsetka))
                {
                    raspored.Add(new RasporedBlok
                    {
                        VrijemePocetka = vrijemePocetka,
                        VrijemeZavrsetka = vrijemeZavrsetka,
                        Tip = film.Rezervan ? "Rezervni program" : "Film",
                        Naziv = film.Naziv
                    });
                }
            }


            var rezervneEmisije = emisijeZaDan.Where(e => e.Rezervna)
           .OrderByDescending(e => e.Prioritet)
           .ThenBy(e => e.VrijemePocetka)
           .ToList();

            foreach (var sadrzaj in rezervneEmisije)
            {
                // Dodaj sadrzaj u raspored
                TimeSpan vrijemePocetka = raspored.LastOrDefault()?.VrijemeZavrsetka ?? TimeSpan.FromHours(6); // Početak dana u 6:00
                TimeSpan vrijemeZavrsetka = vrijemePocetka.Add(TimeSpan.FromMinutes(sadrzaj.Trajanje));

                if (!ImaKoliziju(raspored, vrijemePocetka, vrijemeZavrsetka))
                {
                    raspored.Add(new RasporedBlok
                    {
                        VrijemePocetka = vrijemePocetka,
                        VrijemeZavrsetka = vrijemeZavrsetka,
                        Tip = "Rezervni program - Emisija",
                        Naziv = sadrzaj.Naziv
                    });
                }
            }

            var rezervniFilmovi = emisijeZaDan.Where(e => e.Rezervna)
            .OrderByDescending(e => e.Prioritet)
            .ThenBy(e => e.VrijemePocetka)
            .ToList();

            foreach (var sadrzaj in rezervniFilmovi)
            {
                // Dodaj sadrzaj u raspored
                TimeSpan vrijemePocetka = raspored.LastOrDefault()?.VrijemeZavrsetka ?? TimeSpan.FromHours(6); // Početak dana u 6:00
                TimeSpan vrijemeZavrsetka = vrijemePocetka.Add(TimeSpan.FromMinutes(sadrzaj.Trajanje));

                if (!ImaKoliziju(raspored, vrijemePocetka, vrijemeZavrsetka))
                {
                    raspored.Add(new RasporedBlok
                    {
                        VrijemePocetka = vrijemePocetka,
                        VrijemeZavrsetka = vrijemeZavrsetka,
                        Tip = "Rezervni program - Film",
                        Naziv = sadrzaj.Naziv
                    });
                }
            }

            List<RasporedBlok> blokoviReklama = new List<RasporedBlok>();
            raspored = raspored.OrderBy(r => r.VrijemePocetka).ToList();

            // 5. Ubaci blok reklama između svih sadržaja

            int ukupnoVrijeme = 0;
            List<Reklama> odabraneReklameIzmedju = new List<Reklama>();
            while (ukupnoVrijeme < 3 * 60)
            {
                Reklama prviKandidat;
                try
                {
                    prviKandidat = reklameOstaleSortirane.First();
                }
                catch (InvalidOperationException e)
                {
                    break;
                }
                if (ukupnoVrijeme + prviKandidat.Trajanje > 6 * 60)
                {
                    break;
                }

                ukupnoVrijeme += prviKandidat.Trajanje;
                odabraneReklameIzmedju.Add(prviKandidat);
                reklameOstaleSortirane.Remove(prviKandidat);
            }

            for (int i = 0; i < raspored.Count - 1; i++)
            {
                TimeSpan razmak = raspored[i + 1].VrijemePocetka - raspored[i].VrijemeZavrsetka;
                var prethodnoVrijeme = raspored[i].VrijemeZavrsetka;
                List<RasporedBlok> reklamniBlok = new List<RasporedBlok>();
                if (razmak > TimeSpan.FromMinutes(5) && raspored[i].Tip.Trim() != "Reklame" && raspored[i + 1].Tip.Trim() != "Reklame") // Ako postoji praznina
                {
                    foreach (var odabranaReklama in odabraneReklameIzmedju)
                    {
                        var sadasnjeVrijeme = prethodnoVrijeme.Add(TimeSpan.FromMinutes(odabranaReklama.Trajanje));
                        if (sadasnjeVrijeme > raspored[i+1].VrijemePocetka) {
                            reklamniBlok.Add(new RasporedBlok
                            {
                                VrijemePocetka = prethodnoVrijeme,
                                VrijemeZavrsetka = raspored[i+1].VrijemePocetka,
                                Tip = "Najave",
                                Naziv = "Najave i pauze u programu"
                            });
                        }

                        reklamniBlok.Add(new RasporedBlok
                        {
                            VrijemePocetka = prethodnoVrijeme,
                            VrijemeZavrsetka = sadasnjeVrijeme,
                            Tip = "Reklame",
                            Naziv = odabranaReklama.Naziv
                        });

                        prethodnoVrijeme = sadasnjeVrijeme;
                    }
                    
                    if (prethodnoVrijeme < raspored[i+1].VrijemePocetka)
                    {
                    reklamniBlok.Add(new RasporedBlok
                        {
                            VrijemePocetka = prethodnoVrijeme,
                            VrijemeZavrsetka = raspored[i + 1].VrijemePocetka,
                            Tip = "Najave",
                            Naziv = "Najave i pauze u programu"
                        });
                    }
                   
                }
                raspored.AddRange(reklamniBlok);
            }

            raspored = raspored.OrderBy(r => r.VrijemePocetka).ToList();


            return raspored;
        }
    }
}
