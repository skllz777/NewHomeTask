// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}


void ReleaseArray(double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"maximum value = {max}, minimum value = {min}");
    Console.WriteLine($"difference between max value and min value = {max - min}");
}

Console.Clear();
Console.Write("Enter the number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
