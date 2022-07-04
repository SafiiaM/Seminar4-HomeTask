// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


  int Sum(int a)
  {
    
    int count = Convert.ToString(a).Length;
    int number = 0;
    int result = 0;


    for (int i = 0; i < count; i++)
    {
      number = a - a % 10;
      result = result + (a - number);
      a = a / 10;
    }
   return result;
  }


int sum = Sum(a);
Console.WriteLine("Сумма цифр в числе: -> " + sum);
