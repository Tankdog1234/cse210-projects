using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        string[] titles = {"How to YouTube", "A crash course on calculus", "Relaxing painting with instrumental music"};
        string[] creators = {"MumboJumbo", "pcGaming65", "BobRoss"};
        int[] time = {125, 220, 378};
        string[] accts = {"Todd76", "trelloBlazer", "Bob", "CharlesBrown45", "MumboJumbo", "Grian", "The Organic Chemistry Tutor", "Kool-Aid Man", "tankdog1234"};
        string[] comms = {"This video rocks", "Can you please give me a shoutout on your channel?", "This didn't work for me", "This song is still stuck in my head hours later", "Nice video", "I wish I was that talented", "Could you hold the camera a little more steady in your next video?", "That's some awesome scenery!", "I think I'm seriously addicted to this channel"};
        List<Comment> commList = new();

        //create list of comments with their required data
        for(int i = 0; i < 9; i++)
        {
            commList.Add(new Comment(accts[i], comms[i]));
        }

        //create list of videos with comments
        int x = 0;
        for(int i = 0; i < 3; i++)
        {
            videos.Add(new Video(titles[i], creators[i], time[i]));
            for(int j = 0; j < 3; j++)
            {
                videos[i].AddComments(commList[x]);
                x++;
            }
        }

        //display videos w/ comments
        foreach(Video video in videos)
        {
            video.DisplayComments();
            Console.WriteLine("\n");
        }
    }
}