// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("ЗАДАНИЕ №10");
Console.Write("Введите трехзначное число: ");

int number1 = int.Parse(Console.ReadLine());

int secondDigit = (number1 / 10) % 10;

Console.WriteLine("Вторая цифра: " + secondDigit);
Console.WriteLine(" ");

//_________________________________________________________________________________________________
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("ЗАДАНИЕ №13");
Console.Write("Введите число: ");
string input = Console.ReadLine();
        
int thirdDigit = GetThirdDigit(input);
     
if (thirdDigit == -1)
    {
        Console.WriteLine("Третьей цифры нет");
    }
else
    {
        Console.WriteLine($"Третья цифра: {thirdDigit}");
    }
     
int GetThirdDigit(string number)
{
    int thirdDigit = -1;
        
    if (number.Length >= 3)
    {
        if (int.TryParse(number.Substring(2, 1), out int digit))
        {
            thirdDigit = digit;
        }
    }
        
    return thirdDigit;
}
Console.WriteLine(" ");

//_________________________________________________________________________________________________
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("ЗАДАНИЕ №15");
Console.Write("Введите день недели (число от 1 до 7): ");
int day = int.Parse(Console.ReadLine());

bool Weekend = CheckWeekend(day);

if (Weekend == true)
    {
        Console.WriteLine("День является выходным");
    }
else
    {
        Console.WriteLine("День не является выходным");
    }
    
bool CheckWeekend(int day)
{
    if (day == 6 || day == 7)
        {
            return true;
        }
    else
        {
            return false;
        }
}
