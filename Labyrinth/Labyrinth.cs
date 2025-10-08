namespace Labyrinth;

internal class Labyrinth
{
    private readonly Tile[,] _tiles;
    private int Width { get; }
    private int Height { get; }

    public Labyrinth(string board)
    {

        var rows = board.Split('\n');
        Height = rows.Length;
        Width = rows[0].Length;
        _tiles = new Tile[Height, Width];

        for (var y = 0; y < Height; y++)
        {
            for (var x = 0; x < Width; x++)
            {
                var tileChar = rows[y][x];
                _tiles[y, x] = tileChar switch
                {
                    '#' => new Wall(),
                    ' ' => new Room(),
                    '/' => new Door(),
                    'k' => new Room { Item = new Key() },
                    _ => throw new ArgumentException("Invalid character in board string.")
                };
            }
        }
    }

    public override string ToString()
    {
        var str = "";

        for (var y = 0; y < Height; y++)
        {
            for (var x = 0; x < Width; x++)
            {
                var tile = _tiles[y, x];

                var c = tile switch
                {
                    Wall => '#',
                    Door => '/',
                    Room r when r.Item is Key => 'k',
                    Room => ' ',
                    _ => '?'
                };

                str += c;
            }

            if (y < Height - 1)
                str += '\n';
        }

        return str;
    }
}
