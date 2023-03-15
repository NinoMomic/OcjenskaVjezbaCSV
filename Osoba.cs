using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcjenskaVjezbaKolekcije
{
    internal class Osoba
    {
        string ime, prezime, spol;
        int godiste;

        public Osoba(string ime, string prezime, string spol, int godiste)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.spol = spol;
            this.godiste = godiste;
        }

        public string Ime { get => ime; set => ime = value;}
        public string Spol { get => spol; set => spol = value;}
        public string Prezime { get => prezime; set => prezime = value;}
        public int Godiste { get => godiste; set => godiste = value;}

        public override string ToString()
        {
            string ispis = "Ime: " + this.Ime +
                "Prezime:" + this.Prezime +
                "Godište: " + this.Godiste +
                "Spol: " + this.Spol;

            return ispis;
        }
    }
}
