
Console.WriteLine("  Enter first number ::");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("  Enter second number ::");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2 * n2)
{
    Console.WriteLine($" Square of the number :: {n2} equals :: {n1}");
}
else
    Console.WriteLine(" Square of the number :: {0} not equals :: {1}",
                        n2, n1);
