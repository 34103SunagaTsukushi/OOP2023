using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        List<ItemData> ItemDatas= new List<ItemData>();

        public Form1() {
            InitializeComponent();
        }
        Dictionary<string, string> FavoriteDict = new Dictionary<string, string>();

        class FavoriteSet {
            public string Key { get; set; }
            public string Value { get; set; }

            public FavoriteSet(string key ,string value) {
                this.Key = key;
                this.Value = value;

            }
            public override string ToString() {
                return Value;
            }
        }

        //URLからRSSを取得する
        private void btGet_Click(object sender, EventArgs e) {
            try { 
                if(tbUrl.Text.Length != 0) {
                    using(var wc = new WebClient()) {
                        var url = wc.OpenRead(tbUrl.Text);
                        //wc.DownloadString();
                        XDocument xdoc = XDocument.Load(url);

                        //btGetがクリックされたときに初期化する
                        ItemDatas.Clear();
                        lbRssTitle.Items.Clear();

                        ItemDatas = xdoc.Root.Descendants("item").Select(x => new ItemData {
                            Title = (string)x.Element("title"),
                            Link = (string)x.Element("link")

                        }).ToList();

                        foreach(var node in ItemDatas) {
                            lbRssTitle.Items.Add(node.Title);
                        }
                    }
                } else {
                    //URLが入力されていないのにbtGetがクリックされたときのエラー
                    tbException.Text = "URLが入力されていません。";
                }


            } catch(System.Net.WebException ) {
                //URLが正しくないときのエラー
                tbException.Text = "正しいURLを入力して下さい。";
                tbUrl.Text = string.Empty;
            }
        }

        //タイトルがクリックされたときにサイトを表示する
        private void lbRssTitle_Click(object sender, EventArgs e) {
            //お気に入り登録にも表示
            tbFavoriteTitle.Text = lbRssTitle.SelectedItem.ToString();
            tbFavoriteUrl.Text = ItemDatas[lbRssTitle.SelectedIndex].Link;

            //tbException.Text = ItemDatas[lbRssTitle.SelectedIndex].Link;

            if(lbRssTitle.Items.Count != 0) {
                wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
            } else {
                //lbRssTitleに選択項目がないときのエラー
                tbException.Text = "選択項目がありません。";
            }
        }

        //経済
        private void rbEconomy_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
        }
        //スポーツ
        private void rbSports_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
        }
        //IT
        private void rbIt_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }
        //エンタメ
        private void rbEntertainment_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
        }
        //お気に入り登録
        private void btRegister_Click(object sender, EventArgs e) {
            //重複排除
            if(!tbFavoriteTitle.Text.Equals("") && !tbFavoriteUrl.Text.Equals("")) {
                if(FavoriteDict.ContainsKey(tbFavoriteUrl.Text) || FavoriteDict.ContainsValue(tbFavoriteTitle.Text)) {
                    tbException.Text = "すでに同じURLかタイトルが登録されています。";
                } else {
                    FavoriteSet favorite = new FavoriteSet(tbFavoriteUrl.Text, tbFavoriteTitle.Text);
                    FavoriteDict.Add(tbFavoriteUrl.Text, tbFavoriteTitle.Text);
                    cbRegister.Items.Add(favorite);
                }
            } else {
                tbException.Text = "タイトルかURLが空です。";
            }
        }
        //comboboxの選択が切り替わった時のイベント
        private void cbRegister_SelectedIndexChanged(object sender, EventArgs e) {
            FavoriteSet favorite = (FavoriteSet)cbRegister.SelectedItem;
            //URLにpickupが入っていたらサイト表示、入っていなかったらtbURLに表示
            if(favorite.Key.Contains("pickup")) {
                wbBrowser.Navigate(favorite.Key);
            } else {
                tbUrl.Text = favorite.Key.ToString();
            }

            //bool isMatch = Regex.IsMatch(favorite.Key, @"^""https://news.yahoo.co.jp/pickup""\S+$");
            //if(isMatch) {
            //    wbBrowser.Navigate(favorite.Key);
            //} else {
            //    tbUrl.Text = favorite.Key.ToString();
            //}
        }
        //前のページへ移動
        private void btBefore_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }
        //後ろのページへ移動
        private void btBack_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }
        //お気に入りの削除（選択されているもの）
        private void btDelete_Click(object sender, EventArgs e) {
            try {
                FavoriteSet favorite = (FavoriteSet)cbRegister.SelectedItem;
                if(favorite != null) {
                    FavoriteDict.Remove(favorite.Key);

                    cbRegister.Items.RemoveAt(cbRegister.SelectedIndex);
                    cbRegister.Text = "";
                    tbFavoriteTitle.Text = "";
                    tbFavoriteUrl.Text = "";
                    wbBrowser.DocumentText = "";
                } else {
                    tbException.Text = "削除項目がありません。";
                }
                
            } catch(System.ArgumentOutOfRangeException) {//選択項目がないのに削除を押した時のException
                tbException.Text = "削除項目が選択されていません。";
            }
        }
        //全部リセットするボタン
        private void btAllReset_Click(object sender, EventArgs e) {
            tbException.Text = "";
            tbUrl.Text = "";
            lbRssTitle.Items.Clear();
            tbFavoriteTitle.Text = "";
            tbFavoriteUrl.Text = "";
            wbBrowser.DocumentText = "";
            cbRegister.Items.Clear();
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {
            this.MaximizedBounds = new Rectangle(0, 0,800,800);
        }
        private void tbUrl_TextChanged(object sender, EventArgs e) {
            tbFavoriteUrl.Text = tbUrl.Text;
        }
    }
}
