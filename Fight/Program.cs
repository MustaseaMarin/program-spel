int heroHp = 100;
int villainHp = 100;

string heroName = "Mustasea Marin";
string villainName = "mustafas";

while (heroHp > 0 && villainHp > 0)
{
    Console.WriteLine("\n----- ===== EN NY RUNDA ===== -----");
    Console.WriteLine($"{heroName}: {heroHp} {villainName}: {villainHp}-\n");

    int heroDamage = Random.Shared.Next(20);
    int villainDamage = Random.Shared.Next(20);

    heroHp -= villainDamage;
    heroHp = Math.Max(0, heroHp);

    villainHp -= heroDamage;
    villainHp = Math.Max(0,villainHp);
    Console.WriteLine($"{villainName} gör {villainDamage} skada på {heroName}");

    Console.WriteLine("Press anywhere to continue.");
    Console.ReadKey();
}

Console.WriteLine("\n---- ==== The Round is Over ==== ----");

if (heroHp == 0 && villainHp == 0)
{
    Console.WriteLine("Tie");
}
else if (heroHp == 0)
{
    Console.WriteLine($"{villainName} won!");
}
else
{
    Console.WriteLine($"{heroName} won!");
}

Console.WriteLine("Press anywhere to end.");
Console.ReadKey();
