using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {

        public Bar(double xp ,double yp):base(xp,yp, @"pic\bar.png") {
            base.MoveX = 40.0;
            base.MoveY = 0;

        }
        //抽象クラスを継承しているので、不要なメソッドは空にする
        public override void Move(PictureBox pbBar, PictureBox PbBall) {
            //空のメソッドにする
        }
        public override void Move(Keys direction) {
            if(Keys.Right == direction)
            {
                if (PosX < 635)
                {
                    PosX += MoveX;
                }
                
            }
            else if (Keys.Left == direction)
            {
                if (PosX > 0)
                {
                    PosX -= MoveX;
                }
                    
            }
           
        }
    }
}
