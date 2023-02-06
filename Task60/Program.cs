void GetArray()
{
    Console.Write("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите высоту массива: ");
    int p = Convert.ToInt32(Console.ReadLine());
    int[,,] nums = new int[m, n, p];
    int []RandomChars = new int[m * n * p];
    for (int i = 0; i < m * n * p;)
    {
        bool flag = false;
        int NewRandom = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            if (RandomChars[j] == NewRandom)
            flag = true;
        }
        if (flag == false)
        {
            RandomChars[i] = NewRandom;
            i++;
        }
    }
    // for (int i = 0; i < m * n * p; i++)
    //     Console.WriteLine($"{RandomChars[i]}");
    int x = 0;
    while (x < m * n * p)
    {
        for (int i = 0; i < m; i++)
            {
            for (int j = 0; j < n; j++)
                {            
                for (int k = 0; k < p; k++)
                    {
                    nums[i, j, k] = RandomChars[x];
                    x++;
                    }
                }
            }  
    }
    for (int i = 0; i < nums.GetLength(0); i++)
        {
        for (int j = 0; j < nums.GetLength(1); j++)
            {            
            for (int k = 0; k < nums.GetLength(2); k++)
                {
                Console.Write($"{nums[j, k, i]}({j},{k},{i}) ");
                }
            Console.WriteLine(); 
            }
        }
}
GetArray();

