Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10 && daysUntilExpiration > 0)
{
    Console.WriteLine(daysUntilExpiration);
    if (daysUntilExpiration == 1)
    {
        Console.WriteLine($"Your subscription expires within a day! Renew now and save 20%!");
        discountPercentage += 20 / 100;
        Console.WriteLine(discountPercentage);
    }
    else if (daysUntilExpiration < 6 && daysUntilExpiration > 1)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%");
        discountPercentage += 10 / 100;
        Console.WriteLine(discountPercentage);
    } 
    else
    {
        Console.WriteLine($"Your subscription will expire soon.Renew now!");
    }
}
else if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
    Console.WriteLine(daysUntilExpiration);
}
else 
{
    Console.WriteLine("else");
    Console.WriteLine(daysUntilExpiration);
}


