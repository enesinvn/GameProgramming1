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
        /*
        #region VEHICLE EXPLANATION
        
        Vehicle myVehicle = new Vehicle(100f);
        Console.WriteLine($"myVehicle has {myVehicle.Fuel} percent fuel left");

        Vehicle theVehicle = myVehicle;
        Console.WriteLine($"theVehicle has {theVehicle.Fuel} percent fuel left");
        
        myVehicle.UseFuel(30f);
        Console.ReadLine();
        Console.WriteLine("-------");
        Console.WriteLine("fuel used");
        Console.WriteLine($"myVehicle has {myVehicle.Fuel} percent fuel left");
        Console.WriteLine($"theVehicle has {theVehicle.Fuel} percent fuel left");
        
        #endregion
        */
        
        #region GAME START
        
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

            if (age < 18)
            {
                Console.WriteLine("Thank goodness this is not an 18+ game! Because you couldn't have played it.");
            } else if (age < 65)
            {
                Console.WriteLine("Okay, you are in our target audience. You may play");
            } else 
            {
                Console.WriteLine("Are you sure you can handle the excitement this game will dish out?");
            }
        }
        else
        {
            Console.WriteLine("You did not enter a valid age. I am using the default age");
        }
        
        /*
        Console.WriteLine("Give me a float");
        float randomFloat = 0f;
        if (float.TryParse(Console.ReadLine(), out float thisFloat))
        {
            randomFloat = thisFloat;
            Console.WriteLine($"The float is {randomFloat}");
        }
        */
        
        _player.Initialize(playerName, playerAge);
        
        Console.WriteLine($"Welcome {_player.Name} of {_player.Age} years of age, to this game");
        
        #endregion
        
        
    }
}