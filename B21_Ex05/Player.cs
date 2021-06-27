using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Player
    {
        readonly string m_PlayerType;
        readonly Cell.eCellMark m_PlayerMark;
        private int m_NumberOfPoint;
        private string m_Name;

        public Player(string i_PlayerType, Cell.eCellMark i_PlayerMark, string i_Name)
        {
            m_PlayerType = i_PlayerType;
            m_PlayerMark = i_PlayerMark;
            m_NumberOfPoint = 0;
            m_Name = i_Name;
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        public static bool IsValidPlayer(string i_player)
        {
            bool isValid = true;

            if ((i_player != "c") && (i_player != "p"))
            {
                isValid = false;
            }

            return isValid;
        }

        public string PlayerType
        {
            get
            {
                return m_PlayerType;
            }
        }

        public Cell.eCellMark PlayerMark
        {
            get
            {
                return m_PlayerMark;
            }
        }

        public int NumberOfPoint
        {
            get
            {
                return m_NumberOfPoint;
            }
            set
            {
                m_NumberOfPoint += value;
            }
        }
    }
}
