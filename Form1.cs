using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace formuygulamasi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Veritaban� ba�lant�s�
            string connectionString = "Server=localhost;Database=YemekSiparisiDB;Uid=root;Pwd=mysqlsifre;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // YemekKategorileri'ni ComboBox1'e y�kleme
                    string query = "SELECT DISTINCT KategoriAdi FROM YemekKategorileri";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox1.Items.Clear();  // ComboBox'u �nce temizliyoruz
                        while (reader.Read())
                        {
                            string kategoriAdi = reader["KategoriAdi"].ToString();
                            if (!comboBox1.Items.Contains(kategoriAdi))  // Ayn� kategori zaten eklenmi� mi kontrol ediyoruz
                            {
                                comboBox1.Items.Add(kategoriAdi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritaban� ba�lant� hatas�: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedKategori = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedKategori))
            {
                label1.Text = "Se�ilen Kategori: " + selectedKategori;

                // Veritaban� ba�lant�s�
                string connectionString = "Server=localhost;Database=YemekSiparisiDB;Uid=root;Pwd=mysqlsifre;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Basit bir sorgu ile ba�lay�n
                        string query = "SELECT YemekAdi FROM Yemekler WHERE KategoriID = (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = @KategoriAdi LIMIT 1)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@KategoriAdi", selectedKategori);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            comboBox2.Items.Clear();
                            while (reader.Read())
                            {
                                string yemekAdi = reader["YemekAdi"].ToString();
                                if (!comboBox2.Items.Contains(yemekAdi))
                                {
                                    comboBox2.Items.Add(yemekAdi);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritaban� ba�lant� hatas�: " + ex.Message);
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedYemek = comboBox2.SelectedItem?.ToString() ?? "Yemek Se�ilmedi";

            if (!string.IsNullOrEmpty(selectedYemek))
            {
                label2.Text = "Se�ilen Yemek: " + selectedYemek;

                // TextBox ve ListBox ekleme i�lemi
                textBox1.Text = $"Se�ilen Kategori: {label1.Text.Replace("Se�ilen Kategori: ", "")}, Se�ilen Yemek: {selectedYemek}";

                // E�er ��e zaten yoksa ekleyin
                bool exists = false;
                foreach (var item in listBox1.Items)
                {
                    if (item.ToString().Contains($"Yemek: {selectedYemek}", StringComparison.OrdinalIgnoreCase))
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    listBox1.Items.Add($"Yemek: {selectedYemek}");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Porsiyonun se�ilip se�ilmedi�ini kontrol et
            if (!radioButtonSmall.Checked && !radioButtonMedium.Checked && !radioButtonLarge.Checked)
            {
                MessageBox.Show("L�tfen bir porsiyon se�in!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // ��lemi durdur
            }

            // Mevcut sipari�in detaylar�n� topla
            string kategori = label1.Text.Replace("Se�ilen Kategori: ", "") ?? "Kategori Se�ilmedi";
            string yemek = label2.Text.Replace("Se�ilen Yemek: ", "") ?? "Yemek Se�ilmedi";
            string porsiyon = "";

            if (radioButtonSmall.Checked)
            {
                porsiyon = "K���k";
            }
            else if (radioButtonMedium.Checked)
            {
                porsiyon = "Orta";
            }
            else if (radioButtonLarge.Checked)
            {
                porsiyon = "B�y�k";
            }

            // Ekstra malzemeleri topla
            string ekstraMalzemeler = "";
            if (checkBoxCheese.Checked)
            {
                ekstraMalzemeler += "Peynir ";
            }
            if (checkBoxOnion.Checked)
            {
                ekstraMalzemeler += "So�an ";
            }
            if (checkBoxGarlic.Checked)
            {
                ekstraMalzemeler += "Sar�msak ";
            }

            // Sipari� �zetini olu�tur
            string siparis = $"Kategori: {kategori}, Yemek: {yemek}, Porsiyon: {porsiyon}, Ekstralar: {ekstraMalzemeler.Trim()}";

            // Sipari�i kaydet (Previous Orders ListBox'a ekle)
            if (!listBoxPreviousOrders.Items.Contains(siparis))  // E�er sipari� zaten yoksa ekleyin
            {
                listBoxPreviousOrders.Items.Add(siparis);
            }

            // Mevcut sipari�i temizle (g�rsel olarak temizler)
            listBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            label1.Text = "Se�ilen Kategori:";
            label2.Text = "Se�ilen Yemek:";
            radioButtonSmall.Checked = false;
            radioButtonMedium.Checked = false;
            radioButtonLarge.Checked = false;
            checkBoxCheese.Checked = false;
            checkBoxOnion.Checked = false;
            checkBoxGarlic.Checked = false;

            // Sipari�in ba�ar�yla kaydedildi�ini bildir
            MessageBox.Show("Sipari�iniz kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButtonPorsiyon_CheckedChanged(object sender, EventArgs e)
        {
            // Porsiyon i�in eski de�erleri temizle
            listBox1.Items.Remove("Porsiyon: K���k");
            listBox1.Items.Remove("Porsiyon: Orta");
            listBox1.Items.Remove("Porsiyon: B�y�k");

            // K���k porsiyon se�imi
            if (radioButtonSmall.Checked)
            {
                if (!listBox1.Items.Contains("Porsiyon: K���k"))
                {
                    listBox1.Items.Add("Porsiyon: K���k");
                }
            }

            // Orta porsiyon se�imi
            if (radioButtonMedium.Checked)
            {
                if (!listBox1.Items.Contains("Porsiyon: Orta"))
                {
                    listBox1.Items.Add("Porsiyon: Orta");
                }
            }

            // B�y�k porsiyon se�imi
            if (radioButtonLarge.Checked)
            {
                if (!listBox1.Items.Contains("Porsiyon: B�y�k"))
                {
                    listBox1.Items.Add("Porsiyon: B�y�k");
                }
            }
        }

        private void checkBoxExtras_CheckedChanged(object sender, EventArgs e)
        {
            // Peynir i�in i�lem
            if (checkBoxCheese.Checked)
            {
                if (!listBox1.Items.Contains("Ekstra: Peynir"))
                {
                    listBox1.Items.Add("Ekstra: Peynir");
                }
            }
            else
            {
                listBox1.Items.Remove("Ekstra: Peynir");
            }

            // So�an i�in i�lem
            if (checkBoxOnion.Checked)
            {
                if (!listBox1.Items.Contains("Ekstra: So�an"))
                {
                    listBox1.Items.Add("Ekstra: So�an");
                }
            }
            else
            {
                listBox1.Items.Remove("Ekstra: So�an");
            }

            // Sar�msak i�in i�lem
            if (checkBoxGarlic.Checked)
            {
                if (!listBox1.Items.Contains("Ekstra: Sar�msak"))
                {
                    listBox1.Items.Add("Ekstra: Sar�msak");
                }
            }
            else
            {
                listBox1.Items.Remove("Ekstra: Sar�msak");
            }
        }
    }
}

