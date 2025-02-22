using System.Runtime.CompilerServices;

class Breathing : Activity
{
    public Breathing(string titleParam, string descParam) : base(titleParam, descParam)
    {

    }

    public void InteractBreathing()
    {
        Console.WriteLine("We will now commence the breathing activity! \n\nPlease follow the instructions shown below. \n\n");

        DateTime time = DateTime.Now;
        DateTime futureTime = time.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in through your nose....\n");
            makeAnimation(5, null, 250);

            Console.WriteLine("Breathe out through your mouth....\n");
            makeAnimation(5, null, 250);
        }
        // for (int i = 0; i < 4; i++)
        // {
        //     makeAnimation(_duration, null, _duration);
        //     Console.WriteLine("Breathe in through your nose....\n");
        //     Thread.Sleep(_duration / 4);

        //     makeAnimation(_duration, null, _duration);
        //     Console.WriteLine("Breathe out through your mouth....\n");
        //     Thread.Sleep(_duration / 4);
        // }

    }


}