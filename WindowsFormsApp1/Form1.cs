using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum Direction
        {
            Up,
            FIRST = Up,
            Right,
            Down,
            Left,
            LAST
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");

                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed.");
                        e.Handled = true;
                        break;
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _gameBoard.MoveBadies(_background);
        }

        private bool CheckIfColision()
        {
            //return baddy1.Enabled && IsTouching(goody, baddy1);
            return false;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //_gameBoard.MoveGoody(_background);

            /*
            switch (e.KeyCode)
            {
                case Keys.Right:
                    MoveRight(goody, _goodyStep);
                    break;
                case Keys.Left:
                    MoveLeft(goody, _goodyStep);
                    break;
                case Keys.Down:
                    MoveDown(goody, _goodyStep);
                    break;
                case Keys.Up:
                    MoveUp(goody, _goodyStep);
                    break;
            }
            if(CheckIfColision())
            {
                
                //baddy1.Visible = false;
                //goody.Width += baddy1.Width/2;
                //goody.Height += baddy1.Height/2;
                //baddy1.Enabled = false;
                
                //MessageBox.Show($"Touch!");
            }
        */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
