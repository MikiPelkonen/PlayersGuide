using System;

Tree tree = new();
Announcer announcer = new Announcer(tree);
Harvester harvester = new Harvester(tree);

while (true)
    tree.TryGrow();

public class Tree
{
    public event Action TreeRipened;

    private Random _random = new Random();
    public bool Ripe { get; set; }

    public void TryGrow()
    {
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            TreeRipened?.Invoke();
        }
    }
}

public class Harvester
{
    private int _ripenTimes = 0;
    private Tree _tree;
    
    private void Harvest()
    {
        _tree.Ripe = false;
        _ripenTimes++;
        Console.WriteLine($"The tree has been harvested {_ripenTimes} times.");
    }
    public Harvester(Tree tree)
    {
        _tree = tree;
        _tree.TreeRipened += Harvest;
    }
}

public class Announcer
{
    private void OnTreeRipened() => Console.WriteLine("The tree is ripe!");

    public Announcer(Tree tree)
    {
        tree.TreeRipened += OnTreeRipened;
    }
}
