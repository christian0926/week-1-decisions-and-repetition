int cargoWeight = 810;
int maxWeight = 801;
int containerCount = 4;
int expectedContainers = 4;

// TODO: Erstatt false med riktige sammenligningsuttrykk.
bool isOverweight = false;
bool isExactlyAtLimit = false;
bool hasContainers = false;
bool countDiffersFromExpected = false;
if (cargoWeight > maxWeight)
{
    isOverweight = true;
}
if (cargoWeight == maxWeight)
{
    isExactlyAtLimit = true;
}
if (containerCount > 0)
{
    hasContainers = true;
}
if (expectedContainers == containerCount)
{
    countDiffersFromExpected = true;
}
Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
