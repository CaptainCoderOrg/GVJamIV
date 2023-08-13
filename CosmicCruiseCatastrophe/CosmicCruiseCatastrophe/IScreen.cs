namespace CosmicCruiseCatastrophe;

public interface IScreen
{
    public Task Display();
    public IScreen Next();
}
