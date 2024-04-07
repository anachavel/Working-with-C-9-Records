using System;

namespace ClassesAndRecords
{
    class Program
    {
        static void PrintCourse(Course course)
        {

        }
        
        private static void Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "Working with C# Records";
            pluralsightCourse.Author = "Roland Guijt";

            var anotherCourse = pluralsightCourse;
            
            Console.WriteLine(pluralsightCourse.Name);
            Console.WriteLine(anotherCourse.Name);
        } 
    }
    public class Course
    {
        public string Name { get; set; }
        public String Author { get; set; } // Escribo "prop" y pulso tab para que me cree automáticamente una propiedad
    }
}

