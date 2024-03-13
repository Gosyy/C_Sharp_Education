// На вход поступает трёхзначное число.
// Вывести сумму первой и последней цифр числа.

System.Console.Write("Введите целое трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (bool i = false; i != true;)
{
    if (n / 100 > 0 && n / 100 < 10) // Проверка на трёхзначность
    {
        i = true;
    }

    else 
    {
        System.Console.Write("Введите число, согласно условию - целое трёхзначное: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
}

System.Console.Write($"{n} => {n / 100} + {n % 10} = {n / 100 + n % 10} \n");