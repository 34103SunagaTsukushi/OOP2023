using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }
        List<MyColor> mColors = new List<MyColor>();

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }
        //スライダーが動いた時のイベント
        private void rgbSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color c = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(c);
            colorCombobox.SelectedIndex = -1;
        }
        //STOCKボタンが押された時のイベント
        private void stockButton_Click(object sender, RoutedEventArgs e) {
            var colorList = GetColorList();
            Color brushColor = ((SolidColorBrush)colorArea.Background).Color;//今の色
            //R=?,G=?,B=?のフォーマット
            string color = string.Format("R={0},G={1},B={2}", brushColor.R, brushColor.G, brushColor.B);
            //規定値の設定
            var defaultColor = colorList.FirstOrDefault(x => x.Color == brushColor)?.Name ?? color;
            
            MyColor myColor = new MyColor { Name = defaultColor ,Color = brushColor};//brushColor, colorList
            mColors.Add(myColor);
            stockList.Items.Add(myColor.Name);

        }
        //Bindingにて使わなくなったメソッド
        //private void setColor() {
        //    var r = byte.Parse(rValue.Text);
        //    var g = byte.Parse(gValue.Text);
        //    var b = byte.Parse(bValue.Text);
        //    colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        //}
        //comboboxの選択情報が切り替わった時のイベント
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem ;
            var color = mycolor.Color;
            var name = mycolor.Name;
            colorArea.Background = new SolidColorBrush(color);
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }
        //ストックリストで選択した時のイベント
        private void stockList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            var selectColor = stockList.SelectedItem;
            var matchColor = mColors.Find(x => x.Name == selectColor.ToString());
            rValue.Text = matchColor.Color.R.ToString();
            gValue.Text = matchColor.Color.G.ToString();
            bValue.Text = matchColor.Color.B.ToString();
        }
    }
    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }


    }
}
