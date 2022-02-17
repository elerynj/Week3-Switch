using System;

namespace GradingSwitch
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
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine($"{userResult} on puudulik väärtus!");
                    break;
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
