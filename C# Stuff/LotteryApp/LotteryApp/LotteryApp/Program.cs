using System.Collections;

namespace LotteryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (quit == false)
            {
                string str = @"Please Choose from the Following Options:
1. Lotto - Pick & Win 
2. Try Your Luck
3. Quit";
                Console.WriteLine(str);
                LoterryMaster abc = new LoterryMaster();
                Console.WriteLine("Today's Jackpot price is: "+ "£"+ abc.jackpot.ToString());

                ArrayList userNumbers = new ArrayList();
                ArrayList winNumbers = new ArrayList();

                int menuChoice = 0;

                menuChoice = Convert.ToInt32(Console.ReadLine());

                if (menuChoice == 1)
                {
                    abc.generateWinningNumbers(winNumbers);
                    abc.inputValidation(userNumbers);


                    abc.pushButton();
                    abc.displayWinningNums(winNumbers);
                    Console.WriteLine(abc.compareNumbers(winNumbers, userNumbers));
                    abc.fillForm();
                    Console.Clear();
                }

                else if (menuChoice == 2) { }
                else
                {
                    quit = true;
                }
            }




           
        }
    }
}