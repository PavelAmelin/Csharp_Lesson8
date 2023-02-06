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

void MinSum(int[,] arr)
{
    int min = 1000000000;
    int MinSumStr = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            sum += arr[i, j];
        if (sum < min)
        {
            min = sum;
            MinSumStr = i;
        }
    }
    Console.WriteLine($"{MinSumStr + 1} строка с минимальной суммой");
}

MinSum(GetArray());