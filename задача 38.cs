// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double MaxElement(double[] arr)
{
    double maxel = arr [0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxel)
        {
            maxel = arr[i];
        
        }
    }   
    return maxel;
}

double MinElement(double[] arr)
{
    double minel = arr [0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > minel)
        {
            minel = arr[i];
        
        }
    }   
    return minel;
}

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int n = Int16.Parse(Console.ReadLine()!);

double[] arr = GetArray(n, 1, 1000);
Console.WriteLine(String.Join(",", arr));

double min = MinElement(arr);
double max = MaxElement(arr);
Console.WriteLine($"Разница между мин и макс значением массива: {min - max}");

