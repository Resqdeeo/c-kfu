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

while (y < Math.Pow(Math.E, x))
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
*/


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
