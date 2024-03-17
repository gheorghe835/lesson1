Console.WriteLine("Task :: -N to N ");
Console.WriteLine("  Enter number N :: ");
int N = Convert.ToInt32(Console.ReadLine());
int notN = -N;

while(notN <= N)
{
    Console.Write($" {notN} ");
    notN++;
}
