Console.WriteLine("Дан массив строк ");
string[] array = {"1234", ":-)", "col", "-5", "Moscow", "==", "O(n^2)"};
for (int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
Console.WriteLine();
Console.WriteLine("Конечный массив: ");
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        Console.Write(array[i] + " ");
    }
}
