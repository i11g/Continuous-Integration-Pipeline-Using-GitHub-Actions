﻿using Cars;

public class Tesla : ICar, IElectricalCar
    { 
    public string Model { get; set ; }
    public string Color { get ; set ; }

    public int Battery { get; set ; }
    public string Start()
    {
        return "Engine start";
    }
    public string Stop()
    {
        return "Break!";
    }
    public Tesla (string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }
    public override string ToString()
    {
        return $"{this.Color} Tesla {this.Model} with {this.Battery}\n" +
            $"{this.Start()}\n"+
            $"{this.Stop()}";
    }

}