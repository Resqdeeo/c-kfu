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