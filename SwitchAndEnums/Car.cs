namespace SwitchAndEnums;

public class Car
{
    //public private protected
    //public string model;
    //public int speed;

    private string _model;
    private int _speed;
    private static int _numOfCarInstances;

    public Car()
    {
        _model = "BMW";
        _speed = 180;
        _numOfCarInstances++;
    }

    /// <summary>
    /// Create Car object
    /// </summary>
    /// <param name="model">car model</param>
    /// <param name="s">car max speed</param>
    public Car(string model, int s)
    {
        _model = model;
        _speed = s;
        _numOfCarInstances++;
    }

    /// <summary>
    /// prints information about car
    /// </summary>
    public void PrintInfo()
    {
        Console.WriteLine($"Car model {_model} \nCar maxSpeed is {_speed}\n" +
                          $"number of instance is {_numOfCarInstances}");
    }

    /// <summary>
    /// increase speed method
    /// </summary>
    /// <param name="speed">increased amount</param>
    /// <returns>increased speed amount. If speed is same it means we exceed limit (300)</returns>
    public int IncreaseSpeed(int speed)
    {
        if (speed + _speed > 300)
        {
            return _speed;
        }

        _speed += speed;
        return _speed;
    }

    public string ReturnInfo()
    {
        return $"Car model {_model} \nCar maxSpeed is {_speed}";
    }
}