
class NewWritingAssignment : Assignment

//I had to name this class like this due to an error with the namespace, I only know how to work with that in
//VS and not VS Code, that's why I called the class New.....

{
    private string _title;
    public NewWritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        this._title = title;
    }

    public string GetWritingInformation()
    {
        return this._title + " by " + base._studentName;
    }
}