// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void BinaryNum(int number)
{
    if (number == 0)
    {
        return;
    }
    BinaryNum(number/2);
    Console.Write(number%2);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
BinaryNum(number);


