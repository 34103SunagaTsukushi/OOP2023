﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {

        Random random = new Random();
        private static int count = 0;

        public static int Count { get => 
                count; set => count = value; }

        public TennisBall(double xp ,double yp) : base(xp, yp, @"pic\tennis_ball.png") {

            PosX = xp - 25;
            PosY = yp - 25;
            int rndX = random.Next(-25, 25);
            int rndY = random.Next(-25, 25);

            MoveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定
            MoveY = (rndY != 0 ? rndY : 1);
            Count++;
        }


        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);
            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);

            Console.WriteLine("X座標＝{0},Y座標＝{1}", PosX, PosY);
           
            if (PosX > 750 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            else if (PosY > 520 || PosY < 0 || rBar.IntersectsWith(rBall))
            {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
        public override void Move(Keys direction) {
            ;
        }
    }
}
