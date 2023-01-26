// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("Введите координату X первой точки: ");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y первой точки: ");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z первой точки: ");
double z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату X второй точки: ");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y второй точки: ");
double y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z второй точки: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));

System.Console.WriteLine(result);
