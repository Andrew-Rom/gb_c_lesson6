/*Задача 43
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Пример:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

// Метод считывания
double GetNumFromUser(string message)
{
    Console.Write(message);
    double value = double.Parse(Console.ReadLine());
    return value;
}

// Метод поиска координат точки пересечения
double[] GetCrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    double[] crossPoint = {x, y};
    return crossPoint;
}

// Метод проверки параллельности прямых
bool IsParallelLines(double k1, double k2)
{
    if (k1 == k2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Поиск точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите данные k1, b1, k2, b2");
double aB = GetNumFromUser("b1 = ");
double aK = GetNumFromUser("k1 = ");
double bB = GetNumFromUser("b2 = ");
double bK = GetNumFromUser("k2 = ");
bool isParallel = IsParallelLines(aK, bK);
if (isParallel)
{
    Console.WriteLine("Прямые параллельны.");
}
else
{
    Console.WriteLine($"Точка пересечения имеет следующие координаты: ({string.Join(", ", GetCrossPoint(aK, aB, bK, bB))}).");
}