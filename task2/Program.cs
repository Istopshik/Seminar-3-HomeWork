// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
System.Console.WriteLine("Введите координату x1: ");
double X1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату y1: ");
double Y1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату z1: ");
double Z1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату x2: ");
double X2 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату y2: ");
double Y2 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату z2: ");
double Z2 = double.Parse(Console.ReadLine());

double numSQRT = Math.Pow((X1 - X2),2)+Math.Pow((Y1 - Y2),2)+Math.Pow((Z1 -Z2),2);

double result = Math.Sqrt(numSQRT);

System.Console.WriteLine(result.ToString("c2"));


