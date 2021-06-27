using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public class CellButton : Button
    {
        private int m_ColNumber;
        private int m_RowNumber;
        private Cell.eCellMark m_Mark;

        public CellButton(int i_RowNumber, int i_ColNumber)
        {
            m_ColNumber = i_ColNumber;
            m_RowNumber = i_RowNumber;
            m_Mark = Cell.eCellMark.Mark_Empty;
        }

        public void InitButton()
        {
            this.Text = ((char)Logic.Cell.eCellMark.Mark_Empty).ToString();
            this.Enabled = true;
        }

        public int ColNumber
        {
            get
            {
                return m_ColNumber;
            }
            set
            {
                m_ColNumber = value;
            }
        }

        public int RowNumber
        {
            get
            {
                return m_RowNumber;
            }
            set
            {
                m_RowNumber = value;
            }
        }

        public Cell.eCellMark Mark
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
    }
}
