using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projext_Assigned_Number1
{
    class Program
    {
        static void Main(string[] args)
        { //string firstName , lastName, coloR

            Console.WriteLine("Please tell us, what is your first name? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please tell us, what is your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please tell us, what is your age? ");
            int ageOfUser = int.Parse(Console.ReadLine()); //Console.ReadLine-- this is storing the users input

            Console.WriteLine("In which month were you born? Please enter as a two digit number.");
            int monthOfUser = int.Parse(Console.ReadLine());


            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is type help");
            string favColor = Console.ReadLine();

            if (favColor == "help") //does this section need any adjusting?
            {

                Console.WriteLine("The ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet" + "\n");

                {
                    Console.WriteLine("What's your favorite ROYGBIV color?");
                    favColor = Console.ReadLine();
                }



            }

            Console.WriteLine("\n" + "How many siblings do you have? ");
            int sibs = int.Parse(Console.ReadLine());



            Console.WriteLine(firstName + " " + lastName);

            //part 2
            //what you need will find you and you will find what you need
            if (ageOfUser % 2 == 0)

            {
                Console.WriteLine("You will retire in 5 years.");
            }

            else

            {
                Console.WriteLine("You will retire in 10 years.");

            }

            if (sibs == 0)
            {
                Console.WriteLine("You will have a vacation home in Greece.");
            }

            else if (sibs == 1)
            {
                Console.WriteLine("You will have a vacation home in China.");

            }
            else if (sibs == 2)

            {
                Console.WriteLine("You will have a vacation home in Florida.");
            }

            else if (sibs == 3)
            {
                Console.WriteLine("You will have a vacation home in Japan.");
            }

            else if (sibs >= 3)
            {
                Console.WriteLine("You will have a vacation home in Cleveland, Ohio.");

            }


            else if (sibs <= 0)
            {
                Console.WriteLine("You will have a vacation in Afghanistan, good luck!");
            }

            favColor = favColor.ToLower();

            string favColoR = null;
            if (favColoR == "red" || favColoR == "orange" || favColoR == "yellow" || favColoR == "blue" || favColoR == "indigo" || favColoR == "violet")

                switch (favColoR)

                {
                    case "red":
                        Console.WriteLine("You're bussing to New York!");
                        break;

                    case "orange":
                        Console.WriteLine("Do you enjoy trains? I hope so...you're going to California!");
                        break;

                    case "yellow":
                        Console.WriteLine("Hope you're not afraid of heights you're heading to Toronto by helicopter!");
                        break;

                    case "blue":
                        Console.WriteLine("Get ready to scoot on a scoot through Sicily");
                        break;

                    case "indigo":
                        Console.WriteLine("Get ready to play the ukelele you're going to Hawai'i in a cruise ship");
                        break;

                    case "violet":
                        Console.WriteLine("You're heading to Ibiza on a private jet");
                        break;

                    default:
                        Console.WriteLine("Be sure to travel light...you're on foot buddy!");
                        break;


                }

            if (monthOfUser >= 1 || monthOfUser <= 4)
            {
                Console.WriteLine("You will have $10,000 in the bank.");

            }

            else if (monthOfUser >= 5 || monthOfUser <= 8)

            {
                Console.WriteLine("You will have $3,000 in the bank.");
            }

            else if (monthOfUser >= 9 || monthOfUser <= 12)

            {
                Console.WriteLine("You've got $5 left in your bank account..");
            }

            else

            {
                Console.WriteLine("You've got $1 left in your bank account.");
            }


        }
    }

}
