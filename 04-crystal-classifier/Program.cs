internal class Program
{
    private static void Main(string[] args)
    {
        int energy = 80;
        string classification = "";

        // TODO: Sett classification med if / else if / else.
        if (energy == 0)
        {
            Console.WriteLine("off");
        }
        else if (energy < 0)
        {
            Console.WriteLine("error");
        }
        else
        {
            Console.WriteLine("on");
            if (energy < 20)
            {
                classification = "dormant";
            }
            else if (energy >= 20 && energy < 50)
            {
                classification = "stabil";
            }
            else if (energy >= 50 && energy < 80)
            {
                classification = "unstable";
            }
            else if (energy >= 80)
            {
                classification = "critical";
            }
            answer(classification);
         }
        static void answer(string classification)
        {
        Console.WriteLine ($"Classification: {classification}");
        }
    }
}