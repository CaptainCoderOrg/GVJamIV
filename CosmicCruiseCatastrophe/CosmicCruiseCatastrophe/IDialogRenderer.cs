using Spectre.Console;
namespace CosmicCruiseCatastrophe;

public interface IDialogRenderer
{
    public static IDialogRenderer Default { get; set; } = new DefaultDialogRenderer();
    public Task Render(params string[] text);
}

internal class DefaultDialogRenderer : IDialogRenderer
{
    public async Task Render(params string[] paragraphs)
    {
        foreach(string text in paragraphs)
        {
            foreach(string line in DialogSplitter.Default.Split(text))
            {
                foreach (char ch in line)
                {
                    AnsiConsole.Write(ch);
                    await Task.Delay(1);
                }
                AnsiConsole.WriteLine();
            }
            AnsiConsole.WriteLine();
        }
    }
}