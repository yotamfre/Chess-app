using ChessMasterGuruWarrior.Model.Board;
using ChessMasterGuruWarrior.Model.Piece;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ChessMasterGuruWarrior.ViewViewModel.Game
{
    class GameViewModel
    {
        private Board game_board { get; set; }
        public ObservableCollection<ObservableCollection<Piece>> gameBoard { get; }
        private Piece selectedPiece { get; set; }


        public GameViewModel()
        {
            game_board = new Board();
            game_board.MakeBoard();

            gameBoard = new ObservableCollection<ObservableCollection<Piece>>();
            this.loadBoard();
        }

        public Command<Piece> PieceClicked 
        { 
            get
            {
                return new Command<Piece>((Piece p) =>
                {
                    if (selectedPiece == null)
                    {
                        selectedPiece = p;
                    }

                    else
                    {
                        Board tryMove = selectedPiece.move(game_board, p.PosX, p.PosY);

                        if(tryMove == null)
                        {
                            selectedPiece = null;
                        }
                        else
                        {
                            game_board = tryMove;
                            loadBoard();
                        }
                    }
                });
            }
        }

        private void loadBoard()
        {
            for (int r = 0; r < 8; r++)
            {
                gameBoard.Add(new ObservableCollection<Piece>(game_board.getRow(r).ToList()));
            }
        }
    }
}
