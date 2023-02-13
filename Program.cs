// övning 1

// Random generator = new Random();
// for(int i = 0; i < 10; i++) {
//     int random = generator.Next(4);
//     Console.WriteLine(namn[random]); 
// }
// Console.ReadLine();

//---------------------------------------------------------------------

//övning 2

// string[] namn = {"Benny", "Jenny", "Kenny", "Lenny"};
// beginning:
// Console.WriteLine("Skriv ett tal mellan 0-3");

// string input = Console.ReadLine();


// int vilketNamn = 0;
// try {
//     vilketNamn = int.Parse(input);
// }
// catch {
//     Console.WriteLine("Inte ens en siffra, försök igen!");
//     goto beginning;
// }

// if (vilketNamn < 0 || vilketNamn > namn.Length) {
//     Console.WriteLine("Ogiltlig siffra, försök igen!");
//     goto beginning;
// }

// Console.WriteLine(namn[vilketNamn]);

// Console.ReadLine();

//---------------------------------------------------------------------

// övning 3


// Läs in en grej från användaren
// gör om den grejen till en siffra
// kör en loop så många gånger

// string s = Console.ReadLine();

// int antal = int.Parse(s);

// for (int siffra = 0; siffra < antal; siffra++)
// {
//   Console.WriteLine(siffra);
// }
// Console.ReadLine();

//---------------------------------------------------------------------

// övning 4

List<string> Saker = new List<string>();
Saker.Add("Smör");
Saker.Add("Mjölk");
Saker.Add("Bakpulver");
Saker.Add("Godis");
Saker.Add("Julmust");



// string[] choices = {"Smör", "Mjölk", "Bakpulver", "Godis", "Julmust"};
// Skapa en Inventory-lista


List<string> inventory = new List<string>();

// inventory.Add ("Smör");
// inventory.Add ("Mjölk");
// inventory.Add ("Bakpulver");
// inventory.Add ("Godis");
// inventory.Add ("Julmust");

// Läs in användar-string
string userWish = Console.ReadLine();

foreach (string sak in Saker)
{
    Console.WriteLine(sak);

    if (userWish == sak)
    {
        inventory.Add(sak);
    }
}
  
  //   lägg till det man skrev in i inventory-listan

Console.ReadLine();
