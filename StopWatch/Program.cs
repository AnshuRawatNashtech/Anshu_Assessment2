using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        var stopWatch = new Stopwatch();
        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter start/stop to start or stop the stopwatch respectively.");
            Console.WriteLine("To exit from stop watch press enter without any input");
            var stopWatchInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(stopWatchInput) && stopWatchInput.ToLower() == "start")
            {
                stopWatch.Start();
            }
            else if (!string.IsNullOrWhiteSpace(stopWatchInput) && stopWatchInput.ToLower() == "stop")
            {
                stopWatch.Stop();
            }
            else
            {
                break;
            }


        }

    }
}

public class Stopwatch
{
    private DateTime StartTime { get; set; }
    private DateTime StopTime { get; set; }

    public void Start()
    {
        if (StartTime == DateTime.MinValue)
        {
            StartTime = DateTime.Now;
            Console.WriteLine("Stop watch started at {0}", StartTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
        else
        {
            Console.WriteLine("Stopwatch is already running");
            throw new InvalidOperationException("Stopwatch is already running");
        }
    }

    public void Stop()
    {
        if (StartTime != DateTime.MinValue)
        {
            StopTime = DateTime.Now;
            Console.WriteLine("Stop watch stopped at {0}", StopTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            TimeSpan duration = StopTime - StartTime;
            Console.WriteLine("You stopped after {0}", duration);
            StartTime = DateTime.MinValue;
        }
        else
        {
            Console.WriteLine("Stopwatch can't be stopped: start it first.");
        }
    }




}