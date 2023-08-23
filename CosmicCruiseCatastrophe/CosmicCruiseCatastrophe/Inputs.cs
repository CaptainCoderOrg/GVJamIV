using Spectre.Console;
using Spectre.Console.Rendering;

namespace CosmicCruiseCatastrophe;

public static class Inputs
{

    public static void PressAnyKeys()
    {
        // AnsiConsole.MarkupLine()
        
        IRenderable markup = new Markup("Press the ANY keys to continue").Centered();
        // AnsiConsole.Markup(new Markup("Press the ANY keys to continue").Centered());
        AnsiConsole.Write(markup);
        AnsiConsole.WriteLine();
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
                if (count % 3 == 0)
                {
                    AnsiConsole.WriteLine("\nThe - A N Y - keys!");
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
