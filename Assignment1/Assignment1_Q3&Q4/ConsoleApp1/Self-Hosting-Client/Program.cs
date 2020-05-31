using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Self_Hosting_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower = 0;
            int upper = 0;
            bool valid_lower = true;
            bool valid_upper = true;
            myInterfaceClient proxy = new myInterfaceClient();
            do
            {
                Console.WriteLine("\nPlease Enter a Minimum Limit Number:");
                string lower_text = Console.ReadLine();

                Console.WriteLine("\nPlease Enter a Maximum Limit Number:");
                string upper_text = Console.ReadLine();


                valid_lower = int.TryParse(lower_text, out lower);
                valid_upper = int.TryParse(upper_text, out upper);

                if (lower > upper)
                {
                    Console.WriteLine("The minimum number must be less than maximum number");
                }
                else if (!valid_lower || !valid_upper)
                {
                    Console.WriteLine("Please enter correct numbers");
                }
            } while (!valid_lower || !valid_upper || (lower > upper));

            int secretNum = proxy.SecretNumber(lower, upper);
            bool isValid = true;
            string guess_text = "";
            int guess_num = 0;
            do
            {
                Console.WriteLine("Please enter a guessing number: ");
                guess_text = Console.ReadLine();
                isValid = int.TryParse(guess_text, out guess_num);

                if (isValid)
                {
                    Console.WriteLine("Your guess of {0} is {1}", guess_num, proxy.checkNumber(guess_num, secretNum));
                }
                else if (guess_num < lower || guess_num > upper) {
                    Console.WriteLine("The entered the guess number is out of range");
                }
                else
                {
                    Console.WriteLine("Please enter a correct guessing number");
                }
            } while (!isValid || (guess_num != secretNum));
            Console.WriteLine("Press <ENTER> to Quit");
            Console.ReadLine();
            proxy.Close();
        }
    }
}
