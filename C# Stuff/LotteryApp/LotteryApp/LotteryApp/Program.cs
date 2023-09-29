using System.Collections;

namespace LotteryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoterryMaster abc = new LoterryMaster();

            ArrayList userNumbers = new ArrayList();
            ArrayList winNumbers = new ArrayList();

            abc.generateWinningNumbers(winNumbers);
            abc.inputValidation(userNumbers);


            abc.pushButton();
            abc.displayWinningNums(winNumbers);
            Console.WriteLine(abc.compareNumbers(winNumbers, userNumbers));
            abc.fillForm();
           
        }
    }
}