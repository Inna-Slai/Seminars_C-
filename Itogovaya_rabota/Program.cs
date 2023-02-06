string[] arrayfirst = new string[5] {"589", "inna", "8976", "41", "run"};
string[] arraysecond = new string[arrayfirst.Length];
void SecondArrayWithIF(string[] arrayfirst, string[] arraysecond)
{
    int count = 0;
    for (int i = 0; i < arrayfirst.Length; i++)
    {
    if(arrayfirst[i].Length <= 3)
        {
        arraysecond[count] = arrayfirst[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arrayfirst, arraysecond);
PrintArray(arraysecond);