using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        private Timer moveTimer; //タイマー用
        private SoccerBall soccerBall;
        private TennisBall tennisBall;
        private PictureBox pb;

        private List<Obj> balls = new List<Obj>(); //ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>(); //表示用

        //private List<TennisBall> balls1 = new List<TennisBall>(); //ボールインスタンス格納用
        //private List<PictureBox> pbs1 = new List<PictureBox>(); //表示用

        int count = 0; //ボールの数をカウント

        static void Main(string[] args) {
            Application.Run(new Program());
        }
        public Program() {
            //Form form = new Form();
            //this.Width = 1200; //幅プロパティ
            //this.Height = 800; //高さプロパティ
            this.Size = new Size(800, 600);

            this.BackColor = Color.Green;

            this.Text = "BallGame";

            this.MouseClick += Program_MouseClick;

            this.KeyDown += Program_KeyDown;

            moveTimer = new Timer();
            moveTimer.Interval = 10; //タイマーのインターバル(ms)
            
            moveTimer.Tick += MoveTimer_Tick;　// += ・・デリゲート登録
        }
        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {

            Obj ballObj = null;

            pb = new PictureBox();
            if (e.Button == MouseButtons.Right)//右クリック
            {
                ballObj = new TennisBall(e.X-25, e.Y-25);
                pb.Size = new Size(35, 35); //画像の表示サイズ
            }
            else
            {//左クリック
                //ボールインスタンス生成
                ballObj = new SoccerBall(e.X-25, e.Y-25);
                pb.Size = new Size(50, 50); //画像の表示サイズ
            }
     
            

            pb.Image = ballObj.Image;
            pb.Location = new Point((int)ballObj.PosX, (int)ballObj.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;

            balls.Add(ballObj);
            pbs.Add(pb);


            //this.Text = "ボールの数：" + ++count;
            this.Text = "BallGame:" + balls.Count;

            moveTimer.Start(); //タイマースタート
        }
           

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            
            
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move(); //移動
                pbs[i].Location =new Point((int)balls[i].PosX, (int)balls[i].PosY); //画像の位置
            }/*
            for (int i = 0; i < balls1.Count; i++)
            {
                balls1[i].Move(); //移動
                pbs1[i].Location = new Point((int)balls1[i].PosX, (int)balls1[i].PosY); //画像の位置
            }*/


        }
    }
}
