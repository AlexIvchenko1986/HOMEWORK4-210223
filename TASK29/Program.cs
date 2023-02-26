// Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Создать массив
int[] CreateArray(int length)
{
  return new int[length];
}

// Распечатать массив
void Print(int[] array)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    Console.Write(array[index]);
    ++index;
  }
  Console.WriteLine();
}

int[] arr = CreateArray(100); // Задаем размер массива
// Заполнить массив
void FillArray (int[] arr)
{
  int size = arr.Length;
  for (int index = 0; index < size; index++ )
  {
    arr [index] = index + 1; //new Random().Next (1,10); Или Заполняем случайными числами
  }
}


FillArray(arr);
Print(arr);