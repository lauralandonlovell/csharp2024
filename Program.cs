using System.IO.Compression;

Random random = new();
int roll = random.Next(1, 11);
int monsterHealth = 10;
int heroHealth = 10;

do
{
    roll = random.Next(1, 11);
    Console.WriteLine(roll);
    monsterHealth = 10;
    monsterHealth = monsterHealth - roll;
    Console.WriteLine(monsterHealth);

} while (monsterHealth > 0);
{
    roll = random.Next(1, 11);
    Console.WriteLine(roll);
    heroHealth = 10;
    heroHealth -= roll;
    Console.WriteLine(heroHealth);
}
Console.WriteLine($"Monster Health: {monsterHealth}");
Console.WriteLine($"Hero Health: {heroHealth}");
if (heroHealth > monsterHealth)
{
    Console.WriteLine($"Hero has won by {heroHealth - monsterHealth} points!");
}
else
{
    Console.WriteLine($"Monster wins by {monsterHealth - heroHealth} points!");
}









