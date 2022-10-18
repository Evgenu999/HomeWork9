// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.


string GetSumSequence(int m, int n)
{
    if (n == m) 
    {
        return Convert.ToString(m); 
    }
    else
    {
        return GetSumSequence(m, (n - 1)) + " " + n;
    }
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = GetSumSequence(m, n);
Console.WriteLine(result);