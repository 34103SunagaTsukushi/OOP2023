
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbException = new System.Windows.Forms.TextBox();
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.rbEntertainment = new System.Windows.Forms.RadioButton();
            this.rbIt = new System.Windows.Forms.RadioButton();
            this.rbSports = new System.Windows.Forms.RadioButton();
            this.rbEconomy = new System.Windows.Forms.RadioButton();
            this.gbTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(28, 21);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(374, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(419, 21);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(89, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(184, 75);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(349, 136);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(28, 227);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(829, 385);
            this.wbBrowser.TabIndex = 3;
            // 
            // tbException
            // 
            this.tbException.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbException.Location = new System.Drawing.Point(528, 21);
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(329, 31);
            this.tbException.TabIndex = 4;
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.rbEntertainment);
            this.gbTitle.Controls.Add(this.rbIt);
            this.gbTitle.Controls.Add(this.rbSports);
            this.gbTitle.Controls.Add(this.rbEconomy);
            this.gbTitle.Location = new System.Drawing.Point(28, 75);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(120, 136);
            this.gbTitle.TabIndex = 5;
            this.gbTitle.TabStop = false;
            this.gbTitle.Text = "groupBox1";
            // 
            // rbEntertainment
            // 
            this.rbEntertainment.AutoSize = true;
            this.rbEntertainment.Location = new System.Drawing.Point(6, 85);
            this.rbEntertainment.Name = "rbEntertainment";
            this.rbEntertainment.Size = new System.Drawing.Size(57, 16);
            this.rbEntertainment.TabIndex = 3;
            this.rbEntertainment.TabStop = true;
            this.rbEntertainment.Text = "エンタメ";
            this.rbEntertainment.UseVisualStyleBackColor = true;
            // 
            // rbIt
            // 
            this.rbIt.AutoSize = true;
            this.rbIt.Location = new System.Drawing.Point(6, 63);
            this.rbIt.Name = "rbIt";
            this.rbIt.Size = new System.Drawing.Size(33, 16);
            this.rbIt.TabIndex = 2;
            this.rbIt.TabStop = true;
            this.rbIt.Text = "IT";
            this.rbIt.UseVisualStyleBackColor = true;
            // 
            // rbSports
            // 
            this.rbSports.AutoSize = true;
            this.rbSports.Location = new System.Drawing.Point(6, 41);
            this.rbSports.Name = "rbSports";
            this.rbSports.Size = new System.Drawing.Size(61, 16);
            this.rbSports.TabIndex = 1;
            this.rbSports.TabStop = true;
            this.rbSports.Text = "スポーツ";
            this.rbSports.UseVisualStyleBackColor = true;
            // 
            // rbEconomy
            // 
            this.rbEconomy.AutoSize = true;
            this.rbEconomy.Location = new System.Drawing.Point(7, 19);
            this.rbEconomy.Name = "rbEconomy";
            this.rbEconomy.Size = new System.Drawing.Size(47, 16);
            this.rbEconomy.TabIndex = 0;
            this.rbEconomy.TabStop = true;
            this.rbEconomy.Text = "経済";
            this.rbEconomy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 708);
            this.Controls.Add(this.gbTitle);
            this.Controls.Add(this.tbException);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.gbTitle.ResumeLayout(false);
            this.gbTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.RadioButton rbEntertainment;
        private System.Windows.Forms.RadioButton rbIt;
        private System.Windows.Forms.RadioButton rbSports;
        private System.Windows.Forms.RadioButton rbEconomy;
    }
}

