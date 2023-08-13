using System.Text;

namespace CosmicCruiseCatastrophe;

public class DialogSplitter
{
    public static DialogSplitter Default { get; } = new DialogSplitter(80);
    public DialogSplitter(int maxLength) => MaxLength = maxLength;
    public int MaxLength { get; }

    public IEnumerable<string> Split(string toSplit)
    {
        IEnumerable<string> tokens = toSplit.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
        List<string> lines = new ();
        StringBuilder builder = new ();
        foreach (string token in tokens)
        {
            if (builder.Length + token.Length >= MaxLength)
            {
                lines.Add(builder.ToString().Trim());
                builder.Clear();                
            }
            builder.Append($"{token} ");
        }
        lines.Add(builder.ToString().Trim());
        return lines;
    }

}
