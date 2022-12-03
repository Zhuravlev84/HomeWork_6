/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите числа через зяпятую: ");
string stringNumber = Console.ReadLine();
char simbolComma = ',';
int numbersCount = 1;

for (int i = 0; i < stringNumber.Length; i++)
{
    if (stringNumber[i] == simbolComma)
        numbersCount++;
}

int[] numbers = new int[numbersCount];
int numberIndex = 0;
string subString = "";
for (int i = 0; i < stringNumber.Length; i++)
{
    if (stringNumber[i] == simbolComma)
    {
        numbers[numberIndex] = Convert.ToInt32(subString);
        subString = "";
        numberIndex++;
    }
    else
    {
        subString = subString + stringNumber[i];
    }
}
numbers[numberIndex] = Convert.ToInt32(subString);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        count++;
}

WriteArray(numbers);
Console.Write($" --> {count}");
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
