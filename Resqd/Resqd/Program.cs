/*int ArrSum(ref int[] mas)
{
    int s = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        s += mas[i];
    }
    mas = new int[5] { 1, 1, 1, 1, 1 };
    return s;
}


int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine(ArrSum(ref arr));


foreach (int k in arr)
{
    Console.WriteLine(k);                      
}
*/

/*
List<char> lst = new List<char>();
Dictionary<char, int> symbols = new Dictionary<char, int>();


using (StreamReader reader = new StreamReader(@"D:\Temp\text.txt"))
{
    var str = reader.ReadToEnd();
    foreach(char ch in str)
    {
        if(Char.IsLetter(ch))
        {
            if (!lst.Contains(ch))
            {
                lst.Add(ch);
            }
            if(!symbols.Keys.Contains(ch))
            {
                symbols.Add(ch, 1);
            }
            else
            {
                int k = symbols[ch];
                symbols[ch] += 1;
            }
        }
    }
}

foreach(var ch in lst)
{
    Console.Write(ch);
}

foreach(char ch in symbols.Keys)
{
    Console.WriteLine($"{ch} - {symbols[ch]}");
}


foreach(var k in symbols.Values)
{
    Console.WriteLine(k);
}
*/





using (StreamReader reader = new StreamReader(@"D:\Temp\wordscnt.txt"))
{
    string words = await reader.ReadToEndAsync();
    string[] count = words.Split(new char[] { ' ', '?', '\n', ',', '.', '\t', '\r'  },StringSplitOptions.RemoveEmptyEntries);
    foreach(var item in count)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine(count.Length);
}
