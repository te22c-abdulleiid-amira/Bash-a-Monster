// skapar ett nytt objekt av klassen Giorno och monster och tilldelar det variabeln theGiorno/theMonster
Giorno theGiorno = new Giorno();
Monster theMonster = new Monster();

// skriver ut deras namn och hälsopoäng (hp) till konsolen
Console.WriteLine($"{theGiorno.name} har {theGiorno.health} hp");
Console.WriteLine($"{theMonster.name} har {theMonster.health} hp och {theMonster.size} storlek");

// skriver ut "fight" till konsolen för att indikera att en strid börjar
Console.WriteLine("fight");

// minskar Monstrets hälsopoäng (hp) med 10
theMonster.health -= 10;

// skriver ut Monstrets namn och nuvarande hälsopoäng (hp) till konsolen efter skadan
Console.WriteLine($"{theMonster.name} har nu {theMonster.health} hp");

Console.WriteLine("tryck vart som helst för att fortsätta");
Console.ReadKey();
