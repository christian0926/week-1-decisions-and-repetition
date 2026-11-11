string dockingCode = "north";
string instruction = "Unknown docking code";
dockingCode = dockingCode.ToUpper();

// TODO: Bruk switch statement til å sette instruction.
switch (dockingCode) {
    case "SERVICE":
        instruction = "dock at matinance bay";
        break;
    case "NORTH":
        instruction = "dock at gate 1";
        break;
    case "EAST":
        instruction = "dock at gate 2";
        break;
    case "CLOSED":
        instruction = "hold position";
        break;
}
Console.WriteLine(instruction);
