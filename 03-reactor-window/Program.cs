int energy = 50;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable = energy > 39 && energy < 71;

Console.WriteLine($"Reactor stable: {isStable}");
