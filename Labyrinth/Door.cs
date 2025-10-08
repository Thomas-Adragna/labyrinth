namespace Labyrinth;

internal class Door : Tile
{
    private Key key { get; } = new Key();
    private bool isOpen = false;
    override public bool IsTraversable => isOpen;
    /// <summary>
    /// 
    /// </summary>
    override public void Pass()
    {
        if (!IsTraversable){ throw new NotTraversableException(); }
    }
    public void Open(Key key)
    {
        if (this.key == key)
        {
            isOpen = true;
        }
    }
}
