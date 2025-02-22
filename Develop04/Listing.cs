using System.Security.Cryptography.X509Certificates;

class Listing : Activity
{
    public Listing(string titleParam, string descParam) : base(titleParam, descParam)
    {

    }

    public void InteractListing()
    {
        Console.WriteLine("Please list as many responses as you can to the following prompt.");

        List<string> listPrompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"

        };
        Random random = new Random();
        int number = random.Next(listPrompts.Count());
        string prompt = listPrompts[number];
        Console.WriteLine(listPrompts[number]);

        DateTime time = DateTime.Now;
        DateTime futureTime = time.AddSeconds(_duration);

        List<string> entries = new List<string>();
        while (DateTime.Now < futureTime)
        {
            Console.Write(">");
            string entry = Console.ReadLine();
            entries.Add(entry);
        }
        number = entries.Count();
        Console.WriteLine($"You listed {number} items. ");



    }

}