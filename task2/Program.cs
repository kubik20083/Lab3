//Программа, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
System.Console.WriteLine("Введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"A ({x1},{y1},{z1})");
System.Console.WriteLine("Введите x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"B ({x2},{y2},{z2})");


double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Длинна отрезка AB {length}");

