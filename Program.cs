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

            if (ageOfUser % 2 == 0)                     //if someones age is odd then it will print the statement below 
            { Console.WriteLine("You will retire in 5 years.");
                                                   //make this equal to number or years until retirement

            }
            else                                     //if its not the given case above it will default to the one below
            {
                Console.WriteLine("You will retire in 10 years.");
                                //if even, this will appear
            }

            favColor = favColor.ToLower();

            if (favColor == "red" || favColor == "orange" || favColor == "yellow" || favColor == "green" || favColor == "blue" || favColor == "indigo" || favColor == "violet" )
                switch (favColor)

            { case "red" :
                Console.WriteLine("You will be driving a sports car soon!");
                break;

            case "orange":
                Console.WriteLine("You'll be travelling by skateboard!");
                        break;
            
                case "yellow":
                Console.WriteLine("You'll be getting around by bus!");
                         break;

                case "green":
                Console.WriteLine("You'd better travel light...you'll be on foot!");
                        break;
            
                case "indigo":
                Console.WriteLine("You're travelling via rollerskates");
                        break;

                case "violet":
                Console.WriteLine("You're get you're own private jet!");
                        break;
                                    
           }

            int broSis = int.Parse(Console.ReadLine());

            if (broSis == 0)

            { Console.WriteLine("You'll travel to New Zealand"); }

           else if  (broSis == +1)

            { Console.WriteLine("You'll travel to France");

            
            }
            if (broSis == 2)

            {
                Console.WriteLine("You'll travel to Jamaica");
            }

            if (broSis == +2)
            {

                Console.WriteLine("You'll travel to Cuba");

            }
            else if (broSis == +3) 
            {
                Console.WriteLine("You'll travel to the Andes");
                  
               

                }
                
    
                if (broSis >= 3) 
                

                { Console.WriteLine("You can travel anywhere South America!");
                }

            int month = int.Parse(Console.ReadLine());

            if (month <= 4)

            {
                Console.WriteLine("You have $15,000 in the bank");

            }
            else

             if (month <= 8)
            {
                Console.WriteLine("You have $5,000 in the bank");
            }
            else


                if (month <= 12)

            {
                Console.WriteLine("You have $2 in the bank");
            }
            else

            {
                Console.WriteLine("You have $0 in the bank");
            }



            //part 3
            // The user’s fortune should be written as such: 
            //[First Name]
            //[Last Name]
            //will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            //Program should be able to handle whether or not a user inputs capital or lowercase letters.

        }
    }

}


