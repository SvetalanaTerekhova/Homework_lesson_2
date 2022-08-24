// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите целое число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

while (number < 1 || number >7)
{
    Console.WriteLine("Вы ввели число не от 1 до 7. Введите целое число от 1 до 7: ");
    number = int.Parse(Console.ReadLine());
}
if (number == 6 || number == 7)
{
    Console.Write("Ответ: " + number + " -> выходной день");
}
else
{
    Console.Write("Ответ: " + number + " -> рабочий день");
}