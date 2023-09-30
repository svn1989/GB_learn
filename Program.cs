//ЗАДАНИЕ №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("ЗАДАНИЕ №2");
// Ввод двух чисел
Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());

// Сравнение чисел
  if (a > b)
{
    Console.WriteLine($"Больше число {a}");
}
else if (a < b)
{
    Console.WriteLine($"Больше число {b}");
}
else
{
    Console.WriteLine("Числа равны.");
}

//_________________________________________________________________________________________________
//ЗАДАНИЕ №4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("ЗАДАНИЕ №4");
// Ввод трех чисел
Console.WriteLine("Введите число c:");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число d:");
int d = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число f:");
int f = int.Parse(Console.ReadLine());

// Нахождение максимального числа
int maxNumber = c;

if (d > maxNumber)
{
    maxNumber = d;
}

if (f > maxNumber)
{
    maxNumber = f;
}

// Вывод максимального числа
Console.WriteLine($"Максимальное число: {maxNumber}");


//_________________________________________________________________________________________________
//ЗАДАНИЕ №6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("ЗАДАНИЕ №6");
// Ввод числа
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

// Проверка, является ли число четным
if (number % 2 == 0)
{
    Console.WriteLine("Число четное.");
}
else
{
    Console.WriteLine("Число нечетное.");
}


// _________________________________________________________________________________________________
// ЗАДАНИЕ №8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("ЗАДАНИЕ №8");
// Ввод числа
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

// Вывод всех четных чисел от 1 до N
Console.WriteLine($"Четные числа от 1 до {N}:");
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
