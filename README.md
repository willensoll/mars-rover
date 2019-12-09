# mars-rover
Mars Rover kata solution in C#

Language used: C#
IDE: JetBrains Rider
How to run the console app
Unzip the file
Import into chosen IDE.
Build Solution.
Run Unit Tests
Run Solution


I decided to write this kata in C# as this is the language I am most comfortable with.

I have split the application into 4 classes with their respective subclasses and interfaces contained inside. 

The direction class handles the rovers orientation and ultimately governs the direction the rover will move in. 

The navigation class handles the instructions that tell the rovers how to navigate the plateau. I have used the command pattern in this class as I believe that its modular approach would allow me to easily expand this in the future. I had not used the co

Assumptions
The input will always be in the correct format.
The rover will not continue forward if it exceeds the bounds of the plateau grid.
Future improvements:
Validation on console inputs, better error handling and a retry function on console commands if input incorrectly.

