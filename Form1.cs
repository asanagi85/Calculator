using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Calculator346
{
    public partial class Form1 : Form
    {
        //現在画面に表示されている数値が既に小数点を含んでいるかの変数
        private bool isDecimal;
        //現在画面に表示されている0が0ボタンが入力された結果であるかどうかを判断する変数
        private bool checkZeroBtn;
        //現在演算子が入力されている状態かを判断するフラグ
        private bool isOperatingNow;
        //演算子が入力されたら既存で入力した数値を入れる変数
        private string firstNumber = string.Empty;
        //演算子を入れる変数
        private string symbolOfOperator = string.Empty;
        //演算子のあとに入力された数値を入れる変数
        private string secondNumber = string.Empty;
        //現在画面に表示された数値が計算結果であるかどうかを判断する
        private bool isCalculateResult;
        //10桁を超えたフリーズかどうかを判断するフラグ
        private bool isOverTenDigit;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //テキストボックスの初期値を０にする
            txtResult.Text = "0";
            //小数点値を初期化する
            CheckDecimal();
            //最初のZero状態では+/-が動作できないようにする
            checkZeroBtn = false;
        }

        //現在の画面で表示されている値が小数点を含んでいるかチェックするメッソド
        private bool CheckDecimal()
        {
            isDecimal = txtResult.Text.Contains(".");
            return isDecimal;
        }

        /// <summary>
        ///現在入力された演算子を区別するメソッド 
        ///既存演算子の有無を判別し、有りの場合、SecondNumが入力された場合は既登録の演算子を返す。そうでなければ入力された演算子を登録する
        ///既に演算子が登録され、SecondNumがない場合はなにもしない
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        private string WhatOperatorNow(string op)
        {
            string result = string.Empty;
            string inputOp = op;
            op = IsSymbolNull(op);
            if (op == string.Empty )
            {
                result = "";
            }
            else
            {
                switch (op)
                {
                    case "+": result = AddOperate(inputOp); break;
                    case "-": result = SubOperate(inputOp); break;
                    case "×": result = MulOperate(inputOp); break;
                    case "÷": result = DivOperate(inputOp); break;
                    case "=": result = EqualOperate(op); break;
                }
            }
            if (result == string.Empty)
            {
                result = txtResult.Text;
            }
            if (!symbolOfOperator.Equals("="))
            {
                isOperatingNow = true;
            }
            return result;
        }

        //10番機能：プラス演算のメソッド
        private string AddOperate(string op)
        {
            firstNumber = ChangeNullToZero(firstNumber);
            if (secondNumber != string.Empty)
            {
                decimal fstNum = decimal.Parse(firstNumber);
                decimal sndNum = decimal.Parse(secondNumber);
                decimal result = fstNum + sndNum;
                secondNumber = string.Empty;
                firstNumber = result.ToString();
                firstNumber = removeZeroUnderOne(firstNumber);
                isCalculateResult = true;
                //계산결과값을 참으로 바꾸고, 계산중을 거짓으로 바꿈
                isOperatingNow = false;
                return RemoveOverTenDigit(firstNumber);
            }
            else
            {
                return "";
            }
        }

        //11番機能：マイナス演算のメソッド
        private string SubOperate(string op)
        {
            firstNumber = ChangeNullToZero(firstNumber);
            if (secondNumber != string.Empty)
            {
                decimal fstNum = decimal.Parse(firstNumber);
                decimal sndNum = decimal.Parse(secondNumber);
                decimal result = fstNum - sndNum;
                secondNumber = string.Empty;
                firstNumber = result.ToString();
                firstNumber = removeZeroUnderOne(firstNumber);
                isCalculateResult = true;
                isOperatingNow = false;
                return RemoveOverTenDigit(firstNumber);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 12番機能：掛け算のメソッド
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        private string MulOperate(string op)
        {
            firstNumber = ChangeNullToZero(firstNumber);
            if (secondNumber != string.Empty)
            {
                decimal fstNum = decimal.Parse(firstNumber);
                decimal sndNum = decimal.Parse(secondNumber);
                decimal result = fstNum * sndNum;
                secondNumber = string.Empty;
                firstNumber = result.ToString();
                firstNumber = removeZeroUnderOne(firstNumber);
                isCalculateResult = true;
                isOperatingNow = false;
                return RemoveOverTenDigit(firstNumber);
            }
            else
            {
                return "";
            }
        }

        /// 13番機能：割り算のメソッド
        private string DivOperate(string op)
        {
            firstNumber = ChangeNullToZero(firstNumber);
            if (secondNumber != string.Empty)
            {
                decimal fstNum = decimal.Parse(firstNumber);
                decimal sndNum = decimal.Parse(secondNumber);
                decimal result = 0;
                try
                {
                    result = fstNum / sndNum;
                }
                catch(Exception e)
                {
                    lblError.Text = "E";
                    pnl1.Enabled = false;
                    pnl2.Enabled = false;
                    btn0.Enabled = false;
                }
                secondNumber = string.Empty;
                firstNumber = result.ToString();
                firstNumber = removeZeroUnderOne(firstNumber);
                isCalculateResult = true;
                isOperatingNow = false;
                return RemoveOverTenDigit(firstNumber);
            }
            else
            {
                return"";
            }
        }

        /// <summary>
        /// =メソッド
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        private string EqualOperate(string op)
        {
            isOperatingNow = false;
            isCalculateResult = true;
            firstNumber = ChangeNullToZero(firstNumber);
            decimal result = decimal.Parse(firstNumber);
            firstNumber = removeZeroUnderOne(result+"");
            if (!secondNumber.Equals(string.Empty))
            {
                firstNumber = secondNumber;
                secondNumber = string.Empty;
                return RemoveOverTenDigit(firstNumber);
            }
            else
            {
                return RemoveOverTenDigit(firstNumber);
            }
        }

        /// <summary>
        /// 既存演算子が登録されているかを判別するメソッド
        /// </summary>
        private string IsSymbolNull(string op)
        {
            if(symbolOfOperator != string.Empty)
            {
                return IsSecondNumberExist(op);
            }
            else
            {
                //登録済みの演算子がない場合は入力された演算子を登録する
                symbolOfOperator = op;
                if(op.Equals("="))
                {
                    return op;
                }
                return "";
            }
        }

        //secondNumberにデータが入力されているかどうかを判断するメソッド
        private string IsSecondNumberExist(string op)
        {
            if(secondNumber != string.Empty)
            {
                string oldOp = symbolOfOperator;
                symbolOfOperator = op;
                return oldOp;
            }
            else
            {
                symbolOfOperator = op;
                if (op == "=")
                {
                    return symbolOfOperator;
                }
                else
                {
                    return "";
                }
            }
        }

        //演算のスタンバイをするメソッド
        private void ReadyOperate(string op)
        {
            symbolOfOperator = op;
        }

        //もし、現在演算子が入力らせている状態であれば、すでに入力されている数値を保存するメソッド
        private string OperatingNow()
        {
            string num = string.Empty;
            if (isOperatingNow)
            {
                if (secondNumber == string.Empty)
                {
                    num = "0";
                }
                else
                {
                    num = txtResult.Text;
                    //firstNumber = num;
                }
            }
            else
            {
                if (isCalculateResult)
                {
                    num = "0";
                    firstNumber = txtResult.Text;
                    isCalculateResult = false;
                }
                else
                {
                    num = txtResult.Text;
                }
            }
            return num;
        }

        /// <summary>
        /// 画面に数字を足し、前の0をなくすメソッド
        /// 入力された数字を格納する変数
        /// 現在表示画面が10桁を超えていなければ、numに入力された値を代入、そうでなければメッセージボックスを開き、なにも代入しない
        /// 入力値が.であれば取りあえず後ろに.1をつける
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string AddNumberAndClearZero(string num)
        {
            string inputResult = string.Empty;
            txtResult.Text = OperatingNow();
            num = CheckDigitMorethenTen(num);
            if (num == ".")
            {
                num = CheckPointMoreThenTwo();
                inputResult += txtResult.Text + num;
            }
            else if (CheckDecimal())
            {
                inputResult += txtResult.Text + num;
            }
            else if (!CheckDecimal() && !txtResult.Text.Contains("-"))
            {
                string rmvFrontZero = txtResult.Text + num;
                string rmvComma = string.Empty;
                //カンマを除去する
                rmvComma = OnlyNumber(rmvFrontZero);
                decimal afterRemovedZero = decimal.Parse(rmvComma);
                //テキストに戻して再度画面に表示させる
                inputResult += FirstChangeFormat(afterRemovedZero + "");
            }
            else if (!CheckDecimal() && txtResult.Text.Contains("-"))
            {
                string rmvFrontZero = txtResult.Text + num;
                string rmvComma = string.Empty;
                //カンマを除去する
                rmvComma = OnlyNumber(rmvFrontZero);
                decimal afterRemovedZero = decimal.Parse(rmvComma);
                //テキストに戻して再度画面に表示させる
                inputResult += FirstChangeFormat("-" + afterRemovedZero);
            }
            if (isOperatingNow)
            {
                secondNumber = inputResult;
            }
            else
            {
                firstNumber = inputResult;
            }
            return inputResult;
        }
        //カンマを除去するメソッド
        private string OnlyNumber(string num)
        {
            string onlyNumber = string.Empty;
            foreach (char c in num)
            {
                if (char.IsNumber(c))
                 {
                    onlyNumber += c;
                    num = onlyNumber;
                }
            }
            return num;
        }
        //7番機能：桁区切りのフォーマット
        //フォーマット1段階：初期値に0か00が入力されたら0を返すメソッド
        private string FirstChangeFormat(string num)
        {
            if((num == "0" && txtResult.Text == "0"))
            {
                return "0";
            }
            else
            {
               return num = SecondChangeFormat(num);
            }
        }
        //フォーマット2段階：ドット有無の処理を分けて返すメソッド
        private string SecondChangeFormat(string num)
        {
            if(num.Contains("."))
            {
                return num = ThirdChangeFormat(num);
            }
            else
            {
               return num = FirthChangeFormat(num);
            }
        }

        /// <summary>
        /// フォーマット3段階：ドットがある場合の処理を返すメソッド 
        ///現在画面に表示された文字列を保存させる
        ///整数部分と小数点以下を分離する
        ///文字列にIndexOfメソッドを利用し、ドットがある場所のインデックスを調べる
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string ThirdChangeFormat(string num)
        {
            if (num.Contains("-"))
            {
                
                int indextOfDot = num.IndexOf(".");
                //substringを利用し、最初からドットまでを全部抜き取り、整数だけ新しい文字列変数に代入する
                string integer = num.Substring(0, indextOfDot);
                if (integer.Contains("-"))
                {
                    integer = integer.Remove(0,1);
                }
                //substringを利用し、ドットから最後まで抜き取って小数部分の文字列を変数に代入する
                string underOne = num.Substring(indextOfDot, num.Length - indextOfDot);
                //整数部分の文字列にString.Formatを活用し、区切りカンマを反映させる
                decimal changeInterger = decimal.Parse(integer);
                integer = String.Format("{0:#,#}", changeInterger);
                integer = ChangeNullToZero(integer);
                num = "-" + integer + underOne;
            }
            else
            {
                int indextOfDot = num.IndexOf(".");
                //substringを利用し、最初からドットまでを全部抜き取り、整数だけ新しい文字列変数に代入する
                string integer = num.Substring(0, indextOfDot);
                //substringを利用し、ドットから最後まで抜き取って小数部分の文字列を変数に代入する
                string underOne = num.Substring(indextOfDot, num.Length - indextOfDot);
                //整数部分の文字列にString.Formatを活用し、区切りカンマを反映させる
                decimal changeInterger = decimal.Parse(integer);
                integer = String.Format("{0:#,#}", changeInterger);
                integer = ChangeNullToZero(integer);
                num = integer + underOne;
            }
            return num;
        }

        //フォーマット4段階：ドットがない場合の処理を返すメソッド
        private string FirthChangeFormat(string num)
        {
            if (num.Contains("-"))
            {
                num = OnlyNumber(num);
                if (num == string.Empty)
                {
                    num = txtResult.Text;
                }
                decimal changeInterger = decimal.Parse(num);
                num = String.Format("{0:#,#}", changeInterger);
                num = ChangeNullToZero(num);
                num = "-" + num;
            }
            else if (!num.Contains("-"))
            {
                num = OnlyNumber(num);
                if (num == string.Empty)
                {
                    num = txtResult.Text;
                }
                decimal changeInterger = decimal.Parse(num);
                num = String.Format("{0:#,#}", changeInterger);
                num = ChangeNullToZero(num);
            }
            return num;
        }

        //nullであれば０に返すメソッド
        private string ChangeNullToZero(string nothing)
        {
            if (nothing == string.Empty)
            {
                return "0";
            }
            else
            {
                return nothing;
            }
        }
        //9番機能：10桁までしか表示できないよう制限する。
        private string CheckDigitMorethenTen(string number)
        {
            string num = txtResult.Text + number; //現在画面に表示されている文字列を入れる変数
            string onlyNumber = ""; //数字のみ入れる変数
            foreach (char c in num)
            {
                if (Char.IsNumber(c))
                {
                    onlyNumber += c;
                }
            }
            if(onlyNumber.Length > 10 && number != "00")
            {
                MessageBox.Show("10桁までしか入力できません");
                return "";
            }
            else if (onlyNumber.Length > 10 && number == "00")
            {
                if(onlyNumber.Length == 11)
                {
                    return "0";
                }
                else
                {
                    MessageBox.Show("10桁までしか入力できません");
                    return "";
                }
            }
            else
            {
                return number;
            }
        }

        //.が2個以上あるかチェックするメッソド
        private string CheckPointMoreThenTwo()
        {
            if (CheckDecimal())
            {
                return null;
            }
            else
            {
                return ".";
            }
        }

        //整数と小数点以下の数字を分離し、整数だけ返すメソッド
        private string SeperateInt(string num)
        {
            int index = num.IndexOf(".");
            return num.Substring(0, index);
        }

        //整数と小数点以下の数字を分離し、小数点以下だけ返すメソッド
        private string SeperateUnderOne(string num)
        {
            int index = num.IndexOf(".");
            return num.Substring(index, num.Length-index );
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string inputResult=string.Empty;
            checkZeroBtn = true;
            inputResult = AddNumberAndClearZero((sender as Button).Text);
            txtResult.Text = inputResult;
        }

        //演算子を入力されたときの処理
        private void btn_OperatorClick(object sender, EventArgs e)
        {
            string inputResult = string.Empty;
            isOperatingNow = true;
            lblOperator.Text = NotdisplayEqualOperator((sender as Button).Text); 
            inputResult = WhatOperatorNow((sender as Button).Text);
            txtResult.Text = FirstChangeFormat(inputResult);
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        //初期化のメソッド
        private void AllClear()
        {
            txtResult.Text = "0";
            isDecimal = false;
            checkZeroBtn = false;
            lblOperator.Text = string.Empty;
            isOperatingNow = false;
            isCalculateResult = false;
            symbolOfOperator = string.Empty;
            firstNumber = string.Empty;
            secondNumber = string.Empty;
            pnl1.Enabled = true;
            pnl2.Enabled = true;
            btn0.Enabled = true;
            lblError.Text = string.Empty;
            btnClear.Enabled = true;
        }

        /// <summary>
        /// bsボタンをクリックしたとき
        /// 現在表示されている表示内容で数字のみの桁数
        /// 表示テキストの長さが0であれば0を表示させる
        /// 削除している文字列がDotの場合はisDecimalをfalseに変える
        /// 最後の一桁を消したあと1桁より多いかつ小数点を含んでいる場合
        /// 数値の最後が.の場合
        /// 表示の最後がDotではあるが、0.である場合
        /// 数値の最後が.でないかつ0の場合
        /// 数値が小数点を含んでいて、.が数値の最後ではない場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            int currentDigit = OnlyNumber(txtResult.Text).Length;
            checkZeroBtn = true;
            string result = string.Empty;
            if (currentDigit == 1)
            {
                txtResult.Text = "0";
            }
            else if (currentDigit > 1)
            {
                if (CheckFinalCharIsDot() && !CheckZeroPoint(txtResult.Text))
                {
                    string overOne = SeperateInt(txtResult.Text);
                    string underOne = SeperateUnderOne(txtResult.Text);
                    underOne = underOne.Remove(underOne.Length - 1, 1);
                    overOne = overOne.Remove(overOne.Length-1, 1);
                    result = FirstChangeFormat(overOne + underOne);
                }
                else if (CheckFinalCharIsDot() && CheckZeroPoint(txtResult.Text))
                {
                    string removedNum = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
                    result = removedNum;
                }
                else if (!CheckFinalCharIsDot() && !CheckDecimal())
                {
                    string removedNum = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
                    result = FirstChangeFormat(removedNum);
                }
                else if (!CheckFinalCharIsDot() && CheckDecimal())
                {
                    string overOne = SeperateInt(txtResult.Text);
                    string underOne = SeperateUnderOne(txtResult.Text);
                    underOne = underOne.Remove(underOne.Length - 1, 1);
                    result = FirstChangeFormat(overOne + underOne);
                }
            }
            if (isOperatingNow)
            {
                secondNumber = result;
            }
            else
            {
                firstNumber = result;
            }

            txtResult.Text = result;
        }

        //画面のテキスト表示が0.かどうかを判断するメソッド
        private bool CheckZeroPoint(string num)
        {
            return num == "0.";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnEqual.Focus();
            string inputResult = string.Empty;
            switch (e.KeyChar.ToString())
            {
                case "1":
                    txtResult.Text = AddNumberAndClearZero("1");
                    break;
                case "2":
                    txtResult.Text = AddNumberAndClearZero("2");
                    break;
                case "3":
                    txtResult.Text = AddNumberAndClearZero("3");
                    break;
                case "4":
                    txtResult.Text = AddNumberAndClearZero("4");
                    break;
                case "5":
                    txtResult.Text = AddNumberAndClearZero("5");
                    break;
                case "6":
                    txtResult.Text = AddNumberAndClearZero("6");
                    break;
                case "7":
                    txtResult.Text = AddNumberAndClearZero("7");
                    break;
                case "8":
                    txtResult.Text = AddNumberAndClearZero("8");
                    break;
                case "9":
                    txtResult.Text = AddNumberAndClearZero("9");
                    break;
                case "0":
                    txtResult.Text = AddNumberAndClearZero("0");
                    break;
                case ".":
                    txtResult.Text = AddNumberAndClearZero(".");
                    break;
                case "+":
                    isOperatingNow = true;
                    lblOperator.Text = e.KeyChar.ToString();
                    inputResult = WhatOperatorNow(e.KeyChar.ToString());
                    txtResult.Text = FirstChangeFormat(inputResult);
                    break;
                case "-":
                    isOperatingNow = true;
                    lblOperator.Text = e.KeyChar.ToString();
                    inputResult = WhatOperatorNow(e.KeyChar.ToString());
                    txtResult.Text = FirstChangeFormat(inputResult);
                    break;
                case "*":
                    isOperatingNow = true;
                    lblOperator.Text = "×";
                    inputResult = WhatOperatorNow(lblOperator.Text);
                    txtResult.Text = FirstChangeFormat(inputResult);
                    break;
                case "/":
                    isOperatingNow = true;
                    lblOperator.Text = "÷";
                    inputResult = WhatOperatorNow(lblOperator.Text);
                    txtResult.Text = FirstChangeFormat(inputResult);
                    break;
            }

            //bsキーを押されたときの動作
            if (char.IsControl(e.KeyChar))
            {
                int currentDigit = OnlyNumber(txtResult.Text).Length;
                checkZeroBtn = true;
                string result = string.Empty;
                if (currentDigit == 1)
                {
                    txtResult.Text = "0";
                }
                else if (currentDigit > 1)
                {
                    if (CheckFinalCharIsDot() && !CheckZeroPoint(txtResult.Text))
                    {
                        string overOne = SeperateInt(txtResult.Text);
                        string underOne = SeperateUnderOne(txtResult.Text);
                        underOne = underOne.Remove(underOne.Length - 1, 1);
                        overOne = overOne.Remove(overOne.Length - 1, 1);
                        result = FirstChangeFormat(overOne + underOne);
                    }
                    else if (CheckFinalCharIsDot() && CheckZeroPoint(txtResult.Text))
                    {
                        string removedNum = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
                        result = removedNum;
                    }
                    else if (!CheckFinalCharIsDot() && !CheckDecimal())
                    {
                        string removedNum = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
                        result = FirstChangeFormat(removedNum);
                    }
                    else if (!CheckFinalCharIsDot() && CheckDecimal())
                    {
                        string overOne = SeperateInt(txtResult.Text);
                        string underOne = SeperateUnderOne(txtResult.Text);
                        underOne = underOne.Remove(underOne.Length - 1, 1);
                        result = FirstChangeFormat(overOne + underOne);
                    }
                }
                if (isOperatingNow)
                {
                    secondNumber = result;
                }
                else
                {
                    firstNumber = result;
                }

                txtResult.Text = result;
            }
            btnEqual.Focus();
        }

        //小数点以下での0処理
        private string removeZeroUnderOne(string num)
        {
            if (num.Contains("."))
            {
                while (num.EndsWith("0"))
                {
                    num = num.Remove(num.Length - 1);
                }
                if (num.EndsWith("."))
                {
                    num = num.Remove(num.Length - 1);
                }
            }
            return num;
        }

        //計算結果の桁数を数えてくれるメソッド
        private decimal CountDigit(string num)
        {
            decimal count = 0;
            string onlyNumber = OnlyNumber(num);
            count = onlyNumber.Length;
            return count;
        }


        /// <summary>
        /// もし計算結果が10桁を超える場合は11桁を切れ捨て、返しすメソッド
        /// //一旦結果の値が10桁を超えたら、前から10桁まで抜き取る
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string RemoveOverTenDigit(string num)
        {
            string underElevenNum = string.Empty;
            decimal totalDigit = 0;
            if (CountDigit(num) > 10)
            {
                //10桁超えたフラグが立つ
                isOverTenDigit = true;

                //計算結果が整数の桁数が10桁を超えたら、エラー処理する
                if (decimal.Parse(num) > 10000000000 || decimal.Parse(num) < -10000000000)
                {
                    lblError.Text = "E";
                    pnl1.Enabled = false;
                    pnl2.Enabled = false;
                    btn0.Enabled = false;
                }
                //計算結果の総桁数を求める
                totalDigit = CountDigit(num);
                //10桁を超えたときに.を入れるIndex値を求める
                totalDigit = totalDigit - 10;
                underElevenNum = OnlyNumber(num);
                underElevenNum = underElevenNum.Substring(0, 10);
                //10桁の計算結果に10桁を超えた分の桁数に.を反映する
                if (num.Contains("."))
                {
                    underElevenNum = underElevenNum.Insert(num.IndexOf("."), ".");
                }
                //もし既存数値に-がついていてたら-をつける
                if (num.Contains("-"))
                {
                    underElevenNum = "-" + underElevenNum;
                }
            }
            else
            {
                underElevenNum = num;
            }
            //まずは結果に.があるかないかをチェック
            if (!underElevenNum.Contains("."))
            {
                //もし、もとの結果値に10桁以内に小数点があれば、10桁で加工後、小数点元の位置に戻す
                if (IndexOfDot(num) > 0 && IndexOfDot(num) < 10)
                {
                    underElevenNum = underElevenNum.Insert(IndexOfDot(num), ".");
                }
            }
            //小数点をもとの位置に戻した数値をリターンする
            return underElevenNum;
        }

        //小数点がある場合、何桁目にあったかのインデックス表示
        private int IndexOfDot(string num)
        {
            int indexOfDot = num.IndexOf(".");
            return indexOfDot;
        }

        //現在の画面表示文字列の一番後ろに.であるかどうかを判断するメッソド
        private bool CheckFinalCharIsDot()
        {
            return txtResult.Text.EndsWith(".");
        }

        //表示されている数値が-かつ小数点が含んでいるかどうかを判断し、-がついていれば-を削除するメソッド
        private string ConvertMinusNumber(string num)
        {
            if (num.Contains("-"))
            {
                //もしすでに - があれば既存 - を消す
                num = num.Replace("-","");
            }
            else
            {
                num = "-" + num;
            }
            return num;
        }

        //画面の数値が小数点を含んでいるかつ一番後ろが0であるか判別するメソッド
        private bool CheckFinalCharIsZero()
        {
            if (CheckDecimal())
            {
                return txtResult.Text.Substring(txtResult.Text.Length - 1, 1) == "0";
            }
            else
            {
                return false;
            }
        }

        //6番機能:＋/－ボタン
        private void btnReverse_Click(object sender, EventArgs e)
        {
            string num = string.Empty;
            num = txtResult.Text;
            if (!checkZeroBtn && num == "0")
            {
                txtResult.Text = FirstChangeFormat(num);
            }
            else
            {
                num = ConvertMinusNumber(num);
                txtResult.Text = FirstChangeFormat(num);
            }
            if (secondNumber.Equals(string.Empty) && isOperatingNow)
            {
                return;
            }

            if (secondNumber.Equals(string.Empty))
            {
                firstNumber = num;
            }
            else
            {
                secondNumber = num;
            }
        }

        //もし、入力値が＝であれば何も返さないメソッド
        private string NotdisplayEqualOperator(string op)
        {
            if (op == "=")
            {
                isOperatingNow = false;
                isCalculateResult = true;
                return string.Empty;
            }
            else
            {
                return op;
            }
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (isDecimal)
            {
                return;
            }
            else
            {
                txtResult.Text = AddNumberAndClearZero(".");
            }
        }

        //16番：クリアボタン
        private void btnClear_Click(object sender, EventArgs e)
        {
            secondNumber = string.Empty;
            checkZeroBtn = false;
            pnl1.Enabled = true;
            pnl2.Enabled = true;
            btn0.Enabled = true;
            lblError.Text = string.Empty;
            if (isOverTenDigit)
            {
                firstNumber = txtResult.Text;
                isOverTenDigit = false;
            }
            else
            {
                txtResult.Text = "0";
                lblOperator.Text = string.Empty;
                if (isOperatingNow && !secondNumber.Equals(string.Empty))
                {
                    secondNumber = string.Empty;
                }
                else if(isOperatingNow && secondNumber.Equals(string.Empty))
                {
                    AllClear();
                }
            }
        }

        //17番：OFFボタン
        private void btnOff_Click(object sender, EventArgs e)
        {
            pnl1.Enabled = false;
            pnl2.Enabled = false;
            btn0.Enabled = false;
            btnClear.Enabled = false;
            txtResult.Text = string.Empty;
            firstNumber = string.Empty;
            secondNumber = string.Empty;
            symbolOfOperator = string.Empty;
        }
    }
}
