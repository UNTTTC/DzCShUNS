// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.; 
Console.WriteLine("Введите число А");
string numA = Console.ReadLine();
int A = int.Parse(numA);
Console.WriteLine("Введите число B");
string numB = Console.ReadLine();
int B = int.Parse(numB);
Console.Write("Это число больше: ");
if(A > B)
{
    Console.Write(A);
}
else
{
   Console.Write(B); 
}