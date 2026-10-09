internal class Program
{
    private static void Main(string[] args)
    {
        int energy = -4;
        bool onof = false;
        string classification = "";

        // TODO: Sett classification med if / else if / else.
        if (energy == 0)
        {
            classification = "off";
        }
        else if (energy < 0)
        {
            classification = "?";
        }
        else if (energy > 0)
        {
            classification = "on";
        }
        answer(classification, onof);
        if (energy > 0){onof = true;}
        if (onof)
            {
            if (energy >= 40 && energy <= 70)
            {
                classification = "optimal";
            }
            else if (energy > 70)
            {
                classification = "too high";
            }
            else if (energy < 40)
            {
                classification = "too low";
            }
            answer(classification, onof);
        }
        static void answer(string classification, bool onof)
        {
            if (onof)
            {
                Console.WriteLine(classification);
            }
            else
            {
                Console.WriteLine($"Classification: {classification}");
            }
        }
    }
}