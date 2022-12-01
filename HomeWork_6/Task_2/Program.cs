/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int b1 = ReadInt("Введите B1: ");
int k1 = ReadInt("Введите K1: ");
int b2 = ReadInt("Введите B2: ");
int k2 = ReadInt("Введите K2: ");

if (k1 == k2)
{
    Console.Write("Прямые параллельны");
    return;
}
double temp1 = b1 - b2;
double temp2 = k2 - k1;

double x = temp1 / temp2;
double y = k2 * x + b2;

Console.Write($"({x}; {y})");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}