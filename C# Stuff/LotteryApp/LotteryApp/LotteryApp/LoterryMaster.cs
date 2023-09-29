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

        public void displayWinningNums(ArrayList winNumbers)
        {

                foreach (int j in winNumbers)
                {

                    Console.WriteLine(+j);

                }


        }

        public ArrayList fillForm()
        {
            string dashedLine = new string('-', Console.WindowWidth - 1);
            string formTitle = "**[LOTTERY FORM]**";
            string detailsTitle = "{PERSONAL DETAILS}";
            string addressTitle = "{BILLING ADDRESS}";
            string contactTitle = "{CONTACT INFORMATION}";
            string submitTitle = "[THE FORM HAS BEEN SUBMITTED]";

            int padding = (Console.WindowWidth - formTitle.Length) / 2;

            int numberOfBreaks = 3;
            string lineBreaks = string.Join(Environment.NewLine, new string('\n', numberOfBreaks));

            string mainHeading = new string('-', padding) + formTitle + new string('-', padding);
            string detailsHeading = new string('-', padding) + detailsTitle + new string('-', padding);
            string addressHeading = new string('-', padding) + addressTitle + new string('-', padding);
            string contactHeading = new string('-', padding) + contactTitle + new string('-', padding);
            string submitHeading = new string('-', padding) + submitTitle + new string('-', padding);

            Console.WriteLine(mainHeading);
            Console.WriteLine(lineBreaks);
            Console.WriteLine(detailsHeading);
            Console.Write("1. - Please Enter Your First Name: ");
            string fname = Console.ReadLine();
            Console.Write("2. - Please Enter Your Last Name: ");
            string lname = Console.ReadLine();
            Console.Write("3. - Please Enter Your Department: ");
            string deptName = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine(addressHeading);
            Console.Write("1. - Please Enter The First Line Of Your Address: ");
            string adrLine1 = Console.ReadLine();
            Console.Write("2. - [OPTIONAL] Please Enter The Second Line Of Your Address: ");
            string adrLine2 = Console.ReadLine();
            Console.Write("3. - Please Enter Your Postcode: ");
            string postcode = Console.ReadLine();

            Console.WriteLine(contactHeading);
            Console.Write("1. - Please Enter Your E-mail Address: ");
            string email = Console.ReadLine();
            Console.Write("2. - Please Enter Your Phone Number: ");
            string phoneNo = Console.ReadLine();


            Console.WriteLine(submitHeading);








            ArrayList form = new ArrayList();
            return form;
        }

    }
}
