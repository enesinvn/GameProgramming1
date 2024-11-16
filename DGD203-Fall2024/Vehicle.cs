namespace FirstGame;

public abstract class Vehicle
{
    public double Fuel { get; protected set; }  // Fuel in liters
    public bool IsEngineOn { get; protected set; }
    public int CurrentGear { get; protected set; }
    public int MaxGear { get; protected set; }
    public float Speed { get; protected set; }

    public Vehicle(double initialFuel, int maxGear)
    {
        Fuel = initialFuel;
        Speed = 0f;
        CurrentGear = 1; // Vehicles start in the first gear
        MaxGear = maxGear;
        IsEngineOn = false;
    }

    // Start the engine
    public void StartEngine()
    {
        if (!IsEngineOn)
        {
            if (Fuel > 0)
            {
                IsEngineOn = true;
                Console.WriteLine("Engine started.");
            }
            else
            {
                Console.WriteLine("Not enough fuel to start the engine.");
            }
        }
        else
        {
            Console.WriteLine("Engine is already running.");
        }
    }

    // Stop the engine
    public void StopEngine()
    {
        if (IsEngineOn)
        {
            IsEngineOn = false;
            Console.WriteLine("Engine stopped.");
        }
        else
        {
            Console.WriteLine("Engine is already off.");
        }
    }

    public void Accelerate(float acceleration)
    {
        if (IsEngineOn && Fuel > 0)
        {
            UseFuel(acceleration * 0.1f); 
            Speed += acceleration * CurrentGear; 
            Console.WriteLine($"Accelerated to {Speed} km/h. Remaining fuel: {Fuel} liters.");
        }
        else if (!IsEngineOn)
        {
            Console.WriteLine("Cannot accelerate. The engine is off.");
        }
        else
        {
            Console.WriteLine("Not enough fuel to accelerate.");
        }
    }

    // Brake the vehicle
    public void Brake(float deceleration)
    {
        Speed = Speed - deceleration < 0f ? 0f : Speed - deceleration;
        Console.WriteLine($"Braked to {Speed} km/h.");
    }

    // Shift gear
    public void ShiftGear(int gear)
    {
        if (gear < 1 || gear > MaxGear)
        {
            Console.WriteLine("Invalid gear!");
            return;
        }

        CurrentGear = gear;
        Console.WriteLine($"Shifted to gear {CurrentGear}.");
    }

    public void Refuel(double amount)
    {
        if (amount > 0)
        {
            Fuel += amount;
            Console.WriteLine($"{amount} liters of fuel added. Current fuel level: {Fuel} liters.");
        }
        else
        {
            Console.WriteLine("Please enter a valid fuel amount.");
        }
    }

    // Use fuel
    private void UseFuel(double fuel)
    {
        Fuel = Fuel - fuel < 0 ? 0 : Fuel - fuel;
    }
    
    // Display vehicle status
    public void DisplayStatus()
    {
        Console.WriteLine($"Speed: {Speed} km/h, Fuel: {Fuel} liters, Current Gear: {CurrentGear}, Engine: {(IsEngineOn ? "On" : "Off")}");
    }
}
