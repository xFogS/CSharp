using Animals;

public class Program
{
    static void Main(string[] args)
    {
        OnTheEarth[] earth =
        {
            new Cat(),
            new Dog(),
            new Hamster(),
            new HermitСrab()
        };

        Bird[] birds =
        {
            new Eagle(),
            new Parrot(),
            new Magpie(),
            new Swallow(),
        };

        Fish[] fish =
        {
            new Crab(),
            new Jellyfish(),
            new Oysters(),
            new Shark(),
        };

        foreach (var item in earth) { item.Voice(); }
        foreach (var item in birds) { item.Voice(); }
        foreach (var item in fish) { item.Voice(); }
    }
}
