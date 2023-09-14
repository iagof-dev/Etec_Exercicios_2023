namespace TecnoMarket
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_valorunit = new System.Windows.Forms.TextBox();
            this.txt_qntitemselected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(536, 37);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(99, 74);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(641, 37);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(99, 74);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(641, 367);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(99, 34);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(641, 407);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 34);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar Venda";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(641, 447);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(99, 34);
            this.btn_gravar.TabIndex = 4;
            this.btn_gravar.Text = "Gravar Venda";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(641, 487);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(99, 34);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.AllowUserToDeleteRows = false;
            this.dgv_Lista.AllowUserToOrderColumns = true;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descrição,
            this.Quant,
            this.Unit});
            this.dgv_Lista.Location = new System.Drawing.Point(37, 117);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.ReadOnly = true;
            this.dgv_Lista.Size = new System.Drawing.Size(703, 244);
            this.dgv_Lista.TabIndex = 6;
            this.dgv_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_CellClick);
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // Quant
            // 
            this.Quant.HeaderText = "Quant";
            this.Quant.Name = "Quant";
            this.Quant.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "V. Unitário";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Red;
            this.txt_id.Location = new System.Drawing.Point(212, 8);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(68, 24);
            this.txt_id.TabIndex = 7;
            this.txt_id.Text = "1";
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(212, 38);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(318, 20);
            this.txt_desc.TabIndex = 8;
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(212, 65);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(90, 20);
            this.txt_quant.TabIndex = 9;
            // 
            // txt_valorunit
            // 
            this.txt_valorunit.Location = new System.Drawing.Point(212, 91);
            this.txt_valorunit.Name = "txt_valorunit";
            this.txt_valorunit.Size = new System.Drawing.Size(122, 20);
            this.txt_valorunit.TabIndex = 10;
            // 
            // txt_qntitemselected
            // 
            this.txt_qntitemselected.Location = new System.Drawing.Point(547, 375);
            this.txt_qntitemselected.Name = "txt_qntitemselected";
            this.txt_qntitemselected.Size = new System.Drawing.Size(70, 20);
            this.txt_qntitemselected.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor Unitário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(305, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantidade de Item Selecionado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.Blue;
            this.txt_total.Location = new System.Drawing.Point(340, 479);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(74, 24);
            this.txt_total.TabIndex = 18;
            this.txt_total.Text = "R$0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_qntitemselected);
            this.Controls.Add(this.txt_valorunit);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dgv_Lista);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Name = "Form1";
            this.Text = "TecnoMarket";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_valorunit;
        private System.Windows.Forms.TextBox txt_qntitemselected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_total;
    }
}

