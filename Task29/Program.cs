// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int [8] { 1,2,5,7,19,6,1,33 };
int[] array1 = { 1,2,5,7,19,6,1,33 };


int index = 0;
var rnd = new Random();

while (index < array.Length)
{
    index ++;
}

for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write("[");
    if (i < array.Length -1) Console.Write(array[i] + ",");
    else Console.Write(array[i] + "]");

    }
// Console.WriteLine(array[0]);

// int[] arr = { 1,2,5,7,19,6,1,33 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// PrintArray(arr);


