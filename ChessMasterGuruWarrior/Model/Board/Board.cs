using System;
using System.Collections.Generic;
using System.Text;
using ChessMasterGuruWarrior.Model.Piece;

namespace ChessMasterGuruWarrior.Model.Board
{
    public class Board
    {
        
        public Piece.Piece[,] board = new Piece.Piece[8,8];

        public static Board newBoard { get; set; }

        //public bool InCheck { get; set; }

        //public int[] OpenSpaces { get; set; } = [null, null, null];

        public Board()
        {
            board = new Piece.Piece[8,8];
        }

        

        public void MakeBoard()
        {
            //instantiates black
            newBoard = new Board();
            board[0,0] = new Rook(false, 0, 0);
            board[0, 1] = new Knight(false, 0, 1);
            board[0, 2] = new Bishop(false, 0, 2);
            board[0, 3] = new Queen(false, 0, 3);
            board[0, 4] = new King(false, 0, 4);
            board[0, 5] = new Bishop(false, 0, 5);
            board[0, 6] = new Knight(false, 0, 6);
            board[0, 7] = new Rook(false, 0, 7);
            board[1, 0] = new Pawn(false, false, 0, 0);
            board[1, 1] = new Pawn(false, false, 0, 1);
            board[1, 2] = new Pawn(false, false, 0, 2);
            board[1, 3] = new Pawn(false, false, 0, 3);
            board[1, 4] = new Pawn(false, false, 0, 4);
            board[1, 5] = new Pawn(false, false, 0, 5);
            board[1, 6] = new Pawn(false, false, 0, 6);
            board[1, 7] = new Pawn(false, false, 0, 7);

            //instantiates white
            board[7, 0] = new Rook(false, 7, 0);
            board[7, 1] = new Knight(false, 7, 1);
            board[7, 2] = new Bishop(false, 7, 2);
            board[7, 3] = new Queen(false, 7, 3);
            board[7, 4] = new King(false, 7, 4);
            board[7, 5] = new Bishop(false, 7, 5);
            board[7, 6] = new Knight(false, 7, 6);
            board[7, 7] = new Rook(false, 7, 7);
            board[6, 0] = new Pawn(false, false, 7, 0);
            board[6, 1] = new Pawn(false, false, 7, 1);
            board[6, 2] = new Pawn(false, false, 7, 2);
            board[6, 3] = new Pawn(false, false, 7, 3);
            board[6, 4] = new Pawn(false, false, 7, 4);
            board[6, 5] = new Pawn(false, false, 7, 5);
            board[6, 6] = new Pawn(false, false, 7, 6);
            board[6, 7] = new Pawn(false, false, 7, 7);
        }
        //for if we want type back
        //board[7, 0] = new Rook(false, 7, 0, "Rook");
        //board[7, 1] = new Knight(false, 7, 1, "Knight");
        //board[7, 2] = new Bishop(false, 7, 2, "Bishop");
        //board[7, 3] = new Queen(false, 7, 3, "Queen");
        //board[7, 4] = new King(false, 7, 4, "King");
        //board[7, 5] = new Bishop(false, 7, 5, "Bishop");
        //board[7, 6] = new Knight(false, 7, 6, "Knight");
        //board[7, 7] = new Rook(false, 7, 7, "Rook");
        //board[6, 0] = new Pawn(false, false, 7, 0, "Pawn");
        //board[6, 1] = new Pawn(false, false, 7, 1, "Pawn");
        //board[6, 2] = new Pawn(false, false, 7, 2, "Pawn");
        //board[6, 3] = new Pawn(false, false, 7, 3, "Pawn");
        //board[6, 4] = new Pawn(false, false, 7, 4, "Pawn");
        //board[6, 5] = new Pawn(false, false, 7, 5, "Pawn");
        //board[6, 6] = new Pawn(false, false, 7, 6, "Pawn");
        //board[6, 7] = new Pawn(false, false, 7, 7, "Pawn");


        public bool IsInCheck(bool is_white)
        {
            //finds position of the king
            int KingX = 0;
            int KingY = 0;
            for(int r = 0; r < 8; r++)
            {
                for(int n = 0; n < 8; n++)
                {
                    if (board[r,n].GetType() == typeof(King) && board[r,n].IsWhite == is_white)
                    {
                        KingX = r;
                        KingY = n;
                    }
                }
            }
            

            //check for knight checks
            if (KingX + 2 < 8 && KingY + 1 < 8)
            {
                if (board[KingX + 2, KingY + 1].GetType() == typeof(Knight) && board[KingX + 2, KingY + 1].IsWhite != is_white)
                {
                    return true;
                }
            }

            if (KingX + 1 < 8 && KingY + 2 < 8)
            {
                if (board[KingX + 1, KingY + 2].GetType() == typeof(Knight) && board[KingX + 1, KingY + 2].IsWhite != is_white)
                {
                    return true;
                }
            }

            if (KingX - 2 >= 0 && KingY + 1 < 8)
            {
                if (board[KingX - 2, KingY + 1].GetType() == typeof(Knight) && board[KingX - 2, KingY + 1].IsWhite != is_white)
                {
                    return true;
                }
            }

            if (KingX - 1 >= 0 && KingY + 2 < 8)
            {
                if (board[KingX - 1, KingY + 2].GetType() == typeof(Knight) && board[KingX - 1, KingY + 2].IsWhite != is_white)
                {
                    return true;
                }
            }

            if (KingX - 1 >= 0 && KingY - 2 >= 0)
            {
                if (board[KingX - 1, KingY - 2].GetType() == typeof(Knight) && board[KingX - 1, KingY - 2].IsWhite != is_white)
                {
                    return true;
                }
            }

            if (KingX - 2 >= 0 && KingY - 1 >= 0)
            {
                if (board[KingX - 2, KingY - 1].GetType() == typeof(Knight) && board[KingX - 2, KingY - 1].IsWhite != is_white)
                {
                    return true;
                }
            }

            if (KingX + 2 < 8 && KingY - 1 >= 0)
            {
                if (board[KingX + 2, KingY - 1].GetType() == typeof(Knight) && board[KingX + 2, KingY - 1].IsWhite != is_white)
                {
                    return true;
                }
            }

            if (KingX + 1 < 8 && KingY - 2 >= 0)
            {
                if (board[KingX + 1, KingY - 2].GetType() == typeof(Knight) && board[KingX + 1, KingY - 2].IsWhite != is_white)
                {
                    return true;
                }
            }
            int a = KingX + 1;
            int b = KingX - 1;
            int c = KingY + 1;
            int d = KingY - 1;
            //Checks for Rook/Queen check
            while (a < 8 && board[a, KingY].IsWhite != is_white)
            {
                if((board[a, KingY].GetType() == typeof(Queen)) && (board[a, KingY].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[a, KingY].GetType() == typeof(Rook)) && (board[a, KingY].IsWhite != is_white))
                {
                    return true;
                }
                a++;
            }

            while (b >= 0 && board[b, KingY].IsWhite != is_white)
            {
                if ((board[b, KingY].GetType() == typeof(Queen)) && (board[b, KingY].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[b, KingY].GetType() == typeof(Rook)) && (board[b, KingY].IsWhite != is_white))
                {
                    return true;
                }
                b--;
            }

            while (c < 8 && board[KingX, c].IsWhite != is_white)
            {
                if ((board[KingX, c].GetType() == typeof(Queen)) && (board[KingX, c].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[KingX, c].GetType() == typeof(Rook)) && (board[KingX, c].IsWhite != is_white))
                {
                    return true;
                }
                c++;
            }

            while (d >= 0 && board[KingX, d].IsWhite != is_white)
            {
                if ((board[KingX, d].GetType() == typeof(Queen)) && (board[KingX, d].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[KingX, d].GetType() == typeof(Rook)) && (board[KingX, d].IsWhite != is_white))
                {
                    return true;
                }
                d++;
            }

            while (a < 8 && board[a, c].IsWhite != is_white && c < 8)
            {
                if ((board[a, c].GetType() == typeof(Queen)) && (board[a, c].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[a, c].GetType() == typeof(Bishop)) && (board[a, c].IsWhite != is_white))
                {
                    return true;
                }
                a++;
                c++;
            }

            while (a < 8 && board[a, c].IsWhite != is_white && d < 8)
            {
                if ((board[a, d].GetType() == typeof(Queen)) && (board[a, d].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[a, d].GetType() == typeof(Bishop)) && (board[a, d].IsWhite != is_white))
                {
                    return true;
                }
                a++;
                d--;
            }

            while (b >= 0 && board[b, c].IsWhite != is_white && c < 8)
            {
                if ((board[b, c].GetType() == typeof(Queen)) && (board[b, c].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[b, c].GetType() == typeof(Bishop)) && (board[b, c].IsWhite != is_white))
                {
                    return true;
                }
                b--;
                c++;
            }

            while (b >= 0 && board[b, c].IsWhite != is_white && d >= 0)
            {
                if ((board[b, c].GetType() == typeof(Queen)) && (board[b, c].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[b, c].GetType() == typeof(Bishop)) && (board[b, c].IsWhite != is_white))
                {
                    return true;
                }
                b--;
                d--;
            }

            return false;
        }
    }
}
