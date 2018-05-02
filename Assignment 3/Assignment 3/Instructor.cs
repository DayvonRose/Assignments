namespace Assignment_3
{
    class Instructor
    {
        private string Name = "";
        private string CourseName = "";

        public Instructor(string name, string coursename)
        {
            this.Name = name;
            this.CourseName = coursename;
        }
        public void SetStudentGrade(Student Student, int Grade)
        {
            Student.SetGrade(Grade);
        }
        public void InstructorPrint()
        {
            System.Console.WriteLine(Name + ", Instructor of " + CourseName);
        }

    }
}
