


Console.Write("  Enter array dimensions :: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine("---------------");
//foreach
foreach (int item in array)
{
    //array = 8;
}
foreach (int item in array)
{
    Console.Write(array + " ");
}
Console.WriteLine("\n ---------------");
//function

void printArray(int[] list)
{
    foreach (int item in list)
    {
        Console.Write($"{item}");
    }
}
printArray(array);

int[] randomArray(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return list;
}
Console.WriteLine("\n ---------------");
int[] newRandomArray = randomArray(array);
printArray(newRandomArray);

Console.Write("  Enter the number :: ");
int m = Convert.ToInt32(Console.ReadLine());

int flag = 0;
foreach (var item in newRandomArray)
{
    if (item == m)
    {
        flag++;
    }
}

if (flag > 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
string Str(int[] col, int m)
{
    foreach (var item in col)
    {
        if (item == m)
        {
            return "Yes";
        }
    }
    return "No";
}
Console.WriteLine(Str(newRandomArray,m));