using System;

Color[] Colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
Rank[] Ranks = new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.Dollar, Rank.Percent, Rank.Caret, Rank.Ampersand };

foreach (Color color in Colors)
{
    foreach (Rank rank in Ranks)
    {
        Card card = new Card(color, rank);
        Console.WriteLine($"The {card.Color} {card.Rank}");
    }
}

public class Card
{
    Rank[] Faces = new Rank[] { Rank.Dollar, Rank.Percent, Rank.Caret, Rank.Ampersand };

    public Color Color { get; }
    public Rank Rank { get; }

    public bool IsNumberCard => !IsFaceCard;

    public bool IsFaceCard
    {
        get
        {
            foreach (Rank r in Faces)
            {
                if (Rank == r)
                    return true;
            }
            return false;
        }
    }

    public Card(Color color, Rank rank)
    {
        Color = color;
        Rank = rank;
    }

}

public enum Color { Red, Green, Blue, Yellow}
public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand}
