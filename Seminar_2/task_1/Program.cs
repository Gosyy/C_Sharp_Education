// Задача 1: Напишите программу, 
// которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int multiplicity[] = { 7, 23 }; // multiplicity - анг. кратность

if (number % multiplicity[0] == 0 && number / multiplicity[1] == 0)
{
    System.Console.WriteLine($"number = {number} => кратно {multiplicity[0]} и {multiplicity[1]}");
}
else System.Console.WriteLine($"number = {number} =>  не кратно {multiplicity[0]} и {multiplicity[1]}");
