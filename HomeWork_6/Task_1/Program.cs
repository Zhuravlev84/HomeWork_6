/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите числа через зяпятую: ");
string stringNumber = Console.ReadLine();
char simbol = ',';
char simbol2 = '-';
char simbol3 = '0';
int simbolMinus = 0;
int simbolComma = -1;
int simbolNull = 0;
for (int i = 0; i < stringNumber.Length; i++)
{
    if (stringNumber[i] != simbol)
    {
        string digit = Convert.ToString(stringNumber[i]);
        simbolComma++;
        if (stringNumber[i] == simbol3)
        {
            simbolNull++;
        }
        if (stringNumber[i] == simbol2)
        {
            simbolMinus++;
        }
    }
}
Console.WriteLine($"{stringNumber} --> {stringNumber.Length - simbolMinus - simbolComma - simbolNull}");
