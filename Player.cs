using System.Runtime.InteropServices;

namespace Players;

public class Player
{
    private readonly string _name;
    private int _points;

    public Player(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public void Play(Player player2)
    {
        var random = new Random();
        var whoWon = random.Next(0, 1);
        if (whoWon == 0)
        {
            _points++;
            player2._points--;
        }
        else
        {
            _points--;
            player2._points++;
        }
    }

    public void ShowNameAndPoints()
    {
        Console.WriteLine($"{_name} has {_points} points.");
    }
}