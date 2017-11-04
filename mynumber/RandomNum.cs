using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mynumber
{
    class RandomNum
    {
        //どこで宣言するのが正しい？
        //メソッドでいちいち宣言するより一回だけの方がええよね？
        public Random r = new Random();

        /// <summary>
        /// ランダム変数生成
        /// 引数で渡した桁数の乱数を生成する。
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] randNum(int digits)
        {
            int[] numArry = new int[digits];
            
            for (int i = 0; i < digits; i++){
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
        /// <param name="numArry"></param>
        /// <returns></returns>
        public int chkDigits(int[] numArry)
        {
            Double chkdigit = 0;
            int qn = 0;
            int sumPQ = 0;

            //ランダム数値の最下位桁を1桁目と考えるので
            //配列順序を逆転させて計算を楽にする。
            Array.Reverse(numArry);

            //2~7の重みを計算
            //これだとマイナンバーの11桁と住民票コードの10桁にしか対応できないけどまあいい？
            for (int i = 0; i < numArry.Length; i++){
                //Qnを求める
                if (0 < i + 1 && i + 1 < 7){
                    qn = i + 1;
                }else if (6 < i + 1 && i + 1 < 12){
                    qn = i - 5;
                }
                //Qnとマイナンバーの各桁を掛けて和を取る
                sumPQ = sumPQ + numArry[i] * qn;
            }
            //和 mod 11
            chkdigit = (Double)sumPQ % 11;

            //チェックデジットが1以下になった場合
            //ここってもしかして小数点以下を気にせずに0ならばでいい？
            if (0 <= chkdigit && chkdigit <= 1){
                //0 ~ 1ならば
                //これさ、1以下の数値ってあり得る？
                chkdigit = 0;
            }else{
                chkdigit = 11 - chkdigit;
            }

            //整数型でチェックデジットを返す。
            return (int)chkdigit;
        }
        /// <summary>
        /// 法人番号のチェックデジット算出
        /// </summary>
        /// <param name="numArry"></param>
        /// <returns></returns>
        public int chkComDigits(int[] numArry)
        {
            Double chkdigit = 0;
            int qn = 0;
            int sumPQ = 0;

            //ランダム数値の最下位桁を1桁目と考えるので
            //配列順序を逆転させて計算を楽にする。
            Array.Reverse(numArry);

            //1,2の重みを割り当てる
            for (int i = 0; i < numArry.Length; i++)
            {
                //Qnを求める iが偶数:1 , iが奇数:2
                if (i % 2 == 1)
                {
                    qn = 1;
                }else{
                    qn = 2;
                }
                //Qnと各桁を掛けて和を取る
                sumPQ = sumPQ + numArry[i] * qn;
            }
            //和 mod 9
            chkdigit = (Double)sumPQ % 9;

            //整数型でチェックデジットを返す。
            return 9 - (int)chkdigit;
        }
    }
}
