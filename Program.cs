using System;

namespace DeliverableTwoFL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many coin flips?");
            int numberOfFlips = int.Parse(Console.ReadLine());
            int correctCount = 0;
            

            for (int i = 0; i <= numberOfFlips; i++)
            {

                int headsOrTailsGuessNumber;
                

                Console.WriteLine("Heads Or Tails?");
                string headsOrTailsGuess = Console.ReadLine();
                if (headsOrTailsGuess == "heads")
                {
                    headsOrTailsGuessNumber = 1;
                }
                else
                {
                    headsOrTailsGuessNumber = 2;
                }



                Random rd = new Random();
                int rand = rd.Next(1, 3);
                int percentageFormula = correctCount / numberOfFlips * 100;

                if (rand != headsOrTailsGuessNumber && rand == 2)
                {
                    
                    string hort = "tails";

                    Console.WriteLine("Your guess: " + headsOrTailsGuess);
                    Console.WriteLine("Result: " + hort + "|| Number Correct: " + correctCount);
                    Console.WriteLine(percentageFormula);


                }
                else if (rand == headsOrTailsGuessNumber && rand == 2)
                {
                    correctCount++;
                    
                    string hort = "tails";
                    
                    Console.WriteLine("Your guess: " + headsOrTailsGuess);
                    Console.WriteLine("Result: " + hort + "|| Number Correct: " + correctCount);
                    Console.WriteLine(percentageFormula);

                }
                else if (rand != headsOrTailsGuessNumber && rand == 1)
                {
                   
                    string hort = "heads";

                    Console.WriteLine("Your guess: " + headsOrTailsGuess);
                    Console.WriteLine("Result: " + hort + "|| Number Correct: " + correctCount);
                    Console.WriteLine(percentageFormula);


                }
                else if (rand == headsOrTailsGuessNumber && rand == 1)
                {
                    correctCount++;
                    
                    string hort = "heads";
                    
                    Console.WriteLine("Your guess: " + headsOrTailsGuess);
                    Console.WriteLine("Result: " + hort + "|| Number Correct: " + correctCount);
                    Console.WriteLine(percentageFormula);

                }
            }
        }
    }
}
