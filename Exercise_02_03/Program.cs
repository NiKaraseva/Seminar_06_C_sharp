/* Задача 1: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины.*/


/* Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);

if((num1 + num2 > num3) && (num2 + num3 > num1) && (num1 + num3 > num2))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник НЕ существует"); 
} */ 



/* Задача 2: Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */ 


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

// Console.WriteLine(Convert.ToString(num,2));

int d10 = 1;
int result = 0;
while (num != 0)
{
    result = result + num % 2 * d10;
    num = num /2;
    d10 = d10 * 10;
}
Console.WriteLine(result);

