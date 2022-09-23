// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int counter = 0;

while (temp > 0)
{
    temp = temp / 10;
    counter = counter + 1;
}

if (counter < 3)
{
    Console.Write("третьей цифры нет");
}

else if (counter > 3)
{
    int counter2 = 1;
    while (counter - counter2 >= 3)
    {
        num = num / 10;
        counter2 = counter2 + 1;
    }
    num = num % 10;
    Console.WriteLine($"третья цифра числа = {num}");
}

else
{
    num = num % 10;
    Console.WriteLine($"третья цифра числа = {num}");
}

