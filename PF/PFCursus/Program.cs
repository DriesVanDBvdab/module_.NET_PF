//Console.WriteLine("Hello,"+
//    " World!");
//Console.WriteLine("Asterix");
//Console.WriteLine("Obelix");
//Console.ReadKey(); //1
//Console.BackgroundColor = ConsoleColor.Gray;
//Console.ForegroundColor = ConsoleColor.Red; //2
//Console.Clear(); //3
//Console.SetCursorPosition(10, 2);
//Console.WriteLine("Suske"); //4
//Console.SetCursorPosition(25, 6);
//Console.WriteLine("Wiske");
//float alcoholDuvel, alcoholHapkin;
//alcoholDuvel = alcoholHapkin = 8.5f;
//Console.WriteLine(alcoholDuvel);
//Console.WriteLine(alcoholHapkin);
//decimal kostprijsInUSD = 80000m;
//Console.WriteLine(kostprijsInUSD.GetType()); 
//Console.WriteLine(kostprijsInUSD.GetTypeCode());

//int eenWedde = 1500;
//double eenTweedeWedde = eenWedde;
//Console.WriteLine(eenTweedeWedde);

//double eenWedde = 1500.78;
//int eenTweedeWedde = (int)eenWedde;
//Console.WriteLine(eenWedde);
//Console.WriteLine(eenTweedeWedde);

//int getal1 = 1500;
//byte getal2 = (byte)getal1;
//Console.Write("getal1: ");
//Console.WriteLine(getal1);
//Console.Write("getal2: ");
//Console.WriteLine(getal2);

//const float CmInch = 2.54f;
//float cm = 100.0f;
//float inch = cm / CmInch;
//Console.WriteLine(cm);
//Console.WriteLine(inch);

//const int BtwNummer = 213252520; // (1)
//int deeltal = BtwNummer / 100; // (2)
//int rest = deeltal % 97; // (3)
//int controle = BtwNummer % 100; // (4)
//Console.Write("97 - de rest van de deling van de eerste 7 cijfers door 97: "); 
//Console.WriteLine(97 - rest); // (5)
//Console.Write("Twee laatste cijfers: "); Console.WriteLine(controle); // (6)


//11 datum en tijd
//DateTime beginTijdRekening = new DateTime();
//DateTime beginEuro = new DateTime(2002, 1, 1);
//DateTime mijnGeboortedatum = new DateTime(1966, 8, 1, 10, 15, 0);
//Console.WriteLine(beginTijdRekening);
//Console.WriteLine(beginEuro);
//Console.WriteLine(mijnGeboortedatum);

//DateTime datum1 = new DateTime(2022, 1, 1);
//DateTime datum2 = new DateTime(2022, 1, 1);
//DateTime datum3 = new DateTime(2022, 1, 2);
//Console.WriteLine(datum1 == datum2); //true
//Console.WriteLine(datum2 >= datum3);

//DateTime factuurDatum = new DateTime(2023, 1, 1); 
//Console.WriteLine(factuurDatum.AddDays(40)); 
//DateTime uitersteBetaalDatum = factuurDatum.AddDays(40);
//Console.WriteLine(uitersteBetaalDatum);

//DateTime begindatum = new DateTime(2023, 1, 1, 8, 0, 0);
//DateTime einddatum = new DateTime(2023, 2, 1, 12, 30, 50);
//Console.WriteLine(begindatum);
//Console.WriteLine(einddatum);
//Console.WriteLine();
//TimeSpan interval = einddatum - begindatum;
//Console.WriteLine(interval.ToString());

//Console.WriteLine(interval.Days); //onderdeel aantal dagen
//Console.WriteLine(interval.TotalDays); //totaal aantal dagen als een decimaal getal
//Console.WriteLine(interval.Hours); //onderdeel aantal uren (range -23 tot 23)
//Console.WriteLine(interval.TotalHours); //totaal aantal uren
//Console.WriteLine(interval.Minutes); //onderdeel aantal minuten (range -59 tot 59)
//Console.WriteLine(interval.TotalMinutes);//totaal aantal minuten
//Console.WriteLine(interval.Seconds); //onderdeel seconden (range -59 tot 59)
//Console.WriteLine(interval.TotalSeconds);//totaal aantal seconden
//Console.WriteLine(interval.Milliseconds);//onderdeel aantal milliseconden
////(range -999 tot 999)
//Console.WriteLine(interval.TotalMilliseconds); //totaal aantal milliseconden
//Console.WriteLine(interval.Ticks); //1 milliseconde = 10000 ticks

//DateTime vandaag = DateTime.Now; 
//DateOnly datumVandaag = DateOnly.FromDateTime(vandaag); 
//TimeOnly nu = TimeOnly.FromDateTime(vandaag);
//Console.WriteLine(vandaag);
//Console.WriteLine(datumVandaag);
//Console.WriteLine(nu);

//12 Het type string
//using System.Text;

//string krijger1 = "Asterix";
//string krijger2 = "Obelix";
//string samen = krijger1 + " en " + krijger2;
//Console.WriteLine(samen);

//StringBuilder bericht = new StringBuilder("hallo"); // (2)
//Console.WriteLine(bericht);
//bericht.Append(" iedereen"); // (4)
//Console.WriteLine(bericht);

//string krijger1 = "Asterix";
//string krijger2 = "Obelix";
//string groteKrijger = "Asterix";
//string kleineKrijger = "asterix";
//Console.WriteLine(krijger1 == krijger2); // (1)
//Console.WriteLine(krijger1 == groteKrijger); // (2)
//Console.WriteLine(krijger1 == kleineKrijger); // (3)
//Console.WriteLine(krijger1.CompareTo(krijger2));

//string kinderenWoord = "7";
//byte kinderen = Convert.ToByte(kinderenWoord);

//const float CmInch = 2.54f;
//Console.Write("Tik een lengte in cm: ");
//float cm = float.Parse(Console.ReadLine());
//Console.Write("lengte in inch: "); Console.WriteLine(cm/CmInch); 
//Console.Write("Geboortedatum: "); 
//DateTime geboortedatum = DateTime.Parse(Console.ReadLine()); 
//Console.WriteLine(geboortedatum);

//string tekst = null; Console.WriteLine(string.IsNullOrEmpty(tekst)); //geeft True want tekst is null
//tekst = string.Empty; Console.WriteLine(string.IsNullOrEmpty(tekst)); //geeft True want tekst is leeg
//tekst = "\t \n"; Console.WriteLine(string.IsNullOrEmpty(tekst)); //geeft False
//tekst = "hallo"; Console.WriteLine(string.IsNullOrEmpty(tekst)); //geeft False

//string tekst = null; Console.WriteLine(string.IsNullOrWhiteSpace(tekst)); //geeft True
//tekst = string.Empty; Console.WriteLine(string.IsNullOrWhiteSpace(tekst)); //geeft True
//tekst = "\t \n"; Console.WriteLine(string.IsNullOrWhiteSpace(tekst)); //geeft True
//tekst = "hallo"; Console.WriteLine(string.IsNullOrWhiteSpace(tekst)); //geeft False


//var getal = 15.365f;
//Console.WriteLine("{0,-10}", getal);
//Console.WriteLine("{0, 10}", getal);
//Console.WriteLine("{0, 7:N1}", getal);
//DateTime tijd = DateTime.UtcNow;
//Console.WriteLine("{0,30}", tijd);

//TekenLijn();
//TekenLijn();
//void TekenLijn() { Console.WriteLine("----------------"); }

//using PFCursus; // (1)
//Werknemer werknemer1; // (2)
//werknemer1 = new Werknemer(); // (3)
//Werknemer werknemer2 = new();

//Werknemer ik;
//ik = new Werknemer();
//if (ik is null) // (1)
//    Console.WriteLine("niet verbonden");
//else
//    Console.WriteLine("verbonden");

//using Firma.Personeel;
//using PFCursus;
//Werknemer werknemer1 = new Werknemer();
//werknemer1.Naam = "Jef"; 
//Console.WriteLine(werknemer1.Naam);

//Werknemer ik = new Werknemer();
//ik.Naam = "Asterix";
//ik.Geslacht = Geslacht.Man;
//ik.InDienst = new DateTime(2022, 1, 1);
//ik.Afbeelden();

//Werknemer ik = new Werknemer();
//ik.Naam = "Asterix";
//ik.Geslacht = Geslacht.Man;
//ik.InDienst = new DateTime(2022, 1, 1);
//Werknemer jij = new Werknemer();
//jij.Naam = "Obelix";
//jij.Geslacht = Geslacht.Man;
//jij.InDienst = new DateTime(2022, 1, 2);
//LijnenTrekker lijnenTrekker = new LijnenTrekker(); // (1)
//ik.Afbeelden();
//lijnenTrekker.TrekLijn(30); // (2)
//jij.Afbeelden();
//lijnenTrekker.TrekLijn(79); // (3)

//Werknemer ik = new Werknemer();
//ik.Naam = "Asterix";
//ik.Geslacht = Geslacht.Man;
//ik.InDienst = new DateTime(2022, 1, 1);
//Werknemer jij = new Werknemer();
//jij.Naam = "Obelix";
//jij.Geslacht = Geslacht.Man;
//jij.InDienst = new DateTime(2022, 1, 2);
//LijnenTrekker lijnenTrekker = new LijnenTrekker();
//ik.Afbeelden();
//lijnenTrekker.TrekLijn(30, '-'); // (1)
//jij.Afbeelden();
//lijnenTrekker.TrekLijn(79, '=');

//Omzetter omzetter = new Omzetter(); 
//Console.Write("Afstand in cm: "); 
//double cm = double.Parse(Console.ReadLine()); 
//Console.WriteLine($"{omzetter.CmNaarInch(cm)} inches"); // (1)
//LijnenTrekker lijnenTrekker = new LijnenTrekker(); 
//lijnenTrekker.TrekLijn(30, '-'); 
//Console.Write("Afstand in inches: "); 
//double inches = double.Parse(Console.ReadLine()); 
//Console.WriteLine($"{omzetter.InchNaarCm(inches)} cm");

//Werknemer ik = new Werknemer();
//ik.Naam = "Asterix";
//ik.Geslacht = Geslacht.Man;
//ik.InDienst = new DateTime(2022, 1, 1);
//Werknemer jij = new Werknemer();
//jij.Naam = "Obelix";
//jij.Geslacht = Geslacht.Man;
//jij.InDienst = new DateTime(2022, 1, 2);
//LijnenTrekker lijnenTrekker = new LijnenTrekker();
//ik.Afbeelden();
//lijnenTrekker.TrekLijn(30, '-');
//jij.Afbeelden();
//lijnenTrekker.TrekLijn(79, '=');
//lijnenTrekker.TrekLijn();
//lijnenTrekker.TrekLijn(10);

//int eerste = 10, tweede = 20;
//Verwisselaar verwisselaar = new Verwisselaar();
//verwisselaar.Verwissel(ref eerste, ref tweede);
//Console.WriteLine(eerste);
//Console.WriteLine(tweede);

//int eerste = 10, tweede = 20;
//Verwisselaar verwisselaar = new Verwisselaar();
//verwisselaar.VerwisselNaarAndereVariabelen(eerste, tweede,
//out int resultaat1, out int resultaat2);
//Console.WriteLine(resultaat1);
//Console.WriteLine(resultaat2);

//int eerste = 10, tweede = 20;
//int resultaat1, resultaat2;
//Verwisselaar verwisselaar = new Verwisselaar();
//verwisselaar.VerwisselNaarAndereVariabelen(eerste, tweede,
//out resultaat1, out resultaat2);
//Console.WriteLine(resultaat1);
//Console.WriteLine(resultaat2);

//Omzetter omzetter = new Omzetter();
//Console.Write("Afstand in cm: ");
//if (double.TryParse(Console.ReadLine(), out double cm)) // (1)
//    Console.WriteLine($"{omzetter.CmNaarInch(cm)} inches");
//else
//        Console.WriteLine("Geen correct getal");

//int resultaat = Som(4, 5); Console.WriteLine(resultaat); 
//int Som(int getal1, int getal2) { // (1)
//    return getal1 + getal2;
//}

//int resultaat = Som(4, 5); 
//Console.WriteLine(resultaat); 
//int Som(int getal1, int getal2) => getal1 + getal2;

//Werknemer ik = new Werknemer("Asterix", new DateTime(2022, 1, 1), Geslacht.Man); 
//ik.Afbeelden();
//Werknemer jij = new Werknemer();
//jij.Afbeelden();

//Werknemer2 ik = new Werknemer2("Asterix", new DateTime(2024, 1, 1), Geslacht.Man);
//ik.Afbeelden();

//var eersteMan = new Persoon { Naam = "Adam", AantalKinderen = 2 }; // (1)
//var eersteVrouw = new Persoon("Eva") { AantalKinderen = 2 }; // (2)
//var eersteZoon = new Persoon { Naam = "Kaïn" }; // (3)
//eersteZoon.AantalKinderen = 0;
//var persoon = new { Nr = 1, Naam = "Adam", AantalKinderen = 2 }; // (1)
//Console.WriteLine(persoon.GetType().ToString());
//Console.WriteLine(persoon.Naam);

//using PFCursus;
//Persoon p1 = new Persoon // (1)
//{
//    ID = 1,
//    Naam = "Adam",
//    AantalKinderen = 2
//};
//Persoon p2 = new Persoon { ID = 2, Naam = "Bert", AantalKinderen = 0 };
////Persoon p3 = new Persoon();
//Persoon p4 = new Persoon(3, "Luc", 2);

//Werknemer ik = new Werknemer("Asterix", DateTime.Today, Geslacht.Man);
//Werknemer jij = new Werknemer("Obelix", DateTime.Today, Geslacht.Man);
//Werknemer.Personeelsfeest = new DateOnly(2023, 12, 12);
//Console.WriteLine(Werknemer.Personeelsfeest);
//ik.Afbeelden();
//jij.Afbeelden();

//Console.WriteLine(Werknemer.Personeelsfeest);

//Console.WriteLine(Rekenaar.Kwadraat(3));

//var land = "belgië"; // (1)
//Console.WriteLine(land.ToUpperFirst()); // (2)
//Console.WriteLine(land.Right(3));

//Arbeider ik = new Arbeider("Asterix", new DateTime(2022, 1, 1),
//        Geslacht.Man, 24.79m, 3);
//ik.Afbeelden();

//Bediende ik = new Bediende("Asterix", new DateTime(2022, 1, 1),
//    Geslacht.Man, 2400.79m);
//ik.Afbeelden();

//Manager ik = new Manager("Asterix", new DateTime(2022, 1, 1),
//    Geslacht.Man, 2400.79m, 7000m);
//ik.Afbeelden();

//Manager ik = new Manager("Asterix", new DateTime(2022, 1, 1),
//Geslacht.Man, 2400.79m, 7000m); // (1)
//Console.WriteLine(ik is Manager); // (2)
//Console.WriteLine(ik is Bediende); // (3)
//Console.WriteLine(ik is Werknemer); // (4)
//Console.WriteLine(ik is Arbeider); // (5)
//Console.WriteLine(ik is string); // (6)
//Werknemer jij = new Bediende("Obelix", new DateTime(2022, 1, 2),
//    Geslacht.Man, 2400.79m); // (7)
//Console.WriteLine(jij is Bediende); // (8)
//Console.WriteLine(jij is Werknemer);

//Manager ik = new Manager("Asterix", new DateTime(2022, 1, 1),
//Geslacht.Man, 2400.79m, 7000m);
//Console.WriteLine(ik.ToString());

//Manager ik = new Manager("Asterix", new DateTime(2022, 1, 1),
//Geslacht.Man, 2400.79m, 7000m);
//Manager mezelf = ik;
//Manager dezelfde = new Manager("Asterix", new DateTime(2022, 1, 1),
//Geslacht.Man, 2400.79m, 7000m);
//Console.WriteLine(ik.Equals(mezelf));
//Console.WriteLine(ik.Equals(dezelfde));

//Manager ik = new Manager("Asterix", new DateTime(2022, 1, 1),
//Geslacht.Man, 2400.79m, 7000m);
//Console.WriteLine(ik.Bonus);
//Werknemer jij = new Bediende("Obelix", new DateTime(2022, 1, 2),
//Geslacht.Man, 2400.79m);
//Console.WriteLine(jij);
//Manager jijAlsManager = (Manager)jij;
//Manager hij = new Manager("Abraracourcix", new DateTime(2022, 1, 3),
//Geslacht.Man, 6666.66m, 10000m);
//Werknemer hijAlsWerknemer = (Werknemer)hij;
//Console.WriteLine(hijAlsWerknemer);

//object obj = new Werknemer("Asterix", DateTime.Today, Geslacht.Man);
//Werknemer deAndere = obj as Werknemer;

//Werknemer ik = new Bediende("Asterix", DateTime.Today,
//Geslacht.Man, 1500m);
//Werknemer jij = new Arbeider("Obelix", DateTime.Today,
//Geslacht.Man, 10m, 1);
//Bediende hij;
//hij = (Bediende)ik;
//hij.Afbeelden();
////hij = (Bediende)jij;
////hij.Afbeelden();
//hij = ik as Bediende;
//if (hij is not null)
//    hij.Afbeelden();
//hij = jij as Bediende;
//if (hij is not null)
//    hij.Afbeelden();

//Object[] lijst = new Object[]
//{
//new Arbeider("Asterix", new DateTime(2022, 1, 1), Geslacht.Man, 24.79m, 3),
//new Bediende("Obelix", new DateTime(2022, 2, 1), Geslacht.Man, 2400.79m),
//new Bediende("Walhalla", new DateTime(2022,1,1), Geslacht.Vrouw,2000m),
//null,
//"C# 7.0"
//};
//foreach (var item in lijst) 
//    Console.WriteLine(Info(item));

//string Info(Object obj)
//{
//    switch (obj)
//    {
//        case Werknemer w when w.Geslacht == Geslacht.Man:
//            return $"{w.Naam} is een mannelijke werknemer ";
//        case Arbeider a when a.Geslacht == Geslacht.Vrouw:
//            return $"{a.Naam} is een vrouwelijke arbeider " +
//        $"met een uurloon van {a.Uurloon} euro";
//        case Arbeider a when a.Geslacht == Geslacht.Man:
//            return $"{a.Naam} is een mannelijke arbeider " +
//        $"met een uurloon van {a.Uurloon} euro";
//        case Bediende b when b.Geslacht == Geslacht.Vrouw:
//            return $"{b.Naam} is een vrouwelijke bediende " +
//        $"met een wedde van {b.Wedde} euro";
//        case Bediende b when b.Geslacht == Geslacht.Man:
//            return $"{b.Naam} is een mannelijke bediende " +
//        $"met een wedde van {b.Wedde} euro";
//        case null: 
//            return $"null";
//        default: 
//            return $"{obj} is geen werknemer";
//    }
//}

//Manager jij = new Manager("Asterix", new DateTime(2022, 1, 1),
//   Geslacht.Man, 2400.79m, 7000m);

//Arbeider asterix = new Arbeider("Asterix", new DateTime(2022, 1, 1),
//Geslacht.Man, 24.79m, 3);
//Bediende obelix = new Bediende("Obelix", new DateTime(1995, 1, 1),
//Geslacht.Man, 2400.79m);
//Manager idefix = new Manager("Idefix", new DateTime(1996, 1, 1),
//Geslacht.Man, 2400.79m, 7000m);
//Console.WriteLine(asterix.Premie);
//Console.WriteLine(obelix.Premie);
//Console.WriteLine(idefix.Premie);

//Werknemer[] personeel = new Werknemer[3]; // (1)
//personeel[0] = new Arbeider("Asterix", new DateTime(2022, 1, 1), // (2)
//Geslacht.Man, 24.79m, 3);
//personeel[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), // (3)
//Geslacht.Man, 2400.79m);
//personeel[2] = new Manager("Idefix", new DateTime(1996, 3, 1), // (4)
//Geslacht.Man, 2400.79m, 7000m);
//foreach (Werknemer eenWerknemer in personeel) // (5)
//    eenWerknemer.Afbeelden();

//Afdeling afdeling1 = new Afdeling("Strijd", 0);
//Afdeling afdeling2 = new Afdeling("Feest", 1);
//Werknemer[] personeel = new Werknemer[3];
//personeel[0] = new Arbeider("Asterix", new DateTime(2022, 1, 1),
//Geslacht.Man, 24.79m, 3);
//personeel[0].Afdeling = afdeling1;
//personeel[1] = new Bediende("Obelix", new DateTime(1995, 2, 1),
//Geslacht.Man, 2400.79m);
//personeel[1].Afdeling = afdeling1;
//personeel[2] = new Manager("Idefix", new DateTime(1996, 3, 1),
//Geslacht.Man, 2400.79m, 7000m);
//personeel[2].Afdeling = afdeling2;
//foreach (Werknemer eenWerknemer in personeel)
//    eenWerknemer.Afbeelden();


//Afdeling afdelingStrijd = new Afdeling("Strijd", 0);
//Arbeider asterix = new Arbeider("Asterix", new DateTime(2023, 1, 1),
//Geslacht.Man, 24.79m, 3, afdelingStrijd);
//asterix.Afbeelden();

//Afdeling afdelingStrijd = new Afdeling("Strijd", 0);
//Arbeider ik = new Arbeider("Asterix", DateTime.Today,
//Geslacht.Man, 24.79m, 3, afdelingStrijd);
//ik.Regime = new Werknemer.WerkRegime(
//Werknemer.WerkRegime.RegimeType.Voltijds);
//Console.WriteLine(ik.Regime);
//Console.WriteLine(ik.Regime.AantalVakantiedagen);

//using PFCursus;
//Class1 c1 = new Class1();
////c1.ToonTekst(); // (1)
//IVoorbeeld c1MetDefaultImplementatie = new Class1();
//c1MetDefaultImplementatie.ToonTekst();
//Class2 c2 = new Class2();
//c2.ToonTekst();


//Afdeling afdeling1 = new Afdeling("Strijd", 0);
//IKost[] kosten = new IKost[4]; // (1)
//kosten[0] = new Arbeider("Asterix", new DateTime(2022, 1, 1),
//Geslacht.Man, 24.79m, 3, afdeling1);
//kosten[1] = new Bediende("Obelix", new DateTime(2022, 2, 1),
//Geslacht.Man, 2400.79m, afdeling1);

//kosten[2] = new Manager("Idefix", new DateTime(2022, 3, 1),
//Geslacht.Man, 2400.79m, 7000m, afdeling1);
//kosten[3] = new Fotokopiemachine("123", 500, 0.025m);
//decimal totaleKost = 0m; // (2)
//foreach (IKost kost in kosten) // (3)
//{
//    Console.WriteLine(kost.Menselijk);
//    Console.WriteLine(kost.BerekenKostprijs());
//    totaleKost += kost.BerekenKostprijs(); // (4)
//}
//Console.WriteLine(totaleKost);

//Afdeling afdeling1 = new Afdeling("Strijd", 0);
//Object[] dingen = new Object[3]; // (1)
//dingen[0] = new Arbeider("Asterix", new DateTime(2022, 1, 1), Geslacht.Man, 14.7m, 3, afdeling1);
//dingen[1] = new Fotokopiemachine("Racekyo", 500, 0.025m);
//dingen[2] = "C#";
//foreach (Object ding in dingen) // (2)
//    Console.WriteLine(ding is IKost);

//Object[] dingen = new Object[3];
//dingen[0] = new Firma.Personeel.Arbeider("Asterix", new DateTime(2022, 1, 1),Firma.Personeel.Geslacht.Man, 24.79m, 3);
//dingen[1] = new Firma.Materiaal.Fotokopiemachine("123", 500, 0.025m);
//dingen[2] = "C#";
//foreach (Object ding in dingen)
//    Console.WriteLine(ding is Firma.IKost);

//using MateriaalStatus = Firma.Materiaal.Status; // (1)
//using PersoneelStatus = Firma.Personeel.Status; // (2)
//MateriaalStatus statusBoorMachine = MateriaalStatus.Werkend; // (3)
//PersoneelStatus statusChef = PersoneelStatus.HogerKader; // (4)
//Console.WriteLine(statusBoorMachine);
//Console.WriteLine(statusChef);

//decimal getal1, getal2;
//try
//{
//    Console.Write("eerste getal :");
//    getal1 = decimal.Parse(Console.ReadLine());
//    Console.Write("tweede getal :");
//    getal2 = decimal.Parse(Console.ReadLine());
//    Console.WriteLine("deling: " + getal1 / getal2);
//}
//catch (FormatException) // (1)
//{
//    Console.WriteLine("Je tikt geen getal");
//}
//catch (DivideByZeroException) // (2)
//{
//    Console.WriteLine("Delen door nul niet toegelaten");
//}
//catch (Exception) // (3)
//{
//    Console.WriteLine("Een fout heeft zich voorgedaan");
//}

//decimal getal1, getal2;
//try // (1)
//{
//    Console.Write("eerste getal: ");
//    getal1 = decimal.Parse(Console.ReadLine());
//    try // (2)
//    {
//        Console.Write("tweede getal: ");
//        getal2 = decimal.Parse(Console.ReadLine());
//        if (getal2 != 0m)
//            Console.WriteLine("deling: " + getal1 / getal2);
//        else
//            Console.WriteLine("Delen door nul niet toegelaten");
//    }
//    catch (FormatException) // (3)
//    {
//        Console.WriteLine("Je tikt geen getal als tweede getal");
//    }
//}
//catch (FormatException) // (4)
//{
//    Console.WriteLine("Je tikt geen getal als eerste getal");
//}

//using Firma.Personeel;
//try
//{
//    Arbeider jos = new Arbeider(
//    "Jos", new DateTime(2002, 10, 1),
//    Geslacht.Man, -10, 3);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Creatie arbeider mislukt");
//    Console.WriteLine(ex.StackTrace);
//}

//using Firma.Personeel;

//try
//{
//    Arbeider jos = new Arbeider("Jos", new DateTime(2002, 10, 1),
//    Geslacht.Man, -10, 3);
//    Console.WriteLine("Object arbeider succesvol aangemaakt");
//}
//catch (Arbeider.UurloonException ex)
//{
//    Console.WriteLine($"Fout: {ex.Message}: {ex.VerkeerdUurloon}");
//}
//catch (Arbeider.PloegenstelselException ex)
//{
//    Console.WriteLine($"Fout: {ex.Message}: {ex.VerkeerdPloegenstelsel}");
//}
//Console.WriteLine("Einde programma");

//try // (1)
//{
//    StreamWriter sw = new StreamWriter(@"C:\Users\Gebruiker\Documents\vdab\cursus\c#_basis\module_.NET_PF\PF\getallen.txt");
//    Console.Write("Tik een getal: ");
//    int getal;
//    while ((getal = int.Parse(Console.ReadLine())) != -1)
//    {
//        sw.WriteLine(getal);
//        Console.Write("Tik een getal: ");
//    }
//    sw.Close();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//StreamWriter sw = null;
//try
//{
//    sw = new StreamWriter(@"C:\Users\Gebruiker\Documents\vdab\cursus\c#_basis\module_.NET_PF\PF\getallen.txt");
//    Console.Write("Tik een getal: ");
//    int getal;
//    while ((getal = int.Parse(Console.ReadLine())) != -1)
//    {
//        sw.WriteLine(getal);
//        Console.Write("Tik een getal: ");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    sw.Close(); // (2)
//}

//try
//{
//    using (StreamWriter sw = new StreamWriter(@"C:\Users\Gebruiker\Documents\vdab\cursus\c#_basis\module_.NET_PF\PF\getallen.txt"))
//    {
//        Console.Write("Tik een getal: ");
//        int getal;
//        while ((getal = int.Parse(Console.ReadLine())) != -1)
//        {
//            sw.WriteLine(getal);
//            Console.Write("Tik een getal: ");
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    using StreamWriter sw = new StreamWriter(@"C:\Users\Gebruiker\Documents\vdab\cursus\c#_basis\module_.NET_PF\PF\getallen.txt"); // (1)
    Console.Write("Tik een getal: ");
    int getal;
    while ((getal = int.Parse(Console.ReadLine())) != -1)
    {
        sw.WriteLine(getal);
        Console.Write("Tik een getal: ");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}