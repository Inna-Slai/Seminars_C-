//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Введите число а я выдам сумму цифр введенного числа");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

  int Sum(int number)
  {
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

int sum = Sum(number);
Console.WriteLine("Сумма цифр в числе: " + sum);