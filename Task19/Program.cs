// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());

if(N<10000 || N>=100000)
{Console.WriteLine("Введено не пятизначное число"); return;}

int num5 = N % 10;
int num4 = (N - num5) % 100;
int num3 = (N - num5 - num4) % 1000;
int num2 = (N - num5 - num4 - num3) % 10000;
int num1 = (N - num5 - num4 - num3 - num4) % 100000;
if(num1/10000 == num5 && num2/1000 == num4/10)
{
    Console.WriteLine($"Число {N} является палиндром");
}
else 
{
    Console.WriteLine($"Число {N} не является палиндром");
}