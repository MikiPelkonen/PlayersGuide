using System;

Sword original = new Sword(Material.Iron, Gemstone.None, 15, 3);
Sword firstVariation = original with { material = Material.Steel, gemstone = Gemstone.Amber };
Sword secondVariation = original with { length = 25, guardWith = 5, material = Material.Bronze };

Console.WriteLine(original);
Console.WriteLine(firstVariation);
Console.WriteLine(secondVariation);

public record Sword(Material material, Gemstone gemstone, int length, int guardWith);

public enum Gemstone { None, Emerald, Amber, Sapphire, Diamond, Bitstone }
public enum Material { Wood, Bronze, Iron, Steel, Binarium }