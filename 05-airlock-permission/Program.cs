bool hasSuit = true;
int oxygenPercent = 54;
int pressure = 101;
bool alarmActive = true;

// TODO: Kombiner alle kravene i ett logisk uttrykk.
bool canOpenAirlock = hasSuit && !alarmActive && oxygenPercent > 30 && pressure > 90 && pressure < 110;

if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
