//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число, а я скажиу не палиндром ли оно");
Console.Write("Введите число: ");
string number = Console.ReadLine();

void YourNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - не является палиндромом.");
}

if (number!.Length == 5){
  YourNumber(number);
}
else Console.WriteLine($"Введите число из пяти цифр");
