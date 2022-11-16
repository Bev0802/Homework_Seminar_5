// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//веществтвенные числа(дробьные). через псевдогенератор можно. создать три метода для выселения разницы.

//МЕТОДЫ
//метод создает массив из случайных вещественных чисел.
double[] CreateArrayRnddouble(int size, int min, int max)
{
    double[] array = new double [size]; // создаем массив
    Random rnd = new Random();          // создаем переменную для случайных чисел.
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min; // создаем число массива в заданном диапазоне
        array[i] = Math.Round(num, 1); // записываем в массив число округленное до 1 знака после запятой.
    }
    return array;
}
//метод выводит на печать массив.
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

//метод находит максимальный элемент массива.
double MaxNumberArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i <= array.Length-1; i++)
    {
    if (max < array[i]) max=array[i];
    }
    return max;
}
//метод находит минимальный элемент массива.
double MinNumberArray(double[] array)
{
    double min = array[0];
for (int i = 1; i <= array.Length-1; i++)
    {
    if (min > array[i]) min=array[i];
    }
    return min;
}
//метод находит разницу между числами.
double DifferenceNumber(double max, double min)
{
    double difference = max - min;
    difference = Math.Round(difference, 1);
    return difference;

}


//ВЫВОД РЕЗУЛЬТАТА
double[] arr = CreateArrayRnddouble(5, 1, 99);
PrintArray(arr);
double maxNumber = MaxNumberArray(arr);
double minNumber = MinNumberArray(arr);
double differenceNum = DifferenceNumber(maxNumber, minNumber);
Console.Write($" -> разница между максимальным {maxNumber} и минимальным {minNumber} элементами массива -> {differenceNum}");
