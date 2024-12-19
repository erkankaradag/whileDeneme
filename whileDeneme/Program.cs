/* APPLICATION 1
                                    //Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırma

using System;
namespace whileExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter <10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                counter++;
            }
        }
    }
}
*/

//----------------------------------//1-20 arasındaki sayıları konsola yazdırma---------------------------------------------------------------

/* APLICATION 2

using System;
namespace whileExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number <= 20)
            {
                Console.WriteLine(number);
                number++;
            }
        }
    }
}
*/

//----------------------------------//1-20 arasındaki çift sayıları yazdırma---------------------------------------------------------------

/* APLICATION 3

using System;
namespace whileExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2; 
            while (number <= 20)
            {
                Console.WriteLine(number);
                number += 2;
            }
        }
    }
}
*/

//----------------------------------//50 ile 150 arasındaki sayıların toplamını yazdırma---------------------------------------------------------------

/* APLICATION 4
 
using System;
namespace whileExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int number = 50;
            while (number <= 150)
            {
                total += number;
                number++;
            }
        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + total);
        }
    }
}
*/

//----------------------------------//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı yazdırma---------------------------------------------------------------

/* APLICATION 5 
 
 using System;
namespace whileExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int singleTotal = 0;
            int doubleTotal = 0;
            while (number <= 120)
            {
                if (number % 2 == 0)
                {
                    doubleTotal += number;
                }
                else
                {
                    singleTotal += number;
                }
                number++;
            }
            Console.WriteLine("Tek sayılar toplamı: " + singleTotal);
            Console.WriteLine("Çift sayılar toplamı:" + doubleTotal);
        }
    }
}
*/