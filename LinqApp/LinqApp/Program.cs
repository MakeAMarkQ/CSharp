using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
namespace LinqApp
{
    public class Student
    {
        #region data
        public enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public GradeLevel Year;
        public List<int> ExamScores;
        protected static List<Student> students = new List<Student>
    {
        new Student {FirstName = "Terry", LastName = "Adams", Id = 120,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int> { 99, 82, 81, 79}},
        new Student {FirstName = "Fadi", LastName = "Fakhouri", Id = 116,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int> { 99, 86, 90, 94}},
        new Student {FirstName = "Hanying", LastName = "Feng", Id = 117,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int> { 93, 92, 80, 87}},
        new Student {FirstName = "Cesar", LastName = "Garcia", Id = 114,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int> { 97, 89, 85, 82}},
        new Student {FirstName = "Debra", LastName = "Garcia", Id = 115,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int> { 35, 72, 91, 70}},
        new Student {FirstName = "Hugo", LastName = "Garcia", Id = 118,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int> { 92, 90, 83, 78}},
        new Student {FirstName = "Sven", LastName = "Mortensen", Id = 113,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int> { 88, 94, 65, 91}},
        new Student {FirstName = "Claire", LastName = "O'Donnell", Id = 112,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int> { 75, 84, 91, 39}},
        new Student {FirstName = "Svetlana", LastName = "Omelchenko", Id = 111,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int> { 97, 92, 81, 60}},
        new Student {FirstName = "Lance", LastName = "Tucker", Id = 119,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int> { 68, 79, 88, 92}},
        new Student {FirstName = "Michael", LastName = "Tucker", Id = 122,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int> { 94, 92, 91, 91}},
        new Student {FirstName = "Eugene", LastName = "Zabokritski", Id = 121,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int> { 96, 85, 91, 60}}
    };
        #endregion

        //* 1) Hae kaikki oppilaat ja tulosta etunimi ja sukunimi
        internal static void Tehtävä_1_Metodi()
        {
            var highScores = from student in students
                             select student;
            foreach (var item in highScores)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            Console.WriteLine();
        }
        //* 2) Hae kaikki oppilaat, joiden sukunimi alkaa Fllä ja tulosta ne
        internal static void Tehtävä_2_Metodi()
        {


            var queryFirstLetters =
                from student in students
                where student.LastName[0] == 'F'
                select student;

            foreach (var item in queryFirstLetters)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            Console.WriteLine();
        }
        //* 3) Hae kaikki oppilaat, joiden paras arvosana on ainakin 90.
        internal static void Tehtävä_3_Metodi()
        {
            var highScores = from student in students
                             where student.ExamScores.Max() > 90
                             select student;

            foreach (var item in highScores)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            Console.WriteLine();
        }
        //* 4) Hae kaikki kolmannen vuosikurssin oppilaat
        internal static void Tehtävä_4_Metodi()
        {
            var highScores = from student in students
                             where student.Year == GradeLevel.SecondYear
                             select student;

            foreach (var item in highScores)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            Console.WriteLine();
        }
        //* 5) Hae kaikki oppilaat vuoden mukaan ja tulosta etunimi ja sukunimi.
        internal static void Tehtävä_5_Metodi()
        {
            var queryFirstLetters =
                from student in students
                group student by student.Year into uusRyhma
                orderby uusRyhma.Key
                select uusRyhma;

            foreach (var studentGroup in queryFirstLetters)
            {
                Console.WriteLine($"{studentGroup.Key}");
                // Nested foreach is required to access group items.
                foreach (var student in studentGroup)
                {
                    Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
                }
            }
            Console.WriteLine();
        }
        //* 6) Hae kaikki oppilaat vuoden mukaan ja tulosta paras arvosana sekä etunimi ja sukunimi.
        internal static void Tehtävä_6_Metodi()
        {
            var queryFirstLetters =
                from student in students
                orderby student.Year
                select student;

            foreach (var item in queryFirstLetters)
            {
                Console.WriteLine($"{item.ExamScores.Max()} {item.FirstName} {item.LastName}");
            }
            Console.WriteLine();
        }
    }
    public class City
    {
        #region fields
        public int population;
        public string name;
        #endregion fields
        #region constructors
        City() { }
        public City(string name, int population)
        {
            this.name = name;
            this.population = population;
        }
        #endregion constructors
        #region methods
        #endregion methods
    }
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ studies
            List<int> scores = new List<int>() { 97, 92, 81, 60, 55, 22, 87 };
            List<City> cities = new List<City>();
            cities.Add(new City("Oulu", 203000));
            cities.Add(new City("Helsinki", 500000));
            cities.Add(new City("Turku", 198000));
            cities.Add(new City("Tampere", 230000));
            // make query

            //
            //* 1) Hae kaikki oppilaat ja tulosta etunimi ja sukunimi
            Console.WriteLine("\nTehtävä_1_Metodi\n");
            Student.Tehtävä_1_Metodi();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            //* 2) Hae kaikki oppilaat, joiden sukunimi alkaa Fllä ja tulosta ne.
            Console.WriteLine("\nTehtävä_2_Metodi\n");
            Student.Tehtävä_2_Metodi();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            //* 3) Hae kaikki oppilaat, joiden paras arvosana on ainakin 90.
            Console.WriteLine("\nTehtävä_3_Metodi\n");
            Student.Tehtävä_3_Metodi();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            //* 4) Hae kaikki kolmannen vuosikurssin oppilaat
            Console.WriteLine("\nTehtävä_4_Metodi\n");
            Student.Tehtävä_4_Metodi();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            //* 5) Hae kaikki oppilaat vuoden mukaan ja tulosta etunimi ja sukunimi.
            Console.WriteLine("\nTehtävä_5_Metodi\n");
            Student.Tehtävä_5_Metodi();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            //* 6) Hae kaikki oppilaat vuoden mukaan ja tulosta paras arvosana sekä etunimi ja sukunimi.
            Console.WriteLine("\nTehtävä_6_Metodi\n");
            Student.Tehtävä_6_Metodi();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            //
        }
    }
}