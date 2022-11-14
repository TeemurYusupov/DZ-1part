Console.Clear();

// заполнение
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];


for(int i = 0; i < n; i ++)
{
Console.WriteLine("Введите значение массива:  ");
array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("[" + string.Join("," , array) + "] ->");


for(int j = 0; j < n; j++)
{
  if (array[j].Length < 4)
  {
       Console.Write("[" +  string.Join("," ,array[j]) + "]");
  }
}