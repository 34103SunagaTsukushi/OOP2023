using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class TennisBall : Obj {

        Random random = new Random();
        private static int count;

        public TennisBall(double xp ,double yp) : base(xp, yp, @"pic\tennis_ball.png") {

            PosX = xp - 25;
            PosY = yp - 25;
            int rndX = random.Next(-25, 25);
            int rndY = random.Next(-25, 25);

            MoveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定
            MoveY = (rndY != 0 ? rndY : 1);

        }

        public override void Move() {
            Console.WriteLine("X座標＝{0},Y座標＝{1}", PosX, PosY);
            PosX += MoveX;
            PosY += MoveY;
            if (PosX > 750 || PosX < 0)
            {
                MoveX *= -1;
            }
            else if (PosY > 520 || PosY < 0)
            {
                MoveY *= -1;
            }
        }
    }
}
