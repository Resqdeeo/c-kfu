
using System;
using System.Reflection.PortableExecutable;

int[,] GetMatrix(int n)
{
    Random r = new Random();
    int[,] matr = new int[n, n];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            matr[i, j] = r.Next(100);
    return matr;
}


void WriteInFile(int[,] matrix, string path)
{
    using (StreamWriter writer = new StreamWriter(path))
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        writer.WriteLine($"{m} {n}");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                writer.Write(matrix[i, j] + " ");
            writer.WriteLine();
        }
    }
}


int[,] ReadFromFile(string path)        //Считывание матрицы из файла
{
    using (StreamReader reader = new StreamReader(@"D:\Temp\test.txt"))
    {
        var mn = reader.ReadLine().Split(' ');
        int m = int.Parse(mn[0]);
        int n = int.Parse(mn[1]);

        var matr = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            var row = reader.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matr[i, j] = int.Parse(row[j]);
            }
        }
        return matr;
    }
}


void PrintMatr(int[,] matr)             //Вывод матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],3}");
        Console.WriteLine();
    }
}


int OddNumber()                         //Генерация случайного нечетного числа
{
    Random random = new Random();
    int number = 0;
    do
    {
        number = random.Next(100);
    }
    while (number % 2 != 0);
    return number;
}


int[,] GetMatrixOfOddNumbers(int n)     //Генерация матрицы из нечетных чисел
{
    Random r = new Random();
    int[,] matr = new int[n, n];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            matr[i, j] = OddNumber();
    return matr;
}


void CheckMagicSquare(int[,] matrix)    //Проверка матрицы на то, является ли она магическим квадратом
{
    int n = matrix.GetLength(0);
    int[] Magic = new int[(2 * n + 2)];     //Создаем массив, в которой будут суммы столбцов, строк, диагоналей (n + n + 2)
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Magic[i] += matrix[i, j]; // суммы строк (c 1 по n), записываем их в первые n элементов массива
            Magic[i + n] += matrix[j, i]; // сумммы столбцов (c 1 по n), записываем их во вторую часть n элементов массива
        }
    }
    for (int j = 0; j < n; j++)
    {
        Magic[0 + 2 * n] += matrix[j, j]; //сумму главной диагонали так же добавляем в массив
        Magic[1 + 2 * n] += matrix[j, (n - j - 1)];//и сумму побочной
    }
    bool flag = true;
    for (int i = 1; i < Magic.Length; i++)
    {
        if (Magic[0] != Magic[i])
        {
            flag = false;
            break;
        }
    }
    if (flag == false)
        Console.WriteLine("Эта матрица не является магическим квадратом.");
    else
        Console.WriteLine("Это матрица - магический квадрат");
}


int[,] SumOfMatrix(int[,] matrone, int[,] matrtwo)  //Сумма двух матриц
{
    var n = matrtwo.GetLength(0);
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = matrone[i, j] + matrtwo[i, j];
    return matrix;
}


bool IsPrime(int number)                    //Проверка числа на простоту
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}


void PrimePillar(int[,] matrix)            //Вывод столбца с наибольшим кол-ком простых чисел
{
    var maxj = 0;
    for (int j = 0; j < matrix.GetLength(1) ; j++)
    {
        int count = 0;
        var maxCount = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            if (IsPrime(matrix[i, j]))
            {
                count++;
            }
        if (count > maxCount)
        {
            maxCount = count;
            maxj = j;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
        Console.WriteLine(matrix[i, maxj]);
}



int size = 5;
var firstmatr = GetMatrixOfOddNumbers(size);
PrintMatr(firstmatr);
Console.WriteLine();
var secondmatr = ReadFromFile(@"D:\Temp\test.txt");
PrintMatr(secondmatr);
CheckMagicSquare(secondmatr);

var thirdmatr = SumOfMatrix(firstmatr, secondmatr);
PrimePillar(thirdmatr);



