Console.WriteLine("Введите Трёхзначное число: ");
int C = Convert.ToInt32(Console.ReadLine());

int P = 0;

while (P==0)
{
    if(C<100||C>999)
    {
        Console.WriteLine("Число неверное. Введите Трёхзначное число: ");
        C = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        P=1;
    }
}

C = C/10;
C = C%10;

Console.Write("Вторая цифра числа: ");
Console.WriteLine(C);

Console.WriteLine(" ");