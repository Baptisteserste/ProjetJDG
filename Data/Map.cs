public class Map
{
    public Tile[,] Tiles { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public Map(int width, int height)
    {
        Width = width;
        Height = height;
        Tiles = new Tile[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                {
                    Tiles[x, y] = new Tile(TileType.Montagne); 
                }
                else if (x == width / 2 && y == height / 2)
                {
                    Tiles[x, y] = new Tile(TileType.Ville);
                }
                else
                {
                    Tiles[x, y] = new Tile(TileType.Plaine);
                }
            }
        }
    }

    public void Display()
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                Console.Write(Tiles[x, y].Symbol);
            }
            Console.WriteLine();
        }
    }

    public Tile GetTile(int x, int y)
    {
        if (x >= 0 && x < Width && y >= 0 && y < Height)
        {
            return Tiles[x, y];
        }
        else
        {
            return null;
        }
    }
}

// Enum pour les types de tuiles
public enum TileType
{
    Plaine,
    Forêt,
    Montagne,
    Eau,
    Ville,
    Donjon
}

// Classe Tile
public class Tile
{
    public TileType Type { get; set; }
    public char Symbol { get; set; }

    public Tile(TileType type)
    {
        Type = type;
        switch (type)
        {
            case TileType.Plaine:
                Symbol = '.';
                break;
            case TileType.Forêt:
                Symbol = 'F';
                break;
            case TileType.Montagne:
                Symbol = 'M';
                break;
            case TileType.Eau:
                Symbol = '~';
                break;
            case TileType.Ville:
                Symbol = 'V';
                break;
            case TileType.Donjon:
                Symbol = 'D';
                break;
            default:
                Symbol = '?';
                break;
        }
    }
}