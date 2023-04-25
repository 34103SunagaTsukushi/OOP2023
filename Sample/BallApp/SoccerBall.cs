using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall :Obj{
        //フィールド
       
        Random random = new Random();
        private static int count;
      
        //コンストラクタ
        public SoccerBall(double xp,double yp ):base( xp,  yp,@"pic\soccer_ball.png") {
            
            int rndX = random.Next(-15, 15);
            int rndY = random.Next(-15, 15);

            MoveX =(rndX != 0 ? rndX :1); //乱数で移動量を設定
            MoveY =(rndY != 0 ? rndY :1);

        }
        
        public override void Move(){

            Console.WriteLine("X座標＝{0},Y座標＝{1}", PosX, PosY);
            PosX += MoveX;
            PosY += MoveY;
            if (PosX > 750 || PosX < 0){
                MoveX *= -1;
            }else if (PosY > 520 || PosY < 0){
                MoveY *= -1;
            }

        }
    }
}
