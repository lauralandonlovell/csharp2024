Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

daysUntilExpiration = 0;

if (daysUntilExpiration < 11 && daysUntilExpiration != 0)
{
    if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
        Console.WriteLine(daysUntilExpiration);
    }
    else if (daysUntilExpiration < 6)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
        Console.WriteLine(daysUntilExpiration);
    }
    else if (daysUntilExpiration >= 6)
    {
        Console.WriteLine($"Your subscription will expire soon. Renew now!");
    }
}
else if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
    Console.WriteLine(daysUntilExpiration);
} 
else 
{
    //Console.WriteLine("do nothing");
}


