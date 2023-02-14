// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }

    }
}
void PrintArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix);
Console.WriteLine("Ваш случайный массив: ");
PrintArrayWithRandom(matrix);
int minsum = 0;
int sumline = SumLineElements(matrix, 0);
for(int i = 1;i <matrix.GetLength(0);i++)
{
    int tempSumLine = SumLineElements(matrix, i);
    if(sumline > tempSumLine)
    {
        sumline = tempSumLine;
        minsum = i;
    }
}
Console.WriteLine($"\n{minsum + 1} - строка с наименьшей суммой ({sumline}) элементов");

int SumLineElements(int[,] matrix, int i)
{
    int sumline = matrix[i,0];
    for(int j = 1;j < matrix.GetLength(1);j++)
    {
        sumline += matrix[i,j];
    }
    return sumline;
}
