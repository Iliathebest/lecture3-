// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//  Console.WriteLine("Введите пятизначное число");

Console.WriteLine("Введите пятизначное число");

string n= Console.ReadLine(); 

 void CheckingNumber(string n)
 {

  if( n[0]==n[4]&&n[1]==n[3])
   {
    Console.WriteLine("Является полиндромом");
    
   }
 else
   {
      Console.WriteLine("Не является пoлиндромом");
   }

 }