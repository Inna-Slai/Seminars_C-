﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Введите число и я выведу Вам третью цифру этого числа");
Console.Write("Введите число: ");

int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "Нет третьей цифры в числе" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());

