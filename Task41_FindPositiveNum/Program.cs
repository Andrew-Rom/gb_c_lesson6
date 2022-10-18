/*Задача 41
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Примеры:
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

// Метод получения массива при вводе
int[] GetArrayFromString(string stringArray)
{
    string[] strArray = stringArray.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int[] numArray = new int[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        numArray[i] = int.Parse(strArray[i]);
    }
    return numArray;
}

// Метод подсчета положительных чисел
int CalculatePositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;

}

Console.Write("Задайте массив чисел (через запятую): ");
string getArray = Console.ReadLine();
int[] arrayFromUser = GetArrayFromString(getArray);
int quantityPosNum = CalculatePositiveNumbers(arrayFromUser);
Console.WriteLine($"В массиве [{string.Join(", ", arrayFromUser)}] чисел больше 0: {quantityPosNum}.");