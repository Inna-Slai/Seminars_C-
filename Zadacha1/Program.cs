//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введи первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA > NumberB)
{
  Console.WriteLine("Максимальное из двух чисел = " + NumberA);
}
else
{
  Console.WriteLine("Максимальное из двух чисел = " + NumberB);
}
