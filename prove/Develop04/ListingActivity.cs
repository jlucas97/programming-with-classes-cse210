
class ListingActivity : Activity
{
    public ListingActivity() : base("Welcome to the Listing Activity", "This activity will help you reflect on " +
     "the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public override void RunActivity(int timer)
    {
        throw new NotImplementedException();
    }

    public override string DisplayActivity()
    {
        return base.DisplayActivity();
    }

    public override string DisplayFarewell(int timer)
    {
        throw new NotImplementedException();
    }
}
