//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.WriteLine();
Console.WriteLine("Введите три числа и я найду наибольшее из них.");

Console.Write("Введи первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;   // дополнительная переменная

if (max < secondNumber) {
  max = secondNumber;
}
if (max < thirdNumber) {
  max = thirdNumber;
}
Console.WriteLine("Максимальное число из трех равно " + max);