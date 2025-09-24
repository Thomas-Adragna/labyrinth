namespace Labyrinth;

internal class Door : Tile
{
    private Key key { get; } = new Key();
    override public bool IsTraversable { get; protected set; } = false;
    /// <summary>
    /// 
    /// </summary>
    override public void Pass()
    {
        if (!IsTraversable){ throw new NotTraversableException(); }
    }
    public void open(Key key)
    {
        if (this.key == key)
        {
            IsTraversable = true;
        }
    }
}
