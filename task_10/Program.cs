// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());

while (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели не трёхзначное число. Введите трёхзначное число: ");
    number = int.Parse(Console.ReadLine());
}
int number1 = (number / 100) * 100;
int number3 = number % 10;
int number2 = (number - number1 - number3) / 10;

Console.WriteLine("Ответ: " + number2 + " - вторая цифра числа " + number);