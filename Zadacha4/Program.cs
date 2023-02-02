// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (numberA > max ) max = numberA;
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;

System.Console.WriteLine("max = ");
System.Console.WriteLine(max);