using System;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        // Start the stopwatch
        stopwatch.Start();

        // Waiting for user input
        Console.WriteLine("Press any key to stop the stopwatch...");
        Console.ReadKey(true);

        // Stop the stopwatch
        stopwatch.Stop();

        // Display the duration
        TimeSpan duration = stopwatch.GetDuration();
        Console.WriteLine($"Duration: {duration.TotalSeconds} seconds");
    }
}

public class Stopwatch
{
    private DateTime startTime;
    private DateTime stopTime;
    private bool isRunning;

    public void Start()
    {
        if (isRunning)
        {
            throw new InvalidOperationException("Stopwatch is already running.");
        }

        startTime = DateTime.Now;
        isRunning = true;
    }

    public void Stop()
    {
        if (!isRunning)
        {
            throw new InvalidOperationException("Stopwatch is not running.");
        }

        stopTime = DateTime.Now;
        isRunning = false;
    }

    public TimeSpan GetDuration()
    {
        if (!isRunning)
        {
            return stopTime - startTime;
        }
        else
        {
            throw new InvalidOperationException("Stopwatch is still running.");
        }
    }
}
