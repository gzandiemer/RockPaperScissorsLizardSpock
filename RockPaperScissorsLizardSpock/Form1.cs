using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsLizardSpock
{
    public partial class Form1 : Form 
    {
         Random random = new Random();
         int hum_choice;
         int com_choice;
         static int humScore = 0;
         static int comScore = 0;
         

        public Form1()
        {
            InitializeComponent();
        }


        //Define what happens when you click each-button
        private void btn_rock_Click(object sender, EventArgs e)
        {
            pictureBox_humMove.Image = new Bitmap(@"images/Hause/H_rock.jpg
      ");
            hum_choice = 0;
            ButtonClickCommonActs();
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            pictureBox_humMove.Image = new Bitmap(@"images\Hause\H_paper.jpg");
            hum_choice = 1;
            ButtonClickCommonActs();
        }

        private void btn_scissors_Click(object sender, EventArgs e)
        {
            pictureBox_humMove.Image = new Bitmap(@"images\Hause\H_scissors.jpg");
            hum_choice = 2;
            ButtonClickCommonActs();
        }

        private void btn_lizard_Click(object sender, EventArgs e)
        {
            pictureBox_humMove.Image = new Bitmap(@"images\Hause\H_lizard_head.png");
            hum_choice = 3;
            ButtonClickCommonActs();
        }

        private void btn_spock_Click(object sender, EventArgs e)
        {
            pictureBox_humMove.Image = new Bitmap(@"images\Hause\H_spock.png");
            hum_choice = 4;
            ButtonClickCommonActs();
        }        

        public void ButtonClickCommonActs()
        {
            ComputerChoice();
            CheckWinner();
            CheckGameOver();
            pictureBox_humMove.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Comics.Visible = false;
            pictureBox_Qmark.Visible = false;
        }

        //set a function for the computer to make also a move each time a button is clicked. Define 5 cases to choose random from the list
        public void ComputerChoice()
        {
           com_choice = random.Next(0,5);
           switch(com_choice)
            {
                case 0:
                    pictureBox_comMove.Image = new Bitmap(@"images\Hause\H_rock.jpg");
                    pictureBox_comMove.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 1:
                    pictureBox_comMove.Image = new Bitmap(@"images\Hause\H_paper.jpg");
                    pictureBox_comMove.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2:
                    pictureBox_comMove.Image = new Bitmap(@"images\Hause\H_scissors.jpg");
                    pictureBox_comMove.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 3:
                    pictureBox_comMove.Image = new Bitmap(@"images\Hause\H_lizard_head.png");
                    pictureBox_comMove.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 4:
                    pictureBox_comMove.Image = new Bitmap(@"images\Hause\H_spock.png");
                    pictureBox_comMove.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

        }


        // Set a function to decide who wins and add score to winner and show a message to declare
        public void CheckWinner() 
        {
            // double h = Convert.ToDouble(hum_choice);
            // double c = Convert.ToDouble(com_choice);
            int h = hum_choice;
            int c = com_choice;
          

            if (hum_choice == com_choice)
                lbl_scoreboard.Text = " Well, great minds think alike!";
                
            
            else if (h == 0 && c == 2 )
            {
                lbl_scoreboard.Text = "You Rock!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();              
            }

            else if (h == 0 && c == 3)
            {
                lbl_scoreboard.Text = "Genius!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();   
            }

            else if (h == 1 && c == 0)
            {
                lbl_scoreboard.Text = "Great job , buddy!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();
            }

            else if (h == 1 && c == 4)
            {
                lbl_scoreboard.Text = "That deserves an Applause!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();
            }

            else if (h == 2 && c == 1)
            {
                lbl_scoreboard.Text = "Wow! Look at you!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();
            }

            else if (h == 2 && c == 3)
            {
                lbl_scoreboard.Text = "Hell yeah!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();
            }

            else if (h == 3 && c == 1)
            {
                lbl_scoreboard.Text = "Yeehaw!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();
            }

            else if (h == 3 && c == 4)
            {
                lbl_scoreboard.Text = "Brillant choice!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();
            }

            else if (h == 4 && c == 0)
                
            {
                lbl_scoreboard.Text = "You're killing it!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();
            }

            else if (h == 4 && c == 2)

            {
                lbl_scoreboard.Text = "Go tiger!";
                humScore++;
                lbl_humScore.Text = humScore.ToString();
            }

            else
            {
                lbl_scoreboard.Text = "Oops! Bad move!";
                comScore++;
                lbl_comScore.Text = comScore.ToString();
            }
                
        }

        //check if one of the players have made it to 10
        public void CheckGameOver()
        {
            
            if (humScore == 10)
            {
                lbl_scoreboard.Text = "You won against computer!\nRespect !";
                btn_reset.Visible = true;
                Panel_buttons.Visible = false;

            }

            else if (comScore == 10)
            {
                lbl_scoreboard.Text = "You lost against computer!\nNext time try harder !";
                btn_reset.Visible = true;
                Panel_buttons.Visible = false;
            }
            
        }
        

        // define function of reset button 
        private void btn_reset_Click(object sender, EventArgs e)
        {
            humScore = 0;
            comScore = 0;
            lbl_humScore.Text = "0";
            lbl_comScore.Text = "0";
            pictureBox_Comics.Visible = true;
            pictureBox_Qmark.Visible = true;
            Panel_buttons.Visible = true;
            btn_reset.Visible = false;
            lbl_scoreboard.Text = "Good luck with the next challenge !";
        }
        
    }
}
