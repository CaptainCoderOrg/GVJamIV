using Spectre.Console;
namespace CosmicCruiseCatastrophe;

public class TitleScreen : IScreen
{

    public Task Display()
    {
        Console.Clear();
        AnsiConsole.Write(
            new FigletText("Gorachan")
                .Centered()
                .Color(Color.Red)
        );

        AnsiConsole.Write(
            new FigletText("in")
                .Centered()
                .Color(Color.Green)
        );

        AnsiConsole.Write(
            new FigletText("Cosmic Cruise")
                .Centered()
                .Color(Color.Aqua)
        );

        AnsiConsole.Write(
            new FigletText("Catastrophe")
                .Centered()
                .Color(Color.Orange1)
        );
        Inputs.GetAnyKeys();
        return Task.CompletedTask;
    }

    public IScreen Next() => new NameEntryScreen();
}
