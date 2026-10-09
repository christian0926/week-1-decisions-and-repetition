string dockingCode = "SERVICE";
string instruction = "";

// TODO: Bruk switch statement til å sette instruction.
switch (dockingCode) {
    case "SERVICE":
        instruction = "maskinen får service";
        break;
    case "noe":
        instruction = "noe";
        break;
}
Console.WriteLine(instruction);
