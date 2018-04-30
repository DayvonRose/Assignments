namespace Lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            ///////////////////
            //  Variables   //
            /////////////////

            Person p1 = new Person();
            Person p2 = new Person();

            Person s1 = new Person();
            Person s2 = new Person();

        System.Console.WriteLine("[ Enter Information For P1 ]");
            System.Console.WriteLine("");

            /////////////////////////////////////////
            //  Ask for the P1's name             //
            ///////////////////////////////////////


            System.Console.Write("Enter Your First Name                          : ");

            p1.FirstName = System.Console.ReadLine();

            ////////////////////////////////////
            //  Ask for the P1's last name   //
            //////////////////////////////////

            System.Console.Write("Enter Your Last Name                           : ");

            p1.LastName = System.Console.ReadLine();

            ///////////////////////////////
            //  Ask for the P1's age    //
            /////////////////////////////

            System.Console.Write("Enter Your Age                                 : ");

            p1.Age = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges += p1.Age;


            //////////////////////////////////////
            //  Ask for the P1's spouse name   //
            ////////////////////////////////////

            System.Console.Write("Enter Your Spouse's First Name                 : ");

            s1.FirstName = System.Console.ReadLine();
            s1.LastName = p1.LastName;

            //////////////////////////////////////
            //  Ask for the P1's spouse age    //
            ////////////////////////////////////

            System.Console.Write("Enter Your Spouse's Age                        : ");

            s1.Age = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges += s1.Age;

            System.Console.WriteLine("");
            System.Console.WriteLine("[ Enter Information For P2 ]");
            System.Console.WriteLine("");

            /////////////////////////////////////////
            //  Ask for the P2's name             //
            ///////////////////////////////////////


            System.Console.Write("Enter Your First Name                          : ");

            p2.FirstName = System.Console.ReadLine();

            ////////////////////////////////////
            //  Ask for the P2's last name   //
            //////////////////////////////////

            System.Console.Write("Enter Your Last Name                           : ");

            p2.LastName = System.Console.ReadLine();

            ///////////////////////////////
            //  Ask for the P2's age    //
            /////////////////////////////

            System.Console.Write("Enter Your Age                                 : ");

            p2.Age = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges += p2.Age;


            //////////////////////////////////////
            //  Ask for the P2's spouse name   //
            ////////////////////////////////////

            System.Console.Write("Enter Your Spouse's First Name                 : ");

            s2.FirstName = System.Console.ReadLine();
            s2.LastName = p2.LastName;

            //////////////////////////////////////
            //  Ask for the P2's spouse age    //
            ////////////////////////////////////

            System.Console.Write("Enter Your Spouse's Age                        : ");

            s2.Age = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges += s2.Age;
            ///////////////////////////
            //  Print Name and Age  //
            /////////////////////////
            System.Console.WriteLine(" ");
            System.Console.WriteLine("[ Printing Results ]");
            System.Console.WriteLine(" ");

            p1.PrintNameAndAge();
            s1.PrintNameAndAge();
            p2.PrintNameAndAge();
            s2.PrintNameAndAge();

            System.Console.WriteLine("");
            System.Console.WriteLine("Average Age = " + Person.SumOfAllAges/4);
            System.Console.WriteLine("");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
