namespace Assignment_3
{
    class Student
    {
        private string Name = "";
        private int Grade = 0;
        private Instructor Teacher;

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
            this.Grade = 0;

        }

        public void SetGrade(int Grade)
        {
            this.Grade = Grade;
        }
        public void Print()
        {
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Grade: " + Grade);
            System.Console.Write("Instructor: ");
        }
    }
}
