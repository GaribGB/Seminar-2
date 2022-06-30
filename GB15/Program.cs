Console.WriteLine("Введите цифру: ");
int D = Convert.ToInt32(Console.ReadLine());

int P=0;

while(P==0)
{
    if(D>7||D<1)
    { 
        Console.WriteLine("Такого дня недели не существует, введите правильную цифру");
        D = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        P=1;
    }
}

if(D>5)
{
Console.WriteLine("Да. Выходной");
}
else
{
Console.WriteLine("Нет");
}


Console.WriteLine(" ");