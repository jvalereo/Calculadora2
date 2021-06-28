namespace Caluculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.BtnSoma = new System.Windows.Forms.Button();
            this.BtnSubtrair = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnDivisão = new System.Windows.Forms.Button();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textMedia = new System.Windows.Forms.TextBox();
            this.BtnLimpa = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(207, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULADORA";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(57, 86);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(32, 18);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Olá";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(135, 86);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(22, 18);
            this.lblPeriodo.TabIndex = 2;
            this.lblPeriodo.Text = "- -";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(32, 137);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(126, 18);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Digite Numero 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(290, 138);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(126, 18);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Digite Numero 2:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.Color.Transparent;
            this.lblMedia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(202, 183);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(56, 18);
            this.lblMedia.TabIndex = 5;
            this.lblMedia.Text = "Média:";
            // 
            // BtnSoma
            // 
            this.BtnSoma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoma.Location = new System.Drawing.Point(81, 225);
            this.BtnSoma.Name = "BtnSoma";
            this.BtnSoma.Size = new System.Drawing.Size(90, 33);
            this.BtnSoma.TabIndex = 6;
            this.BtnSoma.Text = "Soma";
            this.BtnSoma.UseVisualStyleBackColor = true;
            this.BtnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // BtnSubtrair
            // 
            this.BtnSubtrair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtrair.Location = new System.Drawing.Point(188, 225);
            this.BtnSubtrair.Name = "BtnSubtrair";
            this.BtnSubtrair.Size = new System.Drawing.Size(90, 33);
            this.BtnSubtrair.TabIndex = 7;
            this.BtnSubtrair.Text = "Subtrair";
            this.BtnSubtrair.UseVisualStyleBackColor = true;
            this.BtnSubtrair.Click += new System.EventHandler(this.BtnSubtrair_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicar.Location = new System.Drawing.Point(294, 225);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(90, 33);
            this.BtnMultiplicar.TabIndex = 8;
            this.BtnMultiplicar.Text = "Multiplicar";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // BtnDivisão
            // 
            this.BtnDivisão.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivisão.Location = new System.Drawing.Point(401, 225);
            this.BtnDivisão.Name = "BtnDivisão";
            this.BtnDivisão.Size = new System.Drawing.Size(90, 33);
            this.BtnDivisão.TabIndex = 9;
            this.BtnDivisão.Text = "Divisão";
            this.BtnDivisão.UseVisualStyleBackColor = true;
            this.BtnDivisão.Click += new System.EventHandler(this.BtnDivisão_Click);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(164, 138);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(114, 20);
            this.textNum1.TabIndex = 10;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(422, 139);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(114, 20);
            this.textNum2.TabIndex = 11;
            // 
            // textMedia
            // 
            this.textMedia.Location = new System.Drawing.Point(264, 183);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(114, 20);
            this.textMedia.TabIndex = 12;
            // 
            // BtnLimpa
            // 
            this.BtnLimpa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpa.Location = new System.Drawing.Point(188, 269);
            this.BtnLimpa.Name = "BtnLimpa";
            this.BtnLimpa.Size = new System.Drawing.Size(90, 33);
            this.BtnLimpa.TabIndex = 13;
            this.BtnLimpa.Text = "Limpar";
            this.BtnLimpa.UseVisualStyleBackColor = true;
            this.BtnLimpa.Click += new System.EventHandler(this.BtnLimpa_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(294, 269);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(90, 33);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(581, 323);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpa);
            this.Controls.Add(this.textMedia);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.BtnDivisão);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnSubtrair);
            this.Controls.Add(this.BtnSoma);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button BtnSoma;
        private System.Windows.Forms.Button BtnSubtrair;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnDivisão;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textMedia;
        private System.Windows.Forms.Button BtnLimpa;
        private System.Windows.Forms.Button BtnSair;
    }
}

