using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OcjenskaVjezbaKolekcije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            List<Osoba> listaOsoba = new List<Osoba>();

            string File = @"C:\Users\ucenik\Desktop\NinoMomic 3.D\OcjenskaVjezba.csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();
            String[] headings = { "Ime", "Prezime", "Spol", "Godiste" };
            output.AppendLine(string.Join(separator, headings));

            try
            {
                Osoba osoba = new Osoba(txtBoxIme.Text, txtBoxPrezime.Text, comboBoxSpol.Text, Convert.ToInt16(txtBoxGodiste.Text));
                txtBoxIme.Clear();
                txtBoxPrezime.Clear();
                txtBoxGodiste.Clear();

                DialogResult upit = MessageBox.Show("Želite li upisati jos podataka", "", 
                    MessageBoxButtons.YesNo , MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        {
                            break;
                        }
                    case DialogResult.No:
                        {
                            listaOsoba.Add(osoba);

                            foreach (Osoba os in listaOsoba)
                            {
                                String[] newLine = { txtBoxIme.Text, txtBoxPrezime.Text,
                                         comboBoxSpol.Text, txtBoxGodiste.Text};
                                output.AppendLine(string.Join(separator, newLine));

                                try
                                {
                                    

                                }
                                catch (Exception Greska)
                                {
                                    Console.WriteLine("Podatci se ne mogu upisati u CSV file.");
                                    return;
                                }
                            }
                            break;
                        }
                }
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message, "Pogrešan unos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {

        }
    }
}
