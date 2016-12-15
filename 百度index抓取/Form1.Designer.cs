namespace 百度index抓取
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
            this.textBox_all = new System.Windows.Forms.TextBox();
            this.textBox_first = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_second = new System.Windows.Forms.TextBox();
            this.button_calc = new System.Windows.Forms.Button();
            this.textBox_ret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_all
            // 
            this.textBox_all.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_all.Location = new System.Drawing.Point(13, 13);
            this.textBox_all.Name = "textBox_all";
            this.textBox_all.Size = new System.Drawing.Size(744, 21);
            this.textBox_all.TabIndex = 0;
            // 
            // textBox_first
            // 
            this.textBox_first.Location = new System.Drawing.Point(59, 48);
            this.textBox_first.Name = "textBox_first";
            this.textBox_first.Size = new System.Drawing.Size(100, 21);
            this.textBox_first.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "first";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "second";
            // 
            // textBox_second
            // 
            this.textBox_second.Location = new System.Drawing.Point(59, 79);
            this.textBox_second.Name = "textBox_second";
            this.textBox_second.Size = new System.Drawing.Size(100, 21);
            this.textBox_second.TabIndex = 4;
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(14, 106);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(75, 23);
            this.button_calc.TabIndex = 5;
            this.button_calc.Text = "计算";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // textBox_ret
            // 
            this.textBox_ret.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ret.Location = new System.Drawing.Point(165, 48);
            this.textBox_ret.Multiline = true;
            this.textBox_ret.Name = "textBox_ret";
            this.textBox_ret.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ret.Size = new System.Drawing.Size(592, 312);
            this.textBox_ret.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 372);
            this.Controls.Add(this.textBox_ret);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.textBox_second);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_first);
            this.Controls.Add(this.textBox_all);
            this.Name = "Form1";
            this.Text = "百度index估值";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_all;
        private System.Windows.Forms.TextBox textBox_first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_second;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.TextBox textBox_ret;
    }
}

