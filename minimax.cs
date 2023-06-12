using System;
using System.Collections.Generic;
using System.Text;

namespace Othello
{
    public class minimax
    {
        public Board Board;
        private ComputerPlayer player;
        private int depth = 1;
        

        public minimax(Board board) {
            this.Board = board;

        }

        public void minimaxDecision(Square[,] board, bool whitesTurn, out int x, out int y, LevelEnum level)
        {
            if (level == LevelEnum.Beginner)
            {
                depth = 1;
            }
            else if (level == LevelEnum.Intermediate)
            {
                depth = 3;
            }
            else {
                depth = 5;
            }
            
            int[] moveX = new int[60];
            int[] moveY = new int[60];
            char me = 'W';
            char opponent = 'B';
            int numMoves;
            if (!whitesTurn)
            {
                me = 'B';
                opponent = 'W';
            }

            getMoveList(board, moveX, moveY, out numMoves, me);
            if (numMoves == 0) // if no moves return -1
            {
                x = -1;
                y = -1;
            }
            else
            {
                // Remember the best move
                int bestMoveVal = -99999;
                int bestX = moveX[0], bestY = moveY[0];
                // Try out every single move
                for (int i = 0; i < numMoves; i++)
                {
                    // Apply the move to a new board

                    Square[,] tempBoard = new Square[8, 8];
                    Board.copyBoard(board ,ref tempBoard);
                    makeTempMove(tempBoard, moveX[i], moveY[i], me);
                    // Recursive call, initial search ply = 1
                    int val = minimaxValue(tempBoard, me, opponent, 1 ,level);
                    // Remember best move
                    if (val > bestMoveVal)
                    {
                        bestMoveVal = val;
                        bestX = moveX[i];
                        bestY = moveY[i];
                    }
                }
                // Return the best x/y
                x = bestX;
                y = bestY;
            }
        }
        void getMoveList(Square[,] tempBoard, int[] moveX, int[] moveY, out int numMoves, char me)
        {
            numMoves = 0;  // Initially no moves found

            // Check each square of the board and if we can move there, remember the coordinates
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                {
                    if (validMove(tempBoard, x, y, me)) // If find valid move, remember coordinates
                    {
                        moveX[numMoves] = x;
                        moveY[numMoves] = y;
                        numMoves++;     // Increment number of moves found
                    }
                }
        }
        public bool validMove(Square[,] tempBoard, int x, int y, char piece)
        {
            if (tempBoard[x, y].State == StateEnum.Black || tempBoard[x, y].State == StateEnum.White)
                return false;

            char opponent = 'B';
            if (piece == 'B')
            {
                opponent = 'W';
            }

            // If we can flip in any direction, it is valid
            // Check to the left
            if (checkFlip(tempBoard, x - 1, y, -1, 0, piece, opponent))
                return true;
            // Check to the right
            if (checkFlip(tempBoard, x + 1, y, 1, 0, piece, opponent))
                return true;
            // Check down
            if (checkFlip(tempBoard, x, y - 1, 0, -1, piece, opponent))
                return true;
            // Check up
            if (checkFlip(tempBoard, x, y + 1, 0, 1, piece, opponent))
                return true;
            // Check down-left	
            if (checkFlip(tempBoard, x - 1, y - 1, -1, -1, piece, opponent))
                return true;
            // Check down-right
            if (checkFlip(tempBoard, x + 1, y - 1, 1, -1, piece, opponent))
                return true;
            // Check up-left	
            if (checkFlip(tempBoard, x - 1, y + 1, -1, 1, piece, opponent))
                return true;
            // Check up-right
            if (checkFlip(tempBoard, x + 1, y + 1, 1, 1, piece, opponent))
                return true;

            return false; // If we get here, we didn't find a valid flip direction
        }

        bool checkFlip(Square[,] tempBoard, int x, int y, int deltaX, int deltaY,
               char myPiece, char opponentPiece)
        {
            StateEnum Mystate;
            StateEnum Opstate;

            if (myPiece == 'W')
            {
                Mystate = StateEnum.White;
                Opstate = StateEnum.Black;
            }
            else {
                Mystate = StateEnum.Black;
                Opstate = StateEnum.White;
            }


            if ( (x != -1 && x != 8) && (y != -1 && y != 8)) 
            {
                if ((tempBoard[x, y].State == Opstate)) {
                    while ((x >= 0) && (x < 8) && (y >= 0) && (y < 8))
                    {



                        if ((x >= 0) && (x < 8) && (y >= 0) && (y < 8))
                        {
                            if (tempBoard[x, y].State == StateEnum.Empty) // not consecutive
                                return false;
                            if (tempBoard[x, y].State == Mystate)
                                return true;        // At least one piece we can flip
                            else
                            {
                                // It is an opponent piece, just keep scanning in our direction
                            }
                        }
                        x += deltaX;
                        y += deltaY;
                    }
                }
                  
            }
            return false; // Either no consecutive opponent pieces or hit the edge of the board
        }
        void makeTempMove(Square[,] tempBoard, int x, int y, char piece)
        {
            // Put the piece at x,y
            char opponent = 'B';
            if (piece == 'W')
            {
                tempBoard[x,y].State = StateEnum.White;
            }
            else
            {
                opponent = 'W';
                tempBoard[x, y].State = StateEnum.Black;

            }



            // Check to the left
            if (checkFlip(tempBoard, x - 1, y, -1, 0, piece, opponent))
                flipPieces(tempBoard, x - 1, y, -1, 0, piece, opponent);
            // Check to the right
            if (checkFlip(tempBoard, x + 1, y, 1, 0, piece, opponent))
                flipPieces(tempBoard, x + 1, y, 1, 0, piece, opponent);
            // Check down
            if (checkFlip(tempBoard, x, y - 1, 0, -1, piece, opponent))
                flipPieces(tempBoard, x, y - 1, 0, -1, piece, opponent);
            // Check up
            if (checkFlip(tempBoard, x, y + 1, 0, 1, piece, opponent))
                flipPieces(tempBoard, x, y + 1, 0, 1, piece, opponent);
            // Check down-left	
            if (checkFlip(tempBoard, x - 1, y - 1, -1, -1, piece, opponent))
                flipPieces(tempBoard, x - 1, y - 1, -1, -1, piece, opponent);
            // Check down-right
            if (checkFlip(tempBoard, x + 1, y - 1, 1, -1, piece, opponent))
                flipPieces(tempBoard, x + 1, y - 1, 1, -1, piece, opponent);
            // Check up-left	
            if (checkFlip(tempBoard, x - 1, y + 1, -1, 1, piece, opponent))
                flipPieces(tempBoard, x - 1, y + 1, -1, 1, piece, opponent);
            // Check up-right
            if (checkFlip(tempBoard, x + 1, y + 1, 1, 1, piece, opponent))
                flipPieces(tempBoard, x + 1, y + 1, 1, 1, piece, opponent);
        }


        // Flips pieces in the given direction until we don't hit any more opponent pieces.
        // Assumes this is a valid direction to flip (we eventually hit one of our pieces).
        void flipPieces(Square[,] tempBoard, int x, int y, int deltaX, int deltaY, char myPiece, char opponentPiece)
        {

            StateEnum Mystate;
            StateEnum Opstate;

            if (myPiece == 'W')
            {
                Mystate = StateEnum.White;
                Opstate = StateEnum.Black;
            }
            else
            {
                Mystate = StateEnum.Black;
                Opstate = StateEnum.White;
            }

            while (tempBoard[x,y].State == Opstate)
            {
                tempBoard[x, y].State = Mystate;
                x += deltaX;
                y += deltaY;
            }
        }

        bool gameOver(Square[,] tempBoard)
        {
            int[] XMoveX = new int[60];
            int[] XMoveY = new int[60];
            int[] OMoveX = new int[60];
            int[] OMoveY = new int[60];
            int numXMoves, numOMoves;
            getMoveList(tempBoard, XMoveX, XMoveY, out numXMoves, 'B');
            getMoveList(tempBoard, OMoveX, OMoveY, out numOMoves, 'W');
            if ((numXMoves == 0) && (numOMoves == 0))
                return true;
            return false;
        }

        int heuristic(Square[,] tempBoard, char whoseTurn, LevelEnum level)
        {
            char opponent = 'B';
            if (whoseTurn == 'B')
                opponent = 'W';
            int ourScore = score(tempBoard, whoseTurn, level);
            int opponentScore = score(tempBoard, opponent,level);
            return (ourScore - opponentScore);
        }


        int score(Square[,] tempBoard, char whoseTurn, LevelEnum level)
        {
            player = new ComputerPlayer();
            player.Level = level;
            StateEnum myState;
            if (whoseTurn == 'W')
            {
                myState = StateEnum.White;
            }
            else {
                myState = StateEnum.Black;
            }
                
            int total = 0;
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                {
                    if (tempBoard[x,y].State == myState)
                    {
                        total = total + player.ScoreSquare(x,y);
                    }


                }
            return total;
        }
        int minimaxValue(Square[,] tempBoard, char originalTurn, char currentTurn, int searchPly,LevelEnum level)
        {
            if ((searchPly == depth) || gameOver(tempBoard)) // Change to desired ply lookahead
            {
                return heuristic(tempBoard, originalTurn, level);
            }
            int[] moveX = new int[60];
            int[] moveY = new int[60];
            int numMoves;
            char opponent = 'B';
            if (currentTurn == 'B')
                opponent = 'W';
            getMoveList(tempBoard, moveX, moveY, out numMoves, currentTurn);

            if (numMoves == 0) // if no moves skip to next player's turn
            {
                return minimaxValue(tempBoard, originalTurn, opponent, searchPly + 1,level);
            }
            else
            {
                // Remember the best move
                int bestMoveVal = -99999; // for finding max
                if (originalTurn != currentTurn)
                    bestMoveVal = 99999; // for finding min
                                         // Try out every single move
                for (int i = 0; i < numMoves; i++)
                {
                    // Apply the move to a new board

                    Square[,] tempBoard2 = new Square[8, 8];
                    Board.copyBoard(tempBoard, ref tempBoard2);
                    Move tempMove = new Move();
                    makeTempMove(tempBoard2, moveX[i], moveY[i], currentTurn);
                    // Recursive call
                    int val = minimaxValue(tempBoard2, originalTurn, opponent,
                     searchPly + 1 ,level);
                    // Remember best move
                    if (originalTurn == currentTurn)
                    {
                        // Remember max if it's the originator's turn
                        if (val > bestMoveVal)
                            bestMoveVal = val;
                    }
                    else
                    {
                        // Remember min if it's opponent turn
                        if (val < bestMoveVal)
                            bestMoveVal = val;
                    }
                }
                return bestMoveVal;
            }
            return -1; // Should never get here
        }

    }
}

