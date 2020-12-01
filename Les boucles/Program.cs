using System;

namespace Les_boucles
{
    class boucle
    {
        static void Main(string[] args)
        {
            int a = 1;
            int c = 1;
           Random random = new Random();
            int randomNumber;
            randomNumber = random.Next(2, 200);  
            while (a <= 30)
            {
                c = a * randomNumber;
                Console.WriteLine(c);
                a++;
            }

        }
    }
}
