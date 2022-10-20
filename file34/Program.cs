// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Console.Clear();
int[] numbers = new int[4];

void EvenArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void Array(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
    Console.Write(array[i] + " ");
    }
  Console.WriteLine();
}

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++ )
    {
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
    }
  return quantity;
}
EvenArray(numbers, 100, 1000);
Array(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Чётных чисел в массиве: {quantity}");