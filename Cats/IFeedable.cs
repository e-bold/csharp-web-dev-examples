namespace Cats;

public interface IFeedable
{
    void Eat();
    void Nap()
    {
        Console.WriteLine("snooooze");
    }

}
