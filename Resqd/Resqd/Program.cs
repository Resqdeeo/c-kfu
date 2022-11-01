using System.Runtime.InteropServices;

int[] GenerateMas(int n)
{
    Random r = new Random();
    int[] mas = new int[n];
    for(int i = 0; i < n; i++)
    {
        mas[i] = r.Next(-100, 100);
    }
    return mas; 
}



void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($"{mas[i]} ");  
    Console.WriteLine();
}


void BubbleSort(int[] mas)
{
    //int n = mas.Length;
    //for(int k = n - 1; k > 0; k--)
    //    for(int i = 0; i < k; i++)
    //        if (mas[i] > mas[i + 1])
    //        {
    //            var t = mas[i];
    //            mas[i] = mas[i + 1];
    //            mas[i + 1] = t;
    //        }
    int n = mas.Length;
    bool fl = true;
    while(fl)
    {
        fl = false;
        for (int i = 0; i < n - 1; i++)
            if (mas[i] < mas[i + 1])
            {
                var t = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = t;
                fl = true;
            }      
    }
}


int GetMaxInd(int[] mas, int n)
{
    int iMax = 0;
    for (int i = 1; i < n; i++)
        if (mas[i] > mas[iMax])
            iMax = i;
    return iMax;
}


void TradeSort(int[] mas)
{
    int n = mas.Length;
    for (int k = n - 1; k > 0; k--)
    {
        var indexmax = GetMaxInd(mas, k);
        var t = mas[indexmax];
        mas[indexmax] = mas[k - 1];
        mas[k - 1] = t;
    }
    
}

int N = 20;
int[] arr = GenerateMas(N);
PrintMas(arr);
TradeSort(arr);
PrintMas(arr);