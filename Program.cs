// Программа задает массив из 8 элементов и наполняет его произвольными элементами
int[] array = new int[8];
void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(2,9);
}
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[array.Length - 1]} ");
}
PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);