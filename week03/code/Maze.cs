/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    private readonly int _LEFT = 0;
    private readonly int _RIGHT = 1;
    private readonly int _UP = 2;
    private readonly int _DOWN = 3;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

   // TODO: Solve Maze Problem - Implement code for checking and moving left.
    // If movement is possible, execute the move; otherwise, display "Can't go that way!"
    public void MoveLeft() {
        // FILL IN CODE
        if (_mazeMap[(_currX, _currY)][_LEFT])
        {
            _currX--;
            Console.WriteLine($"Moving left to ({_currX}, {_currY}).");
        }
        else{
            Console.WriteLine("Can't move left!");
        }
    }

    /// <summary>
    /// Check if moving right is possible. If yes, execute the move. If not, display "Can't go that way!"
    /// </summary>

    public void MoveRight() {
        // FILL IN CODE
        if (_mazeMap[(_currX, _currY)][_RIGHT])
        {
            _currX++;
            Console.WriteLine($"Moving right to ({_currX}, {_currY}).");
        }
        else{
            Console.WriteLine("Can't move right!");
        }
    }
        /// <summary>
        /// Check if moving up is possible. If yes, execute the move. If not, display "Can't go that way!"
        /// </summary>

    public void MoveUp() {
        // FILL IN CODE
        if (_mazeMap[(_currX, _currY)][_UP])
        {
            _currY--;
            Console.WriteLine($"Moving up to ({_currX}, {_currY}).");
        }
        else{
            Console.WriteLine("Can't move up!");
        }
    }
        /// <summary>   
        /// Check if moving down is possible. If yes, execute the move. If not, display "Can't go that way!"
        /// </summary>

    public void MoveDown() {
        // FILL IN CODE
        if (_mazeMap[(_currX, _currY)][_DOWN])
        {
            _currY++;
            Console.WriteLine($"Moving down to ({_currX}, {_currY}).");
        }
        else{
            Console.WriteLine("Can't move down!");
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}