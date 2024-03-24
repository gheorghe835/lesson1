//
int n = 4;//Convert.ToInt32(Console.ReadLine());
Console.Write($"  Enter array dimensions :: {n} \n");

/*int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write("\n ----------- \n ");
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < 0)
    {
        array[i] = array[i] * -1;
    }
    else
    {
        array[i] = array[i] * -1;
    }
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
*/

void printArray(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item}  ");
    }
    Console.WriteLine("\n --------");
}
int[] randomArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(-10, 10);
    }
    return col;
}


int[] arr = randomArray(new int[n]);
printArray(arr);

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;
}
printArray(arr);
Console.WriteLine("\n -------- \n");
