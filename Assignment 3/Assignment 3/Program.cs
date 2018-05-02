namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            System.Console.WriteLine("-----College of Soverign-----");
            System.Console.WriteLine("");
            System.Console.WriteLine("-Mathematics-");
            System.Console.WriteLine("");

            Jane.Print();
            John.InstructorPrint();
            System.Console.WriteLine("");
            Joe.Print();
            John.InstructorPrint();
            System.Console.WriteLine("");

            System.Console.WriteLine("-English-");

            System.Console.WriteLine("");
            Matt.Print();
            Mike.InstructorPrint();
            System.Console.WriteLine("");
            Melissa.Print();
            Mike.InstructorPrint();

            System.Console.WriteLine("");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
