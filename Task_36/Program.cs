// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array1 = new int[15];
int sumPos = 0;

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(-999, 1000);
}

Console.WriteLine(String.Join(", ", array1));
Console.WriteLine();

for (int j = 0; j < array1.Length; j++)
{
    if (j%2 > 0)
    {
        sumPos+= array1[j];
        Console.Write(" "+sumPos);
    }
}

Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечетных позичиях "+sumPos);