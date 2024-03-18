string? readResult;
string jobtitle = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your jobtitle (Administrator, Manager, or User): ");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        jobtitle = readResult.Trim();
    }
    if (jobtitle.ToLower() == "administrator" || jobtitle.ToLower() == "manager" || jobtitle.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"The jobtitle that you specified, \"{jobtitle}\", does not exist.");
    }
} while (validEntry == false);

Console.WriteLine($"Your input value ({jobtitle}) has been accepted.");
readResult = Console.ReadLine();














