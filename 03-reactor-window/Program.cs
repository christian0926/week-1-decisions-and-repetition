int energy = 50;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable = false;
if (energy > 39 && energy < 71)
{
    isStable = !isStable;
}

Console.WriteLine($"Reactor stable: {isStable}");
