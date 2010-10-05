
The current folder contains three projects; two libraries and an interface program. The three projects have been combined to one Microsoft Visual Studio solution. They can be used as a whole, or separately, according to the developer's needs.

All source code files are distributed under the GNU General Public License v3. More details and special conditions are available in the beginning of each individual file.

The three projects are:
1. IR52cLow - Library for managing the Eurobtec IR52c 5-DOF robotic arm. Contains: 
	lowlvl.cs (main file) - Accepts "low level" commands for each individual motor.
	CommunicationManager.cs - used to communicate with the robot's controller through serial port (COM)

2. SolveNMove - Library for solving the direct and inverse kinematic problem and moving a 5-Degrees-Of-Freedom robotic arm. Contains:
	highlvl.cs (main file) - can accept a point in space and move the robot accordingly (along with other functionality)
	RoboMath.cs - Solves the direct and inverse kinematic problem
	MatrixManipulation.cs - contains matrix-handling functions

3. Interface - Windows application to use a 5-Degrees-Of-Freedom robotic arm. Contains:
	Form1.cs (main file) - interface to move a 5-DOF robotic arm using buttons, written commands or a wiimote
	MatrixManipulation.cs - contains matrix-handling functions

Latest code is available at http://tinyurl.com/duth-robotics
 or http://code.google.com/p/duth-robotics-team-project1

18/7/2010, Chris Mavrakis (cmavr8@gmail.com, cmavrakis.com) and the team.

Test