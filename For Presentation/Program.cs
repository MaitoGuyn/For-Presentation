bool IsPathCrossing(string path)
{
    List<Tuple<int, int>> positions = new List<Tuple<int, int>>();
    int x = 0;
    int y = 0;
    positions.Add(new Tuple<int, int>(x, y));

    foreach (char direction in path)
    {
        if (direction == 'N')
        {
            y += 1;
        }
        if (direction == 'S')
        {
            y -= 1;
        }
        if (direction == 'E')
        {
            x += 1;
        }
        if (direction == 'W')
        {
            x -= 1;
        }

        Tuple<int, int> newPosition = new Tuple<int, int>(x, y);
        if (positions.Contains(newPosition))
        {
            return true;
        }
        positions.Add(newPosition);
    }
    return false;
}
Console.WriteLine(IsPathCrossing("NES"));

