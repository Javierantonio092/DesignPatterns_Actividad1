using DesignPatterns_Adapter;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        CoolCorpInterface robot = new CoolCorpRobot();
        robot.CurrentSpeedInKilometersPerHour = 3;
        robot.Jump(12);
        Console.ReadKey();
    }

}

