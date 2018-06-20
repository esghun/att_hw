
The application used to demonstrate DFS based algorithm to search, count and
color black islands on white board. 
	
At the screen of the application user will find the following controls:
	- board size controls: set board width and height and click "Create" to initialize
	  a board
	- White/black ratio: default value is 3, meaning number of white pixels is aproximately
	  3 times number of black pixels. if the value is 0, all pixels are black
	- Randomize: randomly fill a board according to a White/black ratio
	- Solve: search for a islands and color them
	- Clear: reset a board
	
Implementation:
	CBoard: class holding a vector of integers representing colors of each pixel on a board.
			The class exposes a set of APIs for manipulating board pixels.
			The class remaps 2-dimentional board to 1-dimentional vector.
			
	CIslandPainter: scan a board. For each black pixel, find adjacent black pixels and set
					them a new color
					
	CColorGenerator: used to generate unique colors

	
