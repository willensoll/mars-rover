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

You can run the tests which contain the supplied test inputs - and you can run the application and input your own commands in the console.

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

