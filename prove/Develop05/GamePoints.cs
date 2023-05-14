
class GamePoints
{

    private int _cumulatedPoints;

    public GamePoints()
    {
        CumulatedPoints = 0;
    }

    public int CumulatedPoints { get => _cumulatedPoints; set => _cumulatedPoints = value; }
}