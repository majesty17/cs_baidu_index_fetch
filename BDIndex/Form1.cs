using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //窗口载入
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser_main.Navigate(textBox_url.Text);
        }
        //转到
        private void button_navi_Click(object sender, EventArgs e)
        {
            webBrowser_main.Navigate(textBox_url.Text);
        }
        //web加载完毕
        private void webBrowser_main_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox_url.Text = webBrowser_main.Url.AbsoluteUri;
        }

        //获取数据
        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser_main.Document == null) 
            {
                MessageBox.Show("doc is null!");
                return;
            }
            HtmlDocument doc = webBrowser_main.Document;//.OpenNew(true);
            if (doc == null)
            {
                MessageBox.Show("doc is null too!");
                return;
            }
           /*
            HtmlElementCollection paths=doc.GetElementsByTagName("path");
            for (int i = 0; i < paths.Count; i++) 
            {
                MessageBox.Show(paths[i].OuterHtml);
            }
            */
            textBox1.Text = doc.GetElementById("trend").InnerHtml;
            MessageBox.Show(doc.GetElementById("trend").InnerHtml);


        }


    }
}
