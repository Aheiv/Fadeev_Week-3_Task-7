using System;

namespace ЛАБ7_2_УП
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше сообщение: ");
            string str = Console.ReadLine();
            int counter = 0;
            bool b = false;
            foreach (string item in str.Split(new Char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
            {
                b = false;
                foreach (char ch in item)
                    if (char.IsUpper(ch))
                        b = true;
                    else
                    {
                        b = false;
                        break;
                    }
                if (b) counter++;
            }

            Console.WriteLine("Кол-во слов только из прописных букв = {0}", counter);
        }
    }
}
