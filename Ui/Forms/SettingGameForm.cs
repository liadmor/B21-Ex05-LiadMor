using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ui.Forms
{
    public class SettingGameForm : Form
    {
        private Label m_Players;
        private CheckBox m_CheckBoxPlayer2;
        private TextBox m_TextBoxPlayer1;
        private TextBox m_TextBoxPlayer2;
        private Label m_BoardSize;
        private Label label4;
        private NumericUpDown m_NumberOfRows;
        private Label label5;
        private NumericUpDown m_NumerOfColumn;
        private Button m_StartButton;
        private Label lablePlayer1;

        public SettingGameForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingGameForm));
            this.m_Players = new System.Windows.Forms.Label();
            this.lablePlayer1 = new System.Windows.Forms.Label();
            this.m_CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.m_TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.m_TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.m_BoardSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_NumberOfRows = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.m_NumerOfColumn = new System.Windows.Forms.NumericUpDown();
            this.m_StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumerOfColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // Players
            // 
            this.m_Players.AutoSize = true;
            this.m_Players.Location = new System.Drawing.Point(13, 13);
            this.m_Players.Name = "Players";
            this.m_Players.Size = new System.Drawing.Size(68, 20);
            this.m_Players.TabIndex = 0;
            this.m_Players.Text = "Players: ";
            this.m_Players.Click += new System.EventHandler(this.label1_Click);
            // 
            // lablePlayer1
            // 
            this.lablePlayer1.AutoSize = true;
            this.lablePlayer1.Location = new System.Drawing.Point(34, 45);
            this.lablePlayer1.Name = "lablePlayer1";
            this.lablePlayer1.Size = new System.Drawing.Size(69, 20);
            this.lablePlayer1.TabIndex = 1;
            this.lablePlayer1.Text = "Player 1:";
            this.lablePlayer1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // checkBoxPlyer2
            // 
            this.m_CheckBoxPlayer2.AutoSize = true;
            this.m_CheckBoxPlayer2.Location = new System.Drawing.Point(38, 78);
            this.m_CheckBoxPlayer2.Name = "checkBoxPlyer2";
            this.m_CheckBoxPlayer2.Size = new System.Drawing.Size(95, 24);
            this.m_CheckBoxPlayer2.TabIndex = 2;
            this.m_CheckBoxPlayer2.Text = "Player 2:";
            this.m_CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.m_CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxPlayer1
            // 
            this.m_TextBoxPlayer1.Location = new System.Drawing.Point(130, 46);
            this.m_TextBoxPlayer1.Name = "textBoxPlayer1";
            this.m_TextBoxPlayer1.Size = new System.Drawing.Size(156, 26);
            this.m_TextBoxPlayer1.TabIndex = 3;
            // 
            // textBoxPlayer2
            // 
            this.m_TextBoxPlayer2.Enabled = false;
            this.m_TextBoxPlayer2.Location = new System.Drawing.Point(130, 78);
            this.m_TextBoxPlayer2.Name = "textBoxPlayer2";
            this.m_TextBoxPlayer2.Size = new System.Drawing.Size(156, 26);
            this.m_TextBoxPlayer2.TabIndex = 4;
            this.m_TextBoxPlayer2.Text = "Computer";
            // 
            // BoardSize
            // 
            this.m_BoardSize.AutoSize = true;
            this.m_BoardSize.Location = new System.Drawing.Point(13, 132);
            this.m_BoardSize.Name = "BoardSize";
            this.m_BoardSize.Size = new System.Drawing.Size(91, 20);
            this.m_BoardSize.TabIndex = 5;
            this.m_BoardSize.Text = "Board Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rows: ";
            // 
            // numRows
            // 
            this.m_NumberOfRows.Location = new System.Drawing.Point(101, 166);
            this.m_NumberOfRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.m_NumberOfRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.m_NumberOfRows.Name = "numRows";
            this.m_NumberOfRows.Size = new System.Drawing.Size(55, 26);
            this.m_NumberOfRows.TabIndex = 7;
            this.m_NumberOfRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.m_NumberOfRows.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cols:";
            // 
            // numColmn
            // 
            this.m_NumerOfColumn.Location = new System.Drawing.Point(232, 166);
            this.m_NumerOfColumn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.m_NumerOfColumn.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.m_NumerOfColumn.Name = "numColmn";
            this.m_NumerOfColumn.Size = new System.Drawing.Size(55, 26);
            this.m_NumerOfColumn.TabIndex = 9;
            this.m_NumerOfColumn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.m_NumerOfColumn.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // StartButton
            // 
            this.m_StartButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.m_StartButton.Location = new System.Drawing.Point(76, 215);
            this.m_StartButton.Name = "StartButton";
            this.m_StartButton.Size = new System.Drawing.Size(160, 34);
            this.m_StartButton.TabIndex = 10;
            this.m_StartButton.Text = "Start!";
            this.m_StartButton.UseVisualStyleBackColor = false;
            this.m_StartButton.Click += new System.EventHandler(this.buttun_Click);
            // 
            // SettingGameForm
            // 
            this.AccessibleDescription = "";
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(298, 254);
            this.Controls.Add(this.m_StartButton);
            this.Controls.Add(this.m_NumerOfColumn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_NumberOfRows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_BoardSize);
            this.Controls.Add(this.m_TextBoxPlayer2);
            this.Controls.Add(this.m_TextBoxPlayer1);
            this.Controls.Add(this.m_CheckBoxPlayer2);
            this.Controls.Add(this.lablePlayer1);
            this.Controls.Add(this.m_Players);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingGameForm";
            this.Text = "Settings ";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumerOfColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void textBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void buttun_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (m_CheckBoxPlayer2.CheckState == CheckState.Checked)
            {
                m_TextBoxPlayer2.Enabled = true;
                m_TextBoxPlayer2.Text = string.Empty;
            }
            else
            {
                m_TextBoxPlayer2.Enabled = false;
                m_TextBoxPlayer2.Text = "Computer";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.m_NumerOfColumn.Value = this.m_NumberOfRows.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.m_NumberOfRows.Value = this.m_NumerOfColumn.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public string Player1Name
        {
            get
            {
                return m_TextBoxPlayer1.Text;
            }
        }

        public string Player2Name
        {
            get
            {
                return m_TextBoxPlayer2.Text;
            }
        }

        public bool CheckBoxPlayer2
        {
            get
            {
                return m_CheckBoxPlayer2.Checked;
            }
        }

        public int NumerOfColumn
        {
            get
            {
                return (int)this.m_NumerOfColumn.Value;
            }
        }

        public string textBoxPlayer1
        {
            get
            {
                return this.m_TextBoxPlayer1.Text;
            }
        }




        private void Player1_Click(object sender, EventArgs e)
        {

        }
    }
}
