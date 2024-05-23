using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exceptions
{
    internal class Program
    {
        // Обработка исключений. Наш код - свод правил, но всегда будут исключения из них
        static void Main(string[] args)
        {
            /*try { }
             catch (Exception e) // Exception - спец.класс в C#
             {
                 throw e; // Показываем наше исключение, throw генерирует исключение явно
             }
             finally // Должно выполниться в любом случае, поймали ли мы исключение или нет
             { 

             }*/

            // Задача 1 - Деньги

            /*Money money1 = new Money(10, 50);
            Money money2 = new Money(5, 25);
            Console.WriteLine("Денежка 1 = " + money1.ToString());
            Console.WriteLine("Денежка 2 = " + money2.ToString());
            try
            {
                Money sum = money1 + money2;
                Console.WriteLine(sum.ToString());
                Money diff = money1 - money2;
                Console.WriteLine(diff.ToString());
                Money dev = money1 / 2;
                Console.WriteLine(dev.ToString());
                Money mul = money2 * 2;
                Console.WriteLine(mul.ToString());
                Money inc = ++money1;
                Console.WriteLine(inc.ToString());
                Money dec = --money2;
                Console.WriteLine(dec.ToString());
                Console.WriteLine("Money 1 > Money 2: " + (money1 > money2));
                Console.WriteLine("Money 1 == Money 2: " + (money1 == money2));
                Console.WriteLine("Money 1 < Money 2: " + (money1 < money2));
            }
            catch (Bankrot ex) // Конкретные искл. должны быть перед общим искл.
            { 
                Console.WriteLine("Bankrot ex: " + ex.Message);
            }
            catch (Exception ex) // Общие искл.
            {
                Console.WriteLine("Exception: " + ex.Message);
            }*/

            // Задача 2 - Перевод строки в число (выход за пределы диапазона int)

            /*Console.Write("Введите набор символов -> ");
            string str = Console.ReadLine();
            try 
            {
               int num = Convert.ToInt32(str);
               Console.WriteLine(num);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введённое число выходит за пределы диапазона Int");                
            }
            catch (FormatException)
            {
                Console.WriteLine("Введённое значение не является числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }*/

            // Задача 3 - Доступ по возрасту
            /*Console.Write("Введите возраст -> ");            
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                    throw new UnderageException("Возраст < 18");                
                Console.WriteLine("Доступ разрешён");
            }
            catch (UnderageException ex) 
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }  
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

            // Задача 4 - Поиск студента по списку
            StudentManagementSystem students = new StudentManagementSystem();
            students.AddStudent("Вася", 15);
            students.AddStudent("Петя", 18);
            students.AddStudent("Ваня", 21);
            try
            {
                Student result = students.GetStudentByName("Вас");
                Console.WriteLine(result.Name);
            }
            catch ( UnderageException ex )
            { Console.WriteLine(ex.Message); }
                
        }
    }
}
