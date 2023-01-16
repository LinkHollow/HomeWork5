// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array = GetArray(22);
System.Console.WriteLine($"[{String.Join(" ", Array)}]");

int count = 0; 
foreach (int el in Array)
{
    if(el % 2 == 0)
    {
        count++;
    }
}

System.Console.WriteLine($"Количество чётных чисел в массиве равно: {count}");

// ----------Method--------------
int[] GetArray (int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}