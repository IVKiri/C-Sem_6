// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintFib(int n)
{
    Console.Write("0 1 ");
    int f1 = 0;
    int f2 = 1;
    int result = 0;
    for (int i = 0; i < n - 2; i++)    
    {
        result = f1 + f2;
        Console.Write(result + " ");
        f1 = f2;
        f2 = result;
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintFib(N);