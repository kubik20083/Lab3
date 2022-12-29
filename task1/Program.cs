// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int x = number.Length;

if (x == 5)
{
if (number[0] == number[4] && number[1] == number[3])
{
Console.WriteLine($"{number} - число палиндром");
}
else
{
Console.WriteLine($"{number} - число не палиндром");
}
}
else
{
Console.WriteLine($"{number} - не является пятизначным числом");
}
