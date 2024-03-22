// Задача 4: Напишите программу, 
// которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую В ОБРАТНОМ ПОРЯДКЕ.

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) { number *= -1; }
System.Console.Write($"Цифры числа {number} в обратном порядке: ");

for (int i = 10; number != 0;)
{
    System.Console.Write($"{number % i}, ");
    number /= 10;
}
