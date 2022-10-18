// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.


int GetSumSequence(int m, int n)
{
    if (m == n)
    {
        return m;
    }

    int sum = m + GetSumSequence(m + 1, n);
    return sum;
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());


int sum = GetSumSequence(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} = {sum}");
