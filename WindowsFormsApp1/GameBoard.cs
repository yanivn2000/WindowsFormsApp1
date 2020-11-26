using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class GameBoard
    {
        private int _numOfBadies = 10;
        private Bady[] _badies;
        private Goody _goody;

        public GameBoard()
        {
            this._badies = new Bady[10];
            for (int i = 0; i < _numOfBadies; i++)
            {
                this._badies[i] = new Bady();
            }
            _goody = new Goody();

        }
        public void Init()
        {
            foreach (var item in this._badies)
                item.BeginInit();
            _goody.BeginInit();
        }

        public void BuildBadies()
        {
            int gap = 50;
            for (int i = 0; i < _badies.Length; i++)
            {
                _badies[i].Build(i, gap);
                gap += 100;
            }
        }
        public void BuildGoody()
        {
            _goody.Build();
        }
        public void Add(System.Windows.Forms.Control.ControlCollection Controls)
        {
            foreach (var item in this._badies)
                item.Add(Controls);
            _goody.Add(Controls);
        }

        public void EndInit()
        {
            foreach (var item in this._badies)
                item.EndInit();

            _goody.EndInit();
        }
        public void MoveBadies(System.Windows.Forms.PictureBox background)
        {
            int step = 1;
            foreach (var item in this._badies)
                item.Move(background, step);
        }
        /*
        private bool IsTouching(PictureBox p1, PictureBox p2)
        {
            if (p1.Location.X + p1.Width < p2.Location.X)
                return false;
            if (p2.Location.X + p2.Width < p1.Location.X)
                return false;
            if (p1.Location.Y + p1.Height < p2.Location.Y)
                return false;
            if (p2.Location.Y + p2.Height < p1.Location.Y)
                return false;
            return true;
        }
        */
    }
}
