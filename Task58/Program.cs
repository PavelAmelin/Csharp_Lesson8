int[,] GetArray1()
{
   Console.Write("Введите количество строк массива1: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива1: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число, до модуля которого будут генерироваться числа в массиве1: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] nums1 = new int[m, n];
    for (int i = 0; i < nums1.GetLength(0); i++)
        {
            for (int j = 0; j < nums1.GetLength(1); j++)
            {
                nums1[i, j] = new Random().Next(-N, N);
                Console.Write($"{nums1[i, j]} ");
            }
            Console.WriteLine();
        }
    return nums1;
}

int[,] GetArray2()
{
   Console.Write("Введите количество строк массива2: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива2: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число, до модуля которого будут генерироваться числа в массиве2: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] nums2 = new int[n, k];
    for (int i = 0; i < nums2.GetLength(0); i++)
        {
            for (int j = 0; j < nums2.GetLength(1); j++)
            {
                nums2[i, j] = new Random().Next(-N, N);
                Console.Write($"{nums2[i, j]} ");
            }
            Console.WriteLine();
        }
    return nums2;
}

void MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
                res[i, j] += arr1[i, k] * arr2[k, j]; 
        }   
    }
    Console.WriteLine();
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
            Console.Write($"{res[i, j]} ");
        Console.WriteLine();        
    }
}

MultiplyArrays(GetArray1(), GetArray2());