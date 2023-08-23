using System.Text;
using Spectre.Console;

namespace CosmicCruiseCatastrophe;

public static class Constants
{
    public const string PlayerName = "Gorachan";
    public const string Elevator = "Stellavator";
    // public const string Elevator = "Movement Shaft";
    // public const string Elevator = "Up 'N Downer";
    // public const string Elevator = "Warp Tunnel";

    public static string Colorify(this string original)
    {
        // ROYGBIV
        string[] colors = {"red", "olive", "yellow", "lime", "aqua", "fuchsia", "purple"};
        StringBuilder builder = new ();
        int ix = 0;
        foreach (char ch in original)
        {
            builder.Append($"[{colors[ix++ % colors.Length]}]{ch}[/]");
        }
        return builder.ToString();
    }
}
