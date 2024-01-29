using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        int nrX = 0, nrT = 0, nrO = 0, nr_sec = 0;
        bool win = false, tie = false;

        SoundPlayer sound = new SoundPlayer(@"D:\c#\TicTacToe\journey_begins.wav");

        Button[,] button_list = new Button[3, 3];
        string[,] button_grid = new string[3, 3];

        void check_win()
        {
            //check win for row
            for (int i = 0; i < 3; i++)
                if (button_grid[i, 0] == button_grid[i, 1] && button_grid[i, 1] == button_grid[i, 2])
                    if (button_grid[i, 0] == "X")
                    {
                        nrX++;
                        win = true;
                        label4.Text = nrX.ToString();
                    }
                    else if (button_grid[i, 0] == "O")
                    {
                        nrO++;
                        win = true;
                        label6.Text = nrO.ToString();
                    }
            //check win for col
            for (int j = 0; j < 3; j++)
                if (button_grid[0, j] == button_grid[1, j] && button_grid[1, j] == button_grid[2, j])
                    if (button_grid[0, j] == "X")
                    {
                        nrX++;
                        win = true;
                        label4.Text = nrX.ToString();
                    }
                    else if (button_grid[0, j] == "O")
                    {
                        nrO++;
                        win = true;
                        label6.Text = nrO.ToString();
                    }
            //check win for 1st diag
            if (button_grid[0, 0] == button_grid[1, 1] && button_grid[1, 1] == button_grid[2, 2])
                if (button_grid[0, 0] == "X")
                {
                    nrX++;
                    win = true;
                    label4.Text = nrX.ToString();
                }
                else if (button_grid[0, 0] == "O")
                {
                    nrO++;
                    win = true;
                    label6.Text = nrO.ToString();
                }
            //check win for 2nd diag
            if (button_grid[0, 2] == button_grid[1, 1] && button_grid[1, 1] == button_grid[2, 0])
                if (button_grid[1, 1] == "X")
                {
                    nrX++;
                    win = true;
                    label4.Text = nrX.ToString();
                }
                else if (button_grid[1, 1] == "O")
                {
                    nrO++;
                    win = true;
                    label6.Text = nrO.ToString();
                }
            if (win)
            {
                button4.Visible = true;
                foreach (Button button in button_list)
                    button.Enabled = false;
            }

        }
        bool isTie()
        {
            //check squares left
            foreach (string s in button_grid)
                if (s == "")
                    return false;
            return true;
        }
        void check_tie()
        {
            //check if tie
            if (isTie() && !win)
            {
                nrT++;
                label5.Text = nrT.ToString();
                tie = true;
                button4.Visible = true;
                foreach (Button button in button_list)
                    button.Enabled = false;

            }
        }

        int verify_score()
        {
            //verificare linii
            for (int i = 0; i < 3; i++)
                if (button_grid[i, 0] == button_grid[i, 1] && button_grid[i, 1] == button_grid[i, 2])
                    if (button_grid[i, 0] == "X")
                        return -10;
                    else if (button_grid[i, 0] == "O")
                        return 10;

            //verificare coloane
            for (int j = 0; j < 3; j++)
                if (button_grid[0, j] == button_grid[1, j] && button_grid[1, j] == button_grid[2, j])
                    if (button_grid[0, j] == "X")
                        return -10;
                    else if (button_grid[0, j] == "O")
                        return 10;

            //verificare diag principala
            if (button_grid[0, 0] == button_grid[1, 1] && button_grid[1, 1] == button_grid[2, 2])
                if (button_grid[0, 0] == "X")
                    return -10;
                else if (button_grid[1, 1] == "O")
                    return 10;

            //verificare diag secundara
            if (button_grid[0, 2] == button_grid[1, 1] && button_grid[1, 1] == button_grid[2, 0])
                if (button_grid[1, 1] == "X")
                    return -10;
                else if (button_grid[1, 1] == "O")
                    return 10;

            return 0;
        }
        int minimax(bool turn)
        {
            //minimax algorithm
            int score = verify_score();

            if (score == 10 || score == -10)
                return score;

            if (isTie() == true)
                return 0;

            if (turn)
            {
                //Bot(O) turn
                int best = -1000;
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (button_grid[i, j] == "")
                        {
                            button_grid[i, j] = "O";
                            best = Math.Max(best, minimax(!turn));
                            button_grid[i, j] = "";
                        }
                return best;
            }
            else
            {
                //Player(X) turn
                int best = 1000;
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (button_grid[i, j] == "")
                        {
                            button_grid[i, j] = "X";
                            best = Math.Min(best, minimax(!turn));
                            button_grid[i, j] = "";
                        }
                return best;
            }

        }

        class Move
        {
            public int row, col;
            public Move(int r, int c)
            {
                row = r;
                col = c;
            }
        }
        Move best_move()
        {
            //best move for bot
            int best = -1000;
            Move bestIndex = new Move(-1, -1);

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (button_grid[i, j] == "")
                    {
                        button_grid[i, j] = "O";
                        int value = minimax(false);
                        button_grid[i, j] = "";

                        if (value > best)
                        {
                            best = value;
                            bestIndex = new Move(i, j);
                        }
                    }
            return bestIndex;
        }
        void bot_move()
        {
            //making the move
            if (!win && !tie)
            {
                Move move = best_move();
                button_grid[move.row, move.col] = "O";
                button_list[move.row, move.col].Text = "O";
                check_win();

            }
        }

        void initialie_squares()
        {
            button_list[0, 0] = square1;
            button_list[0, 1] = square2;
            button_list[0, 2] = square3;
            button_list[1, 0] = square4;
            button_list[1, 1] = square5;
            button_list[1, 2] = square6;
            button_list[2, 0] = square7;
            button_list[2, 1] = square8;
            button_list[2, 2] = square9;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            sound.Play();
            initialie_squares();
            foreach (Button button in button_list)
                button.Click += button_click;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    button_grid[i, j] = "";
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 255, 255, 255), 10);
            l.DrawLine(pen, 285, 90, 285, 450);
            l.DrawLine(pen, 405, 90, 405, 450);
            l.DrawLine(pen, 165, 210, 525, 210);
            l.DrawLine(pen, 165, 330, 525, 330);
            l.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back
            sound.Stop();
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //reset
            foreach (Button button in button_list)
            {
                button.Text = "";
                button.Enabled = true;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    button_grid[i, j] = "";
            nr_sec = 0;
            timer1.Stop();
            button4.Visible = false;
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label8.Text = "00";
            label9.Text = "00";
            nrX = 0;
            nrT = 0;
            nrO = 0;
            win = false;
            tie = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //continue
            foreach (Button button in button_list)
            {
                button.Text = "";
                button.Enabled = true;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    button_grid[i, j] = "";
            win = false;
            tie = false;
            button4.Visible = false;
        }

        void button_click(object sender, EventArgs e)
        {
            //square click
            timer1.Start();
            Button button = sender as Button;
            if (button.Text == "")
            {
                button.Text = "X";
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (button_list[i, j].Name == button.Name)
                            button_grid[i, j] = button.Text;
                check_win();
                check_tie();
                bot_move();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nr_sec++;
            if (nr_sec%60 < 10)          
                label8.Text = "0" + (nr_sec % 60).ToString(); 
            else          
                label8.Text = (nr_sec % 60).ToString();
            label9.Text = "0" + (nr_sec / 60).ToString();


        }
    }
}
