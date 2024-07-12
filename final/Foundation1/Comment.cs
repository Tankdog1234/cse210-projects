public class Comment
{
    //attributes
    private string _acct;
    private string _text;

    //constructor
    public Comment(string acct, string text)
    {
        _acct = acct;
        _text = text;
    }

    //methods
    public string GetAcct()
    {
        return _acct;
    }

    public string GetText()
    {
        return _text;
    }
}