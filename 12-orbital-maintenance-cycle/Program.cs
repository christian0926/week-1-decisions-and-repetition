for (int cycle = 1; cycle <= 30; cycle++)
{
    // TODO: Skriv riktig resultat for cycle.
    Console.WriteLine(cycle);
    if (cycle % 4 == 0 && cycle % 6 == 0)
    {
        Console.WriteLine("FULL SERVICE");
    }
    if (cycle % 4 == 0 && cycle % 6 != 0)
    {
        Console.WriteLine("FILTER CHECK");
    }
    if (cycle % 6 == 0 && cycle % 4 != 0)
    {
        Console.WriteLine("THRUSTER CHECK");
    }
}
