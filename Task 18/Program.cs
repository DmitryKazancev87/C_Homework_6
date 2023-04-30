// 18. Программа, которая находит точку пересечения двух прямых, заданных уравнениями: 
// y=k1*x+b1, y=k2*x+b2, значения b1, k1, b2, k2 задаются пользователем.


int EnterInfomation(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}
double b1 = EnterInfomation(" Ввведите значение b1 : ");
double k1 = EnterInfomation(" Ввведите значение k1 : ");
double b2 = EnterInfomation(" Ввведите значение b2 : ");
double k2 = EnterInfomation(" Ввведите значение k2 : ");
// формула нахождения точки для уравнений y=k1*x+b1, y=k2*x+b2 будет выглядеть так:
// x= (-b2+b1)/(-k1+k2) y = k2*x+b2.

double x=(-b2+b1)/(-k1+k2);
double y =k2*x+b2;

System.Console.Write($"Две прямые пересекуться в точке с координатами X: {x}, Y; {y}");
