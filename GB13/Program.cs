Console.WriteLine("Введите число: ");
int C = Convert.ToInt32(Console.ReadLine());

int P = 0;

while (P==0)
{
    if(C<100)
    {
        Console.WriteLine("Третьей цифры нет. Введите большее число: ");
        C = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        P=1;
    }
}


while (C>=100)
{
    if(C<1000)
    {
        Console.Write("Третья цифра числа: ");
        int R=C%10;
        Console.WriteLine(R);
    }
    C=C/10;
}



Console.WriteLine(" ");