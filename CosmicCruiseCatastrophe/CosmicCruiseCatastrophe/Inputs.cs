using Spectre.Console;
namespace CosmicCruiseCatastrophe;

public static class Inputs
{

    public static void GetAnyKeys()
    {
        AnsiConsole.Write(new Text("Press the Any keys to continue").Centered());
        HashSet<char> keys = new HashSet<char>();
        int count = 0;
        while(!keys.ContainsAnyKeys())
        {
            char ch = Console.ReadKey(true).KeyChar;
            if (!ch.IsAnyKey())
            {
                AnsiConsole.Write("Nope ");
                keys.Clear();
                count++;
                if (count % 10 == 0)
                {
                    AnsiConsole.WriteLine("The - A N Y - keys!");
                }
            }
            else
            {
                keys.Add(ch);
            }            
        }
    }

    private static bool ContainsAnyKeys(this HashSet<char> keys) => keys.Contains('a') && keys.Contains('n') && keys.Contains('y');
    private static bool IsAnyKey(this char ch) => "any".Contains(char.ToLower(ch));

}
