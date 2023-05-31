using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beginner_C_Sharp_WinFormsApp_Assignment
{

    public partial class Form3 : Form
    {

        private Random random = new Random();

        public Form3()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 左辺の値を生成
            int number1 = random.Next(1, 101);
            // 右辺の値を生成
            int number2 = random.Next(1, 101);

            // 左辺の数字を設定
            label1.Text = label8.Text = label12.Text = label16.Text = number1.ToString();
            // 右辺の数字を設定
            label3.Text = label6.Text = label10.Text = label14.Text = number2.ToString();

            // 足し算
            label17.Text = (number1 + number2).ToString();

            // 引き算
            label18.Text = (number1 - number2).ToString();

            // 掛け算
            label19.Text = (number1 * number2).ToString();

            // 割り算
            label20.Text = (number1 / number2).ToString();

        }

    }

}
