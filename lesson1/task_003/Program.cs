Console.WriteLine("  Enter number N :: ");
int N = Convert.ToInt32(Console.ReadLine());

int valHundred = N / 100;
int valUnit = N % 10;
int valTen = N / 10 % 10;
int summ = valHundred + valUnit;

Console.WriteLine($" value hundred :: {valHundred}");
Console.WriteLine($" value ten :: {valTen}");
Console.WriteLine($" value unit :: {valUnit}");
Console.WriteLine($" Summ of numbers :: {summ}");