using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace soccerGame
{
    class Goalkeeper
    {
        public int x, y, width, length, ticksSinceLost, ticksSinceGot;
        public double ySpeed, angle;
        public Color color;
        public bool hasBall;
        public Goalkeeper(int _x, int _y, double _ySpeed, double _angle, int _width, int _length, int _ticksSinceLost, int _ticksSinceGot, bool _hasBall, Color _color)
        {
            x = _x;
            y = _y;
            ySpeed = _ySpeed;
            angle = _angle;           
            color = _color;
            hasBall = _hasBall;
            width = _width;
            length = _length;
            ticksSinceGot = _ticksSinceGot;
        }

        //moves goalie within the net's range
        public void Move(Ball b, int maxY, int minY)
        {
            if (b.y > y && y < maxY)
                y = Convert.ToInt16(y + ySpeed);
            if (b.y < y && y  - width > minY)
                y = Convert.ToInt16(y - ySpeed);
        }

        //checks for a collision with the ball
        public bool checkCollision(Ball b)
        {
            Rectangle bRect = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle gRect = new Rectangle(x, y, width, length);

            return bRect.IntersectsWith(gRect);
        }
    }
   
}
