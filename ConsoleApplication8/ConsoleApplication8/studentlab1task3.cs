using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Student // create class Student
    {
        public string name;
        public string surname;
        public double gpa;

        public Student(string _name, string _surname, double _gpa) // задаем параметры
        {
            this.name = _name;
            this.surname = _surname;
            this.gpa = _gpa; // обращение к параметрам        

        }
        public Student()
        {

        }
        public Student(string name, string _surname)
        {
            this.name = name;
            this.surname = _surname;
        }
        public override string ToString() 
        {
            return name + " " + surname + " " + gpa; // возвращение name surname and gpa
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            Student s = new Student("Zhazira", "Umirkalykova", 2.67);
            Student a = new Student("name", "Surname");
            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
