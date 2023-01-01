{
    //Zad
    //import Math;
    //int a = int.Parse(Control.Readline());
    //int b = int.Parse(Control.Readline());
    //int art = (a + b) / 2;
    //int g = Math.sqrt(a * b);
    //if (art > g) ;
    //{
    //Console.Writeline("TAK");
    //}
    //else
    //{
    //Console.Wrieline("NIE");
    //}
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
    //for (int i = 0; i < n+1; i++)
    //{
    //for (int j = 0; j < i; j++)
    //{
    //Console.Write("*");
    //}
    //Console.WriteLine();
    //}
    //Zad.5
    //int n = int.Parse(Console.Readline())
    //for (int i = 1; i < n + 1; i++)
    //{
    //    for (int j; j < n; j++)
    //    {
    //        if (j == n / 2 + 1)
    //        {
    //            Console.Write("*");
    //        }
    //        else if (i == n / 2 + 1)
    //        {
    //            Console.Write("?");
    //        }
    //        else
    //        {
    //            Console.Write(" ");
    //        }
    //        Console.Writeline();
    //    }
    //}

    //Zad.6
    //int n = int.Parse(Console.Readline())
    //for (int i = 1; i < n + 1; i++)
    //{
    //    for (int j; j < n; j++)
    //    {
    //        if (i==n-j)
    //        {
    //            Console.Write("*");
    //        }
    //        else
    //        {
    //            Console.Write(" ");
    //        }
    //        Console.Writeline();
    //    }
    //}

    //Zad.7
    int n = int.Parse(Console.Readline());
    for (int i = 1; i < n + 1; i++)
    {
       for (int j = 1; j < n + 1; j++)
       {
           if (i == 1 || j == 1 || j == n || i == n || i == n/2+1 && j==n/2+1)
           {
               Console.Write("*");
           }
           else
           {
               Console.Write(" ");
           }
           Console.Writeline();
       }
    }


    //*******************************************************************

    //1
    //****
    //***
    //**
    //*

    //int n = int.Parse(Console.Readline());
    //for (int i = 1; i < n + 1; i++)
    //{
    //    for (int j = 1; j < n + 1; j++)
    //    {
    //        if (n-j+1 >= i)
    //        {
    //            Console.Write("*")
    //        }
    //        else
    //        {
    //            Console.Write(" ")
    //        }
    //        Console.Write()
    //    }
    //}

    //2
    //   *
    //  **
    // ***
    //****

    //int n = int.Parse(Console.Readline());
    //for (int i = 1; i < n + 1; i++)
    //{
    //    for (int j = 1; j < n + 1; j++)
    //    {
    //        if (n - j < i)
    //        {
    //            Console.Write("*");
    //        }
    //        else
    //        {
    //            Console.Write(" ");
    //        }
    //        Console.Writeline();
    //    }
    //}


    //int n = int.Parse(Console.Readline());
    //for (int i = 0; i < n+1; i++)
    //{
    //    for (int j = 1; j < i+1; j++)
    //    {
    //        if (j >= i)
    //        {
    //            Console.Write("*");
    //        }
    //        else
    //        {
    //            Console.Write(" ");
    //        }
    //    }
    //}


    //int n = int.Parse(Console.ReadLine());
    //for (int i = 0; i<n; i++)
    //{
    //for (int j = 0; j < n-i; j++)
    //{
    //        Console.Write("*");
    //    }
    //}

    //int n = int.Parse(Console.ReadLine());
    //for (int i = 0; i<n; i++)
    //{
    //    for (int j =0; j <n-j; j++)
    //    {
    //        Console.Write(" ");
    //    }
    //    for (int k = n-i-1; k<n; k++)
    //    {
    //        Console.Write("*");
    //    }
    //}
    //Console.WriteLine();

    //int n = int.Parse(Conosle.Readline());
    //    for (int i = 0; i < n; i++){
    //    for (int j = 0; j < i + 1; j++)
    //    {
    //        Console.Write("-");
    //    }
    //}
}