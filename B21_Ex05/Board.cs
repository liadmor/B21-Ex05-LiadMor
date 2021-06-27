using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic
{
    public class Board
    {
        int m_BoardSize;
        Cell[,] m_Board;

        public Board(int i_BoardSize)
        {
            m_BoardSize = i_BoardSize;
            initBoard();
        }

        public Cell[,] Board1
        {
            get
            {
                return m_Board;
            }
        }

        private void initBoard()
        {
            m_Board = new Cell[m_BoardSize, m_BoardSize];

            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    m_Board[i, j] = new Cell(i, j, Cell.eCellMark.Mark_Empty);
                }
            }
        }

        public static int IsValidSize(string i_SizeBoard)
        {
            int sizeOfBoard;

            if (Int32.TryParse(i_SizeBoard, out sizeOfBoard))
            {
                if ((sizeOfBoard > 9) || (sizeOfBoard < 3))
                {
                    sizeOfBoard = -1;
                }
            }
            else
            {
                sizeOfBoard = -1;
            }

            return sizeOfBoard;
        }

        public static Cell GetCellBoard(Board i_board, int i_row, int i_col)
        {
            return i_board.m_Board[i_row, i_col];
        }

        public static bool ThereIsWinner(Board i_Board, Cell i_Cell)
        {
            return checkColSequence(i_Board, i_Cell) || checkDiagonalSequence(i_Board, i_Cell) || checkRowSequence(i_Board, i_Cell);
        }

        public static bool checkRowSequence(Board i_Board, Cell i_Cell)
        {
            bool thereIsSequence = true;
            char cellMark;

            cellMark = (char)i_Cell.Mark;
            for (int i = 0; i < i_Board.m_BoardSize; i++)
            {
                if ((char)Board.GetCellBoard(i_Board, i_Cell.RowNumber, i).Mark != cellMark)
                {
                    thereIsSequence = false;
                }
            }

            return thereIsSequence;
        }

        private static bool checkColSequence(Board i_Board, Cell i_Cell)
        {
            bool thereIsSequence = true;
            char cellMark;

            cellMark = (char)i_Cell.Mark;
            for (int i = 0; i < i_Board.m_BoardSize; i++)
            {
                if ((char)Board.GetCellBoard(i_Board, i, i_Cell.ColNumber).Mark != cellMark)
                {
                    thereIsSequence = false;
                }
            }

            return thereIsSequence;
        }

        private static bool checkDiagonalSequence(Board i_Board, Cell i_Cell)
        {
            bool thereIsSequence = true;
            char cellMark;

            cellMark = (char)i_Cell.Mark;
            if ((i_Cell.ColNumber != i_Cell.RowNumber) && (i_Cell.ColNumber != (i_Board.m_BoardSize - i_Cell.RowNumber - 1)))
            {
                thereIsSequence = false;
            }
            else
            {
                if (i_Cell.ColNumber == i_Cell.RowNumber)
                {
                    for (int i = 0; i < i_Board.m_BoardSize; i++)
                    {
                        if ((char)Board.GetCellBoard(i_Board, i, i).Mark != cellMark)
                        {
                            thereIsSequence = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < i_Board.m_BoardSize; i++)
                    {
                        if ((char)Board.GetCellBoard(i_Board, i, i_Board.m_BoardSize - i - 1).Mark != cellMark)
                        {
                            thereIsSequence = false;
                        }
                    }
                }
            }

            return thereIsSequence;
        }

        public static bool CheckIfTheBoardIsFull(Board i_Board)
        {
            bool isFull = true;

            for (int i = 0; i < i_Board.m_BoardSize; i++)
            {
                for (int j = 0; j < i_Board.m_BoardSize; j++)
                {
                    if (Cell.IsEmpty(Board.GetCellBoard(i_Board, i, j)))
                    {
                        isFull = false;
                    }
                }
            }

            return isFull;
        }

        public int BoardSize
        {
            get
            {
                return m_BoardSize;
            }
        }
    }
}
