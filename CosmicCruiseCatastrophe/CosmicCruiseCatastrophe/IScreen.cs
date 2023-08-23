namespace CosmicCruiseCatastrophe;

public interface IScreen
{
    public string ScreenName { get; }
    public Task Display();
    public IScreen Next();
}
