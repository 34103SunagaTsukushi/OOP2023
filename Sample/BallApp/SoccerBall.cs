using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image; //画像データ

        private double posX; //x座標
        private double posY; //y座標

        private double moveX = 7.0; //移動量(X方向)
        private double moveY = 7.0; //移動量(Y方向)
        Random random = new Random();

        private static int count;

        //コンストラクタ
        public SoccerBall(double xp, double yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            

            PosX = xp -25;
            PosY = yp -25;
            int rndX = random.Next(-15, 15);
            int rndY = random.Next(-15, 15);


            moveX =(rndX != 0 ? rndX :1); //乱数で移動量を設定
            moveY =(rndY != 0 ? rndY :1);


        }
        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
        public int Count { get => count; set => count = value; }
        //メソッド
        public void Move() {

            Console.WriteLine("X座標＝{0},Y座標＝{1}", posX, posY);
            posX += moveX;
            posY += moveY;
            if (posX > 750 || posX < 0){
                moveX *= -1;
            }else if (posY > 520 || posY < 0){
                moveY *= -1;
            }

        }
    }
}
