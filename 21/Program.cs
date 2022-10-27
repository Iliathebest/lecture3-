// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.WriteLine("Введите значение X1");
int X1= int.Parse(Console.ReadLine());

 Console.WriteLine("Введите значение Y1");
int Y1= int.Parse (Console.ReadLine());
 
 Console.WriteLine("Введите значение Z1");
int Z1= int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение X2");
int X2= int.Parse(Console.ReadLine());

 Console.WriteLine("Введите значение Y2");
int Y2= int.Parse (Console.ReadLine());
 
 Console.WriteLine ("Введите значение Z2");
int Z2= int.Parse(Console.ReadLine());

double d= Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));

Console.WriteLine("расстояние между двух точек"+d);