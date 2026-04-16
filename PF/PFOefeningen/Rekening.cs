using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Rekening
    {
        private string rekeningNummer = string.Empty;
        public string RekeningNummer
        {
            get { return rekeningNummer; }
            set
            {
                if (value.Length == 16 && value.StartsWith("BE"))
                {
                    rekeningNummer = value;
                }
            }
        }
        private int saldo = 0;
        public int Saldo
        {
            get { return saldo; }
            set { saldo = value;  }
        }
        readonly DateTime creatieDatum = DateTime.Now;
        public DateTime CreatieDatum
        {
            get { return creatieDatum; }
            set
            {
                if (value.Year > 1900)
                {
                    creatieDatum = value;
                }
            }
        }

    }
}
