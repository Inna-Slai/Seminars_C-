//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введи первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber>secondNumber) {
  Console.WriteLine("MAX= " + firstNumber);
}
else {
  Console.WriteLine("Максимальное из двух чисел = " + secondNumber);
}
