namespace Labyrinth;

class Wall : Tile
{
    override public bool IsTraversable => false;
    public override void Pass() => throw new InvalidOperationException("Impossible de traverser un mur");
}
