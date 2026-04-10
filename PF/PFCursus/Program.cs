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

const int BtwNummer = 213252520; // (1)
int deeltal = BtwNummer / 100; // (2)
int rest = deeltal % 97; // (3)
int controle = BtwNummer % 100; // (4)
Console.Write("97 - de rest van de deling van de eerste 7 cijfers door 97: "); 
Console.WriteLine(97 - rest); // (5)
Console.Write("Twee laatste cijfers: "); Console.WriteLine(controle); // (6)