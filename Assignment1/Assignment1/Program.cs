
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////
            //  Variables   //
            /////////////////
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            int heightFeet;
            double heightinches;
            double totalheightCM;
            bool isCitizen;
            bool canVote;

            /////////////////////////////////////////
            //  Great and ask for the user's name //
            ///////////////////////////////////////
            System.Console.Write("Hale: Hello, what is your name? ");

            firstName = System.Console.ReadLine();

            /////////////////////////////////////////
            //  Ask for the user's middle initial //
            ///////////////////////////////////////
            System.Console.Write("Hale: What is your middle initial? ");

            middleInitial = System.Console.ReadLine();

            ////////////////////////////////////
            //  Ask for the user's last name //
            //////////////////////////////////
            System.Console.Write("Hale: What is your last name? ");

            lastName = System.Console.ReadLine();


            ///////////////////////////
            //  Assigns Full Name   //
            /////////////////////////

            fullName = firstName + " " + "." + middleInitial + " " + lastName;

            ///////////////////////////////////////////
            //  Ask for the user's height in feet    //
            /////////////////////////////////////////
            System.Console.Write("Hale: Please provide your height in feet (Only Feet): ");

            heightFeet = int.Parse(System.Console.ReadLine());

            /////////////////////////////////////////////
            //  Ask for the user's height in inches   //
            ///////////////////////////////////////////
            System.Console.Write("Hale: Please provide your height in inches beyond your base height(Only Inches): ");

            heightinches = double.Parse(System.Console.ReadLine());

            totalheightCM = (((heightFeet * 12) + heightinches) * 2.54);

            /////////////////////////////
            //  Ask for the user's age//
            ///////////////////////////
            System.Console.Write("Hale: What is your age: ");

            age = int.Parse(System.Console.ReadLine());

            ///////////////////////////////
            //  Ask if user is Citizen  //
            /////////////////////////////
            System.Console.Write("Hale: Are you a citizen: Yes");
            isCitizen = true;
            System.Console.ReadLine();

            ////////////////////////////////////////////////////
            //  Determines if the user is eligible to vote   //
            //////////////////////////////////////////////////
            if (age >= 18 && isCitizen == true)
            {
                canVote = true;
                System.Console.Write("Hale: Looks like you are elgible to vote.");
            }
            else
            {
                canVote = false;
                System.Console.Write("Hale: Looks like you are not elgible to vote.");
            }
            System.Console.ReadLine();

            ///////////////////////////////
            // Print out information    //
            /////////////////////////////

            System.Console.Write("---- I.D ----");
            System.Console.ReadLine();

            System.Console.Write("Name: " + fullName);
            System.Console.ReadLine();

            System.Console.Write("Height(CM): " + totalheightCM);
            System.Console.ReadLine();

            System.Console.Write("Elgible to vote: ");
            if (canVote)
            {
                System.Console.Write("Yes");
            }
            else
            {
                System.Console.Write("No");
            }
            System.Console.ReadLine();
            /*

            */




        }
    }
}
