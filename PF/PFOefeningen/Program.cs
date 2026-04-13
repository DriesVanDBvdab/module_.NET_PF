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
const int kitKatPrijs = 132;

const int betaalBedrag = 200;
int aantalEuroKitKat = (betaalBedrag - kitKatPrijs) / 100;
int eurocentenKitKat = (betaalBedrag - kitKatPrijs) % 100;
int aantal50CentStukkenKitKat = eurocentenKitKat / 50;
int aantal20CentStukkenKitKat = (eurocentenKitKat % 50) / 20;
int aantal10CentStukkenKitKat = ((eurocentenKitKat % 50) % 20) / 10;
int aantal5CentStukkenKitKat = (((eurocentenKitKat % 50) % 20) % 10) / 5;
int aantal2CentStukkenKitKat = ((((eurocentenKitKat % 50) % 20) % 10) % 5) / 2;
int aantal1CentStukkenKitKat = ((((eurocentenKitKat % 50) % 20) % 10) % 5) % 2;
Console.WriteLine($"terug krijgen voor kitkat: {aantalEuroKitKat} euro's, "+
    $"{aantal50CentStukkenKitKat}x50cent, "+
    $"{aantal20CentStukkenKitKat}x20cent, "+
    $"{aantal10CentStukkenKitKat}x10cent, "+
    $"{aantal5CentStukkenKitKat}x5cents, "+
    $"{aantal2CentStukkenKitKat}x2cents, "+
    $"{aantal1CentStukkenKitKat}x1cents");
