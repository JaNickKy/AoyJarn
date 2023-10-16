

static bool IsPrime(int x)
{
    if (x < 2)
    {
        return false;
    }
    else
    {
        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
                return false;
        }
    }
    return true;
}
int n;
string input = string.Empty;
while (input.Equals("w")) ;
{
    Console.Write("Enter Number:");
    input = Console.ReadLine();
    Int32.TryParse(input, out n);
    
    Console.Write("");
    for (int i = 2; i <= n; i++)
    
    if (IsPrime(i))
    
    Console.Write(i+ ",");
}
