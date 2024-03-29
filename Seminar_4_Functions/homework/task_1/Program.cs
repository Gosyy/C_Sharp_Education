// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
    static void Main() // принимает последовательность символов
    {
        Console.WriteLine("Enter integers. Enter 'q' to quit or stop when sum of digits is even.");

        while (true)
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();

            // Проверка. Если q – выход, если другая буква – просьба ввести новое значение.
            if (input.ToLower() == "q") // Возвращает копию этой строки, преобразованную в нижний регистр (для сравления чисел).
            {
                Console.WriteLine("Exiting program...");
                break;  // Выход из вышестоящего условия.
            }

            // Проверка, что введено челое число.
            if (int.TryParse(input, out int number) == false)   // Преобразует строковое представление числа в его эквивалент 32-битного целого числа со знаком. 
                                                                // Возвращаемое значение указывает, удалось ли преобразование.
            {                                         
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;   // Повторить вышестоящее условие.
            }

            // Проверка суммы цифр числа на чётность.
            if (SumOfDigitsEven(number) == true)
            {
                Console.WriteLine($"Sum of digits of {number} is even. Exiting program...");
                break;
            }
        }
    }

    static bool SumOfDigitsEven(int number) // Функция проверки суммы цифр числа на чётность.
    {
        int sum = 0;
        number = Math.Abs(number); // Модуль числа number

        // Сумма цифр числа
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        // Проверка на чётность. Чётное – true.
        return sum % 2 == 0;
    }
}