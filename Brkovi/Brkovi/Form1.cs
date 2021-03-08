using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brkovi
{
    public partial class Form1 : Form
    {
        List<Brkovi> Lista = new List<Brkovi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Unesi_Click(object sender, EventArgs e)
        {
            try
            {
                Brkovi brk = new Brkovi(ImeTekst.Text, PrezimeTekst.Text, Convert.ToInt32(GodinaTekst.Text), Convert.ToChar(RodTekst.Text));
                Lista.Add(brk);
                ImeTekst.Clear();
                PrezimeTekst.Clear();
                GodinaTekst.Clear();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Greška");
            }
        }

        private void Ispisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Ime" + "\t" + "Prezime" + "\t" + "Godina" + "\t" + "Rod" + "\t" + "Dodatak" + "\r\n");
            foreach (Brkovi brk in Lista)
            {
                richTextBox1.AppendText(brk.Ispis());
            }
        }

        private void Obradi_Click(object sender, EventArgs e)
        {
            foreach (Brkovi brk in Lista)
            {
                if (brk.Rod.ToString() == "M")
                    brk.Dodatak = "Ima brkove";
                else
                    brk.Dodatak = "Nema brkove";
            }
        }
    }
}
