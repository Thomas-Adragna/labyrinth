

namespace Labyrinth;

internal class Room : Tile
{
    public ICollectable? Item { get; set; }
    public override bool IsTraversable => true;

    override public void Pass()
    {
    }
}
