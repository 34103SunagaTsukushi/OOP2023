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

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            DateTime today = DateTime.Now;
            var ans = today - dtp;
            tbMessage.Text = "入力した日にちから" + (today - dtp).Days + "日経過";
            //tbMessage.Text = ans.Days.ToString()+"日";
        }
    }
}
