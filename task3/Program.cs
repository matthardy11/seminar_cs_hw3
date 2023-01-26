// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

if (N == 0)
{
  System.Console.WriteLine("Вы ввели число 0.");
}
else if (N > 0)
{
  for(int i = 1; i <= N; i++)
  {
    System.Console.WriteLine(i + " в кубе: " + i * i * i);
  }
}
else if (N < 0)
{
  for(int i = -1; i >= N; i--)
  {
    System.Console.WriteLine(i + " в кубе: " + i * i * i);
  }
}
