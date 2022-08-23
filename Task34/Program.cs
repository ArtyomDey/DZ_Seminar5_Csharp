// ============================Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue) //1 аргумент - размер массива, 2 - минимальное значение, 3 - максимальное значение.
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.Clear();
int[] newArray = GetArray(5, 100, 999);
int count = 0;
for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] % 2 ==0)
    count++;
}
Console.WriteLine(String.Join(" ", newArray) + $" -> {count}");