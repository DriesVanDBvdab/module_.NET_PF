using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel
{
    internal abstract partial class Werknemer :IKost, IComparable
    {
        //public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
        //{
        //}
        static Werknemer()
        {
            Personeelsfeest = new DateOnly(DateTime.Today.Year, 2, 1);
            while (Personeelsfeest.DayOfWeek != DayOfWeek.Friday)
                Personeelsfeest = Personeelsfeest.AddDays(1);
        }

        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht) : this(naam, inDienst, geslacht, null)
        {
        }
        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht, Afdeling afdeling)
        {
            Naam = naam;
            InDienst = inDienst;
            Geslacht = geslacht;
            Afdeling = afdeling;
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

        private Afdeling afdeling;
        public Afdeling Afdeling
        {
            get
            {
                return afdeling;
            }
            set
            {
                afdeling = value;
            }
        }
        public WerkRegime Regime { get; set; }

        public bool Menselijk
        {
            get
            {
                return true;
            }
        }

        public abstract decimal BerekenKostprijs();

        public virtual void Afbeelden()
        { 
            Console.WriteLine($"Naam: {Naam}"); 
            Console.WriteLine($"Geslacht: {Geslacht}");
            Console.WriteLine($"In dienst: {InDienst}");
            Console.WriteLine($"Personeelsfeest: {Personeelsfeest}");
            if (Afdeling != null) 
                Console.WriteLine(Afdeling);
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
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Werknemer otherWerknemer = obj as Werknemer;
            if (otherWerknemer != null)
                return this.Naam.CompareTo(otherWerknemer.Naam);
            else
                throw new ArgumentException("Other is geen werknemer");
        }
    }
    internal enum Vestiging
    {
        Wevelgem, Wondelgem, Haasrode, Antwerpen, Genk
    }
}
