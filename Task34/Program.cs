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
void even(int[] arr)
{
    int j = 0;
    for (int i = 0; i < a; i++)
    {
        if (arr[i] % 2 == 0)
        {
            j++;
        }
    }
Console.WriteLine("-> " + j);
}

int[] array2 = new int[a];
array(array2);
Print(array2);
even(array2);