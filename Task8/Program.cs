// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
string numA = Console.ReadLine();
int A = int.Parse(numA);
if(A % 2 ==0)
{
    Console.Write("Предыдущие четные значения: ");
    while(A > 0)
    {
        A = A - 2;
        Console.Write(A + ", ");
    }
}    
else
{
    Console.Write("Предыдущие четные значения: ");
    A = A + 1;
    while(A > 0)
    {
        A = A - 2;
        Console.Write(A + ", ");
    }
}

