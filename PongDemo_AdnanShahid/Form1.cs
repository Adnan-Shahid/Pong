//Adnan Shahid
//May 21 2014
//Pong Assignment
//Make a succesfully working Pong game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongDemo_AdnanShahid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Global Variables
        int intSpeed = 5;   //Global ball speed
        int intAngle = 45;  //Set starting angle
        int intxMove = 0;
        int intyMove = 0;
        int intDirectionX = 1;
        int intDirectionY = 1;
        int intComputerScore = 0;
        int intPlayerScore = 0;
        Random RandomClass = new Random();
        int intRandom;
        int intRandom2;
        int intRandom3;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t\tWelcome to SuperPong!\n\t\tMake the ball hit the top of the screen to win! \n\tUse the A button to move left and use the D button to move right");
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            intRandom = RandomClass.Next(1,69); //Random numbers for computer loss chance
            intRandom2 = RandomClass.Next(0,10); //Computer movement if chance for loss
            intRandom3 = RandomClass.Next(0,10);
           
            //gets angle from predetermined text
            this.txtDegree.Text = "225";
            intAngle = Int32.Parse(this.txtDegree.Text);
            this.txtDegree.Text = intAngle.ToString();
            //Math for ball movement
            intxMove = horizontalVal(intSpeed, intAngle);
            intyMove = verticalVal(intSpeed, intAngle);

            //Ball Movement
            this.lblBall.Left += intxMove * intDirectionX;
            this.lblBall.Top -= intyMove * intDirectionY;




            if (this.lblBall.Left < 0)  //Changing ball direction when hitting left wall
            {
                intDirectionX = 1;
            }
            if (this.lblBall.Left > (this.Width - 34)) //Changing ball direction when hitting right wall
            {
                intDirectionX = -1;
            }

            if (intxMove > 0) //Changing ball direction when hitting right wall - when xMoveValue is greater than 0
            {
                if (this.lblBall.Left > (this.Width - 40))
                {
                    intDirectionX = -1;
                }
                if (this.lblBall.Left < 0)  //Left wall
                {
                    intDirectionX = 1;
                }
            }
            else if (intxMove < 0)
            {
                if (this.lblBall.Left > (this.Width - 40))  //Changing ball direction when hitting right wall - when xMoveValue is below than 0
                {
                    intDirectionX = 1;
                }
                if (this.lblBall.Left < 0)
                {
                    intDirectionX = -1;
                }
            }
            if (intyMove > 0)   //Changing Y movement when it is greater than 0
            {
                if (this.lblBall.Top < 10)  //Top wall
                {
                    intDirectionY = -1;
                }
                if (this.lblBall.Top > 400) //Bottom wall
                {
                    intDirectionY = 1;
                }
            }
            else if (intyMove < 0) //Changing Y movement when it is below 0
            {
                if (this.lblBall.Top < 10)
                {
                    intDirectionY = 1;
                }
                if (this.lblBall.Top > 400)
                {
                    intDirectionY = -1;
                }
            }
            
            if (lblBall.Top > 400) //Options for ball hitting the bottom of the field and interactions with player
            {
                
                if (this.lblBall.Left < this.pcbPlayer.Left - 20 || this.lblBall.Left > this.pcbPlayer.Left + this.pcbPlayer.Width)
                {
                    //Checks if player hit the ball, if not, displays a lose message and ends game
                    this.tmrMove.Enabled = false;
                    MessageBox.Show("\tYou Lose! Press start to play another round\n \t\t     or \n\tpress restart to reset the scores");
                    intComputerScore++;
                    lblComputerScore.Text = intComputerScore.ToString();
                }
                else if (this.lblBall.Left == this.pcbPlayer.Left + (int)(0.50 * (this.pcbPlayer.Width)))
                {
                    //Changes angle to 90 if hit in the exact middle
                    intAngle = 90;
                    this.txtDegree.Text = intAngle.ToString();
                }
                else if (this.lblBall.Left < this.pcbPlayer.Left + (int)(0.66 * (this.pcbPlayer.Width)) && this.lblBall.Left > this.pcbPlayer.Left + (int)(0.33 * (this.pcbPlayer.Width)))
                {
                    //Changes angle to 45 if hit within the specifed range
                    intAngle = 45;
                    this.txtDegree.Text = intAngle.ToString();
                }
                else if (this.lblBall.Left > this.pcbPlayer.Left + (int)(0.66 * (this.pcbPlayer.Width)))
                {
                    //Changes angle to 30 if hit within the specifed range
                    intAngle = 30;
                    intDirectionX = 1;
                    this.txtDegree.Text = intAngle.ToString();
                }
                else if (this.lblBall.Left <= this.pcbPlayer.Left + (int)(0.33 * (this.pcbPlayer.Width)))
                {
                    //Changes angle to 30 if hit within the specifed range
                    intAngle = 30;
                    intDirectionX = -1;
                    this.txtDegree.Text = intAngle.ToString();
                }

            }

            
            }

            
        }
            
            
        
        
        public int horizontalVal(int intHyp, int intDegree) //Caculating ball movement on x axis
        {
            int intxMove;
            intxMove = (int)(Math.Cos(intDegree * Math.PI / 180) * intHyp);
            return intxMove;
        }
        public int verticalVal(int intHyp, int intDegree)       //Calculating ball movement on y axis
        {
            int intyMove;
            intyMove = (int)(Math.Sin(intDegree * Math.PI / 180) * intHyp);
            return intyMove;
        }

        private void btnStart_Click(object sender, EventArgs e) //Start
        {
            this.tmrMove.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)  //Stop
        {
            this.tmrMove.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)   //Full Restart
        {
            Application.Restart();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            intSpeed++;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            intSpeed--;
        }

        private void btnAddDegree_Click(object sender, EventArgs e)
        {
            intAngle++;
            this.txtDegree.Text = intAngle.ToString();
        }

        private void btnSubDegree_Click(object sender, EventArgs e)
        {
            intAngle--;
            this.txtDegree.Text = intAngle.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pcbPlayer.Left < Width - 120)
            {
                if (e.KeyCode == Keys.D)
                {
                    this.pcbPlayer.Left += 20;
                }
            }
            if (pcbPlayer.Left > 0)
            {
                if (e.KeyCode == Keys.A)
                {
                    this.pcbPlayer.Left -= 20;
                }
            }
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
