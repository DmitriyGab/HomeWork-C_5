// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] sumArray = new int[7];
int diff = 0;

for (int i = 0; i < sumArray.Length; i++)
{
    sumArray[i] = new Random().Next(1, 100);
}

Console.WriteLine(String.Join(" ", sumArray));
int maxNum= sumArray[0];
int minNum= sumArray[0];

for (int j = 0; j < sumArray.Length; j++)
{
    if (sumArray[j] > maxNum)
    {
        maxNum = sumArray[j];
    }

    else if (sumArray[j] < minNum)
    {
        minNum = sumArray[j];
    }
}

Console.WriteLine("Максимальное значение "+maxNum);
Console.WriteLine("Минимальное значение "+minNum);

diff = maxNum - minNum;
Console.WriteLine($"Разница между максимальным {maxNum} и минимальным {minNum} значениями составляет {diff}");