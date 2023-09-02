using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myTestText = "Пользователь вводит в консольном приложении длинное предложение. Каждое слово в этом предложении отделено пробелом. Создайте метод, который в качестве входного параметра принимает строковую переменную, а в качестве возвращаемого значения — массив слов.";

            PrintWords(SplitText(myTestText));

            Console.WriteLine("\nНажмите любую клавишу для завершения ...");
            Console.ReadKey();
        }

        /// <summary>
        /// Функция разделения текста (из строки) на массив слов.
        /// Для разделения слов используются символы: ' ', ',', '.', ':', ';', '-', '\'', '"', '—'.
        /// Слова в массиве содержатся в том же порядке, что и в исходном тексте.
        /// Повторы не удаляются.
        /// </summary>
        /// <param name="text">Строка текста, который надо разделить на слова</param>
        /// <returns>Массив строк с отлельным словом в каждом элементе</returns>
        static string[] SplitText(string text)
        {
            return text.Split(new char[] { ' ', ',', '.', ':', ';', '-', '\'', '"', '—' });
        }

        /// <summary>
        /// Функция вывода в консоль каждого слова(строки) из массива строк. Пустые строки выведены не будут.
        /// </summary>
        /// <param name="words">Массив строк</param>
        static void PrintWords(string[] words)
        {
            foreach(string word in words)
            {
                if (word != "")
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
