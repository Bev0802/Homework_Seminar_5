// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//веществтвенные числа(дробьные). через псевдогенератор можно. создать три метода:
//создать метод который находит максимальное значение
//создать метод который находит минимальные значения
//создать метод который находит разницу между максимальным и минимальным значениями.
//можно вызывать метод из метода.

double[] CreateArrayRnddouble(int size, int min, int max)
{
    double[] array = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min; // создаем число массива в заданном диапазоне
        array[i] = Math.Round(num, 1); // записываем в массив число округленное до 1 знака после запятой.
    }
    return array;
}

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
    Console.WriteLine("]");
}

double[] arr = CreateArrayRnddouble(5, 1, 99);
PrintArray(arr);