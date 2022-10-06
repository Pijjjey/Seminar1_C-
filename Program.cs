//Задача 2:
/*Console.Write("Введите первое число: ");
int Num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine());
if (Num1 > Num2)
{
 Console.WriteLine($"Максимальное число: {Num1}");
}
else
{
 Console.WriteLine($"Максимальное число: {Num2}");
}


//Задача 4:
Console.Write("Введите первое число: ");
int Num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int Num3 = int.Parse(Console.ReadLine());

int max = Num1;

if (Num1 > Num2)
{
 max = Num1;
}

else
{
 max = Num2;
}

if (Num3 > max)
{
 Num3 = max;
}
Console.WriteLine($"Максимальное число: {max}");



//Задача 6:
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
 Console.WriteLine("Число является четным.");
}
else
{
 Console.WriteLine("Число не является четным.");
}*/


//Задача 8
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int A = 1;
while(A < N)
{
    A = A + 1;
    if(A % 2 ==0)
    {
        Console.Write($"{A}, ");
    }
}

