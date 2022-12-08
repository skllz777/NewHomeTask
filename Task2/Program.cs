// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 20);
}


void ReleaseArray(int[] array)
{
    int sumofOdd = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
     sumofOdd = sumofOdd + array[i];   
    }
    Console.WriteLine($"Sum of elements in odd positions: {sumofOdd}");
}

Console.Clear();
Console.Write("Enter the number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
