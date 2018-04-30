namespace Lab2
{
    public class Person
    {
        //////////////////////////
        //  Member Variables   //
        ////////////////////////


        public string FirstName; // Member (Instance) Variable Declaration (Noun)
        public string LastName; // Member (Instance) Variable Declaration (Noun)
        public int Age; // Member (Instance) Variable Declaration (Noun)




        

        public static double SumOfAllAges; // Exists once on the class

        public string GetFullName()
        {
            return this.LastName + "," + " " + this.FirstName;

        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + " " + "(" + this.Age + ")");
        }


    }
}
