
int n = 10;
int max = 0;
 int num3 = new Random().Next(10, 100);
Console.WriteLine($"num3 :: {num3}");
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(10, 100);
}

for (int i = 0; i < n; i++)
{
     Console.Write(array[i] + " ");
}
Console.WriteLine("\n ----------------");

for (int i = 0; i < n; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("\n ----------------");
for (int i = 0; i < n; i++)
{
    if (array[i] % 2 != 0)
    {
        Console.Write(array[i] + " ");
    }
}
for (int i = 0; i < n; i++)
{
    if (max < array[i] )
    {
        max = array[i];
         
    }
}
Console.Write($"\n Maximum :: {max}");

