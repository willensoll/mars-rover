# mars-rover
Mars Rover kata solution in C#

- Language: C# dotnet 3.0
- IDE: JetBrains Rider

# How to run the console app
- Unzip the file
- Import into chosen IDE (must support .net)
- You will need .Net Core 3.0+ installed on your computer. found here: https://dotnet.microsoft.com/download
- Build Solution
- Run Unit Tests
- Run Solution

I have written this kata in C# as I felt most comfortable writing this with OOP concepts.

You can either run the tests which contain the supplied test inputs - or input your own commands in the console.

I have split the application into 4 classes with their respective subclasses and interfaces contained inside. 

The *direction* class handles the rovers orientation and ultimately governs the direction the rover will move in. 

The *navigation* class handles the instructions that tell the rovers how to navigate the plateau. 
I have used the command pattern in this class as I believe that its modular approach would allow me to easily expand this in the future. I had not used the command pattern before and wanted to take this as an opportunity to learn something new. 

The *plateau* class handles the size of the grid and holds the current location of the rovers on the grid.

The *marsrover* class instantiates the rovers, sets their initial direction and executes the input navigation commands. 

# Assumptions
The input will always be in the correct format.
The rover will not continue forward if it exceeds the bounds of the plateau grid.

# Future features
Validation on console inputs, better error handling and a retry function on console commands if input incorrectly.
I would like to revisit how the setting the inital direction is handled.



Problem : Mars Rover

A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on-board cameras can get a complete view of the surrounding terrain to send back to Earth.

 

A rover’s position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.

In order to control a rover, NASA sends a simple string of letters. The possible letters are ‘L’, ‘R’ and ‘M’. ‘L’ and ‘R’ makes the rover spin 90 degrees left or right respectively, without moving from its current spot. ‘M’ means move forward one grid point, and maintain the same heading.

Assume that the square directly North from (x, y) is (x, y+1).

 

Input: 

The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line gives the rover’s position, and the second line is a series of instructions telling the rover how to explore the plateau.
The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover’s orientation.
Each rover will be finished sequentially, which means that the second rover won’t start to move until the first one has finished moving.
Output: The output for each rover should be its final co-ordinates and heading.

 

Input and Output

Test Input:

5 5

1 2 N

LMLMLMLMM

3 3 E

MMRMMRMRRM

Expected Output:

1 3 N

5 1 E