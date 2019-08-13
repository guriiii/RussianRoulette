using System;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace RussianRoulette
{

    //Game class
    public partial class Game : Form
    {
      
       int TotalRounds = 6;
       int nextNumber;
       int ShotTowardsTarget = 0;
       Random randomBullet = new Random();
       public static int score = 0;

        public Game()
        {
            InitializeComponent();
    
        }

        // Reversing image (based upon radio button)
        
        private void rbHead_CheckedChanged(object sender, EventArgs e)
        {
            pbPistol.Image = Properties.Resources.pistol;
            btnFire.Enabled = true;
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //Changes the image of pistol
            pbPistol.Visible = !pbPistol.Visible;
            btnFire.Enabled = true;
           
        }

        //Function to load bullets
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            btnSpin.Enabled = true;

            // Soundplayer to perform audio actions 
            System.IO.Stream stream = Properties.Resources.Gun_Cocking_Slow_Mike_Koenig_1019236976;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(stream);
            sound.Play();            
        }

        //Function to kill all processes
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit Event
            Application.Exit();
        }


        //Function for spinning the pistol
        private void btnSpin_Click(object sender, EventArgs e)
        {
            
            rbHead.Enabled = true;
            rbAway.Enabled = true;

            // Soundplayer to perform audio actions
            System.IO.Stream stream = Properties.Resources.RevolverSpin;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(stream);
            sound.Play();

            // Generates random number between 1 and 7 
            nextNumber= randomBullet.Next(1, 7);
           
        }

        //Fire function
        private void btnFire_Click(object sender, EventArgs e)
        {
            //Plays sound
            System.IO.Stream stream = Properties.Resources.pistol_shot;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(stream);
            sound.Play();


            btnSpin.Enabled = false;
            btnLoad.Enabled = false;


            //Bullets are made invisible upon every round

            TotalRounds = TotalRounds - 1;

            if (TotalRounds == 5)
            {
                pb1.Visible = !pb1.Visible;

            }
            else if (TotalRounds == 4)
            {
                pb2.Visible = !pb2.Visible;
            }
            else if (TotalRounds == 3)
            {
                pb3.Visible = !pb3.Visible;
            }
            else if (TotalRounds == 2)
            {
                pb4.Visible = !pb4.Visible;
            }
            else if (TotalRounds == 1)
            {
                pb5.Visible = !pb5.Visible;
            }
            else if (TotalRounds == 0)
            {
                pb6.Visible = !pb6.Visible;
                                          

            }

            //If target is towards head

            if (rbHead.Checked)
            {
               ShotTowardsTarget = ShotTowardsTarget + 1;              
            }
            if (ShotTowardsTarget == 2)
            {
                rbHead.Enabled = false;
                rbAway.Checked = true;
            }

            if (nextNumber == TotalRounds && rbAway.Checked)
            {

                score = score - 1;
                String s = score.ToString();
                MessageBox.Show("You lose this game. Total points: "+s);


                // Play again messageBox
                if (MessageBox.Show("Do you want to play another game?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
     
                    ReInitiate();
                }
                else
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    Application.Exit();
                }

            }
            else if (nextNumber == TotalRounds && rbHead.Checked)
            {
                score = score + 1;
                String s = score.ToString();
                MessageBox.Show("Bravo, you are a winner with a score of "+s);

                // Play again messageBox
                if (MessageBox.Show("Do you want to play another game?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // If yes is clicked
                    // Calls function                   
                   ReInitiate();
                }
                else
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); //Start new instance of app
                    Application.Exit(); //Turn off current app 
                }

            }

           
            
            
        }

        
        private void Game_Load(object sender, EventArgs e)
        {
            // Disabled buttons on form load
            btnSpin.Enabled = false;
            rbHead.Enabled = false;
            rbAway.Enabled = false;
            btnFire.Enabled = false;
        }

        public void ReInitiate()
        {
            TotalRounds = 6;
            ShotTowardsTarget = 0;                      
            btnLoad.Enabled = true;
            rbAway.Enabled = true;
            rbHead.Enabled = true;
            pb1.Visible = true;
            pb2.Visible = true;
            pb3.Visible = true;
            pb4.Visible = true;
            pb5.Visible = true;
            pb6.Visible = true;
            rbHead.Enabled = false;
            rbAway.Enabled = false;
        }

        private void Pb3_Click(object sender, EventArgs e)
        {

        }
    }
}