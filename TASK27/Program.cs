// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

internal class Program
{
  static int sum(int abc)
  {
    int result = 0;
    while (abc > 0)
    {
      result = result + abc % 10;
      abc = abc / 10;
    }
    return result;
  }
  static void Main(string[] args)
  {
    int Sumabc = 9012;
    int result = sum(Sumabc);
    Console.WriteLine(result);
  }
}