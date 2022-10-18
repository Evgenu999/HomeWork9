// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.


string GetSequenceDigits(int num)
{
    if (num == 1)
    {
        return "1";
    }
    else
    {
        // string result = num + " " + GetSequenceDigits(num - 1);  можно так
        // return result; 
        return num + " " + GetSequenceDigits(num - 1); // так лучше
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string sequence = GetSequenceDigits(number);
Console.WriteLine($"Все натуральные числа от {number} до 1: ");
Console.WriteLine(sequence);