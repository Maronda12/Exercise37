using System;
using System.Linq;

namespace Exercise37
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {


                int[] numArray = new int[5]; // Creates Array

                //Gets numbers
                Console.WriteLine("Welcome to Total Sum!");
                Console.WriteLine("Please enter your first number:");
                numArray[0] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your second number:");
                numArray[1] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your third number:");
                numArray[2] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your fourth number:");
                numArray[3] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your fifth number:");
                numArray[4] = Convert.ToInt32(Console.ReadLine());

                //Adds the sum of all numbers in array
                int sum = numArray.Sum();
                Console.WriteLine($"{numArray[0]} + {numArray[1]} + {numArray[2]} + {numArray[3]} + {numArray[4]} = {sum}");

                //Continue
                while (true)
                {
                    Console.WriteLine("Would you like to continue? yes/no");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        goOn = true;
                        break;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        Console.WriteLine("Good Bye!");
                        goOn = false;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry I didnt understand that lets try again");
                        break;
                    }
                }
            }  
            
            
        }
    }
}

    

