
abstract class Activity
{
    protected string _startingMessage;
    protected string _description;
    protected int _durationInSeconds;
    protected string endingMessage;

    public Activity(string startingMessage, string description)
    {
        this._startingMessage = startingMessage;
        this._description = description;
    }

    public virtual string DisplayActivity()
    {
        return _startingMessage + " \n\n" +
               _description + "\n\n"
               + "How long, in seconds, would you like for your session? ";
    }
}