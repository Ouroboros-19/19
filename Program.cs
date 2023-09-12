class Program
{
    static void Main()
    {
        int n = 5, jj = n - 1;
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                if (i == j)
                    Console.Write("{0,2}", array[i, j] = i);
                else
                    if (j == jj)
                    Console.Write("{0,2}", array[i, j] = j);
                else
                    Console.Write("{0,2}", array[i, j]);
            jj--;
            Console.WriteLine();
        }
        Console.WriteLine("Для закрытия программы нажмите любую клавишу");
        Console.ReadKey();
    }
}