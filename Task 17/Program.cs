// 17. Программа, которая которая определчет сколько чисел из M заданных больше 0.

int EnterInfomation(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}
int LengthArray = EnterInfomation(" Введите количество чисел : ");
int [] N=new int [LengthArray];
int Count=0;
for (int i=0;i<N.Length;i++)
{
System.Console.Write($"Введите число {i + 1}: ");
int M=int.Parse(Console.ReadLine()!);
if (M > 0)
Count++;
}
System.Console.Write($": всего {N.Length} чисел, количество чисел больше 0 = {Count}");
