using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsBraniCD
{
    class CD
    {
        private List<Brano> _ListaBrani;
        private string _Autore;
        private string _Titolo;

        public CD(List<Brano> lista, string autore, string titolo)
        {
            Autore = autore;
            Titolo = titolo;
            ListaBraniInCD = lista;
        }

        public string Autore
        {
            get;
            set;
        }

        public string Titolo
        {
            get;
            set;
        }

        public List<Brano> ListaBraniInCD
        {
            get;
            set;
        }

        public override string ToString()
        {
            string stringa = "";
            foreach (Brano b in ListaBraniInCD)
            {
                stringa += b.Titolo;
            }

            return stringa;
        }

        public double GetDurataCD()
        {
            double durata = 0;
            foreach (Brano b in ListaBraniInCD)
            {
                durata += b.Durata;
            }
            return durata;
        }
    }
}
