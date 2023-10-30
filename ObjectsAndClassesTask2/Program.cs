using System;

public class Car
{
    public string Model;
    public int Year;
    public bool IsEngineRunning;

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
        IsEngineRunning = false;
    }

    public void StartEngine()
    {
        if (!IsEngineRunning)
        {
            IsEngineRunning = true;
            Console.WriteLine($"{Model} ({Year}) engine started.");
        }
        else
        {
            Console.WriteLine($"{Model} ({Year}) engine has already been started.");
        }
    }

    public void StopEngine()
    {
        if (IsEngineRunning)
        {
            IsEngineRunning = false;
            Console.WriteLine($"{Model} ({Year}) engine stopped.");
        }
        else
        {
            Console.WriteLine($"{Model} ({Year}) engine is already stopped.");
        }
    }
}
