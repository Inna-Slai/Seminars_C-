//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine();
Console.WriteLine("Введите число, а я выведу все четные числа от 1 до введенного числа.");
Console.Write("Введите число: ");
int NumberN = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= NumberN)
{
  if (count % 2 != 1) 
    Console.WriteLine(count);
    
  count += 1;
}
