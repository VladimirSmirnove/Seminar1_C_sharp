// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
int max = a;
if (max > b)
{
   Console.WriteLine($"Первое число наибольшее = {a}, второе число наименьшее = {b}");
}
else
{
   Console.WriteLine($"Первое число наибольшее = {b}, второе число наименьшее = {a}");
}
