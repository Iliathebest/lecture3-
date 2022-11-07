// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите пятизначное число");


int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);

 
int Lenght = anyNumberText.Length;
  if(anyNumberText[0]==anyNumberText[4]&&anyNumberText[1]==anyNumberText[3] )
   {
    Console.WriteLine("Является полиндромом");
    
   }
 else
   {
      Console.WriteLine("Не является пoлиндромом");
   }

 

 