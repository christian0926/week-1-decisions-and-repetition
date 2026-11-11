internal class Program
{
    private static void Main(string[] args)
    {
        int energy = 33;
        bool onof = false;
        string classification = "";

        // TODO: Sett classification med if / else if / else.
        if (energy == 0)
        {
            Console.WriteLine("off");
        }
        else if (energy < 0)
        {
            Console.WriteLine("?");
        }
        else if (energy > 0)
        {
            Console.WriteLine("on");
        }
        if (energy > 0){onof = true;}
        if (onof)
            {
            if (energy < 20)
            {
                classification = "dormant";
            }
            if (energy >= 20 && energy < 50)
            {
                classification = "stabil";
            }
            if (energy >= 50 && energy < 80)
            {
                classification = "unstable";
            }
            else if (energy > 80)
            {
                classification = "critical";
            }
            answer(classification, onof);
        }
        static void answer(string classification, bool onof)
        {
            if (onof)
            {
                Console.WriteLine ($"Classification: {classification}");
            }
            else
            {
                Console.WriteLine(classification);
            }
        }
    }
}