using System.ComponentModel;
using System.Reflection;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

      

        
     


     

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Win make sure your tiles are ticked vertically or horizontally or diagonally.","Hint");
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn= (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";
            turn = !turn;
            btn.Enabled = false;
            turnCount++;
            CheckWinner();
        }
        private void CheckWinner()
        {
            bool yo_winner = false;

           // horizontal_tick_checks

            if((btn1.Text== btn2.Text) &&(btn2.Text==btn3.Text)&&(!btn1.Enabled))
                yo_winner = true;
          else  if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text)&& (!btn4.Enabled))
                yo_winner = true;
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                yo_winner = true;

            // vertical_ticks_checks

            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                yo_winner = true;
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
                yo_winner = true;
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
                yo_winner = true;

            //diagonalchecks

            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
                yo_winner = true;
            else if ((btn7.Text == btn5.Text) && (btn5.Text == btn3.Text) && (!btn7.Enabled))
                yo_winner = true;



            if (yo_winner)
            {
                disableBtns();
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + "  Wins!", "Yay!");

            }//ended if
            else {
                if (turnCount == 9)
                    MessageBox.Show("Draw", "Ah!");
            }
        }//end check horixontal
    
     private void disableBtns()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }//endtry
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount= 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = " ";
                }
            }//endtry
            catch { }
        }

       
    }
}