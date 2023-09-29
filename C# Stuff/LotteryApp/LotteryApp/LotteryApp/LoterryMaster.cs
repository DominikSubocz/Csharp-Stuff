using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApp
{
    internal class LoterryMaster
    {



        public ArrayList inputValidation(ArrayList userNumbers)
        {
            Console.WriteLine("Enter 6 numbers between 1 and 48");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Enter number{i + 1}");
                if(int.TryParse(Console.ReadLine(),out int userInput) && userInput >= 1 && userInput <= 48)
                {
                    Random rand = new Random();
                    userNumbers.Add(userInput);
                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 48");
                    i--;
                }
            }


            return userNumbers;
            
        }

        public void generateWinningNumbers(ArrayList winNumbers)
        {

            Random random = new Random();
            
            for (int i = 0;i < 6;i++)
            {
                winNumbers.Add(random.Next(1,49));
            }
        }


        public string compareNumbers(ArrayList winNumbers, ArrayList userNumbers)
        {
            int matches = 0;
  

            foreach (int i in userNumbers) 
            {
            foreach (int j in winNumbers)
                {
                    if (i == j)
                    {
                        matches++;
                    }
                }
            }

            if (matches == 0)
            {
                return ("Well done for trying! You didn't guess any numbers, but keep playing!");
            }

            else if(matches == 1)
            {
                return ("Well done! You got 1 number correct. Try again for a bigger win!");
            }

            else if (matches == 2)
            {
                return ("Well done! You guessed 2 numbers correctly. Keep playing for even more success!");
            }

            else if (matches == 3)
            {
                return ("Well done! 3 numbers correct. You're on the right track!");
            }

            else if (matches == 4)
            {
                return ("Well done! You matched 4 numbers. Keep it up!");
            }

            else if (matches == 5)
            {
                return ("Well done! You got 5 numbers correct. Try again for the jackpot!");
            }

            else if (matches == 6)
            {
                return ("Well done! Jackpot! You guessed all 6 numbers correctly. Congratulations!");
            }

            return ("error");



        }

        public void pushButton()
        {
            Console.WriteLine("Push Button to Generate Winning Numbers? [PRESS ENTER] :");
            Console.ReadLine();
        }

    }
}
