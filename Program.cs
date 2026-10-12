using System;

namespace StudentApp
{
    // Оголошення класу Student
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }

        public Student(string name, string group)
        {
            Name = name;
            Group = group;
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

            // Вивести інформацію про них на екран
            Console.WriteLine("--- Інформація про студентів ---");
            student1.DisplayInfo();
            student2.DisplayInfo();
        }
    }
}
