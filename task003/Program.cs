// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] Array = GetArray(12, 0, 10);
System.Console.WriteLine($"[{String.Join(" ", Array)}]");

int NewArrayLength = 0;
if (Array.Length % 2 == 0)
{
    NewArrayLength = Array.Length / 2;
}
else
{
    NewArrayLength = (Array.Length / 2) + 1;
}
int[] product = GetArray2(NewArrayLength, Array.Length, Array);

System.Console.WriteLine($"[{String.Join(" ", product)}]");

// ----------Method--------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int[] GetArray2(int size, int ArrayLength, int[] Array)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != (ArrayLength - 1) - i)
        {
            res[i] = Array[i] * Array[(ArrayLength - 1) - i];
        }
        else
        {
            res[i] = Array[i];
        }
    }
    return res;
}