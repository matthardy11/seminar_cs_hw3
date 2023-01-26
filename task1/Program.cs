// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];

if (number < 10000 || number > 99999)
{
  System.Console.WriteLine("Число не пятизначное");
  
}
else
{
  int counter = 4;
  while(number > 0)
  {
    array[counter] = number%10;
    number = number/10;
    counter--;
  }
  
  if (array[0] == array[4] && array[1] == array[3])
  {
    System.Console.WriteLine("Число является палиндромом");
  } 
  else
  {
    System.Console.WriteLine("Число не является палиндромом");
  }
}
