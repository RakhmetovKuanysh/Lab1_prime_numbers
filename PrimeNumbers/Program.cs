using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        /// <summary>
        /// Функция для проверки на простое число
        /// </summary>
        /// <param name="s"> /// Конвертирует строку в числа </param>
        /// <returns></returns>
        static bool IsPrime(string s)
        {
            int x = int.Parse(s);
            /// Счётчик для того, чтобы потом определить простое эти число или нет
            int cnt = 0;
            for (int j = 2; j <= Math.Sqrt(x); ++j)
            {
                if (x % j == 0)
                {
                    cnt++;
                }
            }
            /// Если счетчик равен 0 и заданное число не равно 1 
            /// (так как 1 не простое число) то функция принимает TRUE
            return cnt == 0 && x != 1;

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i) {
                if (IsPrime(args[i]))
                {
                    /// К каждому числу добавляем "Is Prime" или "Is not Prime"
                    Console.WriteLine(args[i] + " Is Prime");
                }
                else
                {
                    Console.WriteLine(args[i] + " Is not Prime");
                }
            }
        }
    }
}
