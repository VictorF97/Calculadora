namespace Calculadora
{
    partial class Calculadora
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
            textResultado = new TextBox();
            buttonAC = new Button();
            buttonSete = new Button();
            buttonOito = new Button();
            buttonNove = new Button();
            buttonDivisao = new Button();
            buttonQuatro = new Button();
            buttonCinco = new Button();
            buttonSeis = new Button();
            buttonMultiplicacao = new Button();
            buttonUm = new Button();
            buttonDois = new Button();
            buttonTres = new Button();
            buttonSubtracao = new Button();
            buttonVirgula = new Button();
            buttonZero = new Button();
            buttonIgual = new Button();
            buttonAdicao = new Button();
            labelOperacao = new Label();
            SuspendLayout();
            // 
            // textResultado
            // 
            textResultado.BackColor = Color.White;
            textResultado.ForeColor = Color.Black;
            textResultado.Location = new Point(6, 12);
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(202, 23);
            textResultado.TabIndex = 0;
            textResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonAC
            // 
            buttonAC.Cursor = Cursors.Hand;
            buttonAC.Location = new Point(161, 59);
            buttonAC.Name = "buttonAC";
            buttonAC.Size = new Size(46, 43);
            buttonAC.TabIndex = 1;
            buttonAC.Text = "AC";
            buttonAC.UseVisualStyleBackColor = true;
            buttonAC.Click += buttonAC_Click;
            // 
            // buttonSete
            // 
            buttonSete.Cursor = Cursors.Hand;
            buttonSete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSete.Location = new Point(5, 108);
            buttonSete.Name = "buttonSete";
            buttonSete.Size = new Size(46, 43);
            buttonSete.TabIndex = 2;
            buttonSete.Text = "7";
            buttonSete.UseVisualStyleBackColor = true;
            buttonSete.Click += buttonSete_Click;
            // 
            // buttonOito
            // 
            buttonOito.Cursor = Cursors.Hand;
            buttonOito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOito.Location = new Point(57, 108);
            buttonOito.Name = "buttonOito";
            buttonOito.Size = new Size(46, 43);
            buttonOito.TabIndex = 3;
            buttonOito.Text = "8";
            buttonOito.UseVisualStyleBackColor = true;
            buttonOito.Click += buttonOito_Click;
            // 
            // buttonNove
            // 
            buttonNove.Cursor = Cursors.Hand;
            buttonNove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNove.Location = new Point(109, 108);
            buttonNove.Name = "buttonNove";
            buttonNove.Size = new Size(46, 43);
            buttonNove.TabIndex = 4;
            buttonNove.Text = "9";
            buttonNove.UseVisualStyleBackColor = true;
            buttonNove.Click += buttonNove_Click;
            // 
            // buttonDivisao
            // 
            buttonDivisao.BackColor = Color.White;
            buttonDivisao.Cursor = Cursors.Hand;
            buttonDivisao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivisao.Location = new Point(161, 108);
            buttonDivisao.Name = "buttonDivisao";
            buttonDivisao.Size = new Size(46, 43);
            buttonDivisao.TabIndex = 5;
            buttonDivisao.Text = "/";
            buttonDivisao.UseVisualStyleBackColor = false;
            buttonDivisao.Click += buttonDivisao_Click;
            // 
            // buttonQuatro
            // 
            buttonQuatro.Cursor = Cursors.Hand;
            buttonQuatro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuatro.Location = new Point(5, 157);
            buttonQuatro.Name = "buttonQuatro";
            buttonQuatro.Size = new Size(46, 43);
            buttonQuatro.TabIndex = 6;
            buttonQuatro.Text = "4";
            buttonQuatro.UseVisualStyleBackColor = true;
            buttonQuatro.Click += buttonQuatro_Click;
            // 
            // buttonCinco
            // 
            buttonCinco.Cursor = Cursors.Hand;
            buttonCinco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCinco.Location = new Point(57, 157);
            buttonCinco.Name = "buttonCinco";
            buttonCinco.Size = new Size(46, 43);
            buttonCinco.TabIndex = 7;
            buttonCinco.Text = "5";
            buttonCinco.UseVisualStyleBackColor = true;
            buttonCinco.Click += buttonCinco_Click;
            // 
            // buttonSeis
            // 
            buttonSeis.Cursor = Cursors.Hand;
            buttonSeis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeis.Location = new Point(109, 157);
            buttonSeis.Name = "buttonSeis";
            buttonSeis.Size = new Size(46, 43);
            buttonSeis.TabIndex = 8;
            buttonSeis.Text = "6";
            buttonSeis.UseVisualStyleBackColor = true;
            buttonSeis.Click += buttonSeis_Click;
            // 
            // buttonMultiplicacao
            // 
            buttonMultiplicacao.Cursor = Cursors.Hand;
            buttonMultiplicacao.Location = new Point(162, 157);
            buttonMultiplicacao.Name = "buttonMultiplicacao";
            buttonMultiplicacao.Size = new Size(46, 43);
            buttonMultiplicacao.TabIndex = 9;
            buttonMultiplicacao.Text = "X";
            buttonMultiplicacao.UseVisualStyleBackColor = true;
            buttonMultiplicacao.Click += buttonMultiplicacao_Click;
            // 
            // buttonUm
            // 
            buttonUm.Cursor = Cursors.Hand;
            buttonUm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUm.Location = new Point(5, 206);
            buttonUm.Name = "buttonUm";
            buttonUm.Size = new Size(46, 43);
            buttonUm.TabIndex = 10;
            buttonUm.Text = "1";
            buttonUm.UseVisualStyleBackColor = true;
            buttonUm.Click += buttonUm_Click;
            // 
            // buttonDois
            // 
            buttonDois.Cursor = Cursors.Hand;
            buttonDois.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDois.Location = new Point(57, 206);
            buttonDois.Name = "buttonDois";
            buttonDois.Size = new Size(46, 43);
            buttonDois.TabIndex = 11;
            buttonDois.Text = "2";
            buttonDois.UseVisualStyleBackColor = true;
            buttonDois.Click += buttonDois_Click;
            // 
            // buttonTres
            // 
            buttonTres.Cursor = Cursors.Hand;
            buttonTres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTres.Location = new Point(109, 206);
            buttonTres.Name = "buttonTres";
            buttonTres.Size = new Size(46, 43);
            buttonTres.TabIndex = 12;
            buttonTres.Text = "3";
            buttonTres.UseVisualStyleBackColor = true;
            buttonTres.Click += buttonTres_Click;
            // 
            // buttonSubtracao
            // 
            buttonSubtracao.Cursor = Cursors.Hand;
            buttonSubtracao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubtracao.Location = new Point(161, 206);
            buttonSubtracao.Name = "buttonSubtracao";
            buttonSubtracao.Size = new Size(46, 43);
            buttonSubtracao.TabIndex = 13;
            buttonSubtracao.Text = "-";
            buttonSubtracao.UseVisualStyleBackColor = true;
            buttonSubtracao.Click += buttonSubtracao_Click;
            // 
            // buttonVirgula
            // 
            buttonVirgula.Cursor = Cursors.Hand;
            buttonVirgula.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVirgula.Location = new Point(5, 255);
            buttonVirgula.Name = "buttonVirgula";
            buttonVirgula.Size = new Size(46, 43);
            buttonVirgula.TabIndex = 14;
            buttonVirgula.Text = ",";
            buttonVirgula.UseVisualStyleBackColor = true;
            buttonVirgula.Click += buttonVirgula_Click;
            // 
            // buttonZero
            // 
            buttonZero.Cursor = Cursors.Hand;
            buttonZero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZero.Location = new Point(57, 255);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(46, 43);
            buttonZero.TabIndex = 15;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Cursor = Cursors.Hand;
            buttonIgual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIgual.Location = new Point(109, 255);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(46, 43);
            buttonIgual.TabIndex = 16;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonAdicao
            // 
            buttonAdicao.BackColor = Color.Transparent;
            buttonAdicao.Cursor = Cursors.Hand;
            buttonAdicao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdicao.Location = new Point(161, 255);
            buttonAdicao.Name = "buttonAdicao";
            buttonAdicao.Size = new Size(46, 43);
            buttonAdicao.TabIndex = 17;
            buttonAdicao.Text = "+";
            buttonAdicao.UseVisualStyleBackColor = false;
            buttonAdicao.Click += buttonAdicao_Click;
            // 
            // labelOperacao
            // 
            labelOperacao.AutoSize = true;
            labelOperacao.BackColor = Color.White;
            labelOperacao.ForeColor = Color.Black;
            labelOperacao.Location = new Point(14, 15);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(0, 15);
            labelOperacao.TabIndex = 18;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(213, 306);
            Controls.Add(labelOperacao);
            Controls.Add(buttonAdicao);
            Controls.Add(buttonIgual);
            Controls.Add(buttonZero);
            Controls.Add(buttonVirgula);
            Controls.Add(buttonSubtracao);
            Controls.Add(buttonTres);
            Controls.Add(buttonDois);
            Controls.Add(buttonUm);
            Controls.Add(buttonMultiplicacao);
            Controls.Add(buttonSeis);
            Controls.Add(buttonCinco);
            Controls.Add(buttonQuatro);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonNove);
            Controls.Add(buttonOito);
            Controls.Add(buttonSete);
            Controls.Add(buttonAC);
            Controls.Add(textResultado);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textResultado;
        private Button buttonAC;
        private Button buttonSete;
        private Button buttonOito;
        private Button buttonNove;
        private Button buttonDivisao;
        private Button buttonQuatro;
        private Button buttonCinco;
        private Button buttonSeis;
        private Button buttonMultiplicacao;
        private Button buttonUm;
        private Button buttonDois;
        private Button buttonTres;
        private Button buttonSubtracao;
        private Button buttonVirgula;
        private Button buttonZero;
        private Button buttonIgual;
        private Button buttonAdicao;
        private Label labelOperacao;
    }
}