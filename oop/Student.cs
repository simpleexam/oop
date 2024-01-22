using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{

/// <summary>
/// класс студента, унаследованный от человека
/// </summary>
    internal class Student : Human
    {
        public string group; //группа
        public int yearStart; //год начала обучения
        public List<int> grade;// средняя успеваемость
        public List<string> subjects; //список предметов

        //конструктор по умолчанию не наследуется. для доступа
        //к функционалу родительского конструктора используется ключевое слово base
        //с передачей только тех параметров, которые должны проинициализированы по логике родителя
        public Student(string name, string surname, DateTime db,
            Gender gender, string nation, string group, int yearStart)
            : base(name, surname, db,gender, nation)
        {
            this.group = group;
            this.yearStart = yearStart;

            grade = new List<int>();    
            subjects = new List<string>();  
        }


        //имитация просмотра курсов
        public void CheckCourse()
        {
            foreach(string s in subjects) 
            {
                Console.WriteLine($"{name} просматривает предмет {s}"); 
            }
        }

        //имитация прохождения теста
        public void CompleteTest()
        {
            Random rnd = new Random();
            grade.Add(rnd.Next(2,6));
            Console.WriteLine($"студент {name} прошел тест на оценку: {grade.Last<int>()} ");
        }

        //вывод средней успеваемости
        public void PrintGrade()
        {
            int total=0;
            foreach(int i in grade)
            {
                total += i;
            }
           
            Console.WriteLine($"средняя успевамость {name}: {(double)total/grade.Count}");
        }

        //добавление предметов
        public void SubscribeCourse(string course)
        {
            subjects.Add(course);
        }
        //переопределение родительского метода - добавляется вывод группы 
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"группа: {yearStart}-{group}");
        }
    }
}
