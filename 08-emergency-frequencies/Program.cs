string signal = "CRIMSON";
signal = signal.ToUpper();
// TODO: Lag switch med kombinerte case-labels.
switch (signal)
{
    case "CRIMSON":
        Console.WriteLine("Evacuate deck");
        break;
    case "RED":
        Console.WriteLine("Evacuate deck");
        break;
    case "SCARLET":
        Console.WriteLine("Evacuate deck");
        break;
    case "AMBER":
        Console.WriteLine("Prepare crew");
        break;
    case "YELLOW":
        Console.WriteLine("Prepare crew");
        break;
        case "GREEN":
        Console.WriteLine("No emergency");
        break;
}
