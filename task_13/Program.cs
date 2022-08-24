// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 1 Вариант решения

Console.Write("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());
int count = 0;
int quantity = number;
while (quantity > 0)
{
    count++;
    quantity = quantity / 10;
}
if (count >= 3)
{
    while (count - 3 > 0)
    {
        count--;
        number = number / 10;
    }
    int number3 = number % 10;
    Console.Write("Ответ: ");
    Console.WriteLine("третья цифра введенного числа -> " + number3);
}
else if (count <= 2)
{
    Console.Write("Ответ:");
    Console.WriteLine("третьей цифры в введенном числе нет");
}

// 2 Вариант решения

/* Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());
string number3 = Convert.ToString(number);
if (number3.Length > 2)
{
    Console.WriteLine("третья цифра введенного числа -> " + number3[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
} */

//