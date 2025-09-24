

namespace Labyrinth
{
    internal class NotTraversableException : Exception
    {
        public NotTraversableException() : base("You cannot pass through this tile.")
        {
        }
    }
}
