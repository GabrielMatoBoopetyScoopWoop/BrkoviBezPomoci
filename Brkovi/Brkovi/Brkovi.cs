using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brkovi
{
    class Brkovi
    {
        string ime, prezime, dodatak;
        int godina;
        char rod;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Godina { get => godina; set => godina = value; }
        public char Rod { get => rod; set => rod = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }

        public Brkovi(string ime, string prezime, int godina, char rod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godina = godina;
            this.rod = rod;
        }

        public string Ispis()
        {
            string ispis = Ime + "\t" + Prezime + "\t" + Convert.ToString(Godina) + "\t" + Convert.ToString(Rod) + "\t" + Dodatak + "\r\n";
            return (ispis);
        }
    }
}
