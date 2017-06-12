using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace soccerGame
{
    class Ball
    {
        public int x, y, size;
        public double xSpeed, ySpeed, deceleration;
        public bool isFree;


        public Ball (int _x, int _y, int _size, double _xSpeed, double _ySpeed, double _deceleration, bool _isFree)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            deceleration = _deceleration;
            isFree = _isFree;
        }

        //method to move ball
        public void Move()
        {
            if (xSpeed != 0 && ySpeed != 0)
            {
                x += Convert.ToInt16(xSpeed);
                y += Convert.ToInt16(ySpeed);
            }
        }

        //decelerates ball in proportions that do not alter its direction vector
        public void Decelerate()
        {
            double speed = Math.Sqrt(xSpeed * xSpeed + ySpeed * ySpeed);

            double newSpeed = speed - deceleration;

            xSpeed *= newSpeed / speed;
            ySpeed *= newSpeed / speed;          
        }

        //checks for collision between ball and player
        public bool CheckPlayer(Player p)
        {
            Rectangle pRect = new Rectangle(p.x, p.y, p.width, p.length);
            Rectangle bRect = new Rectangle(x, y, size, size);

            return (bRect.IntersectsWith(pRect));
        }

        //shoots ball at the angle and number of charge ticks given by the shooting player.
        public void OnShot( int chargeTicks, double angle)
        {
            // total speed is related to shot strength
            double speed = 5 + chargeTicks / 3.5;

            if (angle == 0) { angle = 1; }

            //xSpeed and ySpeed are trigonimically related to the player's angle to the vertical and multiplied by the total speed (due to forming vector triangles similar to the initial ones).
            xSpeed = Math.Sin(angle * Math.PI / 180) * speed;
            ySpeed = -Math.Cos(angle * Math.PI / 180) * speed;
        }

        //checks for out-of-bounds ball
        public bool CheckOOB(int startX, int endX, int startY, int endY)
        {
            if (x + size < startX || x > endX || y + size < startY || y > endY)         
                return true;       
            else return false;
        }

        //checks for a goal and reports which net the goal was scored on
        public string CheckGoal(int startX, int endX, int startY, int endY, int netWidth, int netHeight)
        {
            Rectangle leftNetRect = new Rectangle(startX - netWidth + 5, (endY - startY) / 2 - netHeight / 2 + 5, netWidth - 5,  netHeight - 5);
            Rectangle rightNetRect = new Rectangle(endX - 5, (endY - startY) / 2 - netHeight / 2 - 5, netWidth - 5,  netHeight - 5);
            Rectangle bRect = new Rectangle(x, y, size, size);

            if (bRect.IntersectsWith(leftNetRect))
                return "blue goal";
            else if (bRect.IntersectsWith(rightNetRect))
                return "red goal";
            else return "no goal";
        }

    }


}
