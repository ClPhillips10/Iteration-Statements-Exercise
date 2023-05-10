namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void BigSubtract()
        {

            for(int i = 1000; i <= 1000 && i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            
        }
            
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void UpThree()
        {
            
            for(int i = 3; i >= 3 && i <= 999; i+=3)
            {
                Console.WriteLine($"{i}");



            }
                
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void EqualOrNah()
        {

            Console.Write("Enter a value: ");
            var A = int.Parse(Console.ReadLine());
            Console.Write("Enter a value: ");
            var B = int.Parse(Console.ReadLine());

            if ( A == B)
                {
                Console.WriteLine("Your values are equal");
                }
            else
                Console.WriteLine("not equal");


         }
        //Write a method to check whether a given number is even or odd

        public static void IsItEven()
        {


            Console.Write("Enter a value: ");
            var Num1 = int.Parse(Console.ReadLine());
         




            if (Num1 % 2 == 0)
            {
                Console.WriteLine("This is an even number");

            }
            else
                Console.WriteLine("This number is definitly odd");
        }









            //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg()
        {


            Console.Write("Enter a value: ");
            var PosNum = int.Parse(Console.ReadLine());

            if(PosNum > 0)
            {
                Console.WriteLine($"{PosNum} is positive");
            }
            else if (PosNum < 0)
            {
                Console.WriteLine($"{PosNum} is negative");
            }
            else
            {
                Console.WriteLine("You did not enter anything");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void CanVote()
        {
            Console.Write("Enter your age: ");
            var Age = int.Parse(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You cannot vote");
            }    




        }


        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IntCheck()
        {

            Console.Write("Enter your int: ");
            var UserInt = int.Parse(Console.ReadLine());

            if(UserInt >= -10 && UserInt <= 10)
            {
                Console.WriteLine($"{UserInt} is within -10 and 10");
            }
            else
            {
                Console.WriteLine($"{UserInt} is not within the range of -10 and 10.");
            }



        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Multiply()

        {

            Console.WriteLine("Enter a value to Multiply");
            var value = int.Parse(Console.ReadLine());
            var Multiple = 0;
            do
            {
                Console.WriteLine($"{value} * {Multiple} is {value * Multiple}");
                Multiple++;

            } while (Multiple <= 12);


        }

        //MAIN-----------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("Which Method would you like to activate ?");
            Console.WriteLine("1. Multiply     2. PosOrNeg        3. EqualOrNah");
            Console.WriteLine("4. IntCheck     5. CanVote         6. UpThree");
            Console.WriteLine("7. IsItEven     8. BigSubtract");
            int UserString = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            if (UserString == 1)
            {
                Multiply();

            }
            if (UserString == 2)
            {
                PosOrNeg();

            }
            if (UserString == 3)
            {
                EqualOrNah();

            }
            if (UserString == 4)
            {
                IntCheck();

            }
            if (UserString == 5)
            {
                CanVote();

            }
            if (UserString == 6)
            {
                UpThree();

            }
            if (UserString == 7)
            {
                IsItEven();

            }


            if (UserString == 8)
            {
                BigSubtract();

            }






        }
    }
}
