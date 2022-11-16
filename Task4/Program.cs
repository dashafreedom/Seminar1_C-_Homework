Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int beginN = 1;

while(beginN <= N)
{
    if(beginN % 2 == 0)
    {
        Console.Write(beginN + " ");
    } 

    beginN++;
}
