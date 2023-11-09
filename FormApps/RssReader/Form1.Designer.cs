
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFavoriteTitle = new System.Windows.Forms.TextBox();
            this.tbFavoriteUrl = new System.Windows.Forms.TextBox();
            this.cbRegister = new System.Windows.Forms.ComboBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btBefore = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.gbTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(28, 21);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(578, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btGet.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGet.Location = new System.Drawing.Point(612, 21);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(89, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(184, 75);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(422, 136);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(28, 263);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1033, 396);
            this.wbBrowser.TabIndex = 3;
            // 
            // tbException
            // 
            this.tbException.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbException.Location = new System.Drawing.Point(732, 21);
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
            this.rbEntertainment.CheckedChanged += new System.EventHandler(this.rbEntertainment_CheckedChanged);
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
            this.rbIt.CheckedChanged += new System.EventHandler(this.rbIt_CheckedChanged);
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
            this.rbSports.CheckedChanged += new System.EventHandler(this.rbSports_CheckedChanged);
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
            this.rbEconomy.CheckedChanged += new System.EventHandler(this.rbEconomy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(641, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "タイトル名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(648, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL";
            // 
            // tbFavoriteTitle
            // 
            this.tbFavoriteTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFavoriteTitle.Location = new System.Drawing.Point(791, 75);
            this.tbFavoriteTitle.Name = "tbFavoriteTitle";
            this.tbFavoriteTitle.Size = new System.Drawing.Size(270, 31);
            this.tbFavoriteTitle.TabIndex = 8;
            // 
            // tbFavoriteUrl
            // 
            this.tbFavoriteUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFavoriteUrl.Location = new System.Drawing.Point(732, 113);
            this.tbFavoriteUrl.Name = "tbFavoriteUrl";
            this.tbFavoriteUrl.Size = new System.Drawing.Size(329, 31);
            this.tbFavoriteUrl.TabIndex = 9;
            // 
            // cbRegister
            // 
            this.cbRegister.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegister.FormattingEnabled = true;
            this.cbRegister.Location = new System.Drawing.Point(732, 160);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(329, 32);
            this.cbRegister.TabIndex = 10;
            this.cbRegister.SelectedIndexChanged += new System.EventHandler(this.cbRegister_SelectedIndexChanged);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btRegister.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRegister.Location = new System.Drawing.Point(621, 160);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(105, 32);
            this.btRegister.TabIndex = 11;
            this.btRegister.Text = "登録";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btBefore
            // 
            this.btBefore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btBefore.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBefore.Location = new System.Drawing.Point(12, 224);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(147, 33);
            this.btBefore.TabIndex = 12;
            this.btBefore.Text = "前のページ";
            this.btBefore.UseVisualStyleBackColor = false;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btBack.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(907, 219);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(168, 38);
            this.btBack.TabIndex = 13;
            this.btBack.Text = "後ろのページ";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1087, 708);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btBefore);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.cbRegister);
            this.Controls.Add(this.tbFavoriteUrl);
            this.Controls.Add(this.tbFavoriteTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFavoriteTitle;
        private System.Windows.Forms.TextBox tbFavoriteUrl;
        private System.Windows.Forms.ComboBox cbRegister;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btBack;
    }
}

