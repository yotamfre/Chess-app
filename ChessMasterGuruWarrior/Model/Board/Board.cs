﻿using System;
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

        public Piece.Piece[] getRow(int row)
        {
            Piece.Piece[] arr = new Piece.Piece[8];

            for (int i = 0; i < 8; i++)
            {
                arr[i] = board[row, i];
            }

            return arr;
        }



        public void MakeBoard()
        {
            //instantiates black
            newBoard = new Board();
            board[0, 0] = new Rook(false, 0, 0);
            board[0, 1] = new Knight(false, 0, 1);
            board[0, 2] = new Bishop(false, 0, 2);
            board[0, 3] = new Queen(false, 0, 3);
            board[0, 4] = new King(false, 0, 4);
            board[0, 5] = new Bishop(false, 0, 5);
            board[0, 6] = new Knight(false, 0, 6);
            board[0, 7] = new Rook(false, 0, 7);
            board[1, 0] = new Pawn(false, false, 1, 0);
            board[1, 1] = new Pawn(false, false, 1, 1);
            board[1, 2] = new Pawn(false, false, 1, 2);
            board[1, 3] = new Pawn(false, false, 1, 3);
            board[1, 4] = new Pawn(false, false, 1, 4);
            board[1, 5] = new Pawn(false, false, 1, 5);
            board[1, 6] = new Pawn(false, false, 1, 6);
            board[1, 7] = new Pawn(false, false, 1, 7);

            //instantiates white
            board[7, 0] = new Rook(true, 7, 0);
            board[7, 1] = new Knight(true, 7, 1);
            board[7, 2] = new Bishop(true, 7, 2);
            board[7, 3] = new Queen(true, 7, 3);
            board[7, 4] = new King(true, 7, 4);
            board[7, 5] = new Bishop(true, 7, 5);
            board[7, 6] = new Knight(true, 7, 6);
            board[7, 7] = new Rook(true, 7, 7);
            board[6, 0] = new Pawn(false, true, 6, 0);
            board[6, 1] = new Pawn(false, true, 6, 1);
            board[6, 2] = new Pawn(false, true, 6, 2);
            board[6, 3] = new Pawn(false, true, 6, 3);
            board[6, 4] = new Pawn(false, true, 6, 4);
            board[6, 5] = new Pawn(false, true, 6, 5);
            board[6, 6] = new Pawn(false, true, 6, 6);
            board[6, 7] = new Pawn(false, true, 6, 7);

            //Determines color of empty square and instantiates it
            bool Is_White;

            for(int x = 2; x < 6; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if(((x + y) % 2) == 0)
                    {
                        Is_White = true;
                    }
                    else
                    {
                        Is_White = false;
                    }

                    board[x, y] = new EmptySquare(Is_White, x, y);
                }
            }
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
            bool e = false;

            //Checks for Rook/Queen check
            while (a < 8 && a >= 0 && board[a, KingY].IsWhite != is_white && e == false)
            {

                if((board[a, KingY].GetType() == typeof(Queen)) && (board[a, KingY].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[a, KingY].GetType() == typeof(Rook)) && (board[a, KingY].IsWhite != is_white))
                {
                    return true;
                }

                if (board[a, KingY].GetType() != typeof(EmptySquare))
                {
                    e = true;
                }

                a++;
            }

            a = KingX + 1;
            b = KingX - 1;
            c = KingY + 1;
            d = KingY - 1;
            e = false;

            while (b >= 0 && b < 8 && board[b, KingY].IsWhite != is_white && e == false)
            {
                if ((board[b, KingY].GetType() == typeof(Queen)) && (board[b, KingY].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[b, KingY].GetType() == typeof(Rook)) && (board[b, KingY].IsWhite != is_white))
                {
                    return true;
                }

                if (board[b, KingY].GetType() != typeof(EmptySquare))
                {
                    e = true;
                }

                b--;

            }

            a = KingX + 1;
            b = KingX - 1;
            c = KingY + 1;
            d = KingY - 1;
            e = false;

            while (c < 8 && c >= 0 && board[KingX, c].IsWhite != is_white && e == false)
            {
                if ((board[KingX, c].GetType() == typeof(Queen)) && (board[KingX, c].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[KingX, c].GetType() == typeof(Rook)) && (board[KingX, c].IsWhite != is_white))
                {
                    return true;
                }

                if (board[KingX, c].GetType() != typeof(EmptySquare))
                {
                    e = true;
                }

                c++;
            }

            a = KingX + 1;
            b = KingX - 1;
            c = KingY + 1;
            d = KingY - 1;
            e = false;

            while (d >= 0 && d < 8 && board[KingX, d].IsWhite != is_white && e == false)
            {
                if ((board[KingX, d].GetType() == typeof(Queen)) && (board[KingX, d].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[KingX, d].GetType() == typeof(Rook)) && (board[KingX, d].IsWhite != is_white))
                {
                    return true;
                }

                if (board[KingX, d].GetType() != typeof(EmptySquare))
                {
                    e = true;
                }

                d--;
            }

            a = KingX + 1;
            b = KingX - 1;
            c = KingY + 1;
            d = KingY - 1;
            e = false;

            while (a >= 0 && a < 8 && c >= 0 && c < 8 && board[a, c].IsWhite != is_white && e == false)
            {
                if ((board[a, c].GetType() == typeof(Queen)) && (board[a, c].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[a, c].GetType() == typeof(Bishop)) && (board[a, c].IsWhite != is_white))
                {
                    return true;
                }

                if (board[a, c].GetType() != typeof(EmptySquare))
                {
                    e = true;
                }

                a++;
                c++;
            }

            a = KingX + 1;
            b = KingX - 1;
            c = KingY + 1;
            d = KingY - 1;
            e = false;

            while (a >= 0 && a < 8 && d >= 0 && d < 8 && board[a, d].IsWhite != is_white && e == false)
            {
                if ((board[a, d].GetType() == typeof(Queen)) && (board[a, d].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[a, d].GetType() == typeof(Bishop)) && (board[a, d].IsWhite != is_white))
                {
                    return true;
                }

                if (board[a, d].GetType() != typeof(EmptySquare))
                {
                    e = true;
                }

                a++;
                d--;
            }

            a = KingX + 1;
            b = KingX - 1;
            c = KingY + 1;
            d = KingY - 1;
            e = false;

            while (b >= 0 && b < 8 && c >= 0 && c < 8 && board[b, c].IsWhite != is_white && e == false)
            {
                if ((board[b, c].GetType() == typeof(Queen)) && (board[b, c].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[b, c].GetType() == typeof(Bishop)) && (board[b, c].IsWhite != is_white))
                {
                    return true;
                }

                if (board[b, c].GetType() != typeof(EmptySquare))
                {
                    e = true;
                }

                b--;
                c++;
            }

            a = KingX + 1;
            b = KingX - 1;
            c = KingY + 1;
            d = KingY - 1;
            e = false;

            while (b >= 0 && b < 8 && d >= 0 && d < 8 && board[b, d].IsWhite != is_white && e == false)
            {
                if ((board[b, d].GetType() == typeof(Queen)) && (board[b, d].IsWhite != is_white))
                {
                    return true;
                }

                if ((board[b, d].GetType() == typeof(Bishop)) && (board[b, d].IsWhite != is_white))
                {
                    return true;
                }

                if (board[b, d].GetType() != typeof(EmptySquare))
                {
                    e = true;
                }

                b--;
                d--;
            }

            return false;
        }
    }
}
