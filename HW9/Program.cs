using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Смоделируйте работу простого калькулятора. 
            //Программа должна запрашивать 2 числа, а затем – код операции(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
            //После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
            //1.запрос 2 чисел и кода операции
            //2.обработка исключений
            //3. if для кода операции
            Console.WriteLine("Введите числа а и b, с которыми необходимо произвести операцию");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите код операции( 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное)");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
                Console.WriteLine("Сумма чисел равна {0}", (a + b));
                
            else if (c == 2)
                Console.WriteLine("Разница чисел равна {0}", (a - b));
            else if (c == 3)
                Console.WriteLine("Произведение чисел равно {0}", (a * b));
            else if (c == 4)
            {
                try
                {
                    Console.WriteLine("Частное равно {0}", (a / b));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на 0");
                }
                
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine("Выбран неверный код операции");
            Console.ReadKey();
        }
    }
}
