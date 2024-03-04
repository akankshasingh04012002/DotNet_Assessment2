using System;

class Program
{
    static void Main(string[] args)
    {
        Post post = new Post();

        Console.WriteLine("Enter the names of people who liked your post (press Enter to finish):");

        // Continuously ask the user to enter names until they press Enter
        while (true)
        {
            string input = Console.ReadLine();

            // If the user presses Enter without supplying a name, break out of the loop
            if (string.IsNullOrEmpty(input))
                break;

            post.AddLike(input);
        }

        Console.WriteLine(post.GetLikeMessage());
    }
}

public class Post
{
    private string[] likes;
    private int count;

    public Post()
    {
        likes = new string[10]; // Starting with an initial capacity of 10
        count = 0;
    }

    public void AddLike(string name)
    {
        if (count < likes.Length)
        {
            likes[count] = name;
            count++;
        }
        else
        {
            // If the array is full, resize it by creating a new array with double the capacity
            string[] newLikes = new string[likes.Length * 2];
            Array.Copy(likes, newLikes, likes.Length);
            likes = newLikes;

            // Add the new like
            likes[count] = name;
            count++;
        }
    }

    public string GetLikeMessage()
    {
        if (count == 0)
        {
            return "No one likes your post.";
        }
        else if (count == 1)
        {
            return $"{likes[0]} likes your post.";
        }
        else if (count == 2)
        {
            return $"{likes[0]} and {likes[1]} like your post.";
        }
        else
        {
            int otherPeopleCount = count - 2;
            return $"{likes[0]}, {likes[1]} and {otherPeopleCount} others like your post.";
        }
    }
}
