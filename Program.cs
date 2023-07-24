/* Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 
*/

/*
int isPositiveNumbers()
{
    Console.Write("Введите количество чисел: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int count = 0;

    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            count++;
        }
    }
    return count;
}

int positiveCount = isPositiveNumbers();
Console.WriteLine($"Количество положительных чисел: {positiveCount}");
*/


/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
void pointCrossing(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1 == k2)
    {
        if (b1 == b2)
        Console.WriteLine("Линии пересеклись ");
        else 
        Console.WriteLine("Линии не пересекаются друг с другом");
    }
    else 
    Console.WriteLine($"Точка пересечения здесь: {x}, {y} ");
} 

Console.WriteLine("Введите координаты k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
pointCrossing(k1,b1,k2,b2);
*/