using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PFCursus
{
    internal class Persoon
    {
        private int id;
        public required int ID 
        { 
            get 
            { 
                return id; 
            } 
            init 
            { 
                if (value > 0) 
                    id = value; 
            } 
        }
        public string Naam { get; set; }
        public int AantalKinderen { get; set; }
        public Persoon() { }
        [SetsRequiredMembers]
        public Persoon(int id, string naam)
        {
            ID = id;
            Naam = naam;
        }
        [SetsRequiredMembers]
        public Persoon(int id, string naam, int aantalKinderen) : this(id, naam)
        {
            AantalKinderen = aantalKinderen;
        }
    }
}
