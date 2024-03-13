// Внутри класса Answer напишите метод PrintEvenNumbers, 
// которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно),
// после каждого числа должен быть знак пробела.
// На входе:
// number = 5 
// На выходе:
// 2 4 

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}