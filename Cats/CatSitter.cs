namespace Cats;

public class CatSitter
{
    public IFeedable Pet { get; set; }

      public CatSitter(IFeedable pet) : base(pet)
      {
         Pet = pet;
      }

      public void FeedTheCat() 
      {

         // ...code to prepare the cat's meal...

         Pet.Eat();
      }
}
