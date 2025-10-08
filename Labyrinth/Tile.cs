
namespace Labyrinth;

internal abstract class Tile
{
    protected abstract bool IsTraversable { get; }

    public void Pass()
    {
        if (!IsTraversable)
        {
            throw new NotTraversableException();
        }
    }
}
