{
    //Zad.1
    //int n = int.Parse(Console.ReadLine());
    //for (int i = 0; i<n; i++)
    //{
    //Console.WriteLine("*-|");
    //}
    //Zad.2
    //for (int i=0; i<10; i++)
    //{
    //for (int j = 1; j <11; j++)
    //{
    //Console.WriteLine(i * j + "\t");
    //}
    //}
    //Zad.3
    //int n = int.Parse(Console.ReadLine());
    //for (int i = 0; i < n; i++)
    //{
    //for (int j = 0; j < i; j++)
    //{
    //Console.Write("*");
    //}
    //Console.WriteLine();
    //}
    //Zad.
    //int n = int.Parse(Console.ReadLine());
    //for (int i = 0; i<n; i++)
    //{
        //for (int j = 0; j < n-i; j++)
        {
            //Console.Write("*");
        }
    }
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i<n; i++)
    {
        for (int j =0; j <n-j; j++)
        {
            Console.Write(" ");
        }
        for (int k = n-i-1; k<n; k++)
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}
    