// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] newArr = new int[10];
int count = 0;

for (int i = 0; i < newArr.Length; i++)
{
    newArr[i] = new Random().Next(100, 1000);
}

Console.WriteLine(String.Join(", ", newArr));

for (int j = 0; j < newArr.Length; j++)
{
    if (newArr[j]%2 == 0)
    {
        Console.WriteLine(newArr[j]);
        count++;
    }
}

Console.WriteLine("Количество четных числе в массиве равно "+count);