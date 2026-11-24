int cargoWeight = 810;
int maxWeight = 801;
int containerCount = 4;
int expectedContainers = 4;

// TODO: Erstatt false med riktige sammenligningsuttrykk.
bool isOverweight = cargoWeight > maxWeight;
bool isExactlyAtLimit = cargoWeight == maxWeight;
bool hasContainers = containerCount > 0;
bool countDiffersFromExpected = expectedContainers == containerCount;
Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
