
class Game
{

    private int _cumulatedPoints;

    public Game()
    {
        CumulatedPoints = 0;
    }

    public void RecordEvents(int eventPoints)
    {
        CumulatedPoints += eventPoints;
    }

    public int CumulatedPoints { get => _cumulatedPoints; set => _cumulatedPoints = value; }
}