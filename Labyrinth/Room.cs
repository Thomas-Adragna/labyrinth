

namespace Labyrinth;

internal class Room : Tile
{
    public ICollectable? Item { get; set; }
    protected override bool IsTraversable => true;
    
}
