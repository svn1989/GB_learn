class Program
{
    static void Main(string[] args)
    {
        // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
        Console.WriteLine("ЗАДАНИЕ №64");
        Console.Write("Введите значение N1: ");
        
        int N1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Результат: " + GetNatNum(N1));
        Console.ReadLine();


        // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        Console.WriteLine("ЗАДАНИЕ №66");
        Console.Write("Введите значение M2: ");
        int M2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N2: ");
        int N2 = Convert.ToInt32(Console.ReadLine());
        int sum = GetNatSum(M2, N2); 

        Console.WriteLine("Сумма натуральных чисел от до {1}: {2}", M2, N2, sum);
        Console.ReadLine();


        // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.    
        Console.WriteLine("ЗАДАНИЕ №68");

        Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AkerFunc(m, n);

        Console.WriteLine("Результат: " + result);
        Console.ReadLine();
    }
    

    // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    static string GetNatNum(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        else
        {
            return n + ", " + GetNatNum(n - 1); 
        }
    }


    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    static int GetNatSum(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            sum += i;
        }

        return sum;
    }


    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
        static int AkerFunc(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AkerFunc(m - 1, 1);
        }
        else
        {
            return AkerFunc(m - 1, AkerFunc(m, n - 1));
        }
    }
       
}
