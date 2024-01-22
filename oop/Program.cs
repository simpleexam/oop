namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаются объекты - люди
            Human human1 = new Human("Иван", "Ургант", new DateTime(1999, 05,02), Gender.male, "РФ");
            Human human2 = new Human("Ольга", "Иванова", new DateTime(2005, 12, 25), Gender.female, "РФ");

            //создается объект - студент
            Student stud1 = new Student("Ольга", "Иванова", new DateTime(2005, 12, 25), 
                Gender.female, "РФ", "pk1", 2022);

            //студент записался на курсы
            stud1.SubscribeCourse("программирование");
            stud1.SubscribeCourse("МДК 04.02");
            //студент просматривает курсы
            stud1.CheckCourse();
            //студент проходит тесты
            stud1.CompleteTest();
            stud1.CompleteTest();
            stud1.CompleteTest();
            //отображение средней оценки студента
            stud1.PrintGrade();


        }
    }


}