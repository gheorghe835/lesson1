Console.WriteLine("  Enter number N :: ");
int N = Convert.ToInt32(Console.ReadLine());
int[]array = new int[N];
for(int i=0; i<N; i++)
{
    array[i] = i ;
    Console.Write(array[i] + " ");
}