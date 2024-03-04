using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new post
        StackOverflowPost newPost = new StackOverflowPost("C# Training Program", "Provide brief description of all C# concepts with practical examples.");

        newPost.UpVotePost();
        newPost.UpVotePost();
        newPost.UpVotePost();
        newPost.DownVotePost();
        newPost.UpVotePost();
        newPost.DownVotePost();
        Console.WriteLine("Tile of the post : {0} and Description : {1}" , newPost.Title, newPost.Description);
        Console.WriteLine("Current vote value: " + newPost.VoteCount);
    }
}

public class StackOverflowPost
{
    public string Title { get; }
    public string Description { get; }
    public DateTime CreationDateTime { get; }

    private int voteCount;

    public int VoteCount
    {
        get { return voteCount; }   //only able to get vote count publicly but not able to set it
    }

    public StackOverflowPost(string title, string description)
    {
        Title = title;
        Description = description;
        CreationDateTime = DateTime.Now;
        voteCount = 0;  //initialize default count in constructor
    }

    public void UpVotePost()
    {
        voteCount++;
    }

    public void DownVotePost()
    {
        voteCount--;
    }
}

