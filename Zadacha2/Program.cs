// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    System.Console.WriteLine("Максимальное число: " + numberA);
    System.Console.WriteLine("Минимальное число: " + numberB);
}
else
{
    System.Console.WriteLine("Максимальное число: " + numberB);
    System.Console.WriteLine("Минимальное число: " + numberA);
}