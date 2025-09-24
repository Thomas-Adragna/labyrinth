namespace Labyrinth;

 class Labyrinth
{
    private Tile[,] tiles;
    public Labyrinth(string board)
    {

        string[] rows = board.Split('\n');
        // Tile[,] newTiles = new Tile[rows.GetLength() + 1, row[0].GetLength()];

        foreach (string row in rows)
        {
            foreach (char tile in row)
            {
                Tile t = tile switch
                {
                    '#' => new Wall(),
                    ' ' => new Room(),
                    'D' => new Door(),
                    _ => throw new ArgumentException("Invalid character in board string.")
                };

            }
        }
    }

}
