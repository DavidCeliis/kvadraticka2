using System;

namespace kvadraticka2
{
    class Program
    {

        double a, b, c;

        public void read()
        {
            Console.WriteLine("\n Zadej hodnoty a,b,c");
            Console.Write("\n a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\n b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\n c: ");
            c = double.Parse(Console.ReadLine());

        }
        public void compute()
        {
            int m;
            double r1, r2, d1;
            d1 = b * b - 4 * a * c;
            if (a == 0)
                m = 1;
            else if (d1 > 0)
                m = 2;
            else if (d1 == 0)
                m = 3;
            else
                m = 4;
            switch(m)
            {
                case 1:
                    Console.WriteLine(@"\n");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("\n ");
                    r1 = (-b + Math.Sqrt(d1)) / (2 * a);
                    r2 = (-b - Math.Sqrt(d1)) / (2 * a);
                    Console.WriteLine("\n 1. výsledek  {0:#.##}", r1);
                    Console.WriteLine("\n 2. výsledek  {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("\n");
                    r1 = r2 = (-b) / (2 * a);
 
                    Console.WriteLine("\n 1. výsledek {0:#.##}", r1);
                    Console.WriteLine("\n 2. výsledek {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("\n");
                    r1 = (-b) / (2 * a);
                    r2 = Math.Sqrt(-d1) / (2 * a);
                    Console.WriteLine("\n 1. výsledek {0:#.##} + i {1:#.##}", r1, r2);
                    Console.WriteLine("\n 2. výsledek {0:#.##} - i {1:#.##}", r1, r2);
                    Console.ReadLine();
                    break;
            }
        }
    }

    class vysledky
    {
        public static void Main()
        {
            Program kv = new Program();
            kv.read();
            kv.compute();
            
        }
    }
}

