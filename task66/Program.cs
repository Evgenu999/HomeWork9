// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.


string PrintSequence(int m, int n)
{
    if (n == m)
    {
        return Convert.ToString(m);
    }
    else
    {
        return PrintSequence(m, (n - 1)) + " " + n;
    }
}


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

string result = PrintSequence(m, n); // вывод на экран всех чисел промежутка от м до n 
Console.WriteLine($"Все числа в промежутке от {m} до {n} : ");
Console.WriteLine($"{result}");

int sum = GetSumSequence(m, n);
Console.WriteLine($"Сумма всех чисел в промежутке от {m} до {n} = {sum}");
