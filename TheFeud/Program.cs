using System;
using Flame;
using Frost;
using FlamePig = Flame.Pig;
using FrostPig = Frost.Pig;

Sheep sheep = new Sheep();
Cow cow = new Cow();
FlamePig flamePig = new FlamePig();
FrostPig frostPig = new FrostPig();

Console.WriteLine(sheep);
Console.WriteLine(cow);
Console.WriteLine(flamePig);
Console.WriteLine(frostPig);


namespace Flame
{
    public class Sheep { }
    public class Pig { }
}

namespace Frost
{
    public class Cow { }
    public class Pig { }
}
