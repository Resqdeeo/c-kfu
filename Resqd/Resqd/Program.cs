/*String str = "kabak omar uk ukrku";
bool fl = true;

foreach (var word in str.Split(' '))
{
    fl = true;
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - 1 - i])
        {
            fl = false;
        }
    }
    if (fl)
    {
        Console.WriteLine(word);
    }
}
*/



/*
String str = "kabak omaor uk ukraine";
bool flaggie = false;

foreach (var biggie in str.Split(' '))
{
    flaggie = false;
    for (int i = 1; i < biggie.Length; i++)
    {
        if (biggie[i] == biggie[0])
        {
            flaggie = true;
        }
    }
    if (flaggie)
    {
        Console.WriteLine(biggie);
    }
}
*/


/*
String str = "abcd omaor uk ukraine";
bool flaggie = false;

foreach (var biggie in str.Split(' '))
{
    flaggie = false;
    for (int i = 1; i < biggie.Length; i++)
    {
        if (biggie[i] >= biggie[i - 1])
        {
            flaggie = true;
        }
        else
        {
            flaggie = false;
            break;
        }
    }
    if (flaggie)
    {
        Console.WriteLine(biggie);
    }
}
*/