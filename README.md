# Othello

The Used Programming Language:
The used programming Language is C# and the framework is .Net specially, Windows
Form in .NET framework which is a UI framework for building Windows desktop apps.
It provides one of the most productive ways to create desktop apps based on the
visual designer provided in Visual Studio. Functionality such as drag-and-drop
placement of visual controls makes it easy to build desktop apps.
The Used Heuristic:
The heuristic functions control the ability of the computer to correctly determine how
good a particular state is for a player. A number of factors determine whether a given
state of the game is good for a player. For Othello, factors such as mobility, stability,
corners and coin parity determine how favorable a particular position is for a player.
The most intuitive way to calculate a heuristic value is to create a linear combination
of the quantitative representation of the various important factors.
The utility function which we have used, uses statically assigned weights to squares
on the board to calculate the utility value, and the weights of the corners are greater
than the other weights. The heuristic value for a player is calculated by adding
together the weights of the squares in which the player’s coins are present. The static
board implicitly captures the importance of each square on the board, and
encourages the game play to tend towards capturing corners.
The UML Class Diagram:
The Features we have in our Game:
 We show legal moves in the GUI to the player to guide him through the game if
he is not familiar with it
 If played in an illegal move, an error message appears in the GUI
 We have 2 players, each can choose between different modes separately.
 The coin flips when we press on it (it is dynamic)
 We can undo moves
The Game playing supported Algorithms:
The search technique allows the computer to look ahead and explore different moves
through a systematic generation of next possible moves. The efficiency of the search
technique determines the depth to which the game tree is explored. The higher
difficulty of level we choose to play, the greater the number of nodes that can be
searched, hence the farther the look ahead in the search tree.
Minimax Algorithm:
The minimax search does a depth-first exploration of the entire game tree. The
heuristic functions are utilized at the leaves to provide utility values. The utility values
are then backed up all the way to the root. The manner in which the values are
backed up to a node depends on whether the node is a min node or a max node. A
typical minimax tree is such that the min player and max player alternate.
Alpha-Beta Algorithm:
Alpha-beta search is similar to minimax, except that efficient pruning is done when a
branch is rendered useless. Pruning is done when it becomes evident that exploring a
branch any further will not have an impact on its ancestors.
The figure below illustrates the Minimax Algorithm with Alpha-Beta pruning:
Difficulty Levels Supported:
We have made 3 difficulty levels for the computer as opponent which are: beginner,
intermediate and hard level. Each has its own algorithm and supported heuristics to
calculate the score of all available moves and choose the most suitable one
