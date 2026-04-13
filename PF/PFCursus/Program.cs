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