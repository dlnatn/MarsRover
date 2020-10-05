using System;
using System.Linq;

namespace MarsRover {
    public class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Max Points (X Y) : ");
            var maxPoints = Console.ReadLine().Trim();
            var maxPointList = maxPoints.Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Start Positions (X Y Direction): ");
            var startPositions = Console.ReadLine().Trim().Split(' ');
            Position position = new Position();
            if (startPositions.Count() == 3)
            {
                position.X = Convert.ToInt32(startPositions[0]);
                position.Y = Convert.ToInt32(startPositions[1]);
                position.Direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2]);
            }
            Console.WriteLine("Moves: ");
            var moves = Console.ReadLine().ToUpper();

            try
            {
                position.StartMoving(maxPointList, moves);
                Console.WriteLine($"{position.X} {position.Y} {position.Direction}");
                Console.WriteLine("Second Rover Start Positions (X Y Direction): ");
                var secondRoverStartPositions = Console.ReadLine().Trim().Split(' ');
                Position secondRoverPosition = new Position();

                if (secondRoverStartPositions.Count() == 3)
                {
                    secondRoverPosition.X = Convert.ToInt32(secondRoverStartPositions[0]);
                    secondRoverPosition.Y = Convert.ToInt32(secondRoverStartPositions[1]);
                    secondRoverPosition.Direction = (Directions)Enum.Parse(typeof(Directions), secondRoverStartPositions[2]);
                }
                Console.WriteLine("Moves: ");
                var secondRoverMoves = Console.ReadLine().ToUpper();
                secondRoverPosition.StartMoving(maxPointList, secondRoverMoves);
                Console.WriteLine($"{secondRoverPosition.X} {secondRoverPosition.Y} {secondRoverPosition.Direction}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
