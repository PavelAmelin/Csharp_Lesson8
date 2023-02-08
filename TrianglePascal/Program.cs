using System.Linq;
int [,] GetArray()
{
    Console.Write("Введите размер массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] nums = new int[m, m];
    for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                nums[i, j] = 1;
            }      
        }
    return nums;
}
void PascalTriangle(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i++)
        {
            for (int j = 1; j < i; j++)
            {
                arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
            }
        }
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        string result = string.Concat(Enumerable.Repeat(" " , arr.GetLength(0) - i));    
        Console.Write(result);
        for (int j = 0; j < i + 1; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
PascalTriangle(GetArray());

//Python для сравнения

// 1 способ

// n = int(input())
// row = [1]
// print(' ' * (n - 1), *row)
// for i in range(n - 1):
//     row = [sum(j) for j in zip(row + [0], [0] + row)]
//     print(' ' * (n - 2 - i), *row)

// 2 способ

// n = int(input())
// a = [[1 for j in range(i + 1)] for i in range(n)]
// for i in range(1, len(a)):
//     for j in range(1, i):
//         a[i][j] = a[i - 1][j] + a[i - 1][j - 1]
// for i, row in enumerate(a):
//     print(' ' * (n - i), *row)

// 3 способ

// from math import factorial
// n = int(input())
// for i in range(n):
//     for j in range(i + 1):
//         print(int(factorial(i) / (factorial(j) * factorial(i-j))), end = ' ')
//     print()