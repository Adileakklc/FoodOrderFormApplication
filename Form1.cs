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
            // Veritabaný baðlantýsý
            string connectionString = "Server=localhost;Database=YemekSiparisiDB;Uid=root;Pwd=mysqlsifre;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // YemekKategorileri'ni ComboBox1'e yükleme
                    string query = "SELECT DISTINCT KategoriAdi FROM YemekKategorileri";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox1.Items.Clear();  // ComboBox'u önce temizliyoruz
                        while (reader.Read())
                        {
                            string kategoriAdi = reader["KategoriAdi"].ToString();
                            if (!comboBox1.Items.Contains(kategoriAdi))  // Ayný kategori zaten eklenmiþ mi kontrol ediyoruz
                            {
                                comboBox1.Items.Add(kategoriAdi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabaný baðlantý hatasý: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedKategori = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedKategori))
            {
                label1.Text = "Seçilen Kategori: " + selectedKategori;

                // Veritabaný baðlantýsý
                string connectionString = "Server=localhost;Database=YemekSiparisiDB;Uid=root;Pwd=mysqlsifre;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Basit bir sorgu ile baþlayýn
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
                        MessageBox.Show("Veritabaný baðlantý hatasý: " + ex.Message);
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedYemek = comboBox2.SelectedItem?.ToString() ?? "Yemek Seçilmedi";

            if (!string.IsNullOrEmpty(selectedYemek))
            {
                label2.Text = "Seçilen Yemek: " + selectedYemek;

                // TextBox ve ListBox ekleme iþlemi
                textBox1.Text = $"Seçilen Kategori: {label1.Text.Replace("Seçilen Kategori: ", "")}, Seçilen Yemek: {selectedYemek}";

                // Eðer öðe zaten yoksa ekleyin
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
            // Porsiyonun seçilip seçilmediðini kontrol et
            if (!radioButtonSmall.Checked && !radioButtonMedium.Checked && !radioButtonLarge.Checked)
            {
                MessageBox.Show("Lütfen bir porsiyon seçin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ýþlemi durdur
            }

            // Mevcut sipariþin detaylarýný topla
            string kategori = label1.Text.Replace("Seçilen Kategori: ", "") ?? "Kategori Seçilmedi";
            string yemek = label2.Text.Replace("Seçilen Yemek: ", "") ?? "Yemek Seçilmedi";
            string porsiyon = "";

            if (radioButtonSmall.Checked)
            {
                porsiyon = "Küçük";
            }
            else if (radioButtonMedium.Checked)
            {
                porsiyon = "Orta";
            }
            else if (radioButtonLarge.Checked)
            {
                porsiyon = "Büyük";
            }

            // Ekstra malzemeleri topla
            string ekstraMalzemeler = "";
            if (checkBoxCheese.Checked)
            {
                ekstraMalzemeler += "Peynir ";
            }
            if (checkBoxOnion.Checked)
            {
                ekstraMalzemeler += "Soðan ";
            }
            if (checkBoxGarlic.Checked)
            {
                ekstraMalzemeler += "Sarýmsak ";
            }

            // Sipariþ özetini oluþtur
            string siparis = $"Kategori: {kategori}, Yemek: {yemek}, Porsiyon: {porsiyon}, Ekstralar: {ekstraMalzemeler.Trim()}";

            // Sipariþi kaydet (Previous Orders ListBox'a ekle)
            if (!listBoxPreviousOrders.Items.Contains(siparis))  // Eðer sipariþ zaten yoksa ekleyin
            {
                listBoxPreviousOrders.Items.Add(siparis);
            }

            // Mevcut sipariþi temizle (görsel olarak temizler)
            listBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            label1.Text = "Seçilen Kategori:";
            label2.Text = "Seçilen Yemek:";
            radioButtonSmall.Checked = false;
            radioButtonMedium.Checked = false;
            radioButtonLarge.Checked = false;
            checkBoxCheese.Checked = false;
            checkBoxOnion.Checked = false;
            checkBoxGarlic.Checked = false;

            // Sipariþin baþarýyla kaydedildiðini bildir
            MessageBox.Show("Sipariþiniz kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButtonPorsiyon_CheckedChanged(object sender, EventArgs e)
        {
            // Porsiyon için eski deðerleri temizle
            listBox1.Items.Remove("Porsiyon: Küçük");
            listBox1.Items.Remove("Porsiyon: Orta");
            listBox1.Items.Remove("Porsiyon: Büyük");

            // Küçük porsiyon seçimi
            if (radioButtonSmall.Checked)
            {
                if (!listBox1.Items.Contains("Porsiyon: Küçük"))
                {
                    listBox1.Items.Add("Porsiyon: Küçük");
                }
            }

            // Orta porsiyon seçimi
            if (radioButtonMedium.Checked)
            {
                if (!listBox1.Items.Contains("Porsiyon: Orta"))
                {
                    listBox1.Items.Add("Porsiyon: Orta");
                }
            }

            // Büyük porsiyon seçimi
            if (radioButtonLarge.Checked)
            {
                if (!listBox1.Items.Contains("Porsiyon: Büyük"))
                {
                    listBox1.Items.Add("Porsiyon: Büyük");
                }
            }
        }

        private void checkBoxExtras_CheckedChanged(object sender, EventArgs e)
        {
            // Peynir için iþlem
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

            // Soðan için iþlem
            if (checkBoxOnion.Checked)
            {
                if (!listBox1.Items.Contains("Ekstra: Soðan"))
                {
                    listBox1.Items.Add("Ekstra: Soðan");
                }
            }
            else
            {
                listBox1.Items.Remove("Ekstra: Soðan");
            }

            // Sarýmsak için iþlem
            if (checkBoxGarlic.Checked)
            {
                if (!listBox1.Items.Contains("Ekstra: Sarýmsak"))
                {
                    listBox1.Items.Add("Ekstra: Sarýmsak");
                }
            }
            else
            {
                listBox1.Items.Remove("Ekstra: Sarýmsak");
            }
        }
    }
}

