using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P5_4_714230001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tambahkan pilihan jenis kelamin ke comboBoxJenisKelamin
            comboBoxJenisKelamin.Items.Add("Laki-laki");
            comboBoxJenisKelamin.Items.Add("Perempuan");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi Pilihan Kelas (CheckBox)
            bool isKelasSelected = checkBoxSepakBola.Checked || checkBoxBasket.Checked ||
                                   checkBoxRenang.Checked || checkBoxBuluTangkis.Checked ||
                                   checkBoxTenis.Checked || checkBoxVoli.Checked ||
                                   checkBoxYoga.Checked || checkBoxPanahan.Checked;

            // Validasi Pilihan Jadwal (RadioButton)
            bool isJadwalSelected = radioButtonSeninRabu.Checked || radioButtonSelasaKamis.Checked ||
                                    radioButtonJumatMinggu.Checked || radioButtonMinggu.Checked;

            // Cek apakah Pilihan Kelas dan Pilihan Jadwal diisi
            if (!isKelasSelected)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isJadwalSelected)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> kelasList = new List<string>();
            if (checkBoxSepakBola.Checked) kelasList.Add("Sepak Bola");
            if (checkBoxBasket.Checked) kelasList.Add("Basket");
            if (checkBoxRenang.Checked) kelasList.Add("Renang");
            if (checkBoxBuluTangkis.Checked) kelasList.Add("Bulu Tangkis");
            if (checkBoxTenis.Checked) kelasList.Add("Tenis");
            if (checkBoxVoli.Checked) kelasList.Add("Voli");
            if (checkBoxYoga.Checked) kelasList.Add("Yoga");
            if (checkBoxPanahan.Checked) kelasList.Add("Panahan");

            string kelas = string.Join(", ", kelasList);

            // Mengambil nilai dari pilihan jadwal
            string jadwal = "";
            if (radioButtonSeninRabu.Checked) jadwal = "Senin s/d Rabu, 14.00 - 16.00";
            if (radioButtonSelasaKamis.Checked) jadwal = "Selasa s/d Kamis, 14.00 - 16.00";
            if (radioButtonJumatMinggu.Checked) jadwal = "Jumat s/d Minggu, 09.00 - 11.00";
            if (radioButtonMinggu.Checked) jadwal = "Minggu, 13.00 - 20.00";
            MessageBox.Show(
                "Nama : " + textBox1.Text +  // Menggunakan .Text untuk mendapatkan isi dari TextBox
                "\nJenis Kelamin : " + comboBoxJenisKelamin.SelectedItem?.ToString() +  // Menggunakan SelectedItem untuk ComboBox
                "\nTanggal Lahir : " + dateTimePicker1.Value.ToString("dd MMMM yyyy") +  // Menggunakan format tanggal untuk DateTimePicker
                "\nPilihan Kelas : " + kelas +  // Menampilkan pilihan kelas
                "\nPilihan Jadwal : " + jadwal,  // Menampilkan pilihan jadwal
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbYa_CheckedChanged(object sender, EventArgs e)
        {
            // Validasi apakah jenis kelamin telah dipilih di ComboBox
            
            if (comboBoxJenisKelamin.SelectedIndex == -1)
            {
                MessageBox.Show("Harus memilih salah satu jenis kelamin", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Jika jenis kelamin telah dipilih, tampilkan pesan konfirmasi atau lakukan logika lainnya
                string jenisKelamin = comboBoxJenisKelamin.SelectedItem.ToString();
                MessageBox.Show("Jenis kelamin yang dipilih: " + jenisKelamin, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
