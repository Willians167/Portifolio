namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnZero = new Button();
            btnvirgula = new Button();
            btnResultado = new Button();
            btnLimpar = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnAdicacao = new Button();
            btnSubtracao = new Button();
            textDisplay = new TextBox();
            labelOperação = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 331);
            button1.Name = "button1";
            button1.Size = new Size(77, 77);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 331);
            button2.Name = "button2";
            button2.Size = new Size(77, 77);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(190, 331);
            button3.Name = "button3";
            button3.Size = new Size(77, 77);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 248);
            button4.Name = "button4";
            button4.Size = new Size(77, 77);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(107, 248);
            button5.Name = "button5";
            button5.Size = new Size(77, 77);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(190, 248);
            button6.Name = "button6";
            button6.Size = new Size(77, 77);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(24, 165);
            button7.Name = "button7";
            button7.Size = new Size(77, 77);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(107, 165);
            button8.Name = "button8";
            button8.Size = new Size(77, 77);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(190, 165);
            button9.Name = "button9";
            button9.Size = new Size(77, 77);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(24, 411);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(77, 77);
            btnZero.TabIndex = 9;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnvirgula
            // 
            btnvirgula.Location = new Point(107, 411);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(77, 77);
            btnvirgula.TabIndex = 10;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = true;
            btnvirgula.Click += btnvirgula_Click;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(190, 411);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(77, 77);
            btnResultado.TabIndex = 12;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(270, 82);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(77, 77);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(270, 165);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(77, 77);
            btnDivisao.TabIndex = 14;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(270, 248);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(77, 77);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnAdicacao
            // 
            btnAdicacao.Location = new Point(270, 411);
            btnAdicacao.Name = "btnAdicacao";
            btnAdicacao.Size = new Size(77, 77);
            btnAdicacao.TabIndex = 16;
            btnAdicacao.Text = "+";
            btnAdicacao.UseVisualStyleBackColor = true;
            btnAdicacao.Click += btnAdicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(270, 331);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(77, 77);
            btnSubtracao.TabIndex = 17;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // textDisplay
            // 
            textDisplay.Location = new Point(24, 20);
            textDisplay.Name = "textDisplay";
            textDisplay.ReadOnly = true;
            textDisplay.Size = new Size(332, 27);
            textDisplay.TabIndex = 18;
            textDisplay.TextAlign = HorizontalAlignment.Right;
            textDisplay.TextChanged += textDisplay_TextChanged;
            // 
            // labelOperação
            // 
            labelOperação.AutoSize = true;
            labelOperação.Location = new Point(15, 49);
            labelOperação.Name = "labelOperação";
            labelOperação.Size = new Size(0, 20);
            labelOperação.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 504);
            Controls.Add(labelOperação);
            Controls.Add(textDisplay);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicacao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnLimpar);
            Controls.Add(btnResultado);
            Controls.Add(btnvirgula);
            Controls.Add(btnZero);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnZero;
        private Button btnvirgula;
        private Button btnResultado;
        private Button btnLimpar;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnAdicacao;
        private Button btnSubtracao;
        private TextBox textDisplay;
        private Label labelOperação;
    }
}
