namespace Labyrinth;

class Wall : Tile
{
    override public bool IsTraversable { get; } = false;
    override public void Pass()
    {
        if (!IsTraversable) { throw new NotTraversableException(); }
    }
}
