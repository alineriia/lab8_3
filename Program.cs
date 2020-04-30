using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Оголосити тип делегату, що посилається на метод. Вимоги до сигнатури методу наступні:
 метод отримує вхідним параметром змінну типу double;
 метод повертає значення типу double, яке є результатом обчислення згідно з умовою задачі.
Реалізувати виклик трьох методів з допомогою одного делегату, які отримують радіус кола R в якості
вхідного параметру і обчислюють:
довжину кола за формулою D = 2πR;
 площу круга за формулою S = πR2;\
 об‘єм кулі. Формула V = 4/3πR3.
Методи повинні бути представлені в окремому класі як нестатичні.*/
namespace lab8_3
{
    class Program
    {
        delegate double Delegate(double p);
        static void Main(string[] args)
        {
            double r, result;
            Func functions = new Func();
            Delegate delegat;
            Console.Write("Enter R ");
            r = Double.Parse(Console.ReadLine());

            delegat = functions.Length;
            try
            {
                result = delegat(r);
                Console.WriteLine("Length = " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of input");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Out Of Memory to create new object");
            }

            delegat = functions.Square;
            try
            {
                result = delegat(r);
                Console.WriteLine("Square = " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of input");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Out Of Memory to create new object");
            }

            delegat = functions.Volume;
            try
            {
                result = delegat(r);
                Console.WriteLine("Volume = " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of input");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Out Of Memory to create new object");
            }
            Console.ReadKey();

        }
    }
}
