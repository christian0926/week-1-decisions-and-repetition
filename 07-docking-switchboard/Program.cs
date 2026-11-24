string dockingCode = "north";
string instruction = "";
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
    default:
        instruction = "Unknown docking code";
        break;
}
Console.WriteLine(instruction);
