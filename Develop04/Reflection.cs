class Reflection : Activity
{
    public Reflection(string titleParam, string descParam) : base(titleParam, descParam)
    {

    }

    public void InteractReflection()
    {
        List<string> prompts = new List<string>()
        {
            "Think of a time you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."

        };

        Random random = new Random();
        int number = random.Next(prompts.Count());
        string prompt = prompts[number];
        Console.WriteLine(prompts[number]);

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Thread.Sleep(5);
        Console.Clear();


        List<string> reflectPrompts = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        DateTime time = DateTime.Now;
        DateTime futureTime = time.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            random = new Random();
            number = random.Next(reflectPrompts.Count());
            prompt = reflectPrompts[number];
            Console.WriteLine(reflectPrompts[number]);
            makeAnimation(15, null, 250);
        }
    }


}