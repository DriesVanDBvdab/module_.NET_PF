using System;
using System.Collections.Generic;
using System.Text;

namespace PFOefeningen
{
    internal class Klant
    {
        public Klant(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }
        private string voornaam;
        public string Voornaam
        {
            get { return voornaam; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    voornaam = value;
                }
            }
        }
        public string achternaam;
        public string Achternaam
        {
            get { return achternaam; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    achternaam = value;
                }
            }
        }
        public void Afbeelden()
        {
            Console.WriteLine($"Klant: {Voornaam} {Achternaam}");
        }
    }
}
