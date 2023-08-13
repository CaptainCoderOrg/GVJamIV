using Shouldly;
using CosmicCruiseCatastrophe;
namespace CosmicCruiseCatastrphe.Tests;

public class DialogSplitterTests
{
    [Fact]
    public void test_split()
    {
        // Triple A testing: (AAA)
        // Arrange
        DialogSplitter splitter = new DialogSplitter(80);

        // Act
        string[] lines = splitter.Split(
        """
        Stepping onto the galactic cruise ship, a staff member in a sleek uniform approaches with a warm smile. 
        Their sapphire eyes lock onto yours as they extend a hand to greet you. "Welcome aboard," they say in a 
        harmonious voice, requesting your name for registration.
        """).ToArray();

        // Assert
        lines[0].ShouldBe("Stepping onto the galactic cruise ship, a staff member in a sleek uniform");
        lines[1].ShouldBe("approaches with a warm smile. Their sapphire eyes lock onto yours as they");
        lines[2].ShouldBe("extend a hand to greet you. \"Welcome aboard,\" they say in a harmonious voice,");
        lines[3].ShouldBe("requesting your name for registration.");
    }
}