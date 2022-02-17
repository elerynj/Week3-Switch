using System;

namespace Gradingif
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai 'A', kuvab konsool "Suurepärane!";
            //'B', kuvab konsool "Väga hea!";
            //'C', kuvab konsool "Hea!;
            //'D', kuvab konsool "Rahuldav";
            //'E', kuvab konsool "Kasin";
            //'F', kuvab konsool "Puudulik";
            //kui kasutaja sisestab midagi muud, siis kuvab konsool "Vale väärtus!";

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if(userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if(userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if(userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if(userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if(userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine($"{userResult} on vale väärtus!");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
