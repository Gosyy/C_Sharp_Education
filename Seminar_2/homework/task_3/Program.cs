//  Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//  и показывает наибольшую цифру числа.

System.Console.Write("Введите целое двузначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10 || number > 99) // Проверка двузначности
{
    if (number < 10)
    {
        System.Console.Write("Введеное число меньше 10! Введите двузначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    
    if (number > 99)
    {
        System.Console.Write("Введеное число больше 99! Введите двузначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
}

if (number / 10 > number % 10)
{
    System.Console.WriteLine($"Наибольшая цифра числа {number} => {number / 10}");
}

if (number / 10 < number % 10)
{
    System.Console.WriteLine($"Наибольшая цифра числа {number} => {number % 10}");
}

if (number / 10 == number % 10)
{
    System.Console.WriteLine($"Цифры числа {number} => равны");
}