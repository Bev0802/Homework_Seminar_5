// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. //нечётные позиции массива, а не числа..
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//МЕТОДЫ
//метод создает массив из случайных чисел.
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

//метод выводит на печать массив.
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
    }
    Console.Write("] ");
}

//метод счиатет сумму нечётных элементов
int SumOddElements (int[] arr)
{
    int sum = 0;
    for (int i = 1; i <= arr.Length-1; i=i+2)
    {
    sum=sum+arr[i]; 
    }
    return sum;
}

//ВЫВОД РЕЗУЛЬТАТА
int[] array = CreateArrayRndInt(4, -99, 99);
PrintArray(array);
Console.WriteLine($" -> cумма нечётных элементов {SumOddElements(array)}");