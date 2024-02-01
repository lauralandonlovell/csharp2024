using System.Text.RegularExpressions;

Random dice = new();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = 0;
total += roll1;
total += roll2;
total += roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus added!");
        total += 6;
        Console.WriteLine(total);
    }
    else
    {
        Console.WriteLine("You rolled doubles!! +2 bonus added!!");
        total += 2;
        Console.WriteLine(total);
    }
}
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose!");
}



