/*Написать программу,которая из имеющегося массива строк,формирует 
массив из строк, длинна которых меньше или равна 3 символа.
*/
string[] array1 = { "123", "day", "hello", "world", "12" };
string[] array2 = new string[array1.Length];

ArrayThreeSymbol(array1, array2);
PrintArray(array2);

void ArrayThreeSymbol(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.ResetColor();
}