// See https://aka.ms/new-console-template for more information

/*
double x;
x = double.Parse(Console.ReadLine());

double y = 0;
double p = 1;

int i = 10;

while (i > 0)
{
    y = y + i * p;
    p = p * x;
    i--;
}
Console.WriteLine(y);
*/

/*
double x;
x = double.Parse(Console.ReadLine());

double y = 0;
double p = x;
int i = 10;

while (i > 0)
{
    y = y + Math.Cos(x);
    p = p * x;
    i--;
}
Console.WriteLine(y);
*/

/*
double x, step, y, cnt;
x=double.Parse(Console.ReadLine());
step = Math.Sin(x);
y = 1;
cnt = 0;
while (y > 0.001)
{
    y=Math.Sin(step);
    step = Math.Sin(step);
    cnt++;
}
Console.WriteLine($"{y},{cnt}");
*/


/*
double x;
x = double.Parse(Console.ReadLine());

double y = 1;
int step = 1;
int fact = 1;

while (y <= Math.Pow(Math.E, x))
{
    fact = fact * step;
    y += Math.Pow(x, step) / fact;
    step++;
}
Console.WriteLine(y);
*/


/*
for (int i = 100; i <= 999; i++)
{
    if ((i / 100 != i % 10) && (i / 100 != (i % 100) / 10) && (i % 10 != (i % 100) / 10))
    {
        Console.WriteLine(i);
    }
}
*/

/*
double x, y = 1;
int fact = 1, step = 0;
x = double.Parse(Console.ReadLine());

step += 2;
fact = fact * (-step) * (step - 1);
y = y + Math.Pow(x, step) / fact;

while (y < Math.Cos(x))
{
    step += 2;
    fact = fact * (-step) * (step - 1);
    y = y + Math.Pow(x, step) / fact;
}
*/

/*
double x, y;
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());

if (Math.Abs(x) <= 1)
{
    if (x >= 0)
    {
        if (y <= 1 && y >= 0)
        {
            Console.WriteLine("Точка на фигуре");
        }
        else
        {
            Console.WriteLine("Точка не на фигуре");
        }
    }
    else
    {
        if (y > 0)
        {
            if (Math.Abs(x) + Math.Abs(y) <= 1)
            {
                Console.WriteLine("Точка на фигуре");
            }
            else
            {
                Console.WriteLine("Точка не на фигуре");
            }
        }
        else
        {
            if (x * x + y * y <= 1)
            {
                Console.WriteLine("Точка на фигуре");
            }
            else
            {
                Console.WriteLine("Точка не на фигуре");
            }
        }
    }
}
else
{
    Console.WriteLine("Точка не на фигуре");
}
*/


/*
int a, b;
int nod = 1;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

if (a > b)
{
    for (int i = a; i >= 1; i--)
    {
        if (a % i == 0)
        {
            if ((b % i) == 0)
            {
                nod = i;
                break;
            }
        }
    }
}
else
{
    for (int i = b; i >= 1; i--)
    {
        if (b % i == 0)
        {
            if (a % i == 0)
            {
                nod = i;
                break;
            }
        }
    }
}
Console.WriteLine(nod);

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

int nok;
nok = a * b / nod;
*/

//ДОДЕЛАТЬ ДОМА!!!!!!!!!!!
/*
double x, y;                                                     //ЗАДАЧА 1.2!!!!!
x = double.Parse(Console.ReadLine());
y = 0;
int fact = 1;
double xznamenatel = 1;
int step = 0;
int k = 0;


while (Math.Pow(Math.E, 1 / x) - y >= 0.01)                             
{
    y += ((2 * k * x) + 1) / (xznamenatel * fact);
    xznamenatel *= x * x;
    step += 2;
    fact *= step * (step - 1);
    k += 1;
}
Console.WriteLine($"{y}, {Math.Pow(Math.E, 1 / x)}");
*/


/*
int N;
int count;

N = int.Parse(Console.ReadLine());

for (int i = 2; i <= N / 2; i++)
{
    if (N % i == 0)
    {
        count = 0;
        for (int j = 2; j <= i / 2; j++)
        {
            if (i % j == 0)
            {
                count += 1;
                if (count > 0)
                {
                    break;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine(i);
        }
    }
}
*/

/*
int k, x1 = 1, x2 = 1;
k = int.Parse(Console.ReadLine());                      //1,1,2,3,5,8,13
int x = 0;
for (int i = 0; i < k; i++)
{
    x = x1 + x2;
    x2 = x1;
    x1 = x;

}
Console.WriteLine(x);
*/



/*                                                      //ДОДЕЛАТЬ!!!!!!!!!!!!!!! (5 задача)
double x, y;
int k;

x = double.Parse(Console.ReadLine());  

if (x >= 1)
{  
    y = x / 3;
}
else
{
    y = x;
}
*/


/*
int n = 10;
int[] arr = new int[n];

Random r = new Random();


for (int i = 0; i < n; i++)
{
    arr[i] = r.Next(-100, 101);
}

//arr[0] = 20;



int sum = 0, kolPol = 0;
int max = int.MinValue;
//int max = arr[0];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"a[{i}] = {arr[i]}");

    sum += arr[i];


    if (arr[i] > 0)
        kolPol++;


    if (arr[i] > max)
        max = arr[i];
}

Console.WriteLine($"sum = {sum} kolPol = {kolPol} max = {max}");


int[] mas = { -3, -5, -6, -3, -7, -65, -11, -13 };

bool fl = false;   //Содержит ли массив отрицательное число
int fl2 = 1;       //Все числа в массиве отрицательные


for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine($"a[{i}] = {mas[i]}");
    if (mas[i] < 0)
        fl = true;

    if (mas[i] >= 0)
        fl2 = -1;
}

if (fl)
    Console.WriteLine("Есть отрицательное число");
else
    Console.WriteLine("Нет отрицательных чисел");

if (fl2 == 1)
    Console.WriteLine("Все числа в массиве отрицательные");
else
    Console.WriteLine("Не все числа отрицательные");
*/


/*
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];

Random ran = new Random();

for (int i = 0; i < n; i++)
{
    a[i] = ran.Next(-100, 101);
}

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"a[{i}] = {a[i]}");

    if (a[i] < 0)
    {
        if (a[i] > max)
            max = a[i];
    }
    else
    {
        if (a[i] < min)
            min = a[i];
    }
}
Console.WriteLine($"min = {min} max = {max}");
*/


/*
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];

Random ran = new Random();

for (int i = 0; i < n; i++)
{
    a[i] = ran.Next(-100, 101);
}

int max = int.MinValue;
int index = -1;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"a[{i}] = {a[i]}");
    
    if (a[i] > max)
    {
        max = a[i];
        index = i;
    }
}
Console.WriteLine($"max = {max} index = {index}");
*/



/*
int[] minim = { -65, -5, -6, -3, -7, -65, -65, -11 };
int min = int.MaxValue;
int k = 1;
int predp = 0, posled = 0;

for (int i = 0; i < minim.Length; i++)
{
    Console.WriteLine($"minim[{i}] = {minim[i]}");
    if (minim[i] == min)
    {
        k += 1;
        predp = posled;
        posled = i;
    }
    if (minim[i] < min)
    {
        min = minim[i];
        k = 1;
    }
}
Console.WriteLine($"min = {min} k = {k} predp = {predp}");  
*/



/*
int n = int.Parse(Console.ReadLine());               //ДОДЕЛАТЬ ДОМА (ЗАДАЧА 4 НА ПРОВЕРКУ ПРОСТЫХ ЧИСЕЛ В МАССИВЕ)!!!
int[] a = new int[n];

Random ran = new Random();

for (int i = 0; i < n; i++)
{
    a[i] = ran.Next(-100, 101);
}

bool fl = false;
int count;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"a[{i}] = {a[i]}");
    count = 0;
    for (int j = 2; j < a[i] / 2; j++)
    {
        if (a[i] % j == 0)
            count++;
    }

    if (count == 0)
    {
        fl = true;
        break;
    }
}
if (fl)
    Console.WriteLine("Простые числа есть");
else
    Console.WriteLine("Нету простых чисел");
*/


/*
int k = int.Parse(Console.ReadLine());
int[] a = new int[k];

Random rnd = new Random();
int c = 0;

for(int i = 0; i < k; i++)
{
    a[i] = rnd.Next(1000);
    Console.WriteLine($"a[{i}] = {a[i]}");
}

Console.WriteLine();
for (int i = 0; i < k / 2; i++)
{
    c = a[i];
    a[i] = a[k - i - 1];
    a[k - i - 1] = c;
}

for(int i = 0; i < k; i++)
{
    Console.WriteLine($"a[{i}] = {a[i]}");
}
*/


/*
int c = int.Parse(Console.ReadLine());
int[] a = new int[c];

Random rndm = new Random();


for (int i = 0; i < c; i++)
{
    a[i] = rndm.Next(100); 
    Console.WriteLine($"a[{i}] = {a[i]}");
}

int k = int.Parse(Console.ReadLine());

for (int i = 0; i < c; ++i)
{
    int aLast = a[k - 1];
    for (int j = k - 1; j > 0; j--)
    {
        a[j] = a[j - 1];
    }
    a[0] = aLast;
}

for (int i = 0; i < k; i++)
{
    Console.WriteLine($"a[{i}] = {a[i]}");
}
*/


/*
int c = int.Parse(Console.ReadLine());
int[] a = new int[c];

Random rndm = new Random();
bool fl = true;

for (int i = 0; i < c; i++)
{
    a[i] = rndm.Next(100);
    Console.WriteLine($"a[{i}] = {a[i]}");
}

for(int i = 0; i < c - 1; i++)
{
    if (a[i + 1] < a[i])
    {
        fl = false;
    }
}
if (fl)
    Console.WriteLine("Да, упорядочен");
else
    Console.WriteLine("Нет, не упорядочен");
*/


/*
int[] a = new int[] { 1, 2, 3, 4 };
int[] b = new int[] { 6, 7, 8, 8, 10, 12 };

var na = a.Length;
var nb = b.Length;

int[] c = new int[na + nb];

int i = 0, j = 0, k = 0;

while (i < na && j < nb)
{
    if (a[i] < b[j])
    {
        c[k++] = a[i++];
    }
    else
        c[k++] = b[j++];
}

if (i == na)       //закончился массив а
{
    for (i = j; i < nb; i++)
    {
        {
            c[k++] = b[i];
        }
    }
}
else               //закончился массив b
{
    for (j = i; j < na; j++)
    {
        c[k++] = a[j];
    }
}


for(i = 0; i < c.Length; i++)
{
    Console.WriteLine($"c[{i}] = {c[i]}");
}
*/


/*
int[] a = new int[] { 1, 1, 2, 3, 5, 8 };
int[] b = new int[] { 2, 5, 9, 11 };

int na = a.Length;
int nb = b.Length;

int[] c = new int[];
*/



/*
int n = 6, m = 6;

int[,] matr = new int[n, m];

Random r = new Random();
//int[][] mmas = new int[n][];
//for(int i = 0; i < n; i++)
//    mmas[i] = new int[r.Next(8)];



for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
        matr[i, j] = r.Next(100);


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{matr[i, j],4}");
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    int max = matr[i, 0];
    for (int j = 1; j < m; j++)
        if (max < matr[i, j])
            max = matr[i, j];
    Console.WriteLine($"{i} row - max = {max}");
}
for (int j = 0; j < m; j++)
{
    int min = matr[0, j];
    for (int i = 1; i < n; i++)
        if (min > matr[i, j])
            min = matr[i, j];
    Console.WriteLine($"{j} column - min = {min}");
}


for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < m; j++)
    {
        var t = matr[i, j];
        matr[i, j] = matr[j, i];
        matr[j, i] = t;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{matr[i, j],4}");
    Console.WriteLine();
}


//Console.WriteLine(matr.Rank);
//Console.WriteLine(matr.GetLength(0));
//Console.WriteLine(matr.GetLength(1));
*/




/*
int n = 3, m = 3;
Random r = new Random();
int[,] matr = new int[n, m];
 
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matr[i, j] = r.Next(100);
 
    }
}
 
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
 
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
 
        Console.Write($"{matr[m-1-j, i]} ");
    }
    Console.WriteLine();
}
 
 
 
 
int n = 3, m = 3, summa = 0;
Random r = new Random();
int[,] matr = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matr[i, j] = r.Next(100);
        if (i == 0 || j == 0 || i == (n - 1) || j == (m - 1))
        {
            summa += matr[i, j];
        }
    }
}
 
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
 
Console.WriteLine(summa);
 
int n = 3, m = 3;
int[,] matr = new int[n, m];
Random r = new Random();
 
int summ = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matr[i, j] = r.Next(100);
        if (i == j || (i == n - j - 1))
        {
            summ += matr[i, j];
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
*/

/*
int n = 3, m = 5;
int f = 5, k = 2;
int[,] matr = new int[n, m];
int[,] matr2 = new int[n, m];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matr[i, j] = r.Next(100);
    }
}

for (int i = 0; i < f; i++)
{
    for (int j = 0; j < k; j++)
    {
        matr2[i, j] = r.Next(100);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {

    }
}
*/



/*
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int[,] matrixA = new int[m, n];
int[,] matrixB = new int[n, k];
Random rand = new Random();



for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrixA[i, j] = rand.Next(10);
    }
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrixA[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {
        matrixB[i, j] = rand.Next(10);
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {
        Console.Write($"{matrixB[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] matrixC = new int[m, k];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < k; j++)
    {
        for (int v = 0; v < n; v++)
        {
            matrixC[i, j] += matrixA[i, v] * matrixB[v, j];
        }
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{matrixC[i, j]} ");
    }
    Console.WriteLine();
}
*/


/*
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
int c = 0;

Random rand = new Random();



for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(10);
    }
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();


for (int i = 0; i <= m - 2; i = i + 2)
{
    for (int j = 0; j < n; i++)
    {
        c = matrix[i, j];
        matrix[i, j] = matrix[i + 1, j];
        matrix[i + 1, j] = c;
    }
}
*/

int sum = 0;
int n = int.Parse(Console.ReadLine());
int[] massive = new int[n];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    massive[i] = random.Next(100);
    Console.WriteLine($"a[{i}] = {massive[i]}");
}

int max = int.MinValue;
int min = int.MaxValue;
int maxindex = 0;
int minindex = 0;

for (int i = 0; i < n; i++)
{
    if (massive[i] > max)
    {
        max = massive[i];
        maxindex = i;
    }
    if (massive[i] < min)
    {
        min = massive[i];
        minindex = i;
    }
}

if (maxindex > minindex)
{
    for (int i = minindex + 1; i < maxindex; i++)
    {
        sum += massive[i];
    }
}
else
{
    for (int i = maxindex + 1; i < minindex; i++)
    {
        sum += massive[i];
    }
}
Console.WriteLine(sum);