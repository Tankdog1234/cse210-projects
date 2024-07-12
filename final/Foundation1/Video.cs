using System.ComponentModel.DataAnnotations;
using System.Transactions;

public class Video
{
    private string _name;
    private string _creator;
    private int _time;
    private List<Comment> _comments;


    public Video(string name, string creator, int time)
    {
        _name = name;
        _creator = creator;
        _time = time;
        _comments = new();
    }


    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count();
    }

    public void DisplayComments()
    {
        Console.WriteLine($"Title: {_name} | from {_creator} ~~ Length: {_time} sec\n");
        Console.WriteLine($"Number of Comments: {CountComments()}");
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Account: {_comments[i].GetAcct()}");
            Console.WriteLine(_comments[i].GetText());
        }
    }
}