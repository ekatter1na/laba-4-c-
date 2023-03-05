namespace laba_4_cc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
        {
            new Student("Лемескин", "С.В.", 103, new int[] {5,4,5,5,5}),
            new Student("Хрунин", "Е.К.", 201, new int[] {2,3,4,5,3}),
            new Student("Челнокова", "О.С.", 101, new int[]{4,4,5,5,5}),
            new Student("Белоградова", "М.В", 207, new int[]{5,5,4,4,4}),
            new Student("Базарнов", "Е.А.", 317, new int[]{5,5,5,5,5}),
            new Student("Кулиев", "Э.С.",120, new int[]{2,3,3,3,2})
            };
            foreach (Student student in students)
            {
                student.Print();
            }
            Console.WriteLine("\n\n\n\n");
            var sortedStudents = students.OrderBy(s => s.AvgGrade);
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }
        struct Student
        {
            string surname;
            string initials;
            int group;
            int[] grades;
            double avgGrade;

            public Student(string surname, string initials, int group, int[] grades)
            {
                this.surname = surname;
                this.initials = initials;
                this.group = group;
                this.grades = grades;
                avgGrade = grades.Average();
            }
            public double AvgGrade
            {
                get
                {
                    return avgGrade;
                }
            }
            public void Print()
            {
                Console.WriteLine($"ФИО: {surname} {initials}, группа: {group},  средний балл: {avgGrade}");
            }
        }
    }
}