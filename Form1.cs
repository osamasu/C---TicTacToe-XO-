using Osama_Tic_Tac_Toe.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Osama_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public enum enPlayerTurn { Player1 = 1, Player2 = 2 };

        public class clsSettings
        {


            public char[,] GameBoard = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            public enPlayerTurn PlayerTurn;
            public Byte PlayCount;

        }
        clsSettings Settings = new clsSettings();
        public Form1()
        {
            InitializeComponent();


            lb_GameWinner.Text = "In Progress";

            Settings.PlayerTurn = (enPlayerTurn)rnd.Next(1, 3);
            lb_PlayerTurn.Text = Settings.PlayerTurn.ToString();


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen WhitePen = new Pen(White);

            WhitePen.Width = 15;

            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Draw Horizentaly

            e.Graphics.DrawLine(WhitePen, 400, 350, 1050, 350);
            e.Graphics.DrawLine(WhitePen, 400, 520, 1050, 520);

            // Draw Vertical Lines

            e.Graphics.DrawLine(WhitePen, 610, 205, 610, 665);
            e.Graphics.DrawLine(WhitePen, 840, 205, 840, 665);

        }

        private bool CheckWinner()
        {
            for (Byte i = 0; i < 3; i++)
            {
                if (Settings.GameBoard[i, 0] == Settings.GameBoard[i, 1] && Settings.GameBoard[i, 0] == Settings.GameBoard[i, 2])
                    return true;

                if (Settings.GameBoard[0, i] == Settings.GameBoard[1, i] && Settings.GameBoard[0, i] == Settings.GameBoard[2, i])
                    return true;
            }

            if (Settings.GameBoard[1, 1] == Settings.GameBoard[0, 2] && Settings.GameBoard[1, 1] == Settings.GameBoard[2, 0])
                return true;

            if (Settings.GameBoard[1, 1] == Settings.GameBoard[0, 0] && Settings.GameBoard[1, 1] == Settings.GameBoard[2, 2])
                return true;


            return false;
        }

        private void SwitchPlayerTurn()
        {
            if (Settings.PlayerTurn == enPlayerTurn.Player1)
            {
                Settings.PlayerTurn = enPlayerTurn.Player2;
            }
            else
            {
                Settings.PlayerTurn = enPlayerTurn.Player1;
            }

            lb_PlayerTurn.Text = Settings.PlayerTurn.ToString();
        }
        private void ChangeFieldImage(Button ChoosenField, SByte[] PlayedPosition)
        {
            if (IsEmptyField(ChoosenField))
            {
                switch (Settings.PlayerTurn)
                {
                    case enPlayerTurn.Player1:
                        {
                            ChoosenField.Image = Resources.X;
                            Settings.GameBoard[PlayedPosition[0], PlayedPosition[1]] = 'X';

                            break;
                        }

                    case enPlayerTurn.Player2:
                        {
                            ChoosenField.Image = Resources.O;
                            Settings.GameBoard[PlayedPosition[0], PlayedPosition[1]] = 'O';

                            break;
                        }
                }

                Settings.PlayCount++;
                ChoosenField.Tag = "Checked";

                if (CheckWinner().Equals(true))
                {
                    lb_GameWinner.Text = Settings.PlayerTurn.ToString();

                    MessageBox.Show($"Congratulations [ {Settings.PlayerTurn.ToString()} ] - You Have Won :-)", "We Have Winner",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    return;
                }

                if (Settings.PlayCount == 9)
                {
                    lb_GameWinner.Text = "Draw";
                    return;
                }

                SwitchPlayerTurn();
            }
            else
            {
                MessageBox.Show("Wrong Choice , This Field Already Taken - Choose Another Empty Field", "Taken Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsEmptyField(Button ChoosenField) => (ChoosenField.Tag == "?");



        private void GameBtn1_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 0, 0 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void GameBtn2_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 0, 1 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void GameBtn3_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 0, 2 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void GameBtn4_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 1, 0 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void GameBtn5_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 1, 1 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void GameBtn6_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 1, 2 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void GameBtn7_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 2, 0 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void GameBtn8_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 2, 1 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void GameBtn9_Click(object sender, System.EventArgs e)
        {
            SByte[] PlayedPosition = new SByte[2] { 2, 2 };
            ChangeFieldImage((Button)sender, PlayedPosition);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            GameBtn1.Image = Resources.question_mark_96;
            GameBtn2.Image = Resources.question_mark_96;
            GameBtn3.Image = Resources.question_mark_96;
            GameBtn4.Image = Resources.question_mark_96;
            GameBtn5.Image = Resources.question_mark_96;
            GameBtn6.Image = Resources.question_mark_96;
            GameBtn7.Image = Resources.question_mark_96;
            GameBtn8.Image = Resources.question_mark_96;
            GameBtn9.Image = Resources.question_mark_96;

            GameBtn1.Tag = "?";
            GameBtn2.Tag = "?";
            GameBtn3.Tag = "?";
            GameBtn4.Tag = "?";
            GameBtn5.Tag = "?";
            GameBtn6.Tag = "?";
            GameBtn7.Tag = "?";
            GameBtn8.Tag = "?";
            GameBtn9.Tag = "?";

            Settings = new clsSettings();
            lb_GameWinner.Text = "In Progress";

            Settings.PlayerTurn = (enPlayerTurn)rnd.Next(1, 3);
            lb_PlayerTurn.Text = Settings.PlayerTurn.ToString();
        }
    }
}
