
using System.Windows.Forms;

namespace CalenderApp {
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
            if (disposing && (components != null)) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btFowerdYear = new System.Windows.Forms.Button();
            this.btNextYear = new System.Windows.Forms.Button();
            this.btFowerdMonth = new System.Windows.Forms.Button();
            this.btFowerdDay = new System.Windows.Forms.Button();
            this.btNextMonth = new System.Windows.Forms.Button();
            this.btNextDay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btAge = new System.Windows.Forms.Button();
            this.tbNow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(108, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(36, 77);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(125, 41);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(360, 16);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(272, 253);
            this.tbMessage.TabIndex = 3;
            // 
            // btFowerdYear
            // 
            this.btFowerdYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFowerdYear.Location = new System.Drawing.Point(36, 151);
            this.btFowerdYear.Name = "btFowerdYear";
            this.btFowerdYear.Size = new System.Drawing.Size(125, 34);
            this.btFowerdYear.TabIndex = 4;
            this.btFowerdYear.Text = "-年";
            this.btFowerdYear.UseVisualStyleBackColor = true;
            this.btFowerdYear.Click += new System.EventHandler(this.btFowerdYear_Click);
            // 
            // btNextYear
            // 
            this.btNextYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNextYear.Location = new System.Drawing.Point(183, 151);
            this.btNextYear.Name = "btNextYear";
            this.btNextYear.Size = new System.Drawing.Size(125, 34);
            this.btNextYear.TabIndex = 5;
            this.btNextYear.Text = "+年";
            this.btNextYear.UseVisualStyleBackColor = true;
            this.btNextYear.Click += new System.EventHandler(this.btNextYear_Click);
            // 
            // btFowerdMonth
            // 
            this.btFowerdMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFowerdMonth.Location = new System.Drawing.Point(36, 213);
            this.btFowerdMonth.Name = "btFowerdMonth";
            this.btFowerdMonth.Size = new System.Drawing.Size(125, 34);
            this.btFowerdMonth.TabIndex = 6;
            this.btFowerdMonth.Text = "-月";
            this.btFowerdMonth.UseVisualStyleBackColor = true;
            this.btFowerdMonth.Click += new System.EventHandler(this.btFowerdMonth_Click);
            // 
            // btFowerdDay
            // 
            this.btFowerdDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFowerdDay.Location = new System.Drawing.Point(36, 270);
            this.btFowerdDay.Name = "btFowerdDay";
            this.btFowerdDay.Size = new System.Drawing.Size(125, 34);
            this.btFowerdDay.TabIndex = 7;
            this.btFowerdDay.Text = "-日";
            this.btFowerdDay.UseVisualStyleBackColor = true;
            this.btFowerdDay.Click += new System.EventHandler(this.btFowerdDay_Click);
            // 
            // btNextMonth
            // 
            this.btNextMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNextMonth.Location = new System.Drawing.Point(183, 213);
            this.btNextMonth.Name = "btNextMonth";
            this.btNextMonth.Size = new System.Drawing.Size(125, 34);
            this.btNextMonth.TabIndex = 8;
            this.btNextMonth.Text = "+月";
            this.btNextMonth.UseVisualStyleBackColor = true;
            this.btNextMonth.Click += new System.EventHandler(this.btNextMonth_Click);
            // 
            // btNextDay
            // 
            this.btNextDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNextDay.Location = new System.Drawing.Point(183, 270);
            this.btNextDay.Name = "btNextDay";
            this.btNextDay.Size = new System.Drawing.Size(125, 34);
            this.btNextDay.TabIndex = 9;
            this.btNextDay.Text = "+日";
            this.btNextDay.UseVisualStyleBackColor = true;
            this.btNextDay.Click += new System.EventHandler(this.btNextDay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(31, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "現在時刻:";
            // 
            // btAge
            // 
            this.btAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAge.Location = new System.Drawing.Point(183, 77);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(124, 40);
            this.btAge.TabIndex = 12;
            this.btAge.Text = "年齢";
            this.btAge.UseVisualStyleBackColor = true;
            // 
            // tbNow
            // 
            this.tbNow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNow.Location = new System.Drawing.Point(183, 359);
            this.tbNow.Multiline = true;
            this.tbNow.Name = "tbNow";
            this.tbNow.Size = new System.Drawing.Size(243, 27);
            this.tbNow.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 424);
            this.Controls.Add(this.tbNow);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btNextDay);
            this.Controls.Add(this.btNextMonth);
            this.Controls.Add(this.btFowerdDay);
            this.Controls.Add(this.btFowerdMonth);
            this.Controls.Add(this.btNextYear);
            this.Controls.Add(this.btFowerdYear);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btFowerdYear;
        private System.Windows.Forms.Button btNextYear;
        private System.Windows.Forms.Button btFowerdMonth;
        private System.Windows.Forms.Button btFowerdDay;
        private System.Windows.Forms.Button btNextMonth;
        private System.Windows.Forms.Button btNextDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAge;
        private TextBox tbNow;
    }
}

