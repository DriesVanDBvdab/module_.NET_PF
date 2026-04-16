using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Werknemer
    {
        //public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
        //{
        //}
        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
        {
            this.Naam = naam;
            this.InDienst = inDienst;
            this.Geslacht = geslacht;
        }
        private string naam = string.Empty;
        public string Naam
        {
            get 
            {
                return naam;
            }
            set 
            {
                if (value != string.Empty)
                    naam = value;
            }
        }
        private DateTime inDienst;
        public DateTime InDienst 
        { 
            get { return inDienst; } 
            set { inDienst = value; } 
        }
        private Geslacht geslacht; public Geslacht Geslacht
        {
            get { return geslacht; }
            set { geslacht = value; }
        }
        private static DateOnly personeelsfeest;
        public static DateOnly Personeelsfeest { get; set; }
        public void Afbeelden()
        { 
            Console.WriteLine($"Naam: {Naam}"); 
            Console.WriteLine($"Geslacht: {Geslacht}");
            Console.WriteLine($"In dienst: {InDienst}");
            Console.WriteLine($"Personeelsfeest: {Personeelsfeest}");
        } 
    }
}
