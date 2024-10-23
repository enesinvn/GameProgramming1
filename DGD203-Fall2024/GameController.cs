namespace FirstGame;

public class GameController
{
    private PhysicsCalculator _calc;
    private Player _player;
    
    public GameController()
    {
        _calc = new PhysicsCalculator();
        _player = new Player();
    }

    public void StartGame()
    {
        Console.WriteLine("The game started. Please give me your name:");
        string playerName = Console.ReadLine();
        if (playerName == "" || playerName == null)
        {
            Console.WriteLine("There is no name here! You are dead to me");
            playerName = "Dead2Me";
        }
        
        Console.WriteLine("Splendid. Now tell me your age");
        int playerAge = _player.Age;
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            playerAge = age;
        }
        else
        {
            Console.WriteLine("You did not enter a valid age. I am using the default age");
        }
        
        _player.Initialize(playerName, playerAge);
        
        Console.WriteLine($"Welcome {_player.Name} of {_player.Age} years of age, to this class");
    }
}