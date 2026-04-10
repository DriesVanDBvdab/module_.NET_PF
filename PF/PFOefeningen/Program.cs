//Oefening 10.8.1 Conversie Celsius naar Fahrenheit
const float lichaamCelsius = 37.0f;
float lichaamFahrenheit = (lichaamCelsius * 9 / 5) + 32;
Console.WriteLine($"De lichaamstemperatuur in Fahrenheit is: {lichaamFahrenheit} °F");

//Oefening 10.8.2 Omrekening seconden.
const int seconden = 3871;
int uren = seconden / 3600;
int restSeconden = seconden % 3600;
int minuten = restSeconden / 60;
int resterendeSeconden2 = restSeconden % 60;
Console.WriteLine($"{seconden} seconden is gelijk aan {uren} uur, {minuten} minuten en {resterendeSeconden2} seconden.");

//Oefening 10.8.3 Snoepautomaat
const float kitKatPrijs = 1.20f;
const float marsPrijs = 0.57f;

//TODO