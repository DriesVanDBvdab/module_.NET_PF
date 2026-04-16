using System;
using System.Collections.Generic;
using System.Text;

namespace PFCursus
{
    internal abstract class Werknemer
    {
        public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
        {
        }
        static Werknemer()
        {
            Personeelsfeest = new DateOnly(DateTime.Today.Year, 2, 1);
            while (Personeelsfeest.DayOfWeek != DayOfWeek.Friday)
                Personeelsfeest = Personeelsfeest.AddDays(1);
        }
        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
        {
            this.Naam = naam;
            this.InDienst = inDienst;
            this.Geslacht = geslacht;
        }
        public abstract decimal Premie
        {
            get;
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
        public virtual void Afbeelden()
        { 
            Console.WriteLine($"Naam: {Naam}"); 
            Console.WriteLine($"Geslacht: {Geslacht}");
            Console.WriteLine($"In dienst: {InDienst}");
            Console.WriteLine($"Personeelsfeest: {Personeelsfeest}");
        }
        public override string ToString()
        {
            return $"{Naam} {Geslacht}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Werknemer)
            {
                Werknemer deAndere = (Werknemer)obj;
                return this.Naam == deAndere.Naam;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return Naam.GetHashCode();
        }
    }
}
