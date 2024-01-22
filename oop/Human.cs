using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    enum Gender { male, female} //перечисление пола человека

    internal class Human
    {
        public string name;                     //имя человека
        public string surname;                  //фамилия
        public DateTime dateOfBirth;            //дата рождения
        public Gender gender;                   //пол
        public string nationality;              //гражданство
        private int _age;
        /// <summary>
        /// возвращает возраст человека на данный момент времени
        /// </summary>
        /// <returns>возраст</returns>
        public int GetAge()
        {
            return DateTime.Now.Year - dateOfBirth.Year;
        }
        /// <summary>
        /// виртуальный метод - можно переопределить функциональность в дочоернем классе
        /// </summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine($"человек: {surname} {name}\n" +
                $"дата рождения: {dateOfBirth.Year}.{dateOfBirth.Month}.{dateOfBirth.Day}, возраст {_age}\n" +
                $"пол: {gender}\n" +
                $"гражданство: {nationality}");
        }
        //конструктор класса. учитывая что прописан польховательский конструктор - 
        //конструктор без параметров автоматически недоступен
        public Human(string name, string surname, DateTime db,
            Gender gender, string nation)
        {
            this.name = name;
            this.surname = surname;
            dateOfBirth = db;
            this.gender = gender;
            nationality = nation;  
            _age = GetAge();
        }

    }
}
