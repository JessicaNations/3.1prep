/* Store the first sentence of Alice's Adventures in Wonderland in a string.
Prompt the user for a string to search for within this string. 
Print True or False. Make the search case-INsensitive. 
https://docs.microsoft.com/en-us/dotnet/csharp/language- reference/keywords/bool */

public static string getBetween(string strSource, string strStart, string strEnd)
{
    int Start, End;
    string text = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: " +
        "once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, " +
        "'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
    string data = getBetween(text, "Alice", "conversation");
    if (strSource.Contains(strStart) && strSource.Contains(strEnd))
    {
        Start = strSource.IndexOf(strStart, 0) + strStart.Length;
        End = strSource.IndexOf(strEnd, Start);
        return strSource.Substring(Start, End - Start);
    }
    else
    {
        return "";
    }
}