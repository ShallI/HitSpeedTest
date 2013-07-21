namespace 手速测试
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBpm1 = new System.Windows.Forms.Label();
            this.lblLifeTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHits1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLife = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBpm2 = new System.Windows.Forms.Label();
            this.lblLifeHits = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHits2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkK1 = new System.Windows.Forms.CheckBox();
            this.cmbK1 = new System.Windows.Forms.ComboBox();
            this.chkK2 = new System.Windows.Forms.CheckBox();
            this.cmbK2 = new System.Windows.Forms.ComboBox();
            this.chkM1 = new System.Windows.Forms.CheckBox();
            this.cmbM1 = new System.Windows.Forms.ComboBox();
            this.chkM2 = new System.Windows.Forms.CheckBox();
            this.cmbM2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picStatus
            // 
            this.picStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStatus.Location = new System.Drawing.Point(12, 130);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(600, 300);
            this.picStatus.TabIndex = 3;
            this.picStatus.TabStop = false;
            this.picStatus.Click += new System.EventHandler(this.picStatus_Click);
            this.picStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.picStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.picStatus_Paint);
            this.picStatus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(526, 78);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 46);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "重置(回车)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLife);
            this.groupBox1.Controls.Add(this.lblLifeTime);
            this.groupBox1.Controls.Add(this.lblHits1);
            this.groupBox1.Controls.Add(this.lblBpm1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 62);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBpm1
            // 
            this.lblBpm1.AutoSize = true;
            this.lblBpm1.Location = new System.Drawing.Point(249, 41);
            this.lblBpm1.Name = "lblBpm1";
            this.lblBpm1.Size = new System.Drawing.Size(35, 12);
            this.lblBpm1.TabIndex = 19;
            this.lblBpm1.Text = "123.4";
            // 
            // lblLifeTime
            // 
            this.lblLifeTime.AutoSize = true;
            this.lblLifeTime.Location = new System.Drawing.Point(63, 41);
            this.lblLifeTime.Name = "lblLifeTime";
            this.lblLifeTime.Size = new System.Drawing.Size(35, 12);
            this.lblLifeTime.TabIndex = 18;
            this.lblLifeTime.Text = "1.234";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "当前BPM:";
            // 
            // lblHits1
            // 
            this.lblHits1.AutoSize = true;
            this.lblHits1.Location = new System.Drawing.Point(169, 41);
            this.lblHits1.Name = "lblHits1";
            this.lblHits1.Size = new System.Drawing.Size(23, 12);
            this.lblHits1.TabIndex = 16;
            this.lblHits1.Text = "183";
            this.lblHits1.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "点击次数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "剩余时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "测试时间(秒):";
            // 
            // txtLife
            // 
            this.txtLife.Location = new System.Drawing.Point(95, 14);
            this.txtLife.Name = "txtLife";
            this.txtLife.Size = new System.Drawing.Size(85, 21);
            this.txtLife.TabIndex = 11;
            this.txtLife.Text = "5";
            this.txtLife.TextChanged += new System.EventHandler(this.txtLife_TextChanged);
            this.txtLife.Leave += new System.EventHandler(this.txtLife_Leave);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(237, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "定时测试";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtHits);
            this.groupBox2.Controls.Add(this.lblLifeHits);
            this.groupBox2.Controls.Add(this.lblHits2);
            this.groupBox2.Controls.Add(this.lblBpm2);
            this.groupBox2.Location = new System.Drawing.Point(318, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 62);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // lblBpm2
            // 
            this.lblBpm2.AutoSize = true;
            this.lblBpm2.Location = new System.Drawing.Point(249, 41);
            this.lblBpm2.Name = "lblBpm2";
            this.lblBpm2.Size = new System.Drawing.Size(35, 12);
            this.lblBpm2.TabIndex = 28;
            this.lblBpm2.Text = "123.4";
            // 
            // lblLifeHits
            // 
            this.lblLifeHits.AutoSize = true;
            this.lblLifeHits.Location = new System.Drawing.Point(65, 41);
            this.lblLifeHits.Name = "lblLifeHits";
            this.lblLifeHits.Size = new System.Drawing.Size(17, 12);
            this.lblLifeHits.TabIndex = 27;
            this.lblLifeHits.Text = "23";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "当前BPM:";
            // 
            // lblHits2
            // 
            this.lblHits2.AutoSize = true;
            this.lblHits2.Location = new System.Drawing.Point(160, 41);
            this.lblHits2.Name = "lblHits2";
            this.lblHits2.Size = new System.Drawing.Size(23, 12);
            this.lblHits2.TabIndex = 25;
            this.lblHits2.Text = "183";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "点击次数:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "剩余次数:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "测试次数(次):";
            // 
            // txtHits
            // 
            this.txtHits.Location = new System.Drawing.Point(95, 14);
            this.txtHits.Name = "txtHits";
            this.txtHits.Size = new System.Drawing.Size(85, 21);
            this.txtHits.TabIndex = 20;
            this.txtHits.Text = "50";
            this.txtHits.Leave += new System.EventHandler(this.txtHits_Leave);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(537, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.Text = "定量测试";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 46);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "按键设定";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkK1);
            this.flowLayoutPanel1.Controls.Add(this.cmbK1);
            this.flowLayoutPanel1.Controls.Add(this.chkK2);
            this.flowLayoutPanel1.Controls.Add(this.cmbK2);
            this.flowLayoutPanel1.Controls.Add(this.chkM1);
            this.flowLayoutPanel1.Controls.Add(this.cmbM1);
            this.flowLayoutPanel1.Controls.Add(this.chkM2);
            this.flowLayoutPanel1.Controls.Add(this.cmbM2);
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkK1
            // 
            this.chkK1.Checked = true;
            this.chkK1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkK1.Location = new System.Drawing.Point(3, 3);
            this.chkK1.Name = "chkK1";
            this.chkK1.Size = new System.Drawing.Size(36, 20);
            this.chkK1.TabIndex = 8;
            this.chkK1.Text = "K1";
            this.chkK1.UseVisualStyleBackColor = true;
            this.chkK1.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // cmbK1
            // 
            this.cmbK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbK1.FormattingEnabled = true;
            this.cmbK1.Location = new System.Drawing.Point(45, 3);
            this.cmbK1.Name = "cmbK1";
            this.cmbK1.Size = new System.Drawing.Size(70, 20);
            this.cmbK1.TabIndex = 9;
            this.cmbK1.SelectionChangeCommitted += new System.EventHandler(this.settingsChanged);
            // 
            // chkK2
            // 
            this.chkK2.Checked = true;
            this.chkK2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkK2.Location = new System.Drawing.Point(121, 3);
            this.chkK2.Name = "chkK2";
            this.chkK2.Size = new System.Drawing.Size(36, 20);
            this.chkK2.TabIndex = 7;
            this.chkK2.Text = "K2";
            this.chkK2.UseVisualStyleBackColor = true;
            this.chkK2.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // cmbK2
            // 
            this.cmbK2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbK2.FormattingEnabled = true;
            this.cmbK2.Location = new System.Drawing.Point(163, 3);
            this.cmbK2.Name = "cmbK2";
            this.cmbK2.Size = new System.Drawing.Size(70, 20);
            this.cmbK2.TabIndex = 10;
            this.cmbK2.SelectionChangeCommitted += new System.EventHandler(this.settingsChanged);
            // 
            // chkM1
            // 
            this.chkM1.Checked = true;
            this.chkM1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkM1.Location = new System.Drawing.Point(239, 3);
            this.chkM1.Name = "chkM1";
            this.chkM1.Size = new System.Drawing.Size(36, 20);
            this.chkM1.TabIndex = 6;
            this.chkM1.Text = "M1";
            this.chkM1.UseVisualStyleBackColor = true;
            this.chkM1.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // cmbM1
            // 
            this.cmbM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM1.FormattingEnabled = true;
            this.cmbM1.Location = new System.Drawing.Point(281, 3);
            this.cmbM1.Name = "cmbM1";
            this.cmbM1.Size = new System.Drawing.Size(70, 20);
            this.cmbM1.TabIndex = 11;
            this.cmbM1.SelectionChangeCommitted += new System.EventHandler(this.settingsChanged);
            // 
            // chkM2
            // 
            this.chkM2.Checked = true;
            this.chkM2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkM2.Location = new System.Drawing.Point(357, 3);
            this.chkM2.Name = "chkM2";
            this.chkM2.Size = new System.Drawing.Size(36, 20);
            this.chkM2.TabIndex = 5;
            this.chkM2.Text = "M2";
            this.chkM2.UseVisualStyleBackColor = true;
            this.chkM2.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // cmbM2
            // 
            this.cmbM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM2.FormattingEnabled = true;
            this.cmbM2.Location = new System.Drawing.Point(399, 3);
            this.cmbM2.Name = "cmbM2";
            this.cmbM2.Size = new System.Drawing.Size(70, 20);
            this.cmbM2.TabIndex = 12;
            this.cmbM2.SelectionChangeCommitted += new System.EventHandler(this.settingsChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picStatus);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "手速测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBpm1;
        private System.Windows.Forms.Label lblLifeTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHits1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLife;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBpm2;
        private System.Windows.Forms.Label lblLifeHits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHits2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkK1;
        private System.Windows.Forms.ComboBox cmbK1;
        private System.Windows.Forms.CheckBox chkK2;
        private System.Windows.Forms.ComboBox cmbK2;
        private System.Windows.Forms.CheckBox chkM1;
        private System.Windows.Forms.ComboBox cmbM1;
        private System.Windows.Forms.CheckBox chkM2;
        private System.Windows.Forms.ComboBox cmbM2;
    }
}

