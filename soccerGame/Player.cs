using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace soccerGame
{
    class Player
    {   
        //angle stores the angle relative to the positive (rightwards) x vector in radians, starting downwards

        public int x, y, width, length, ticksSinceLost, tackleTicks; 
        public double xSpeed, ySpeed, acceleration, deceleration, angle, maxSpeed;
        public Color color;
        public bool hasBall, actionKeyDown, hasReset;

        public Player(int _x, int _y, double _xSpeed, double _ySpeed, double _acceleration, double _deceleration, double _angle, double _maxSpeed, int _width, int _length, int _ticksSinceLost, int _tackleTicks, bool _hasBall, Color _color, bool _actionKeyDown, bool _hasReset)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            acceleration = _acceleration;
            deceleration = _deceleration;
            angle = _angle;
            maxSpeed = _maxSpeed;
            color = _color;
            hasBall = _hasBall;
            width = _width;
            length = _length;
            ticksSinceLost = _ticksSinceLost;
            tackleTicks = _tackleTicks;
            actionKeyDown = _actionKeyDown;
            hasReset = _hasReset;
        }
        #region movement methods
        //moves player 
        public void Move(/*UserControl u*/)
        {
            //determines x and y direction so that acceleration can occur only in the direction opposite a max speed ball
            
                x = Convert.ToInt16(x + xSpeed);                        
                y = Convert.ToInt16(y + ySpeed);
            /*
            if (x < 0)
                x = 0;
            if (x + width > u.Width) 
                x = u.Width - width;
            if (y < 0)
                y = 0;
            if (y + width > u.Height)
                y = u.Height - width;
                */
        } 

        //accelerates player
        public void Accelerate (string directionX, string directionY)
        {   

            //determines x and y direction so that acceleration can occur only in the direction opposite a max speed ball
            string xDir;
            string yDir;

            if (xSpeed > 0)
                xDir = "right";
            else if (xSpeed < 0)
                xDir = "left";
            else
                xDir = "none";

            if (ySpeed > 0)
                yDir = "down";
            else if (ySpeed < 0)
               yDir = "up";
            else
                yDir = "none";

            //only accelerates if total speed is less than max speed
            if (Math.Sqrt(xSpeed * xSpeed + ySpeed * ySpeed) <= maxSpeed || directionX != xDir)
                {
                    //accelerates based on direction
                    switch (directionX)
                    {                      
                    case "left":
                        xSpeed -= acceleration;
                        break;
                    case "right":
                        xSpeed += acceleration;
                        break;
                    default:
                        break;
                    }           
                }

            if (Math.Sqrt(xSpeed * xSpeed + ySpeed * ySpeed) <= maxSpeed || directionY != yDir)
            {
                switch (directionY)
                {
                    case "up":
                        ySpeed -= acceleration;
                        break;
                    case "down":
                        ySpeed += acceleration;
                        break;
                    default:
                        break;
                }
            }
            //deceleration on neutral player
            if (directionX == "none" && directionY ==  "none")
            {
                xSpeed *= deceleration;
                ySpeed *= deceleration;
            }
        }

        //turns player
        public void Turn(string direction)
        {   
            switch (direction)
            {
                case "left":
                    angle -= 10;
                    break;
                case "right":
                    angle += 10;
                    break;
            }          
        } 
        
        //bursts player forwards quickly
        public void startTackle()
        {
            int speed = 12;

            xSpeed = Math.Sin(angle * Math.PI / 180) * speed;
            ySpeed = -Math.Cos(angle * Math.PI / 180) * speed;

            tackleTicks++;
        }   
       #endregion
    }
}
