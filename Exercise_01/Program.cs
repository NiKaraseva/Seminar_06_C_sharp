/* Программа, которая перевернёт одномерный массив 
(первый эл-т на последнем месте, последний – на первом и т.д) */

int[] array = GetArray(8, 0, 20);
Console.WriteLine(String.Join(" ", array));


Console.WriteLine("Второй метод: ");
int[] reversArray = ReversArray2(array); // вызываем метод 2
Console.WriteLine(String.Join(" ", reversArray)); 


Console.WriteLine("Первый метод: ");
ReversArray1(array); // вызываем метод 1 
Console.WriteLine(String.Join(" ", array));



void ReversArray1(int[] array) // перезаписываем массив
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length - i - 1]; 
        array[array.Length - i - 1] = k; 
    }
}

int [] ReversArray2(int[] array) // метод возвращает новый перевёрнутый массив
{
    int[] result = new int [array.Length]; 
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - i - 1];
    }
    return result; 
}


int[] GetArray(int size, int minValue, int maxValue) // создание массива 
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
} 