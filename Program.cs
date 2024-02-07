string[] students = {"Sophia", "Andrew", "Emma", "Logan"};
decimal[] examScores = {92.2m, 89.6m, 85.6m, 91.2m};
string[] letterGrades = {"A","A-", "A-", "A"};
decimal[] overallGrades = {95.88m, 91.38m, 90.94m, 93.12m};
decimal[] extraCredits = {(92 + 3.68m), (89 + 1.78m), (89 + 5.34m), (96 + 1.92m)};

//int i = 0;
foreach (string i in students)
 {
    
    Console.WriteLine(i);
    // foreach (decimal examScore1 in examScore)
    // {
    //     Console.WriteLine($"{student}:\t\t{examScore[0]}\t\t{overallGrade[0]}\t{letterGrade[0]}\t\t{extraCredit[0]}");
    // }
 } 
Console.WriteLine($"Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
Console.WriteLine($"{students[0]}\t\t{examScores[0]}\t\t{overallGrades[0]}\t{letterGrades[0]}\t{extraCredits[0]}");
Console.WriteLine($"{students[1]}\t\t{examScores[1]}\t\t{overallGrades[1]}\t{letterGrades[1]}\t{extraCredits[1]}");
Console.WriteLine($"{students[2]}\t\t{examScores[2]}\t\t{overallGrades[2]}\t{letterGrades[2]}\t{extraCredits[2]}");
Console.WriteLine($"{students[3]}\t\t{examScores[3]}\t\t{overallGrades[3]}\t{letterGrades[3]}\t{extraCredits[3]}");


//Console.WriteLine(i);
