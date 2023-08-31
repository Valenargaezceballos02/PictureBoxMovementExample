using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxMovementExample
{
    public partial class Form1 : Form
    {

        private const int pictureBox1Speed = 5;
        private const int pictureBox2Speed = 10;
        private const int pictureBox2YOffset = 50;
        private bool pictureBox2MovingLeft = true;
        private int pictureBox2MoveCount = 0;


        public Form1()
        {
            InitializeComponent();


            
            KeyDown += Form1_KeyDown;

         
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox1.Left - pictureBox1Speed >= 0)
                {
                    pictureBox1.Left -= pictureBox1Speed;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (pictureBox1.Right + pictureBox1Speed <= ClientSize.Width)
                {
                    pictureBox1.Left += pictureBox1Speed;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
               



                if (pictureBox2MovingLeft)
            { 
                if (pictureBox2.Left - pictureBox2Speed >= 0)
                {
                    pictureBox2.Left -= pictureBox2Speed;
                }
                else
                {
                    pictureBox2MovingLeft = false;
                    pictureBox2MoveCount++;
                }
            }
            else
            {
                if (pictureBox2.Right + pictureBox2Speed <= ClientSize.Width)
                {
                    pictureBox2.Left += pictureBox2Speed;
                }
                else
                {
                    pictureBox2MovingLeft = true;
                    if (pictureBox2MoveCount >= 2)

                    {
                          pictureBox2MoveCount = 0;
                           if (pictureBox2.Top + pictureBox2YOffset <=  ClientSize.Height - pictureBox2.Height)
                            {
                            pictureBox2.Top += pictureBox2YOffset;
                           }
                        else
                        {
                                 if (pictureBox2.Bounds.IntersectsWith(pictureBox33.Bounds))
                                 {
                                Application.Exit();
                                 }
                                    else
                                    {
                                   
                                        Application.Exit();
                                    }
                        }




                    }
                }
            }
        }


        
    }
}







