// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
string numA = Console.ReadLine();
int A = int.Parse(numA);
if(A % 2 == 0)
{
    Console.WriteLine("Это значение ЧЕТНОЕ"); 
}
else
{
    Console.WriteLine("Это значение НЕ четное");
}