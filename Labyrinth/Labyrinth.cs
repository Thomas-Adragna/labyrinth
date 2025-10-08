namespace Labyrinth;

 class Labyrinth
{
    private Tile[,] tiles;
    public int Width { get; }
    public int Height { get; }

    public Labyrinth(string board)
    {

        string[] rows = board.Split('\n');
        Height = rows.Length;
        Width = rows[0].Length;
        tiles = new Tile[Height, Width];

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                char tileChar = rows[y][x];
                tiles[y, x] = tileChar switch
                {
                    '#' => new Wall(),
                    ' ' => new Room(),
                    'D' => new Door(),
                    'k' => new Room { Item = new Key() },
                    _ => throw new ArgumentException("Invalid character in board string.")
                };
            }
        }
    }
}
