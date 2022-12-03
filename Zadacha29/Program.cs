//Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

Console.WriteLine("Введите массив из 8 чисел");
string input = Console.ReadLine() ??"";
string[] temp = input.Split(' ');

int[] resultArray = new int[temp.Length];
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = int.Parse(temp[i]);
}
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write($"{resultArray[i]}, ");
}
