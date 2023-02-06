int[,] GetArray()
{
   Console.Write("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число, до модуля которого будут генерироваться числа в массиве: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] nums = new int[m, n];
    for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = new Random().Next(-N, N);
                Console.Write($"{nums[i, j]} ");
            }
            Console.WriteLine();
        }
    return nums;
}

void SortingStrokInArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int FirstIndexInRest = 0;
        while (FirstIndexInRest < arr.GetLength(1))
        {   
            int max = arr[i, FirstIndexInRest];
            int max_ind = FirstIndexInRest;
            for (int j = FirstIndexInRest; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    max_ind = j;
                }
            }
            (arr[i, FirstIndexInRest], arr[i, max_ind]) = (arr[i, max_ind], arr[i, FirstIndexInRest]);
            FirstIndexInRest += 1;
        }
    }
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

SortingStrokInArray(GetArray());