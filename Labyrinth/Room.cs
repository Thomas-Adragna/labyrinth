

namespace Labyrinth;

internal class Room : Tile
{
    Collectable? Item { get; set; }
    override public bool IsTraversable { get; } = true;
    override public void Pass()
    {
        if (!IsTraversable) { throw new NotTraversableException(); }
    }
}
