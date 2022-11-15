Console.Write("Введите число1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;
int max1 = b;
int min1 = a;

if(a > b)
{
    Console.WriteLine("max = " + max);
    Console.WriteLine("min = " + min);
}
else
{
    Console.WriteLine("max = " + max1);
    Console.WriteLine("min = " + min1);
}