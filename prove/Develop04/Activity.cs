
abstract class Activity
{
    protected string _startingMessage;
    protected string _description;


    public Activity(string startingMessage, string description)
    {
        this._startingMessage = startingMessage;
        this._description = description;
    }

    public abstract void RunActivity(int timer);

    public virtual string DisplayActivity()
    {
        return _startingMessage + " \n\n" +
               _description + "\n\n"
               + "How long, in seconds, would you like for your session? ";
    }

    public abstract string DisplayFarewell(int timer);
}