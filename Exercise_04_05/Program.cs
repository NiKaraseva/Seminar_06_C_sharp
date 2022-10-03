/* Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */ 

// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());

// Способ 1
/* int num1 = 0;
int num2 = 1; 

Console.Write($"{num1} ");
Console.Write($"{num2} ");

for(int i = 3; i <=n; i++)
{
    int num3 = num1 + num2;
    Console.Write($"{num3} ");
    num1 = num2;
    num2 = num3;
} */ 

// Способ 2 

/* Console.WriteLine(String.Join(" ", GetArray(n)));

int[] GetArray(int size)
{
    int[] res = new int[size];
    res[0] = 0;
    res[1] = 1;
    for(int i = 2; i < size; i++ )
    {
        res[i] = res[i - 1] + res[i - 2];
    }
    return res; 
} */ 



/* Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.*/ 

int[] array = GetArray(10, -10, 10);
Console.WriteLine(String.Join(" ", array));

Console.WriteLine(String.Join(" ", NewMassive(array)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int[] NewMassive(int[] array)
{
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

