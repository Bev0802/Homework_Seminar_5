// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Числа должны быть положительными

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

//метод ищет чётные числа.
int SearchEvenNumbers ( int [] arr)
{
int result = 0;
for (int i = 0; i <= arr.Length-1; i++)
{
   if (arr[i]%2==0) result=result+1;
}
return result;
}

// результаты
int[] array = CreateArrayRndInt(4, 100, 999);
PrintArray(array);
Console.WriteLine($" -> количество чётных чисел в массиве {SearchEvenNumbers(array)}");

