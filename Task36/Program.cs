Console.WriteLine("Укажите количество чисел в массиве");
int a = Convert.ToInt32(Console.ReadLine());
void array(int[] arr)
{
    for (int i = 0; i < a; i++)
    arr[i] = new Random().Next(100, 1000);
}
void Print(int[] arr)
{
    for (int i = 0; i < a; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
void sum(int[] arr)
{
    int result = 0;
    for (int i = 1; i < a; i += 2)
    {
        result += arr[i];
    }
    Console.WriteLine("-> "+result);
}

int[] array2 = new int[a];
array(array2);
Print(array2);
sum(array2);