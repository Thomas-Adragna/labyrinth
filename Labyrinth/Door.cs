namespace Labyrinth;

internal class Door : Tile
{
    private Key Key { get; } = new Key();
    private bool _isOpen = false;
    protected override bool IsTraversable => _isOpen;
    
    public void Open(Key key)
    {
        if (Key == key)
        {
            _isOpen = true;
        }
    }
}
