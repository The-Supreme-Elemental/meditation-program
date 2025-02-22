using System.ComponentModel.Design;

public class Activity
{
    protected int _duration;
    protected string _message;
    protected string _desc;

    public Activity(string titleParam, string descParam)
    {
        _message = titleParam;
        _desc = descParam;
    }
    public void GetDuration()
    {
        Console.Write("How much time would you like to devote to this activity, in seconds? \n\n");
        _duration = int.Parse(Console.ReadLine());
    }

    public void InteractPrologue()
    {
        
        Console.WriteLine($"{_message}");
    }

    public void InteractEpilogue()
    {
        Console.WriteLine("Thank you for participating. I hope this helped!");
    }

    public static string Menu()
    {
        Console.WriteLine("Please choose an option:\n1. Start breathing Activity\n2. Start reflecting Activity\n3. Start listing Activity\n4. Quit. ");
        string choice = Console.ReadLine();
        return choice;
    }

    public void Run()
    {
        GetDuration();
        Console.WriteLine("Get ready...");
        makeAnimation(3);
    }

    public void makeAnimation(int times, List<string> frames = null, int pauseTime = 250) 
    {
        frames ??= ["-", "\\", "|", "/"];
        for (var i = 0; i<times; i++) {
            foreach(var frame in frames) {
                Console.Write(frame);
                Thread.Sleep(pauseTime);
                Console.Write("\b \b");
            }

        }
    }




}