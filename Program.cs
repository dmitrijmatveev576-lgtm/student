using System;

namespace StudentApp
{
    // Базовий клас Person
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Похідний клас Student, який наслідує Person
    public class Student : Person
    {
        // Статичне поле
        public static int StudentCount { get; private set; } = 0;

        public string Group { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }

        public Student(string name, int age, string group, string faculty, int course) 
            : base(name, age)
        {
            Group = group;
            Faculty = faculty;
            Course = course;
            StudentCount++; 
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Студент: {Name}, Вік: {Age}, Група: {Group}, Факультет: {Faculty}, Курс: {Course}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Згенерувати два окремі об'єкти студентів із новими полями
            Student student1 = new Student("Дмитрій Матвєєв", 19, "П-33", "КНТ", 3);
            Student student2 = new Student("Іван Іваненко", 18, "П-33", "КНТ", 3);

            Console.WriteLine("--- Інформація про студентів ---");
            student1.DisplayInfo();
            student2.DisplayInfo();

            Console.WriteLine($"\nЗагальна кількість створених студентів: {Student.StudentCount}");
        }
    }
}
