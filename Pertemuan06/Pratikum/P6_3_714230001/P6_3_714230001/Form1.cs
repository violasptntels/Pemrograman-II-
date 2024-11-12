using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714230001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessages(txtHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if (txtHuruf.Text.All(char.IsLetter))
            {
                SetErrorMessages(txtHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        private void textAngka1_TextChanged(object sender, EventArgs e)
        {
            if (textAngka1.Text == "")
            {
                SetErrorMessages(textAngka1, "Textbox Angka1 tidak boleh kosong!", "", "");
            }
            else if (textAngka1.Text.All(Char.IsDigit))
            {
                SetErrorMessages(textAngka1, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(textAngka1, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void textAngka2_TextChanged(object sender, EventArgs e)
        {
            if (textAngka2.Text == "")
            {
                SetErrorMessages(textAngka2, "Textbox Angka2 tidak boleh kosong!", "", "");
            }
            else if (textAngka2.Text.All(Char.IsDigit))
            {
                SetErrorMessages(textAngka2, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(textAngka2, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void textAngka1_Leave(object sender, EventArgs e)
        {
            // Validasi TextBox Angka1 wajib diisi
            if (string.IsNullOrEmpty(textAngka1.Text))
            {
                SetErrorMessages(textAngka1, "Textbox Angka1 wajib diisi!", "", "");
            }
            //else
            //{
            //    SetErrorMessages(textAngka1, "", "", "Betul!");
            //}

            // Memeriksa apakah Angka2 sudah terisi saat keluar dari Angka1
            if (string.IsNullOrEmpty(textAngka2.Text))
            {
                SetErrorMessages(textAngka2, "Textbox Angka2 juga wajib diisi!", "", "");
            }
        }

        private void textAngka2_Leave(object sender, EventArgs e)
        {
            // Validasi TextBox Angka2 wajib diisi
            if (string.IsNullOrEmpty(textAngka2.Text))
            {
                SetErrorMessages(textAngka2, "Textbox Angka2 wajib diisi!", "", "");
            }
            else
            {
                SetErrorMessages(textAngka2, "", "", "Betul!");
            }

            // Jika Angka2 sudah terisi, lakukan pengecekan pada Angka1
            if (!string.IsNullOrEmpty(textAngka2.Text))
            {
                // Memeriksa apakah Angka1 sudah terisi
                if (string.IsNullOrEmpty(textAngka1.Text))
                {
                    SetErrorMessages(textAngka1, "Textbox Angka1 wajib diisi!", "", "");
                }
                else
                {
                    // Jika Angka1 dan Angka2 terisi, bandingkan nilainya
                    int angka1, angka2;
                    if (int.TryParse(textAngka1.Text, out angka1) && int.TryParse(textAngka2.Text, out angka2))
                    {
                        if (angka1 > angka2)
                        {
                            SetErrorMessages(textAngka1, "", "", "Betul!"); // Tampilkan icon correct pada Angka1 jika Angka1 > Angka2
                        }
                        else
                        {
                            SetErrorMessages(textAngka1, "", "Angka1 harus lebih besar dari Angka2!", ""); // Tampilkan pesan error jika tidak
                            SetErrorMessages(textAngka2, "", "Angka1 harus lebih besar dari Angka2!", ""); // Tampilkan pesan error jika tidak
                        }
                    }
                    else
                    {
                        SetErrorMessages(textAngka1, "", "Input tidak valid!", "");
                        SetErrorMessages(textAngka2, "", "Input tidak valid!", "");
                    }
                }
            }
        }
    }
}
