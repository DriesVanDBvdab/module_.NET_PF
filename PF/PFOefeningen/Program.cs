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
Console.Write("Geef een getal in:");
int getal = int.Parse(Console.ReadLine() ?? string.Empty);
int aantalDelers = 0;
Console.WriteLine($"Delers van {getal}:");
for (int i = 0; i < getal; i++) {     
    if (getal % (i + 1) == 0)
    {
        aantalDelers++;
    }
    Console.WriteLine($"Deler {i}: {i + 1}");
}
if(aantalDelers == 2)
{
    Console.WriteLine($"{getal} is een priemgetal.");
}
else
{
    Console.WriteLine($"{getal} is geen priemgetal.");
}
