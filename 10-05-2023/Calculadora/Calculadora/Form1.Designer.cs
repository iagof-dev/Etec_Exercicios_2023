namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_somar = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(88, 249);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(194, 52);
            this.btn_somar.TabIndex = 1;
            this.btn_somar.Text = "Somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(304, 249);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(194, 52);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(514, 249);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(194, 52);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(239, 80);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(301, 20);
            this.txt_n1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero 2:";
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(239, 119);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(301, 20);
            this.txt_n2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(230, 359);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(45, 51);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.txt_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Timer timer1;
    }
}

