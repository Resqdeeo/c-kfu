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

//ДОДЕЛАТЬ ДОМА!!!!!!!!!!!!

using System.Diagnostics;

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


