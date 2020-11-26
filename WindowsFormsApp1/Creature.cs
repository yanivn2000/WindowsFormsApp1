using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Creature
    {
        protected System.Windows.Forms.PictureBox _pictureBox;

        public void EndInit()
        {
            ((System.ComponentModel.ISupportInitialize)(_pictureBox)).EndInit();
        }
        public void BeginInit()
        {
            ((System.ComponentModel.ISupportInitialize)(_pictureBox)).BeginInit();
        }
        public void Add(System.Windows.Forms.Control.ControlCollection Controls)
        {
            Controls.Add(_pictureBox);
        }
        virtual public void Move(System.Windows.Forms.PictureBox background, int step)
        {

        }

        protected bool MoveRight(System.Windows.Forms.PictureBox background, int step)
        {
            if (_pictureBox.Right + step < background.Width)
            {
                _pictureBox.Left += step;
                return true;
            }
            return false;
        }
        protected bool MoveLeft(int step)
        {
            if (_pictureBox.Left - step > 0)
            {
                _pictureBox.Left -= step;
                return true;
            }
            return false;
        }
        protected bool MoveUp(int step)
        {
            if (_pictureBox.Top - step > 0)
            {
                _pictureBox.Top -= step;
                return true;
            }
            return false;
        }
        protected bool MoveDown(System.Windows.Forms.PictureBox background, int step)
        {
            if (_pictureBox.Top + step < background.Height)
            {
                _pictureBox.Top += step;
                return true;
            }
            return false;
        }
    }
}
