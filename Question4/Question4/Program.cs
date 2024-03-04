using System;

public class Post
{
    private string title;
    private string description;
    private DateTime created;
    private int votes;

    // Constructor to initialize the post
    public Post(string title, string description)
    {
        this.title = title;
        this.description = description;
        created = DateTime.Now;
        votes = 0; // Initialize votes to 0
    }

    // Method to up-vote the post
    public void UpVote()
    {
        votes++;
    }

    // Method to down-vote the post
    public void DownVote()
    {
        votes--;
    }

    // Method to display the current vote value
    public void DisplayCurrentVotes()
    {
        Console.WriteLine($"Current votes for post '{title}': {votes}");
    }

    // Main method to test the Post class
    public static void Main(string[] args)
    {
        // Create a new post
        Post post = new Post("Title of the Post", "Description of the Post");

        // Up-vote and down-vote the post a few times
        post.UpVote();
        post.UpVote();
        post.DownVote();
        post.UpVote();
        post.DownVote();

        // Display the current vote value
        post.DisplayCurrentVotes();
    }
}
