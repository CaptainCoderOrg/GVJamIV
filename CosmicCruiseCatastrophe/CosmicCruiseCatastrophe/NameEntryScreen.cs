using Spectre.Console;

namespace CosmicCruiseCatastrophe;

public class NameEntryScreen : IScreen
{
    public async Task Display()
    {
        AnsiConsole.Clear();

        // Chat GPT Prompt
        // You are boarding a galactic cruise ship. As you are boarding you are greeted by a staff member who asks your name.
        // Generate a description in 2nd person for a text adventure game describing this.

        await IDialogRenderer.Default.Render("""
        Stepping onto the galactic cruise ship, a staff member in a sleek uniform approaches with a warm smile. 
        Their sapphire eyes lock onto yours as they extend a hand to greet you. "Welcome aboard," they say in a 
        harmonious voice, requesting your name for registration. 
        """);

        do
        {
            GetName();
        } while (! AnsiConsole.Confirm($"Are you sure your name is {Constants.PlayerName}?", false));
        
        AnsiConsole.Clear();
        await IDialogRenderer.Default.Render("""
        As you share your name, they record it on
        a holographic tablet, the ship's logo glimmering in the background. With a nod,
        they invite you to explore the ship's interior, promising an adventure-filled
        journey ahead.
        """);

        Inputs.GetAnyKeys();

    }
    
    public static void GetName()
    {
        AnsiConsole.Write("Enter your name: ");
        int inputs = 0;
        while (inputs < Constants.PlayerName.Length)
        {
            Console.ReadKey(true);
            AnsiConsole.Write(Constants.PlayerName[inputs]);
            inputs++;
        }
        Console.ReadKey(true);
        AnsiConsole.Write("\n\n");

    }

    public IScreen Next()
    {
        return null;
    }
}
