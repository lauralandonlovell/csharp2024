using System.IO.Compression;

Random random = new();
int monsterRoll = random.Next(1,11);
int heroRoll = random.Next(1,11);
int monsterHealth = 10;
int heroHealth = 10;

do
{
    heroRoll = random.Next(1, 11);
    Console.WriteLine(heroRoll);
    monsterHealth = 10;
    monsterHealth = monsterHealth - heroRoll;
    Console.WriteLine(monsterHealth);

    monsterRoll = random.Next(1, 11);
    Console.WriteLine(monsterRoll);
    heroHealth = 10;
    heroHealth = heroHealth - monsterRoll;
    Console.WriteLine(heroHealth);

} while (monsterHealth > 0 && heroHealth > 0);
// {
//     roll = random.Next(1, 11);
//     Console.WriteLine(roll);
//     Console.WriteLine("hello");
//     heroHealth = 10;
//     heroHealth -= roll;
//     Console.WriteLine(heroHealth);
// }
Console.WriteLine($"Monster Health: {monsterHealth}");
Console.WriteLine($"Hero Health: {heroHealth}");
if (heroHealth > monsterHealth)
{
    Console.WriteLine($"Hero has won by {heroHealth - monsterHealth} points!");
}
else if (monsterHealth > heroHealth)
{
    Console.WriteLine($"Monster wins by {monsterHealth - heroHealth} points!");
}
else
{
    Console.WriteLine($"Monster and Hero are tied.");
}









