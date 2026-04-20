using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Fotokopiemachine : IKost
    {
        public string SerieNr { get; set; }
        private int aantalGekopieerdeBlz;
        public int AantalGekopieerdeBlz
        {
            get
            {
                return aantalGekopieerdeBlz;
            }
            set
            {
                if (value >= 0)
                    aantalGekopieerdeBlz = value;
            }
        }
        private decimal kostPerBlz;
        public decimal KostPerBlz
        {
            get
            {
                return kostPerBlz;
            }
            set
            {
                if (value > 0)
                    kostPerBlz = value;
            }
        }
        public Fotokopiemachine(string serieNr, int aantalGekopieerdeBlz,
        decimal kostPerBlz)
        {
            SerieNr = serieNr;
            AantalGekopieerdeBlz = aantalGekopieerdeBlz;
            KostPerBlz = kostPerBlz;
        }
        public bool Menselijk
        {
            get
            {
                return false;
            }
        }
        public decimal BerekenKostprijs()
        {
            return AantalGekopieerdeBlz * KostPerBlz;
        }
    }
}
