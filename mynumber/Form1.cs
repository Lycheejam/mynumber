using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mynumber {
    public partial class Form1 : Form {
        //ほかで使用するやつはここで宣言していいんだよね？
        RandomNum rn = new RandomNum();
        int digitResult;

        public Form1() {
            InitializeComponent();
        }

        private void myNumBtn_Click(object sender, EventArgs e) {
            var sb = new StringBuilder();
            int[] myNumArry = new int[11];
            //乱数生成
            myNumArry = rn.randNum(11);
            //チェックデジット計算
            digitResult = rn.chkDigits(myNumArry);
            //結果表示
            resultBox.Text = rn.NumBinding(myNumArry, digitResult);
        }

        private void comNumBtn_Click(object sender, EventArgs e) {
            var sb = new StringBuilder();
            int[] comNumArry = new int[12];
            comNumArry = rn.randNum(12);
            digitResult = rn.chkComDigits(comNumArry);

            resultBox.Text = rn.NumBinding(comNumArry, digitResult);
        }

        private void juCdBtn_Click(object sender, EventArgs e) {
            var sb = new StringBuilder();
            int[] juCdArry = new int[10];
            juCdArry = rn.randNum(10);
            digitResult = rn.chkDigits(juCdArry);

            resultBox.Text = rn.NumBinding(juCdArry, digitResult);
        }
    }
}
