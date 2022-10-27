// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
 Console.WriteLine("Введите значение ");
int n= Convert.ToInt32(Console.ReadLine());
int i=1;
while(i <=n)
{
double b=Math.Pow(i,3);
i++;
Console.WriteLine(b);
}