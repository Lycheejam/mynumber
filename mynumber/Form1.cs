using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mynumber
{
    public partial class Form1 : Form
    {  
        //ほかで使用するやつはここで宣言していいんだよね？
        RandomNum rn = new RandomNum();
        int digitResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void myNumBtn_Click(object sender, EventArgs e)
        {
            int[] myNumArry = new int[11];
            myNumArry = rn.randNum(11);
            digitResult = rn.chkDigits(myNumArry);

            //テキストボックスにマイナンバー表示
            resultBox.Text = "";    //初期化
            for (int i = 0; i < myNumArry.Length; i++)
            {
                resultBox.Text = resultBox.Text + myNumArry[i].ToString();
            }
            //チェックデジットも追加
            resultBox.Text = resultBox.Text + digitResult.ToString();
        }

        private void comNumBtn_Click(object sender, EventArgs e)
        {
            int[] comNumArry = new int[12];
            comNumArry = rn.randNum(12);
            digitResult = rn.chkComDigits(comNumArry);
            //テキストボックスにマイナンバー表示
            resultBox.Text = "";    //初期化
            //マイナンバー、住民票CDと違いチェックデジットが先頭になる。
            resultBox.Text = resultBox.Text + digitResult.ToString();
            for (int i = 0; i < comNumArry.Length; i++)
            {
                resultBox.Text = resultBox.Text + comNumArry[i].ToString();
            }
        }

        private void juCdBtn_Click(object sender, EventArgs e)
        {
            int[] juCdArry = new int[10];
            juCdArry = rn.randNum(10);
            digitResult = rn.chkDigits(juCdArry);
            
            //テキストボックスにマイナンバー表示
            resultBox.Text = "";    //初期化
            for (int i = 0; i < juCdArry.Length; i++)
            {
                resultBox.Text = resultBox.Text + juCdArry[i].ToString();
            }
            //チェックデジットも追加
            resultBox.Text = resultBox.Text + digitResult.ToString();
        }
    }
}
