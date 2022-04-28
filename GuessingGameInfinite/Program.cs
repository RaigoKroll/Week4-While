using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;

            Console.WriteLine("Tere tulemast mängu: Guessing Game Infinite.");
            Console.WriteLine("Mängu võitmiseks tuleb ära arvata arvuti poolt valitud juhuslik number vahemikust 1 kuni 10!");

            while (loopActive)
            {
               
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Õige vastus! Olete mängu võitnud!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale vastus! Proovige uuesti!");
                }
            }
       
            Console.WriteLine("Täname mängimast! :)");


        }
    }
}
