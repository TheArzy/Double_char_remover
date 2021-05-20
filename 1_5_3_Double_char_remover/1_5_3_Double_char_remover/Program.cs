using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1_5_3_Double_char_remover
{
    class Program
    {
        /// <summary>
        /// Ввод текста
        /// </summary>
        /// <returns></returns>
        static string Input()
        {
            return ReadLine();
        }
        /// <summary>
        /// Ввод числа и проверка соответствия условиям
        /// </summary>
        /// <param name="paramMax">Максимальное значение для вводимого числа</param>
        /// <param name="paramMin">Минимальное значение для вводимого числа</param>
        /// <returns>Проверенное введенное число</returns>
        static int Input(int paramMax, int paramMin)
        {
            int input;
            while (true)
            {
                if (int.TryParse(ReadLine(), out input) && input <= paramMax && input >= paramMin) break;
                else Write($"Число должно быть целым от {paramMin} до {paramMax}, попробуйте еще раз: ");
            }
            return input;
        }

        /// <summary>
        /// Удаляет все идущие подряд повторяющиеся символы в тексте
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Обработанный текст</returns>
        static string LessLetters(string text)
        {
            for (int ind = 1; ind < text.Length; ind++)
            {
                string txt = text.ToLower();
                if (txt[ind] == txt[ind - 1])
                {
                    txt = txt.Remove(ind, 1);
                    text = text.Remove(ind, 1);
                    ind--;
                }
            }

            return text;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Write("Введите текст: ");
                string theText = Input();

                WriteLine("\n--------------------------------\n");
                WriteLine(LessLetters(theText));
                WriteLine("\n--------------------------------\n");
                ReadKey(true);

                #region Повтор или выход

                WriteLine("Запустить заново? 1 - Повтор | 0 - Выход");
                Write("Выбор: ");
                if (Input(1, 0) == 0) break; // Завершение программы
                WriteLine();

                #endregion
            }
        }
    }
}
