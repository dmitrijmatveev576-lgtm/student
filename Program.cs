using System;

namespace StudentApp
{

    public class Student
    {
        // Статичне поле
        public static int StudentCount { get; private set; } = 0;

        public string Name { get; set; }
        public string Group { get; set; }

        public Student(string name, string group)
        {
            Name = name;
            Group = group;
            StudentCount++; // Збільшуємо лічильник при створенні нового студента
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Студент: {Name}, Група: {Group}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Згенерувати два окремі об'єкти
            Student student1 = new Student("Дмитрій Матвєєв", "П-33");
            Student student2 = new Student("Іван Іваненко", "П-33");

        
            Console.WriteLine("--- Інформація про студентів ---");
            student1.DisplayInfo();
            student2.DisplayInfo();

            
            Console.WriteLine($"\nЗагальна кількість створених студентів: {Student.StudentCount}");
        }
    }
}
