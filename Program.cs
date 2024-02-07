string[] student = {"Sophia", "Andrew", "Emma", "Logan"};
decimal[] examScore = {92.2m, 89.6m, 85.6m, 91.2m};
string[] letterGrade = {"A","A-"};
decimal[] overallGrade = {95.88m, 91.38m, 90.94m, 93.12m};
decimal[] extraCredit = {(92 + 3.68m), (89 + 1.78m), (89 + 5.34m), (96 + 1.92m)};

int i = 0;
foreach (string student1 in student)
 {
    Console.WriteLine($"Studen\t\tExam Score\t\tOverall Grade\tExtra Credit");
    foreach (decimal examScore1 in examScore)
    {
        Console.WriteLine($"{student1[0]}:\t\t{examScore[0]}\t\t\t{overallGrade[0]}\t{letterGrade[0]}\t\t{extraCredit[0]}");
    }
 }   
i++;
Console.WriteLine(i);
