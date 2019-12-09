using System;
using System.Collections.Generic;
using tw_mars_rover.Plateau;
using tw_mars_rover.Rover;

namespace tw_mars_rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter plateau size: ");
            var plateauParams = Console.ReadLine();
            var r1PlateauInstance = new PlateauGrid(plateauParams);
            var r2PlateauInstance = new PlateauGrid(plateauParams);
            var rover1CommandsToExecute = new List<string>();
            var rover2CommandsToExecute = new List<string>();

            Console.Write("Enter Rover1 deployment Coords and direction: ");
            rover1CommandsToExecute.Add(Console.ReadLine().ToUpper());
            Console.Write("Enter Rover1 movement instructions: ");
            rover1CommandsToExecute.Add(Console.ReadLine().ToUpper());
            Console.Write("Enter Rover2 deployment Coords and direction: ");
            rover2CommandsToExecute.Add(Console.ReadLine().ToUpper());
            Console.Write("Enter rover2 Movement instructions: ");
            rover2CommandsToExecute.Add(Console.ReadLine().ToUpper());
            
            var rover1 = new MarsRover(r1PlateauInstance);
            rover1.SetRoverDirection(rover1CommandsToExecute);
            var rover2 = new MarsRover(r2PlateauInstance);
            rover2.SetRoverDirection(rover2CommandsToExecute);
            rover1.ExecuteCommands(rover1CommandsToExecute);
            rover2.ExecuteCommands(rover2CommandsToExecute);
            Console.WriteLine();
            Console.WriteLine($"Current Rover Position Heading: {rover1.CoordinateX} {rover1.CoordinateY} {rover1.Direction.ToString()[0]}");
            Console.WriteLine($"Current Rover Position Heading: {rover2.CoordinateX} {rover2.CoordinateY} {rover2.Direction.ToString()[0]}");
        }
    }
    }