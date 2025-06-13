class Program
{
    static void Main()
    {
        int soma = 0;
        
        for (int i = 51; i <= 500; i += 2)
        {
            if (i % 3 == 0)
            {
                soma += i;
            }
        }
        
        Console.WriteLine("Soma: " + soma);
    }
}