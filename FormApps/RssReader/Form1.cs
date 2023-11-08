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

        

        private void btGet_Click(object sender, EventArgs e) {
            try {
                if(tbUrl.Text.Length != 0) {
                    using(var wc = new WebClient()) {
                        var url = wc.OpenRead(tbUrl.Text);
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


        private void lbRssTitle_Click(object sender, EventArgs e) {
            tbFavoriteTitle.Text = lbRssTitle.SelectedItem.ToString();
            tbFavoriteUrl.Text = ItemDatas[lbRssTitle.SelectedIndex].Link;


            if(lbRssTitle.Items.Count != 0) {
                wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
            } else {
                //lbRssTitleに選択項目がないときのエラー
                tbException.Text = "選択項目がありません。";
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {

        }


        private void rbEconomy_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
        }

        private void rbSports_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
        }

        private void rbIt_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }

        private void rbEntertainment_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
        }


    }
}
