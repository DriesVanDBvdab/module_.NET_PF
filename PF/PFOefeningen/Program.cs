//Oefening 10.8.1 Conversie Celsius naar Fahrenheit
//const float lichaamCelsius = 37.0f;
//float lichaamFahrenheit = (lichaamCelsius * 9 / 5) + 32;
//Console.WriteLine($"De lichaamstemperatuur in Fahrenheit is: {lichaamFahrenheit} °F");

//Oefening 10.8.2 Omrekening seconden.
//const int seconden = 3871;
//int uren = seconden / 3600;
//int restSeconden = seconden % 3600;
//int minuten = restSeconden / 60;
//int resterendeSeconden2 = restSeconden % 60;
//Console.WriteLine($"{seconden} seconden is gelijk aan {uren} uur, {minuten} minuten en {resterendeSeconden2} seconden.");

//Oefening 10.8.3 Snoepautomaat
//const int kitKatPrijs = 132;

//const int betaalBedrag = 200;
//int aantalEuroKitKat = (betaalBedrag - kitKatPrijs) / 100;
//int eurocentenKitKat = (betaalBedrag - kitKatPrijs) % 100;
//int aantal50CentStukkenKitKat = eurocentenKitKat / 50;
//int aantal20CentStukkenKitKat = (eurocentenKitKat % 50) / 20;
//int aantal10CentStukkenKitKat = ((eurocentenKitKat % 50) % 20) / 10;
//int aantal5CentStukkenKitKat = (((eurocentenKitKat % 50) % 20) % 10) / 5;
//int aantal2CentStukkenKitKat = ((((eurocentenKitKat % 50) % 20) % 10) % 5) / 2;
//int aantal1CentStukkenKitKat = ((((eurocentenKitKat % 50) % 20) % 10) % 5) % 2;
//Console.WriteLine($"terug krijgen voor kitkat: {aantalEuroKitKat} euro's, "+
//    $"{aantal50CentStukkenKitKat}x50cent, "+
//    $"{aantal20CentStukkenKitKat}x20cent, "+
//    $"{aantal10CentStukkenKitKat}x10cent, "+
//    $"{aantal5CentStukkenKitKat}x5cents, "+
//    $"{aantal2CentStukkenKitKat}x2cents, "+
//    $"{aantal1CentStukkenKitKat}x1cents");

// oefening 12.12 Strings
//using System.Text;

//Console.WriteLine("Geef de volgende gegevens in voor u wachtwoord:");
//Console.Write("AcherNaam: ");
//string familieNaam = Console.ReadLine() ?? string.Empty;
//Console.Write("Zonenummer: ");
//string zoneNummer = Console.ReadLine() ?? string.Empty;
//Console.Write("Postcode: ");
//string postcode = Console.ReadLine() ?? string.Empty;

//StringBuilder wachtwoord = new StringBuilder(familieNaam.Substring(1, 1).ToLower());
//wachtwoord.Append(familieNaam.Substring(0, 1).ToUpper());
//wachtwoord.Append(zoneNummer.Remove(0,1));
//int postcodeKwadraat = int.Parse(postcode.Substring(3,1)) * int.Parse(postcode.Substring(3, 1));
//wachtwoord.Append(postcodeKwadraat.ToString());
//wachtwoord.Insert(3, "*");

//Console.WriteLine($"Uw wachtwoord is: ({wachtwoord})");

// Oefening 14.6.1 Kortingsbon
//Console.Write("Geef het aankoop bedrag in:");
//string aankoopBedragInput = Console.ReadLine() ?? string.Empty;
//int aankoopBedrag = int.Parse(aankoopBedragInput);
//float korting = 0.0f;
//switch (aankoopBedrag)
//{
//    case < 25:
//        korting = aankoopBedrag * 0.01f;
//        break;
//    case >= 25 and < 50:
//        korting = aankoopBedrag * 0.02f;
//        break;
//    case >= 50 and < 100:
//        korting = aankoopBedrag * 0.03f;
//        break;
//    case >= 100:
//        korting = aankoopBedrag * 0.05f;
//        break;
//}
//Console.WriteLine($"De korting op een aankoop van {aankoopBedrag} is {korting} euro.");

// Oefening 14.6.2 Schrikkeljaar
//Console.Write("Geef een jaartal in:");
//int jaartal = int.Parse(Console.ReadLine() ?? string.Empty);
//if (jaartal % 4 == 0 && jaartal % 100 != 0 && jaartal % 400 != 0)
//{
//    Console.WriteLine($"{jaartal} is een schrikkeljaar.");
//}
//else
//{
//    Console.WriteLine($"{jaartal} is geen schrikkeljaar.");
//}

// Oefening 14.6.3 Lichtkrant
//Console.Write("Geef een datum in:");
//DateOnly ingegevenDatum = DateOnly.Parse(Console.ReadLine() ?? string.Empty);
//switch(ingegevenDatum.DayOfWeek)
//{
//    case DayOfWeek.Monday:
//    case DayOfWeek.Tuesday:
//    case DayOfWeek.Wednesday:
//    case DayOfWeek.Thursday:
//    case DayOfWeek.Friday:
//        Console.WriteLine("Openingsuren: 9u00 tot 12-00 en van 13u00 tot 18u00");
//        Console.WriteLine("We wensen u een prettige werkdag!");
//        break;
//    case DayOfWeek.Saturday:
//        Console.WriteLine("Openingsuren: 10u00 tot 12-00");
//        Console.WriteLine("We wensen u een fijn weekend!");
//        break;
//    case DayOfWeek.Sunday:
//        Console.WriteLine("Openingsuren: Gesloten");
//        Console.WriteLine("We wensen u een fijn weekend!");
//        break;
//}

// Oefening 15.3.1 Kleinste, grootste en gemiddelde.
//int[] getallen = new int[0];
//Console.WriteLine("Geef een reeks getallen in. Typ '-1' om te stoppen.");
//int getal = 0;
//while (true)
//{
//    getal = int.Parse(Console.ReadLine() ?? string.Empty);
//    if(getal == -1)
//    {
//        break;
//    }
//    Array.Resize(ref getallen, getallen.Length + 1);
//    getallen[getallen.Length - 1] = getal;
//}

//int kleinste = getallen[0];
//int grootste = getallen[0];
//int gemiddelde = getallen[0];
//for (int i = 1; i < getallen.Length; i++)
//{
//    if (getallen[i] < kleinste)
//    {
//        kleinste = getallen[i];
//    }
//    if (getallen[i] > grootste)
//    {
//        grootste = getallen[i];
//    }

//    gemiddelde += getallen[i];
//}
//gemiddelde /= getallen.Length;
//Console.WriteLine($"Kleinste getal: {kleinste}");
//Console.WriteLine($"Grootste getal: {grootste}");
//Console.WriteLine($"Gemiddelde: {gemiddelde}");

// Oefening 15.3.2 Priemgetal
//Console.Write("Geef een getal in:");
//int getal = int.Parse(Console.ReadLine() ?? string.Empty);
//int aantalDelers = 0;
//Console.WriteLine($"Delers van {getal}:");
//for (int i = 0; i < getal; i++) {     
//    if (getal % (i + 1) == 0)
//    {
//        aantalDelers++;
//    }
//    Console.WriteLine($"Deler {i}: {i + 1}");
//}
//if(aantalDelers == 2)
//{
//    Console.WriteLine($"{getal} is een priemgetal.");
//}
//else
//{
//    Console.WriteLine($"{getal} is geen priemgetal.");
//}

// Oefening 15.3.3 IBAN rekeningnummer generator
//using System.Numerics;
//using System.Text;
//using System.Text.RegularExpressions;

//string landCode = "BE";

//Console.Write("Geef u belgish rekeningnummer: ");
//string belgishRekeningNummer = Console.ReadLine() ?? string.Empty;
//string rekening = new string(belgishRekeningNummer.Where(char.IsDigit).ToArray());

//while (true)
//{
//    if (rekening.Length == 12)
//    {
//        break;
//    }
//    Console.WriteLine($"Ongeldig rekeningnummer. Probeer opnieuw. {rekening.Length} {rekening}");
//    belgishRekeningNummer = Console.ReadLine() ?? string.Empty;
//    rekening = new string(belgishRekeningNummer.Where(char.IsDigit).ToArray());
//}
//string rekeningLandcode = rekening + landCode + "00";
//string rekeningLandcodeNumeriek = "";
//foreach (char c in rekeningLandcode)
//{
//    if (char.IsLetter(c))
//    {
//        char upperChar = char.ToUpper(c);
//        int alphabetPosition = upperChar - 'A' + 1;
//        int value = alphabetPosition + 9;
//        Console.WriteLine(value);
//        rekeningLandcodeNumeriek += value.ToString();
//    }
//    else
//    {
//        rekeningLandcodeNumeriek += c;
//    }
//}
//Console.WriteLine(rekeningLandcodeNumeriek);
//BigInteger rekeningGetal = BigInteger.Parse(rekeningLandcodeNumeriek);
//int rest = (int)(rekeningGetal % 97);
//int controleGetal = 98 - rest;
//string IBAN = landCode + controleGetal.ToString("D2") + rekening;
//Console.WriteLine($"Het IBAN nummer is: {IBAN}");

// Oefening 15.3.4 Controle IBAN rekeningnummer
//using System.Numerics;

//Console.WriteLine("IBAN controle oefening");
//const string IBAN = "BE68 5390 0754 7034";
//string IBANzonderSpaties = new string(IBAN.Where(c => !char.IsWhiteSpace(c)).ToArray());
//string rekeningLandcode = IBANzonderSpaties.Substring(4) + IBANzonderSpaties.Substring(0, 4);
//string rekeningLandcodeNumeriek = "";
//foreach (char c in rekeningLandcode)
//{
//    if (char.IsLetter(c))
//    {
//        char upperChar = char.ToUpper(c);
//        int alphabetPosition = upperChar - 'A' + 1;
//        int value = alphabetPosition + 9;
//        rekeningLandcodeNumeriek += value.ToString();
//    }
//    else
//    {
//        rekeningLandcodeNumeriek += c;
//    }
//}
//BigInteger rekeningGetal = BigInteger.Parse(rekeningLandcodeNumeriek);
//int rest = (int)(rekeningGetal % 97);
//if(rest == 1) { 
//    Console.WriteLine($"Het IBAN nummer {IBAN} is geldig.");
//}
//else
//{
//    Console.WriteLine($"Het IBAN nummer {IBAN} is ongeldig.");
//}

// Oefening 17.8.1 Som van rijen en kolommen
//int[,] grid = new int[11,11];
//Random randomGenerator = new Random();
//int totaal = 0;
//for (int i = 0; i < grid.GetLength(0); i++)
//{
//    for (int j = 0; j < grid.GetLength(1); j++)
//    {
//        if (i < 10)
//        {
//            int vak = randomGenerator.Next(0, 99);
//            grid[i, j] = vak;
//            totaal += vak;
//        }
//        else if (i == 10)
//        {
//            grid[i, j] = totaal;
//        }
//    }
//}

// Oefening 17.8.2 Codeerprogramma
//Console.WriteLine("Voer een text in om te coderen:");
//string text = Console.ReadLine() ?? string.Empty;
//string codedText = "";
//for (int i = 0; i < text.Length; i++)
//{
//    char c = text[i];
//    if (char.IsLetter(c))
//    {
//        char upperChar = char.ToUpper(c);
//        switch (upperChar)
//        {
//            case 'A':
//                Console.Write("X");
//                codedText += "Q";
//                continue;
//            case 'B':
//                codedText += "S";
//                continue;
//            case 'C':
//                codedText += "P";
//                continue;
//            case 'D':
//                codedText += "A";
//                continue;
//            case 'E':
//                codedText += "T";
//                continue;
//            case 'F':
//                codedText += "V";
//                continue;
//            case 'G':
//                codedText += "X";
//                continue;
//            case 'H':
//                codedText += "B";
//                continue;
//            case 'I':
//                codedText += "C";
//                continue;
//            case 'J':
//                codedText += "R";
//                continue;
//            case 'K':
//                codedText += "J";
//                continue;
//            case 'L':
//                codedText += "Y";
//                continue;
//            case 'M':
//                codedText += "E";
//                continue;
//            case 'N':
//                codedText += "D";
//                continue;
//            case 'O':
//                codedText += "U";
//                continue;
//            case 'P':
//                codedText += "O";
//                continue;
//            case 'Q':
//                codedText += "H";
//                continue;
//            case 'R':
//                codedText += "Z";
//                continue;
//            case 'S':
//                codedText += "G";
//                continue;
//            case 'T':
//                codedText += "I";
//                continue;
//            case 'U':
//                codedText += "F";
//                continue;
//            case 'V':
//                codedText += "L";
//                continue;
//            case 'W':
//                codedText += "N";
//                continue;
//            case 'X':
//                codedText += "W";
//                continue;
//            case 'Y':
//                codedText += "K";
//                continue;
//            case 'Z':
//                codedText += "M";
//                continue;
//        }



//    }
//    else
//    {
//        codedText += c;
//    }
//}
//Console.WriteLine(codedText);

// Oefening 20.9.1 Bank

//using PFOefeningen;

//Rekening rekening = new Rekening();
//rekening.RekeningNummer = "BE10234523451234";
//rekening.Saldo = 1000;
//rekening.CreatieDatum = new DateTime(2000, 1, 1);
//Console.WriteLine($"Rekeningnummer: {rekening.RekeningNummer}");
//Console.WriteLine($"Saldo: {rekening.Saldo}");
//Console.WriteLine($"Creatiedatum: {rekening.CreatieDatum.ToLongDateString()}");
//rekening.RekeningNummer = "FR10234523451234";
//rekening.Saldo = 1000;
//rekening.CreatieDatum = new DateTime(1890, 1, 1);
//Console.WriteLine($"Rekeningnummer: {rekening.RekeningNummer}");
//Console.WriteLine($"Saldo: {rekening.Saldo}");
//Console.WriteLine($"Creatiedatum: {rekening.CreatieDatum.ToLongDateString()}");

// Oefening 20.9.2 Voertuigen
//using PFOefeningen;

//Voertuig Toyota = new Voertuig();
//Toyota.Polishouder = "Jan Jansen";
//Toyota.Kostprijs = 12500m;
//Toyota.Pk = 95;
//Toyota.GemiddeldVerbruik = 6.5f;

//// Print direct onder de declaratie
//Console.WriteLine("Voertuig: Toyota");
//Console.WriteLine($"  Polishouder: {Toyota.Polishouder}");
//Console.WriteLine($"  Kostprijs: {Toyota.Kostprijs:C}");
//Console.WriteLine($"  PK: {Toyota.Pk}");
//Console.WriteLine($"  Gemiddeld verbruik: {Toyota.GemiddeldVerbruik} l/100km");
//Console.WriteLine($"  Nummerplaat: {Toyota.Nummerplaat}");
//Console.WriteLine();

//Voertuig Tesla = new Voertuig();
//Tesla.Polishouder = "Els Peeters";
//Tesla.Kostprijs = 35000m;
//Tesla.Pk = -12;
//Tesla.GemiddeldVerbruik = 0.0f;
//Tesla.Nummerplaat = "2-DEF-456";

//// Print direct onder de declaratie
//Console.WriteLine("Voertuig: Tesla");
//Console.WriteLine($"  Polishouder: {Tesla.Polishouder}");
//Console.WriteLine($"  Kostprijs: {Tesla.Kostprijs:C}");
//Console.WriteLine($"  PK: {Tesla.Pk}");
//Console.WriteLine($"  Gemiddeld verbruik: {Tesla.GemiddeldVerbruik} l/100km");
//Console.WriteLine($"  Nummerplaat: {Tesla.Nummerplaat}");
//Console.WriteLine();

//Voertuig Peugeot = new Voertuig();
//Peugeot.Polishouder = "Auto BV";
//Peugeot.Kostprijs = 4500m;
//Peugeot.Pk = 75;
//Peugeot.GemiddeldVerbruik = -5.5f;
//Peugeot.Nummerplaat = "XYZ-999";

//// Print direct onder de declaratie
//Console.WriteLine("Voertuig: Peugeot");
//Console.WriteLine($"  Polishouder: {Peugeot.Polishouder}");
//Console.WriteLine($"  Kostprijs: {Peugeot.Kostprijs:C}");
//Console.WriteLine($"  PK: {Peugeot.Pk}");
//Console.WriteLine($"  Gemiddeld verbruik: {Peugeot.GemiddeldVerbruik} l/100km");
//Console.WriteLine($"  Nummerplaat: {Peugeot.Nummerplaat}");
//Console.WriteLine();

//Voertuig Volvo = new Voertuig();
//Volvo.Polishouder = "Bert Autos";
//Volvo.Kostprijs = -30000m;
//Volvo.Pk = 150;
//Volvo.GemiddeldVerbruik = 7.2f;
//Volvo.Nummerplaat = "3-GHI-789";

//// Print direct onder de declaratie
//Console.WriteLine("Voertuig: Volvo");
//Console.WriteLine($"  Polishouder: {Volvo.Polishouder}");
//Console.WriteLine($"  Kostprijs: {Volvo.Kostprijs:C}");
//Console.WriteLine($"  PK: {Volvo.Pk}");
//Console.WriteLine($"  Gemiddeld verbruik: {Volvo.GemiddeldVerbruik} l/100km");
//Console.WriteLine($"  Nummerplaat: {Volvo.Nummerplaat}");
//Console.WriteLine();

//Voertuig Ford = new Voertuig();
//Ford.Kostprijs = 9800m;
//Ford.Pk = 110;
//Ford.GemiddeldVerbruik = 6.9f;
//Ford.Nummerplaat = "RND-123";

//// Print direct onder de declaratie
//Console.WriteLine("Voertuig: Ford");
//Console.WriteLine($"  Polishouder: {Ford.Polishouder}");
//Console.WriteLine($"  Kostprijs: {Ford.Kostprijs:C}");
//Console.WriteLine($"  PK: {Ford.Pk}");
//Console.WriteLine($"  Gemiddeld verbruik: {Ford.GemiddeldVerbruik} l/100km");
//Console.WriteLine($"  Nummerplaat: {Ford.Nummerplaat}");
//Console.WriteLine();

// Oefening 21.13.1 Bank
//using PFOefeningen;
//Rekening rekening = new Rekening();
//rekening.RekeningNummer = "BE10234523451234";
//rekening.Saldo = 1000;
//rekening.CreatieDatum = new DateTime(2000, 1, 1);
//rekening.Afbeelden();
//rekening.Afhalen(200);
//rekening.Afbeelden();
//rekening.Storten(500);
//rekening.Afbeelden();

// Oefening 21.13.2 Voertuigen
//using PFOefeningen;
//Voertuig Toyota = new Voertuig();
//Toyota.Polishouder = "Jan Jansen";
//Toyota.Kostprijs = 12500m;
//Toyota.Pk = 95;
//Toyota.GemiddeldVerbruik = 6.5f;
//Toyota.Afbeelden();

// Oefening 22.14.1 Bank
//using PFOefeningen;
//Rekening rekening = new Rekening("BE10234523451237", 1000, new DateTime(2000, 1, 1));
//rekening.Afbeelden();

// Oefening 22.14.2 Voertuigen
//using PFOefeningen;
//Voertuig Toyota = new Voertuig("Jan Jansen", 12500m, 95, 6.5f, "1-ABC-123");
//Toyota.Afbeelden();

// Oefening 24.10.1 Bank
using PFOefeningen;
Spaarrekening spaarrekening = new Spaarrekening("BE10234523451234", 1000, new DateTime(2000, 1, 1), 0.05m);
spaarrekening.Afbeelden();
Zichtrekening zichtrekening = new Zichtrekening("BE10234523451235", 125, new DateTime(2005, 5, 5), -200);
zichtrekening.Afbeelden();