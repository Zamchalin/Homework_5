// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (10 + 0) - 0;
        }
    Console.Write(array);
}

void ReleaseArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for( int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    for( int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Максимальное число: {max}");
    Console.WriteLine($"Минимальное число: {min}");
    result = max - min;
    Console.WriteLine($"Результат: {result}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);