Console.WriteLine("Укажите количество чисел в массиве");
int a = Convert.ToInt32(Console.ReadLine());
void array(double[] arr)
{
    for (int i = 0; i < a; i++)
    arr[i] = Math.Round(new Random().NextDouble(), 4) * 100;
}
void Print(double[] arr)
{
    for (int i = 0; i < a; i++)
    {
        if (i % 5 == 0) Console.WriteLine();
        Console.Write(arr[i] + " ");
    }
}
double different(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < a; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    double dif = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементами = " + dif);
    return dif;
}

double[] array2 = new double[a];
array(array2);
Print(array2);
Console.WriteLine();
different(array2);