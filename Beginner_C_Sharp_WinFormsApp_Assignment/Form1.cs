namespace Beginner_C_Sharp_WinFormsApp_Assignment
{

    /// <summary>
    /// 題解決型授業
    /// </summary>
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            displayForm2();

            displayForm3();

        }

        /*
         * 【デバッグをしてみよう】
         * 
         * 問題のあるソースコードを配布しますので、これを解決してください。
         * ※一見問題なさそうなコードもあります
         * 
         * また、いくつか実装してほしい内容も記述されていますので、こちらも解決してください。
         */

        /// <summary>
        /// 「7 + 3 = 10」と表示させたい。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = 7;
            int num2 = 3;
            int result = num1 + num2;

            label1.Text = num1 + " + " + num2 + " = " + result;

        }

        /// <summary>
        /// num1 ÷ num2 の結果を表示させたい。
        /// エラーで止まってほしくない。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int result = 0;

                result = num1 / num2;

                label2.Text = result.ToString();

            }
            catch (FormatException formatException)
            {

                label2.Text = formatException.Message;

            }
            catch (OverflowException overflowException)
            {

                label2.Text = overflowException.Message;

            }
            catch (DivideByZeroException divideByZeroException)
            {

                label2.Text = divideByZeroException.Message;

            }

        }

        /*
         * 文字列を6つ取得し、5W1Hの文章を作成するプログラムコードを書いてください。
         * ※5W1Hが含まれる文章の例：「先週、私は学校から課題を与えられたため、自宅でPCを使ってその課題を完成させた。」
         * 
         * e.g.)
         * 　入力：When（いつ）、Where（どこで）、Who（誰が）、What（何を）、Why（なぜ）、How（どのように）
         * 　出力：「昨日、帰り道で、妹が、ネコを、可愛いからと、そっと撫でていた。」
         * 　
         * 　1. 例題を"5W1H"の穴埋め形式に変換する
         * 　   →「 [When] 、 [Where] 、 [Who] 、 [What] 、 [Why] 、 [How] 。」
         * 　2. 入力エリアを作る
         * 　3. ボタンを作る
         * 　4. 文章の表示エリアを作る
         * 　5. ボタンが押されたら 1 で作った空欄に入力された文字をセットする
         * 　6. 5 で作った文章を表示する
         */
        public void displayForm2()
        {

            new Form2().Show();

        }

        /*
         * 1～100のランダムな整数を2つ使い、四則演算の結果を表示するプログラムコードを書いてください。
         * 
         * ランダムな整数の発生方法：
         *    Random random = new Random(); ←ランダムオブジェクトを生成
         *    int number = random.Next(0, 10); ←0～9の整数が呼ばれるたびに発生
         * 
         * e.g.)
         * 　出力結果：「32 ＋ 78 ＝ 110」「85 － 24 ＝ 61」「5 × 61 ＝ 305」「40 ÷ 2 ＝ 20」
         * 
         * cf.)
         * 『C#のRandomの使い方｜Randomクラスの機能と乱数配列の生成』
         * https://www.fenet.jp/dotnet/column/language/8212/
         * 
         * 　1. 数字表示用のラベル、および演算式表示用のラベルを作る
         * 　2. 値変更用のボタンを作る
         * 　3. ランダムのオブジェクトを生成する
         * 　4. 左辺の数値を生成し、左辺のラベルに設定する
         * 　5. 右辺の数値を生成し、右辺のラベルに設定する
         * 　6. 四則演算それぞれの結果を回答ラベルに設定する
         */
        public void displayForm3()
        {

            new Form3().Show();

        }

    }

}