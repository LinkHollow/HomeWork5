// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. (позиции - это индексы, нечетные индексы это 1,3,5 и тд)
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Array = GetArray(12, -22, 23);
System.Console.WriteLine($"[{String.Join(" ", Array)}]");
int sum = 0;
for(int i = 0; i < Array.Length; i++)
{
    if(i % 2 != 0)
    {
        sum = sum + Array[i];
    }
}
System.Console.WriteLine($"сумму элементов, стоящих на нечётных позициях равна: {sum}");
// ----------Method--------------
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}