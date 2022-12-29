//Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int n = new Random().Next(1, 100);
System.Console.WriteLine("Таблица кубов от 1 до " + n);
for(int i = 1; i <= n; i++)
System.Console.WriteLine($"{i} в кубе = " + (int)Math.Pow(i, 3));