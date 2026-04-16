using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Persoon
    {
        private int id;
        public int Id
        {
            get => id;
            set => id = value;
        }
        private string voornaam; 
        public string Voornaam
        {
            get => voornaam;
            set => voornaam = value;
        }
        private string naam; 
        public string Naam
        {
            get => naam;
            set => naam = value;
        }
        public string VolledigeNaam => $"{Voornaam} {Naam}";
    }
}
