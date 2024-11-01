public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding your breathing in and out slowly.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        int elapsed = 0;
        
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);
            Console.WriteLine("Breathe out...");
            ShowSpinner(2);
            elapsed += 4;
        }
        
        DisplayEndMessage();
    }
}
