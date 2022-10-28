using System;

namespace uppgift4_24
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int tal = 0; tal <= 100; tal++)

                if (tal % 3 ==0)
                    Console.WriteLine("Fizz");
                else if (tal % 5 == 0)
                    Console.WriteLine("Buzz");
                else if(tal % 3 == 0 && tal % 5 ==0)
                    Console.WriteLine("FizzBuzz");
                else
                    Console.WriteLine(tal);
        }
    }
}