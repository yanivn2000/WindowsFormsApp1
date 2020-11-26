using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bady : Creature
    {

        private int _baddyStep = 1;
        public Bady()
        {
            _pictureBox = new System.Windows.Forms.PictureBox();
        }
        public void Build(int counter, int gap)
        {
            _pictureBox.BackColor = System.Drawing.Color.Transparent;
            _pictureBox.Image = global::WindowsFormsApp1.Properties.Resources.baddy;
            _pictureBox.Location = new System.Drawing.Point(100 + gap, 100);
            _pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _pictureBox.Name = $"baddy{counter++}";
            _pictureBox.Size = new System.Drawing.Size(100, 100);
            _pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _pictureBox.TabIndex = 2;
            _pictureBox.TabStop = false;
            gap += 150;
        }

        override public void Move(System.Windows.Forms.PictureBox background, int step)
        {
            MoveLeft(_baddyStep);
            /*
            switch (direction)
            {
                case Direction.Left:
                    MoveLeft(baddy1, _baddyStep);
                    break;
                case Direction.Right:
                    MoveRight(baddy1, _baddyStep);
                    break;
                case Direction.Up:
                    MoveUp(baddy1, _baddyStep);
                    break;
                case Direction.Down:
                    MoveDown(baddy1, _baddyStep);
                    break;

            }
            */
        }
    }

}
