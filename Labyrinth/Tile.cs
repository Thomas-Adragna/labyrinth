using System;
namespace Labyrinth;

abstract class Tile
{
    abstract public bool IsTraversable { get; protected set; }
    abstract public void Pass();
}
