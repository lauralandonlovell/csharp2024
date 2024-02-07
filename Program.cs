string[] names = {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int[] sophiaScores = {93, 87, 98, 95, 100};
int[] nicolasScores = {80, 83, 82, 88, 85};
int[] zahirahScores = {84, 96, 73, 85, 79};
int[] jeongScores = {90, 92, 98, 100, 97};

string[] letterGrade = {"A", "B", "C", "D", "F"};
int i = 0;
foreach (name in names)
{
   Console.WriteLine($"{name}: ");
}
    foreach (score in sophiaScores && nicolasScores && zahirahScores && jeongScores)
    {
        if (score >= 90)
        {
            Console.WriteLine($"{letterGrade[0]}");
        }
        elseif (score >= 80)
        {
            Console.WriteLine($"{letterGrade[1]}");
        }
        elseif (score >= 70)
        {
            Console.WriteLine($"{letterGrade[2]}");
        }
        elseif
        {
            Console.WriteLine($"Your grade is a D or below. Ask for help and keep studying!");
        }
        i++;
    }



