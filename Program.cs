// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Bitte geben einen Satz ein: ");
string text = Console.ReadLine();

for(int i = 0; i < text.Length; i++)
{
    if(i == 0)
    {
        Console.WriteLine(text);
    }
    else
    {
        Console.WriteLine(text[i]);
    }
}
Console.ReadKey();



Console.WriteLine("Bitte geben einen Text ein: ");
string text = Console.ReadLine();

if (IsPalindrome(text))
{
    Console.WriteLine(text + " ist ein Palindrom");
}
else
{
    Console.WriteLine(text + " ist kein Palindrom");
}

    static bool IsPalindrome(string text)
    {
        string reversed = "";
    
    
        for(int i = text.Length-1; i >= 0; i--)
        {
            reversed += text[i];
        }

        return reversed.ToLower() == text.ToLower();
    }
*/

Console.WriteLine("Bitte geben einen Text ein: ");
string text     = Console.ReadLine();
string newText = "";

foreach(char a in text)
{
    if (char.IsLetter(a))
    {
        newText += a;
    }
}

Console.WriteLine("Der neue Text: " + newText);

Console.ReadKey();