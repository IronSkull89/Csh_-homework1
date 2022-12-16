// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

bool result1;
Console.Write("Введите первое число: ");
result1 = int.TryParse(Console.ReadLine(), out int a1);
if (!result1) Console.WriteLine("Введённое вами значение не является числом.");

Console.Write("Введите второе число: ");
result1 = int.TryParse(Console.ReadLine(), out int b1);
if (!result1) Console.WriteLine("Введённое вами значение не является числом.");

int max1 = a1;

if (max1 < b1) max1 = b1;

Console.WriteLine("Максимальное число: " + max1);

//----------------------------------------------------------------------------------------------------------------------

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

bool result2;
Console.Write("Введите первое число: ");
result2 = int.TryParse(Console.ReadLine(), out int a2);
if (!result2) Console.WriteLine("Введённое вами значение не является числом.");

Console.Write("Введите второе число: ");
result2 = int.TryParse(Console.ReadLine(), out int b2);
if (!result2) Console.WriteLine("Введённое вами значение не является числом.");

Console.Write("Введите второе число: ");
result2 = int.TryParse(Console.ReadLine(), out int c2);
if (!result2) Console.WriteLine("Введённое вами значение не является числом.");

int max2 = a2;

if (max2 < b2) max2 = b2;
if (max2 < c2) max2 = c2;

Console.WriteLine("Максимальное число: " + max2);

//----------------------------------------------------------------------------------------------------------------------

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

bool result3;
Console.Write("Введите число: ");
result3 = int.TryParse(Console.ReadLine(), out int a3);
if (!result3) Console.WriteLine("Введённое вами значение не является числом.");

if (a3 % 2 == 0) Console.WriteLine($"Число {a3} является чётным.");
else Console.WriteLine($"Число {a3} является нечётным.");

//----------------------------------------------------------------------------------------------------------------------

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

bool result4;
Console.Write("Введите верхнюю границу диапазона: ");
result4 = int.TryParse(Console.ReadLine(), out int N);
if (!result4) Console.WriteLine("Введённое вами значение не является числом.");

int n = 2;

Console.Write($"Чётные числа от 1 до {N}:");
while (n <= N)
{
  Console.Write(" " + n);  
  n += 2;
};