using System.Linq;
int [,] GetArray()
{
    Console.Write("Введите размер массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] nums = new int[m, m];
    for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0)
                    nums[i, j] = 1;
                else
                    nums[i, j] = 0;
            }
        }
    return nums;
}
void PascalTriangle(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            string result = string.Concat(Enumerable.Repeat(" " , arr.GetLength(0) - i));    
            Console.Write(result);
            for (int j = 0; j < i + 1; j++)
            {
                if (i == 0 && j == 0)
                arr[i, j] = 1;
                else if (i > 0 && j > 0)
                arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
}

PascalTriangle(GetArray());
