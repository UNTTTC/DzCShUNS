// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 2, 3, 7 -> 7

Console.WriteLine("Введите число А");
string numA = Console.ReadLine();
int A = int.Parse(numA);
Console.WriteLine("Введите число B");
string numB = Console.ReadLine();
int B = int.Parse(numB);
Console.WriteLine("Введите число C");
string numC = Console.ReadLine();
int C = int.Parse(numC);
int maxNum = 0;
Console.Write("Это число больше: ");
if(A > B)
{
    maxNum = A;
}
else
{
    maxNum = B; 
}
if(maxNum>C)
{
     maxNum = maxNum;
}
else
{
     maxNum = C;
}
Console.Write(maxNum);
