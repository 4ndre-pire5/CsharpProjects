// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] phrase = pangram.Split(' ');

// string[] newPhrase = new string[phrase.Length];

// for (int i = 0; i < phrase.Length; i++)
// {
//     char[] letters = phrase[i].ToCharArray();
//     Array.Reverse(letters);
//     newPhrase[i] = new string(letters);
// }

// string result = String.Join(" ", newPhrase);
// Console.WriteLine(result);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] arrayId = orderStream.Split(',');
Array.Sort(arrayId);

for (int i = 0; i < arrayId.Length; i++)
{
    if (arrayId[i].Length != 4)
    {
        Console.WriteLine($"{arrayId[i]} \t- Error");
    }
    else
    {
        Console.WriteLine(arrayId[i]);
    }
}







