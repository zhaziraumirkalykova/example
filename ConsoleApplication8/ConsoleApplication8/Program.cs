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
        public override string ToString() // change integer to string
        {
            return name + " " + surname + " " + gpa; // возвращение name surname and gpa
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                string name = Console.ReadLine(); // считывает имю и фамилию
                string surname = Console.ReadLine();
                double gpa = Convert.ToDouble(Console.ReadLine()); //change the string to double in order to understand the gpa as it is the real number
                Student information = new Student(name, surname, gpa); // create he information about the student
                Console.WriteLine(information); // задаем информацию именно имя, фамилия, гпа
           
            Console.ReadKey();
        }
    }
}
