// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int Exponenta(int value, int power)
{
    int result = Convert.ToInt32(Math.Pow(value, power));

  for(int i = 1 ; i <= power; i++)
  {
    result = result * value;
  }
    
    return result;
}

  Console.Write("Введите число A: ");
  int value = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int power = Convert.ToInt32(Console.ReadLine());

  int exponenta = Exponenta(value, power);
  Console.WriteLine("Число А в натуральной степени В -> " + Math.Pow(value, power));
