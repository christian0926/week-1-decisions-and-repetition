string signal = "green";
signal = signal.ToUpper();
void c(string signal)
{
    Console.WriteLine(signal);
}
// TODO: Lag switch med kombinerte case-labels.
switch (signal)
{
    case "CRIMSON":
        c("Evacuate deck");
        break;
    case "RED":
        c("Evacuate deck");
        break;
    case "SCARLET":
        c("Evacuate deck");
        break;
    case "AMBER":
        c("Prepare crew");
        break;
    case "YELLOW":
        c("Prepare crew");
        break;
    case "GREEN":
        c("No emergency");
        break;
    default:
        c("Unknown signal");
        break;
}
