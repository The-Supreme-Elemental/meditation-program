using System;

class Program
{
    static void Main(string[] args)
    {

        string menu = Activity.Menu();
        switch(menu)
        {
            case "1": //Breathing
                Breathing breathing = new("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.Run();
                breathing.InteractBreathing();
                breathing.InteractEpilogue();
                break;
            case "2": //Reflecting
                Reflection reflection = new("Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflection.Run();
                reflection.InteractReflection();
                reflection.InteractEpilogue();
                break;
            case "3": //Listing
                Listing listing = new("Welcome to the Listing Activity!", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.Run();
                listing.InteractListing();
                listing.InteractEpilogue();
                break;
            case "4": //Quit
                break;
        }
    }


}