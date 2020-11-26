using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Goody : Creature
    {
        public Goody()
        {
            _pictureBox = new System.Windows.Forms.PictureBox();
        }

        public void Build()
        {
            _pictureBox.BackColor = System.Drawing.Color.Transparent;
            _pictureBox.Image = global::WindowsFormsApp1.Properties.Resources.Wasp;
            _pictureBox.Location = new System.Drawing.Point(420, 217);
            _pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _pictureBox.Name = "goody";
            _pictureBox.Size = new System.Drawing.Size(142, 133);
            _pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _pictureBox.TabIndex = 1;
            _pictureBox.TabStop = false;
        }
    }
}
