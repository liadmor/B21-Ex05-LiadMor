using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Cell
    {
        readonly int m_RowNumber;
        readonly int m_ColNumber;
        eCellMark m_Mark;

        public Cell(int i_RowNumber, int i_ColNumber, eCellMark i_Mark)
        {
            m_RowNumber = i_RowNumber;
            m_ColNumber = i_ColNumber;
            m_Mark = i_Mark;
        }

        public enum eCellMark
        {
            Mark_Empty = ' ',
            Mark_X = 'X',
            Mark_O = 'O',
        }

        public static Cell FindCellForPerson(Player i_NowPlaying, Board i_Board, int i_RowNumber, int i_ColNumber)
        {
            int boardSize;
            Cell validCell = new Cell(-1, -1, eCellMark.Mark_Empty);

            boardSize = i_Board.BoardSize;
            if (i_RowNumber == -1)
            {
                validCell = new Cell(-1, -1, eCellMark.Mark_Empty);
            }
            else
            {
                if (i_ColNumber == -1)
                {
                    validCell = new Cell(-1, -1, eCellMark.Mark_Empty);
                }
                else
                {
                    validCell = Board.GetCellBoard(i_Board, i_RowNumber - 1, i_ColNumber - 1);
                }
            }

            return validCell;
        }

        public static Cell FindCellForComputer(Board i_Board, Random i_RndNumber)
        {
            int rowNumber, colNumber, boardSize;

            Cell validCell = new Cell(-1, -1, eCellMark.Mark_Empty);
            boardSize = i_Board.BoardSize;
            rowNumber = i_RndNumber.Next(1, boardSize + 1);
            colNumber = i_RndNumber.Next(1, boardSize + 1);
            validCell = Board.GetCellBoard(i_Board, rowNumber - 1, colNumber - 1);

            return validCell;
        }

        public static int ValidInputAxis(string i_RowInput, int i_BoardSize)
        {
            int numberRow;

            if (Int32.TryParse(i_RowInput, out numberRow))
            {
                if ((numberRow > i_BoardSize) || (numberRow < 1))
                {
                    numberRow = -1;
                }
            }
            else
            {
                numberRow = -1;
            }

            return numberRow;
        }

        public static bool IsEmpty(Cell i_Cell)
        {
            bool cellIsEmpty = true;

            if ((char)i_Cell.m_Mark != (char)eCellMark.Mark_Empty)
            {
                cellIsEmpty = false;
            }

            return cellIsEmpty;
        }

        public eCellMark Mark
        {
            get
            {
                return m_Mark;

            }
            set
            {
                m_Mark = value;
            }
        }

        public int RowNumber
        {
            get
            {
                return m_RowNumber;
            }
        }

        public int ColNumber
        {
            get
            {
                return m_ColNumber;
            }
        }
    }
}
