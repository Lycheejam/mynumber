using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mynumber {
    class RandomNum {
        //どこで宣言するのが正しい？
        //メソッドでいちいち宣言するより一回だけの方がええよね？
        private Random r = new Random();

        /// <summary>
        /// 乱数生成
        /// 引数で渡した桁数の乱数を生成する。
        /// </summary>
        /// <param name="digits">桁数</param>
        /// <returns>ランダム整数（配列）</returns>
        public int[] randNum(int digits) {
            int[] numArry = new int[digits];

            for (int i = 0; i < digits; i++) {
                //0以上10未満のランダム整数を返す
                numArry[i] = r.Next(10);
            }
            //配列ごと返却
            return numArry;
        }
        /// <summary>
        /// マイナンバーと住民票コードのチェックデジット計算
        /// 乱数の格納された配列を渡してあげてね。
        /// </summary>
        /// <param name="numArry">乱数の配列</param>
        /// <returns>チェックデジット</returns>
        public int chkDigits(int[] numArry) {
            Double chkdigit = 0;
            int qn = 0;
            int sumPQ = 0;

            //ランダム数値の最下位桁を1桁目と考えるので
            //配列順序を逆転させて計算を楽にする。
            Array.Reverse(numArry);

            //2~7の重みを計算
            //これだとマイナンバーの11桁と住民票コードの10桁にしか対応できないけどまあいい？
            foreach (var item in numArry) {
                //Qnを求める
                if (0 < item + 1 && item + 1 < 7) {
                    qn = item + 1;
                } else if (6 < item + 1 && item + 1 < 12) {
                    qn = item - 5;
                }
                //Qnとマイナンバーの各桁を掛けて和を取る
                sumPQ = sumPQ + item * qn;
            }
            //和 mod 11
            chkdigit = (Double)sumPQ % 11;

            //チェックデジットが1以下になった場合
            //ここってもしかして小数点以下を気にせずに0ならばでいい？
            if (0 <= chkdigit && chkdigit <= 1) {
                //0 ~ 1ならば
                //これさ、1以下の数値ってあり得る？
                chkdigit = 0;
            } else {
                chkdigit = 11 - chkdigit;
            }

            //整数型でチェックデジットを返す。
            return (int)chkdigit;
        }

        /// <summary>
        /// 法人番号のチェックデジット算出
        /// </summary>
        /// <param name="numArry">乱数配列</param>
        /// <returns>チェックデジット</returns>
        public int chkComDigits(int[] numArry) {
            Double chkdigit = 0;
            int qn = 0;
            int sumPQ = 0;

            //ランダム数値の最下位桁を1桁目と考えるので
            //配列順序を逆転させて計算を楽にする。
            Array.Reverse(numArry);

            //1,2の重みを割り当てる
            foreach (var item in numArry) {
                //Qnを求める iが偶数:1 , iが奇数:2
                if (item % 2 == 1) {
                    qn = 1;
                } else {
                    qn = 2;
                }
                //Qnと各桁を掛けて和を取る
                sumPQ = sumPQ + item * qn;
            }
            //和 mod 9
            chkdigit = (Double)sumPQ % 9;

            //整数型でチェックデジットを返す。
            return 9 - (int)chkdigit;
        }

        /// <summary>
        /// 番号を文字列に結合する。
        /// </summary>
        /// <param name="numArry">乱数配列</param>
        /// <param name="checkDigit">チェックデジット</param>
        /// <returns>番号</returns>
        public string NumBinding(int[] numArry, int checkDigit) {
            var sb = new StringBuilder();
            foreach (var item in numArry) {
                //sb.Append(item);
                sb.Append(item.ToString());
            }
            //住民票コード/個人番号 or 法人番号
            if (numArry.Length == 12) {
                sb.Insert(0, checkDigit.ToString());    //先頭に追加
                //sb.Insert(0, "X");  //先頭に追加されているかテスト

            } else {
                sb.Append(checkDigit.ToString());   //末尾に追加
                //sb.Append("X"); //末尾に追加されているかテスト
            }

            return sb.ToString();
        }
    }
}
