// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void raised(int A, int B)
// {
//     int res = A;
//     for (int i = 1; i < B; i++)
//     {
//         res = res * A;
//     }
//     Console.WriteLine(res);
// }

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// raised(a, b);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int sum(int n)
// {
//     int count = 0;
//     int result = 0;
//     while (n > 0)
//     {
//         result = result + (n % 10);
//         n /= 10;
//         count++;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sum(n));

// Задача 29: Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]

void checkArr(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    Console.WriteLine($"[{string.Join(", ", arr)}]"); ;
}

Console.Write("Введите количество элементов массива: ");
int x = Convert.ToInt32(Console.ReadLine());
checkArr(x);