namespace Calculator346
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMns = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnMemoryCancle = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btnMemorySubtract = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnGT = new System.Windows.Forms.Button();
            this.btnIncludingTax = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnExcludingTax = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnOff = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.PaleGreen;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(31, 34);
            this.txtResult.MaxLength = 14;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(457, 48);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.BackColor = System.Drawing.Color.PaleGreen;
            this.lblOperator.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOperator.Location = new System.Drawing.Point(471, 63);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(11, 15);
            this.lblOperator.TabIndex = 52;
            this.lblOperator.Text = " ";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.PaleGreen;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblError.Location = new System.Drawing.Point(140, 64);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(11, 15);
            this.lblError.TabIndex = 53;
            this.lblError.Text = " ";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReverse.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReverse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReverse.Location = new System.Drawing.Point(10, 125);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 30);
            this.btnReverse.TabIndex = 10;
            this.btnReverse.Text = "+/-";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMul.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMul.Location = new System.Drawing.Point(296, 122);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 30);
            this.btnMul.TabIndex = 11;
            this.btnMul.Text = "×";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btn_OperatorClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn9.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Location = new System.Drawing.Point(201, 122);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 30);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn8.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(108, 122);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 30);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn7.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(12, 122);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 30);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDiv.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiv.Location = new System.Drawing.Point(296, 77);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 30);
            this.btnDiv.TabIndex = 21;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btn_OperatorClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(29, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMns
            // 
            this.btnMns.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMns.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMns.Location = new System.Drawing.Point(296, 167);
            this.btnMns.Name = "btnMns";
            this.btnMns.Size = new System.Drawing.Size(75, 30);
            this.btnMns.TabIndex = 26;
            this.btnMns.Text = "-";
            this.btnMns.UseVisualStyleBackColor = false;
            this.btnMns.Click += new System.EventHandler(this.btn_OperatorClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(201, 167);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 30);
            this.btn6.TabIndex = 27;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(108, 167);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 30);
            this.btn5.TabIndex = 28;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(12, 167);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 30);
            this.btn4.TabIndex = 29;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAllClear
            // 
            this.btnAllClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAllClear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAllClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllClear.Location = new System.Drawing.Point(29, 306);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(75, 30);
            this.btnAllClear.TabIndex = 30;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlus.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.Location = new System.Drawing.Point(296, 208);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 30);
            this.btnPlus.TabIndex = 31;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btn_OperatorClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(201, 208);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 30);
            this.btn3.TabIndex = 32;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(108, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 30);
            this.btn2.TabIndex = 33;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(12, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 30);
            this.btn1.TabIndex = 34;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn0.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(29, 350);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 30);
            this.btn0.TabIndex = 35;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEqual.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEqual.Location = new System.Drawing.Point(201, 252);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 30);
            this.btnEqual.TabIndex = 37;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btn_OperatorClick);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDot.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDot.Location = new System.Drawing.Point(108, 252);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 30);
            this.btnDot.TabIndex = 38;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn00.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn00.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn00.Location = new System.Drawing.Point(12, 252);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(75, 30);
            this.btn00.TabIndex = 39;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMemoryCancle
            // 
            this.btnMemoryCancle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMemoryCancle.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMemoryCancle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMemoryCancle.Location = new System.Drawing.Point(10, 80);
            this.btnMemoryCancle.Name = "btnMemoryCancle";
            this.btnMemoryCancle.Size = new System.Drawing.Size(75, 30);
            this.btnMemoryCancle.TabIndex = 40;
            this.btnMemoryCancle.Text = "MC";
            this.btnMemoryCancle.UseVisualStyleBackColor = false;
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMemoryAdd.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMemoryAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMemoryAdd.Location = new System.Drawing.Point(201, 77);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(75, 30);
            this.btnMemoryAdd.TabIndex = 41;
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = false;
            // 
            // btnMemorySubtract
            // 
            this.btnMemorySubtract.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMemorySubtract.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMemorySubtract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMemorySubtract.Location = new System.Drawing.Point(108, 77);
            this.btnMemorySubtract.Name = "btnMemorySubtract";
            this.btnMemorySubtract.Size = new System.Drawing.Size(75, 30);
            this.btnMemorySubtract.TabIndex = 42;
            this.btnMemorySubtract.Text = "M-";
            this.btnMemorySubtract.UseVisualStyleBackColor = false;
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMemoryRecall.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMemoryRecall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMemoryRecall.Location = new System.Drawing.Point(12, 77);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(75, 30);
            this.btnMemoryRecall.TabIndex = 43;
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = false;
            // 
            // btnGT
            // 
            this.btnGT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGT.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGT.Location = new System.Drawing.Point(296, 30);
            this.btnGT.Name = "btnGT";
            this.btnGT.Size = new System.Drawing.Size(75, 30);
            this.btnGT.TabIndex = 44;
            this.btnGT.Text = "GT";
            this.btnGT.UseVisualStyleBackColor = false;
            // 
            // btnIncludingTax
            // 
            this.btnIncludingTax.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIncludingTax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnIncludingTax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncludingTax.Location = new System.Drawing.Point(10, 33);
            this.btnIncludingTax.Name = "btnIncludingTax";
            this.btnIncludingTax.Size = new System.Drawing.Size(75, 30);
            this.btnIncludingTax.TabIndex = 45;
            this.btnIncludingTax.Text = "税込";
            this.btnIncludingTax.UseVisualStyleBackColor = false;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBackSpace.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBackSpace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackSpace.Location = new System.Drawing.Point(201, 30);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(75, 30);
            this.btnBackSpace.TabIndex = 46;
            this.btnBackSpace.Text = "▶";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPercentage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPercentage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPercentage.Location = new System.Drawing.Point(108, 30);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(75, 30);
            this.btnPercentage.TabIndex = 47;
            this.btnPercentage.Text = "％";
            this.btnPercentage.UseVisualStyleBackColor = false;
            // 
            // btnExcludingTax
            // 
            this.btnExcludingTax.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExcludingTax.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcludingTax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcludingTax.Location = new System.Drawing.Point(12, 30);
            this.btnExcludingTax.Name = "btnExcludingTax";
            this.btnExcludingTax.Size = new System.Drawing.Size(75, 30);
            this.btnExcludingTax.TabIndex = 48;
            this.btnExcludingTax.Text = "税抜";
            this.btnExcludingTax.UseVisualStyleBackColor = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 315);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(21, 12);
            this.lbl3.TabIndex = 49;
            this.lbl3.Text = "ON";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(33, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(29, 12);
            this.lbl1.TabIndex = 50;
            this.lbl1.Text = "税率";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(119, 15);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 12);
            this.lbl2.TabIndex = 51;
            this.lbl2.Text = "税率設定";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btnOff);
            this.pnl1.Controls.Add(this.lbl2);
            this.pnl1.Controls.Add(this.btnExcludingTax);
            this.pnl1.Controls.Add(this.btnPercentage);
            this.pnl1.Controls.Add(this.btnBackSpace);
            this.pnl1.Controls.Add(this.btnGT);
            this.pnl1.Controls.Add(this.btnMemoryRecall);
            this.pnl1.Controls.Add(this.btnMemorySubtract);
            this.pnl1.Controls.Add(this.btnMemoryAdd);
            this.pnl1.Controls.Add(this.btn00);
            this.pnl1.Controls.Add(this.btnDot);
            this.pnl1.Controls.Add(this.btnEqual);
            this.pnl1.Controls.Add(this.btn1);
            this.pnl1.Controls.Add(this.btn2);
            this.pnl1.Controls.Add(this.btn3);
            this.pnl1.Controls.Add(this.btnPlus);
            this.pnl1.Controls.Add(this.btn4);
            this.pnl1.Controls.Add(this.btn5);
            this.pnl1.Controls.Add(this.btn6);
            this.pnl1.Controls.Add(this.btnMns);
            this.pnl1.Controls.Add(this.btnDiv);
            this.pnl1.Controls.Add(this.btn7);
            this.pnl1.Controls.Add(this.btn8);
            this.pnl1.Controls.Add(this.btn9);
            this.pnl1.Controls.Add(this.btnMul);
            this.pnl1.Location = new System.Drawing.Point(115, 98);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(388, 305);
            this.pnl1.TabIndex = 54;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.lbl1);
            this.pnl2.Controls.Add(this.btnIncludingTax);
            this.pnl2.Controls.Add(this.btnMemoryCancle);
            this.pnl2.Controls.Add(this.btnReverse);
            this.pnl2.Location = new System.Drawing.Point(19, 95);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(96, 170);
            this.pnl2.TabIndex = 55;
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOff.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOff.Location = new System.Drawing.Point(296, 252);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 30);
            this.btnOff.TabIndex = 52;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 426);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtResult);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(7, 88);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMns;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnMemoryCancle;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btnMemorySubtract;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnGT;
        private System.Windows.Forms.Button btnIncludingTax;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnExcludingTax;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnOff;
    }
}

