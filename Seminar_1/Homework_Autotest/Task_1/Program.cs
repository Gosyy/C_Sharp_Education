// Внутри класса Answer напишите метод CompareNumbers, 
// который на вход принимает два числа и выводит, какое число больше, а какое меньше.
// Пример использования:
// На входе:
// firstNumber: '5'
// secondNumber: '6'
// На выходе:
// второе число больше

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if (firstNumber == secondNumber)
        {
            Console.Write("числа равны");
        }
        else if (firstNumber > secondNumber)
        {
            Console.Write("первое число больше");
        }
        else
        {
            Console.Write("второе число больше");
        }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 6;
            secondNumber = 6;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}