bool hasSuit = true;
int oxygenPercent = 21;
int pressure = 98;
bool alarmActive = false;

// TODO: Kombiner alle kravene i ett logisk uttrykk.
bool canOpenAirlock = false;
if (hasSuit && !alarmActive && oxygenPercent > 19.5 && pressure > 90 && pressure < 110)
{
    canOpenAirlock = !canOpenAirlock;
}

if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
