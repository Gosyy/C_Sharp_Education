// На вход поступают два целых числа. 
// Необходимо проверить, является-ли одно квадратом другого.

Console.Write ("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine()); 

// ReadLine принимает значение в формате char
// Convert позволяет конвертировать char в любой тип

Console.Write ("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());

if (b * b == a) 
{
    // System.Console.Write ("a = " + a + ", " + "b = " + b + " => Да \n");
    // Знак + (кокретинации) для связи текста и переменных при выводе

    System.Console.Write ($"a = {a}, b = {b} => Да");
    // $" ... {x} ... " - записать переменные и текст
}

else
{
    // System.Console.Write ("a = " + a + ", " + "b = " + b + " => Нет \n");
    System.Console.Write ($"a = {a}, b = {b} => Нет");
}
