using System;

namespace StudentApp
{
    
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

    
    public class Student : Person
    {
        
        public static int StudentCount { get; private set; } = 0;

        public string Group { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }

        // Конструктор класу Student із передачею name та age у базовий конструктор через base
        public Student(string name, int age, string group, string faculty, int course) 
            : base(name, age) // Виклик конструктора класу Person
        {
            Group = group;
            Faculty = faculty;
            Course = course;
            StudentCount++; // Збільшуємо лічильник при створенні нового студента
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
            // Створення об'єктів з передачею параметрів через конструктор
            Student student1 = new Student("Дмитрій Матвєєв", 17, "П-33", "ІПЗ", 3);
            Student student2 = new Student("Іван Іваненко", 18, "П-33", "ІПЗ", 3);

            Console.WriteLine("--- Інформація про студентів ---");
            student1.DisplayInfo();
            student2.DisplayInfo();

            Console.WriteLine($"\nЗагальна кількість створених студентів: {Student.StudentCount}");
        }
    }
}
