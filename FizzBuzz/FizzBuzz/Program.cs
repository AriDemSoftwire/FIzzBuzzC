// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;


string fizz = "Fizz";
string buzz = "Buzz";
string bang = "Bang";
string bong = "Bong";

for (int i = 0; i <= 260; i++)
{

    string[] printValue = new string[0];
    string finalValue = "";

    if (i % 3 == 0)
    {
        printValue = addWord(fizz, printValue);
    };
    if (i % 5 == 0)
    {
        printValue = addWord(buzz, printValue);
    };
    if (i % 7 == 0)
    {
        printValue = addWord(bang, printValue);
    };
    if (i % 11 == 0)
    {
        Array.Clear(printValue, 0, printValue.Length);
        printValue = addWord(bong, printValue);
    };
    if (i % 17 == 0)
    {
        Array.Reverse(printValue);
    }

    if (printValue.Length == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        foreach (string value in printValue)
        {
           finalValue += value;
        }
        Console.WriteLine(finalValue);
    }
}

static string[] addWord(string word, string[] original)
{
    return original = original.Append(word).ToArray();
}
