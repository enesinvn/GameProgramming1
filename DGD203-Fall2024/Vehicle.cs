namespace FirstGame;

public class Vehicle
{
    public float Fuel { get; private set; }  // percentage of fuel

    public Vehicle(float fuel)
    {
        Fuel = Math.Clamp(fuel, 0f, 100f);
    }

    public void UseFuel(float fuel)
    {
        Fuel = Fuel - fuel < 0f ? 0f : Fuel - fuel;
    }
}