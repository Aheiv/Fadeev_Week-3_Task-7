using System;

namespace ЛАБ7_1_УП
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вашу строку: ");
            string s = Console.ReadLine();
            Console.Write("Введите вашу подстроку: ");
            string substr = Console.ReadLine();
            string ss = s.Replace(substr, "");
            Console.WriteLine("Новая строка: " + ss);
        }
    }
}
