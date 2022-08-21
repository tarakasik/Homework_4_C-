// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Input number A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Input number B: ");
int B = int.Parse(Console.ReadLine()!);

for(int i=0; i <= B ; i++);
{
   double degree = Math.Pow(A, B); 
   Console.WriteLine($"{A}^{B} = {degree}");
}
