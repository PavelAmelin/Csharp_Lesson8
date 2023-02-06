int[,] GetArray()
{
    Console.Write("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] nums = new int[m, n];
    for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = 0;
            }
        }
    return nums;
}

void SpiralArray(int[,] arr)
{
    int x = 0;
    int y = -1;
    int dx = 0;
    int dy = 1;
    int k = 1;
    while (k < arr.GetLength(0) * arr.GetLength(1) + 1)
    {
        if (0 <= x + dx && x + dx < arr.GetLength(0) && 0 <= y + dy && y + dy < arr.GetLength(1) && arr[x + dx, y + dy] == 0)
        {
            x += dx;
            y += dy;
            arr[x, y] = k;
            k += 1;
        }
        else if (dy == 1)
        {
            dy = 0;
            dx = 1; 
        }
        else if (dx == 1)
        {
            dy = -1;
            dx = 0; 
        }
        else if (dy == -1)
        {
            dy = 0;
            dx = -1; 
        }
        else if (dy == 0)
        {
            dy = 1;
            dx = 0; 
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < 10)
                Console.Write($"0{arr[i, j]} ");
                else
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
}
SpiralArray(GetArray());