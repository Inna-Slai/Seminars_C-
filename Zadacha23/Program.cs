//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.WriteLine("Введите число, а я выдам таблицу кубов чисел от 1 до введенного числа");
Console.Write("Введите число: ");
int cub = Convert.ToInt32(Console.ReadLine());
void Cub(int[] cub)
{
  int count = 1;
  int length = cub.Length;
  while (count <  length)
  {
    cub[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}
void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 
int[] arry = new int[cub+1];
Cub(arry);
PrintArry(arry);
