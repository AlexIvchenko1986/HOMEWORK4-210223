// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Math.Pow использовать нельзя
//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int a = 3;
int b = 5;
int stepen = 1;
void Stepen()
{
  for (int i = 1; i <= b; i++)
  {
    stepen = stepen * a;
  }
  Console.WriteLine(stepen);
}
Stepen();
