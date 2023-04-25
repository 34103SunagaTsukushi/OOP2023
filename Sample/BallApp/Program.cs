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
        private PictureBox pb1;

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

            moveTimer = new Timer();
            moveTimer.Interval = 10; //タイマーのインターバル(ms)
            
            moveTimer.Tick += MoveTimer_Tick;　// += ・・デリゲート登録
        }
        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right)//右クリック
            {
                tennisBall = new TennisBall(e.X, e.Y);
                pb1 = new PictureBox();
                pb1.Image = tennisBall.Image;
                pb1.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);
                pb1.Size = new Size(35, 35);
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                pb1.Parent = this;

                balls.Add(tennisBall);
                pbs.Add(pb1);

            }
            else
            {//左クリック
                //ボールインスタンス生成
                soccerBall = new SoccerBall(e.X, e.Y);
                pb = new PictureBox(); //画像を表示するコントロール
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY); //画像の位置
                pb.Size = new Size(50, 50); //画像の表示サイズ
                pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像の表示モード
                pb.Parent = this;
                //this.Text = "ボールの数：" + ++count;
                this.Text = "BallGame:" + balls.Count;

                balls.Add(soccerBall);
                pbs.Add(pb);
            }
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
