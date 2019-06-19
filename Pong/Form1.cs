using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form

    {
        bool goup;
        bool godown;
        int speed = 5;
        int ballX;
        int ballY = 5;
        int score = 0;
        int lblcounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            
            
                pnl_ball.Location = new Point(420, 195);
                tmr_ball.Enabled = true;
            

        }

        private void tmr_ball_Tick(object sender, EventArgs e)
        {
            lbl_counter1.Text = "" + score;
            lbl_counter2.Text = "" + lblcounter;

            pnl_ball.Top -= ballY;
            pnl_ball.Left -= ballX;

            pnl_player2.Top += speed;

            if (score < 5)
            {
                if (pnl_player2.Top < 0 || pnl_player2.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                pnl_player2.Top = pnl_ball.Top + 30;
            }
            
            if (pnl_ball.Left < 0)
            {
                pnl_ball.Left = 0;
                ballX = -ballX;
                ballX -= 2;
                lblcounter++;
            }
            
            if (pnl_ball.Left + pnl_ball.Width > ClientSize.Width)
            {
                pnl_ball.Left = 0;
                ballX = -ballX;
                ballX += 2;
                score++;
            }

            if (pnl_ball.Top < 0 || pnl_ball.Top + pnl_ball.Height > ClientSize.Height)
            {
                ballY = -ballY;
            }

            if (pnl_ball.Bounds.IntersectsWith(pnl_player1.Bounds) || pnl_ball.Bounds.IntersectsWith(pnl_player2.Bounds))
            {
                ballX = -ballX;
            }

            if (goup == true && pnl_player1.Top > 0)
            {
                pnl_player1.Top -= 8;
            }

            if (godown == true && pnl_player1.Top < 455)
            {
                pnl_player1.Top += 8;
            }

            if (score > 10)
            {
                tmr_ball.Stop();
                MessageBox.Show("Herzlichen Glükwunsch! Du hast gewonnen");
            }

            if (lblcounter > 10)
            {
                tmr_ball.Stop();
                MessageBox.Show("Schade! Du hast verloren");
            }

        }
private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
                
        }
    }
}
