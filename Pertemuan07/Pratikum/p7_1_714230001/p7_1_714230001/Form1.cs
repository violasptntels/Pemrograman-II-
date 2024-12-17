using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p7_1_714230001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set initial size of the form
            Size = new Size(345, 243);
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.AppendLine("Nama harus diisi");
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan harus diisi");
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage.AppendLine("Kelas harus diisi");
            }

            string errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                // Display success message and adjust form size
                MessageBox.Show(
                    "Lengkap!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Size = new Size(516, 719);
            }
            else
            {
                // Display error messages
                MessageBox.Show(
                    errorMsg.Trim(),
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekday.Checked)
            {
                // Enable or disable checkboxes based on selection
                checkBoxKuliah.Enabled = true; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false; checkBoxLiburan.Checked = false;
            }
        }

        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekend.Checked)
            {
                // Enable or disable checkboxes based on selection
                checkBoxKuliah.Enabled = false; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = true; checkBoxLiburan.Checked = false;
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            // Get selected radio button text
            string hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked)?.Text;

            // Get checked checkboxes text
            string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text));

            // Display user input details
            MessageBox.Show(
                "Nama: " + textBoxNama.Text + "\n" +
                "Angkatan: " + comboBoxAngkatan.Text + "\n" +
                "Kelas: " + textBoxKelas.Text + "\n" +
                "======================================\n" +
                "Hari: " + hari + "\n" +
                "Kegiatan: " + kegiatan + "\n",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset all input controls
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = true;
                }
            }

            // Reset form size
            Size = new Size(345, 243);

            // Display reset confirmation
            MessageBox.Show(
                "Data berhasil direset",
                "Informasi Reset",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}