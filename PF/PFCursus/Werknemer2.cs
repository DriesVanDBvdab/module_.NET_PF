using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal class Werknemer2(string naam, DateTime inDienst, Geslacht geslacht)
    {
        public Werknemer2() : this("Onbekend", DateTime.Today, Geslacht.Man) { }
        public string Naam { get; set; } = 
            !string.IsNullOrWhiteSpace(naam) ? naam : "Onbekend";
        public DateTime InDienst { get; set; } = inDienst;
        public Geslacht Geslacht { get; set; } = geslacht;
        public void Afbeelden()
        {
            Console.WriteLine($"Naam: {naam}");
            Console.WriteLine($"Geslacht: {geslacht}");
            Console.WriteLine($"In dienst: {inDienst}");
        }
    }
}
