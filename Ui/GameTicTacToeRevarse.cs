using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Ui
{
    public class GameTicTacToeRevarse
    {
        private Player m_PlayerX;
        private Player m_PlayerO;
        private Player m_NowPlaying;
        private Player m_WaitingPlayer;
        private Board m_Board;
        private Random m_RndNumber = new Random();


        public GameTicTacToeRevarse(string i_PlayerXName, string i_PlayerOName, bool i_PlayerOPerson, int i_BoardSize)
        {
            m_PlayerX = new Player("p", Cell.eCellMark.Mark_X, i_PlayerXName);
            if (i_PlayerOPerson)
            {
                m_PlayerO = new Player("p", Cell.eCellMark.Mark_O, i_PlayerOName);
            }
            else
            {
                m_PlayerO = new Player("c", Cell.eCellMark.Mark_O, i_PlayerOName);
            }
            m_NowPlaying = m_PlayerX;
            m_WaitingPlayer = m_PlayerO;
            m_Board = new Board(i_BoardSize);
        }

        public void ChangePlayers()
        {
            if(m_NowPlaying.PlayerMark == m_PlayerX.PlayerMark)
            {
                m_NowPlaying = m_PlayerO;
                m_WaitingPlayer = m_PlayerX;
            }
            else
            {
                m_NowPlaying = m_PlayerX;
                m_WaitingPlayer = m_PlayerO;
            }
        }

        public Player PlayerX
        {
            get
            {
                return m_PlayerX;
            }
            set
            {
                m_PlayerX = value;
            }
        }
        public Player PlayerO
        {
            get
            {
                return m_PlayerO;
            }
            set
            {
                m_PlayerO = value;
            }
        }

        public Player NowPlaying
        {
            get
            {
                return m_NowPlaying;
            }
            set
            {
                m_NowPlaying = value;
            }
        }

        public Player WaitingPlayer
        {
            get
            {
                return m_WaitingPlayer;
            }
            set
            {
                m_WaitingPlayer = value;
            }
        }

        public Board Board
        {
            get
            {
                return m_Board;
            }
            set
            {
                m_Board = value;
            }
        }

        public Cell RunGame(int i_RowNumber, int i_ColNumber, Player i_NowPlaying)
        {
            Cell cell;
            
            if(i_NowPlaying.Name != "Computer")
            {
                cell = Board.GetCellBoard(m_Board, i_RowNumber, i_ColNumber);
                cell.Mark = m_NowPlaying.PlayerMark;
            }
            else
            {
                cell = Cell.FindCellForComputer( m_Board, m_RndNumber);
                while (!Cell.IsEmpty(cell))
                {
                    cell = Cell.FindCellForComputer(m_Board, m_RndNumber);
                }

                cell.Mark = m_NowPlaying.PlayerMark;
            }
            ChangePlayers();
            return cell;
        }
    }
}
