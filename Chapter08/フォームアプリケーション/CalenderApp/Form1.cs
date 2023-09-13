using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalenderApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
           

        }
        private void Form1_Load(object sender,EventArgs e) {
            tbNow.Text = DateTime.Now.ToString("yyyy年MM月dd日 hh時mm分ss秒");
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            DateTime today = DateTime.Now;
            var ans = today - dtp;
            tbMessage.Text = "入力した日にちから" + (today - dtp).Days + "日経過";
            //tbMessage.Text = ans.Days.ToString()+"日";
        }

        private void btFowerdYear_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var year = dtp.AddYears(-1);
            dtpDate.Text = year.ToString();

        }

        private void btFowerdMonth_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var month = dtp.AddMonths(-1);
            dtpDate.Text = month.ToString();
        }

        private void btFowerdDay_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var day = dtp.AddDays(-1);
            dtpDate.Text = day.ToString();
        }

        private void btNextYear_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var year = dtp.AddYears(1);
            dtpDate.Text = year.ToString();
        }

        private void btNextMonth_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var month = dtp.AddMonths(1);
            dtpDate.Text = month.ToString();
        }

        private void btNextDay_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var day = dtp.AddDays(1);
            dtpDate.Text = day.ToString();
        }

        private void btAge_Click(object sender, EventArgs e) {
            var age = GetAge(dtpDate.Value, DateTime.Now);
            tbMessage.Text = "貴方の年齢は" + age + "歳です。";
        }

        private object GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if(targetDay< birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
