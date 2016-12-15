using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 百度index抓取
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {

            string str_all = textBox_all.Text;
            string str_1st = textBox_first.Text;
            string str_2nd = textBox_second.Text;

            if (str_all == "" || str_1st == "" || str_2nd == "")
            {
                MessageBox.Show("不能为空！");
                return;
            }
            textBox_ret.Clear();

            string[] str_all_spi = str_all.Split(',');
            if (str_all_spi.Length <= 1) {
                MessageBox.Show("没找到数据！");
                return;
            }

            double first = Convert.ToDouble(str_1st);
            double second = Convert.ToDouble(str_2nd);

            double first_pic=Convert.ToDouble(str_all_spi[1].Split('L')[0]);
            double second_pic = Convert.ToDouble(str_all_spi[str_all_spi.Length - 1].Split('L')[0]);



            double k =  (second - first) / (second_pic - first_pic);


            textBox_ret.AppendText(first+"\n");
            for (int i = 2; i < str_all_spi.Length-1; i++)
            {
                double value = first + k * (Convert.ToDouble(str_all_spi[i].Split('L')[0]) - first_pic);
                textBox_ret.AppendText(Convert.ToInt32(value) + "\n");
            }
            textBox_ret.AppendText(second+"\n");

        }
    }
}
