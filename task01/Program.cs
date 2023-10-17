// DZ 1

Console.WriteLine("Vvedite piatiznachnoe chislo: ");
string strNumber = Console.ReadLine();

if (strNumber.Length ==5)
{
    if (strNumber[0] == strNumber[4] && strNumber[1] == strNumber[3])
    {
        Console.WriteLine("True");
    }
    else
    {
    Console.WriteLine("False");
    }
}
