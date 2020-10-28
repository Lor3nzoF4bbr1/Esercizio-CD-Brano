using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsBraniCD
{
    class Brano
    {
        public Brano(string titolo, string autore, double durata)
        {
            Titolo = titolo;
            Autore = autore;
            Durata = durata;
        }

        public string Titolo
        {
            get;
            set;
        }

        public string Autore
        {
            get;
            set;
        }

        public double Durata
        {
            get;
            set;
        }
        
        public bool shortSong(double durata)
        {
            if (Durata < durata)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return Titolo + " " + Autore + " " + Durata;
        }
    } 
}
