// Напишите программу, которая задаёт массив
//  из 8 элементов и выводит их на экран.
//  Вводим массив через консоль

// Первый способ:

int[] array = new int[8];
for(int i = 0; i< array.Length; i++)
{
    Console.WriteLine($"Введите элемент {i} массива:\t"); 
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Массив: ");
for(int i = 0; i< array.Length; i++)
{
    Console.Write($"{array[i]} " );  
}
Console.ReadLine();
    
// Второй способ:

// void FillArray(int[] array)
// {
//     int length = array.Length;
//     int i = 0;
//     while (i < length)
//     {
//         Console.WriteLine($"Введите элемент {i} массива:");
//         int number = Convert.ToInt32(Console.ReadLine());
//         array[i] = number;
//         i++;
//     }
// }

// void PrintArray(int[] array)
// {
//     Console.WriteLine("Вывод массива:");
//     int count = array.Length;
//     int i = 0;
//     while (i < count)
//     {
//         Console.Write($"{array[i]} " );
//         i++;
//     }    
// }
// int[] array = new int[8];
// int count = array.Length;

// FillArray(array);
// PrintArray(array);