using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            Console.WriteLine("Tere tulemast mängu: Guessing Game Three Tries.");
            Console.WriteLine("Mängu võitmiseks tuleb ära arvata arvuti poolt valitud juhuslik number vahemikust 1 kuni 10!");

            while (i < 3)
            {
                
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Õige vastus! Olete mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale vastus! Proovige uuesti!");
                    Console.WriteLine($"Sul on jäänud {3 - i} katset.");
                }
                



            }
            Console.WriteLine("Täname mängimast! :)");



        }
    }
}


