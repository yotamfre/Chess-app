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

        

        public Board MakeBoard()
        {
            newBoard = new Board();
            board[0,0] = new Rook(false);
            return board;
        }


        

        public bool IsInCheck(bool is_white)
        {
            //finds position of the king
            int KingX = 0;
            int KingY = 0;
            for(int r = 0; r < 8; r++)
            {
                for(int c = 0; c < 8; c++)
                {
                    if (board[r,c].GetType() == typeof(King) && board[r,c].IsWhite == is_white)
                    {
                        KingX = r;
                        KingY = c;
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

            //Checks for Rook/Queen check
            for(int i = KingX; i < 8; i++)
            {
                if(typeof(board[i, KingY]) == typeof(Queen) && board[i, KingY].IsWhite != is_white)
                {
                    return true;
                }

                if (typeof(board[i, KingY]) == typeof(Rook) && board[i, KingY].IsWhite != is_white)
                {
                    return true;
                }
            }



            return false;
        }
    }
}
