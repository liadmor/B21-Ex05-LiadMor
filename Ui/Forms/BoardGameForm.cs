using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Ui;
using Logic;

namespace Ui.Forms
{
    class BoardGameForm : Form
    {
        private Label m_Players1NameLable;
        private Label m_Players1ScoureLable;
        private Label m_Players2NameLable;
        private Label m_Players2ScoureLable;
        private SettingGameForm m_SettingGame = new SettingGameForm();
        private CellButton[,] m_ButtonArray;
        private GameTicTacToeRevarse m_Game;
        private const int k_MargingLetter = 5;
        private const int k_AsixY = 20;
        private const int k_WidthAndHeight = 35;
        private const int k_MarginCell = 2;
        private const int k_MarginGap = 10;

        public BoardGameForm()
        {
            if(m_SettingGame.ShowDialog() == DialogResult.OK)
            {             
                m_Game = new GameTicTacToeRevarse(m_SettingGame.Player1Name, m_SettingGame.Player2Name, true ? m_SettingGame.CheckBoxPlayer2 : false, m_SettingGame.NumerOfColumn);
                this.InitializeComponent();
                this.ShowDialog();
            }
        }

        private void InitializeComponent()
        {
            int axisX = 5, axisY = 5, count = 0, clientSizeX, clientSizeY, sizeOfBoard;

            sizeOfBoard = m_SettingGame.NumerOfColumn;
            this.m_ButtonArray = new CellButton[sizeOfBoard,sizeOfBoard];
            this.Text = "Tic Tac Toe Reverse";
            this.m_Players1NameLable = new System.Windows.Forms.Label();
            this.m_Players1ScoureLable = new System.Windows.Forms.Label();
            this.m_Players2NameLable = new System.Windows.Forms.Label();
            this.m_Players2ScoureLable = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // m_Players1Name
            // 
            this.m_Players1NameLable.AutoSize = true;
            this.m_Players1NameLable.Location = new System.Drawing.Point(k_MargingLetter, sizeOfBoard * k_WidthAndHeight + sizeOfBoard * k_MarginCell + k_MarginGap);
            this.m_Players1NameLable.Name = "Players1Name";
            this.m_Players1NameLable.TabIndex = 0;
            this.m_Players1NameLable.Text = m_Game.PlayerX.Name.ToString() + ":";

            // 
            // m_Players1Scoure
            // 
            this.m_Players1ScoureLable.AutoSize = true;
            this.m_Players1ScoureLable.Location = new System.Drawing.Point(k_MarginGap + m_Players1NameLable.Left + m_Players1NameLable.Text.Length * k_MargingLetter, sizeOfBoard * k_WidthAndHeight + sizeOfBoard * k_MarginCell + k_MarginGap);
            this.m_Players1ScoureLable.Name = "Players1Scoure";
            this.m_Players1ScoureLable.TabIndex = 1;
            this.m_Players1ScoureLable.Text = m_Game.PlayerX.NumberOfPoint.ToString();

            // 
            // m_Players2Name
            // 
            this.m_Players2NameLable.AutoSize = true;
            this.m_Players2NameLable.Location = new System.Drawing.Point(m_Players1ScoureLable.Left + (k_MarginCell * k_MarginGap), sizeOfBoard * k_WidthAndHeight + sizeOfBoard * k_MarginCell + k_MarginGap);
            this.m_Players2NameLable.Name = "Players2Name";
            this.m_Players2NameLable.TabIndex = 2;
            this.m_Players2NameLable.Text = m_Game.PlayerO.Name.ToString() +":";

            // 
            // m_Players2Scoure
            // 
            this.m_Players2ScoureLable.AutoSize = true;
            this.m_Players2ScoureLable.Location = new System.Drawing.Point(k_MarginGap + m_Players2NameLable.Left + m_Players2NameLable.Text.Length * k_MargingLetter, sizeOfBoard * k_WidthAndHeight + sizeOfBoard * k_MarginCell + k_MarginGap);
            this.m_Players2ScoureLable.Name = "Players2Scoure";
            this.m_Players2ScoureLable.TabIndex = 3;
            this.m_Players2ScoureLable.Text = m_Game.PlayerO.NumberOfPoint.ToString();

            // 
            // BordGameForm
            // 
            for (int j = 0; j < sizeOfBoard; j++)
            {
                for (int i = 0; i < sizeOfBoard; i++)
                {
                    this.m_ButtonArray[j, i] = new CellButton(j, i);
                    setButtonInfo(j, i, axisX, axisY);
                    axisX += k_WidthAndHeight + k_MarginCell;
                    this.Controls.Add(m_ButtonArray[j, i]);
                    count++;
                }

                axisX = k_MargingLetter;
                axisY += k_WidthAndHeight + k_MarginCell;
            }

            this.Controls.Add(this.m_Players1NameLable);
            this.Controls.Add(this.m_Players1ScoureLable);
            this.Controls.Add(this.m_Players2NameLable);
            this.Controls.Add(this.m_Players2ScoureLable);
            this.Name = "BordGameForm";
            this.Load += new System.EventHandler(this.BordGameForm_Load);
            clientSizeX = Math.Max(m_Players2ScoureLable.Left + (m_Players2ScoureLable.Text.Length * k_MargingLetter), sizeOfBoard * (k_WidthAndHeight + k_MarginCell) + (k_MarginCell * k_MarginGap));
            clientSizeY = Math.Max(m_Players2ScoureLable.Top, (k_MargingLetter + (k_MarginCell * k_MarginGap)) + axisY) + (k_MargingLetter + (k_MarginCell * k_MarginGap));
            this.ClientSize = new Size(clientSizeX, clientSizeY);
            stylingForScoureBar();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void setButtonInfo(int i_row, int i_col, int i_asixXGap, int i_asixYGap)
        {
            this.m_ButtonArray[i_row, i_col].Text = ((char)m_ButtonArray[i_row, i_col].Mark).ToString();
            this.m_ButtonArray[i_row, i_col].Width = k_WidthAndHeight;
            this.m_ButtonArray[i_row, i_col].Height = k_WidthAndHeight;
            this.m_ButtonArray[i_row, i_col].Click += TicTacToeButtonCell_Click;
            this.m_ButtonArray[i_row, i_col].Left = i_asixXGap;
            this.m_ButtonArray[i_row, i_col].Top = i_asixYGap;
        }

        void TicTacToeButtonCell_Click(object sender, EventArgs e)
        {
            CellButton clickedButton = (CellButton)sender;
            clickedButton.Text = ((char)m_Game.NowPlaying.PlayerMark).ToString();
            clickedButton.Enabled = false;
            Cell cell = this.m_Game.RunGame(clickedButton.RowNumber, clickedButton.ColNumber, m_Game.NowPlaying);
            checkAndAnnouceIfTheGameOver(cell);
            if (m_Game.NowPlaying.Name == "Computer")
            {
                cell = this.m_Game.RunGame(clickedButton.RowNumber, clickedButton.ColNumber, m_Game.NowPlaying);
                this.m_ButtonArray[cell.RowNumber, cell.ColNumber].Text = ((char)m_Game.WaitingPlayer.PlayerMark).ToString();
                this.m_ButtonArray[cell.RowNumber, cell.ColNumber].Enabled = false;
                checkAndAnnouceIfTheGameOver(cell);
            }
        }

        private void checkAndAnnouceIfTheGameOver(Cell i_Cell)
        {
            string msg;

            if (CheckIfThereIsWinner(i_Cell))
            {
                msg = String.Format("The winner is {0}{1} Would you like to play another round?", m_Game.NowPlaying.Name, Environment.NewLine);
                if (MessageBox.Show(msg, "A Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.m_Game.NowPlaying.NumberOfPoint = 1;
                    setAnotherRound();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (CheckIfTheBoardIsFull(m_Game.Board))
                {
                    msg = String.Format("Tie!{0}Would you like to play another round?", Environment.NewLine);
                    if (MessageBox.Show(msg, "A Tie!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        setAnotherRound();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    stylingForScoureBar();
                }
            }
        }

        private void setAnotherRound()
        {
            this.m_Game.Board = new Board(m_Game.Board.BoardSize);
            foreach (CellButton btm in m_ButtonArray)
            {
                btm.InitButton();
            }

            this.m_Players1ScoureLable.Text = m_Game.PlayerX.NumberOfPoint.ToString();
            this.m_Players2ScoureLable.Text = m_Game.PlayerO.NumberOfPoint.ToString();
            stylingForScoureBar();
        }

         private bool CheckIfThereIsWinner(Cell i_Cell)
        {
            return Board.ThereIsWinner(m_Game.Board, i_Cell);
        }

        private bool CheckIfTheBoardIsFull(Board i_Board)
        {
            return Board.CheckIfTheBoardIsFull(i_Board);
        }

        private void stylingForScoureBar()
        {
            if ((char)m_Game.NowPlaying.PlayerMark == 'X')
            {
                this.m_Players1NameLable.Font = new Font(Font, FontStyle.Bold);
                this.m_Players1ScoureLable.Font = new Font(Font, FontStyle.Bold);
                this.m_Players2NameLable.Font = new Font(Font, FontStyle.Regular);
                this.m_Players2ScoureLable.Font = new Font(Font, FontStyle.Regular);
            }
            else
            {
                this.m_Players2NameLable.Font = new Font(Font, FontStyle.Bold);
                this.m_Players2ScoureLable.Font = new Font(Font, FontStyle.Bold);
                this.m_Players1NameLable.Font = new Font(Font, FontStyle.Regular);
                this.m_Players1ScoureLable.Font = new Font(Font, FontStyle.Regular);
            }
        }

        private void BordGameForm_Load(object sender, EventArgs e)
        {
        }
    }
}
