using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш текст, отделяя слова пробелами : ");
            string inputPhrase = Console.ReadLine();

            Console.WriteLine("\nПосмотрите - программа переставила слова в Вашем тексте в обратном порядке :\n");

            Console.WriteLine(ReversWords(inputPhrase));

            Console.WriteLine("\nНе благодарите, а лучше нажмите любую клавишу для завершения ...");
            Console.ReadKey();

        }

        /// <summary>
        /// Функция переставляет слова в тексте в обратном порядке.
        /// Все знаки препинания будут удалены. Слова будут разделены пробелами.
        /// </summary>
        /// <param name="inputPhrase">Исходный текст в string</param>
        /// <returns>Текст с переставленными в обратном порядке словами</returns>
        static string ReversWords(string inputPhrase)
        {
            string[] words = SplitText(inputPhrase);
            string[] reversWords = ReverseArray(words);
            StringBuilder result = new StringBuilder();
            foreach(string word in reversWords)
            {
                if (word != "")
                {
                    result.Append(word + " ");
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Функция переставляет элементы массива строк в обратном порядке
        /// </summary>
        /// <param name="arr">Входной массив строк</param>
        /// <returns>Развёрнутый в обратном порялке массив строк</returns>
        static string[] ReverseArray(string[] arr)
        {
            string[] result = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - i - 1];
            }

            return result;
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
    }
}
