namespace _221059
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstbox_pedidos = new System.Windows.Forms.ListBox();
            this.btn_InserirPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_p_pedido = new System.Windows.Forms.TextBox();
            this.txt_p_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_p_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalpedidos = new System.Windows.Forms.Label();
            this.txt_d_valor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_d_despesa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_InserirDespesa = new System.Windows.Forms.Button();
            this.lstbox_despesa = new System.Windows.Forms.ListBox();
            this.lbl_totaldespesa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_totalpedidos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_p_valor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_p_cliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_p_pedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_InserirPedido);
            this.groupBox1.Controls.Add(this.lstbox_pedidos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_totaldespesa);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lstbox_despesa);
            this.groupBox2.Controls.Add(this.btn_InserirDespesa);
            this.groupBox2.Controls.Add(this.txt_d_valor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_d_despesa);
            this.groupBox2.Location = new System.Drawing.Point(429, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Despesas";
            // 
            // lstbox_pedidos
            // 
            this.lstbox_pedidos.FormattingEnabled = true;
            this.lstbox_pedidos.Location = new System.Drawing.Point(30, 150);
            this.lstbox_pedidos.Name = "lstbox_pedidos";
            this.lstbox_pedidos.Size = new System.Drawing.Size(309, 160);
            this.lstbox_pedidos.TabIndex = 0;
            // 
            // btn_InserirPedido
            // 
            this.btn_InserirPedido.Location = new System.Drawing.Point(122, 96);
            this.btn_InserirPedido.Name = "btn_InserirPedido";
            this.btn_InserirPedido.Size = new System.Drawing.Size(110, 48);
            this.btn_InserirPedido.TabIndex = 1;
            this.btn_InserirPedido.Text = "Inserir Pedido";
            this.btn_InserirPedido.UseVisualStyleBackColor = true;
            this.btn_InserirPedido.Click += new System.EventHandler(this.btn_InserirPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedido:";
            // 
            // txt_p_pedido
            // 
            this.txt_p_pedido.Location = new System.Drawing.Point(87, 17);
            this.txt_p_pedido.Name = "txt_p_pedido";
            this.txt_p_pedido.Size = new System.Drawing.Size(145, 20);
            this.txt_p_pedido.TabIndex = 3;
            // 
            // txt_p_cliente
            // 
            this.txt_p_cliente.Location = new System.Drawing.Point(87, 43);
            this.txt_p_cliente.Name = "txt_p_cliente";
            this.txt_p_cliente.Size = new System.Drawing.Size(227, 20);
            this.txt_p_cliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // txt_p_valor
            // 
            this.txt_p_valor.Location = new System.Drawing.Point(87, 69);
            this.txt_p_valor.Name = "txt_p_valor";
            this.txt_p_valor.Size = new System.Drawing.Size(145, 20);
            this.txt_p_valor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(26, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total de Pedidos:";
            // 
            // lbl_totalpedidos
            // 
            this.lbl_totalpedidos.AutoSize = true;
            this.lbl_totalpedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalpedidos.ForeColor = System.Drawing.Color.Blue;
            this.lbl_totalpedidos.Location = new System.Drawing.Point(218, 334);
            this.lbl_totalpedidos.Name = "lbl_totalpedidos";
            this.lbl_totalpedidos.Size = new System.Drawing.Size(87, 25);
            this.lbl_totalpedidos.TabIndex = 9;
            this.lbl_totalpedidos.Text = "R$0,00";
            this.lbl_totalpedidos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_d_valor
            // 
            this.txt_d_valor.Location = new System.Drawing.Point(84, 65);
            this.txt_d_valor.Name = "txt_d_valor";
            this.txt_d_valor.Size = new System.Drawing.Size(227, 20);
            this.txt_d_valor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor:";
            // 
            // txt_d_despesa
            // 
            this.txt_d_despesa.Location = new System.Drawing.Point(84, 39);
            this.txt_d_despesa.Name = "txt_d_despesa";
            this.txt_d_despesa.Size = new System.Drawing.Size(145, 20);
            this.txt_d_despesa.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Despesa:";
            // 
            // btn_InserirDespesa
            // 
            this.btn_InserirDespesa.Location = new System.Drawing.Point(113, 96);
            this.btn_InserirDespesa.Name = "btn_InserirDespesa";
            this.btn_InserirDespesa.Size = new System.Drawing.Size(110, 48);
            this.btn_InserirDespesa.TabIndex = 10;
            this.btn_InserirDespesa.Text = "Inserir Despesa";
            this.btn_InserirDespesa.UseVisualStyleBackColor = true;
            this.btn_InserirDespesa.Click += new System.EventHandler(this.btn_InserirDespesa_Click);
            // 
            // lstbox_despesa
            // 
            this.lstbox_despesa.FormattingEnabled = true;
            this.lstbox_despesa.Location = new System.Drawing.Point(20, 150);
            this.lstbox_despesa.Name = "lstbox_despesa";
            this.lstbox_despesa.Size = new System.Drawing.Size(309, 160);
            this.lstbox_despesa.TabIndex = 10;
            // 
            // lbl_totaldespesa
            // 
            this.lbl_totaldespesa.AutoSize = true;
            this.lbl_totaldespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totaldespesa.ForeColor = System.Drawing.Color.Red;
            this.lbl_totaldespesa.Location = new System.Drawing.Point(241, 331);
            this.lbl_totaldespesa.Name = "lbl_totaldespesa";
            this.lbl_totaldespesa.Size = new System.Drawing.Size(87, 25);
            this.lbl_totaldespesa.TabIndex = 11;
            this.lbl_totaldespesa.Text = "R$0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(16, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total de Despesas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.lbl_saldo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saldo da Empresa";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_saldo.Location = new System.Drawing.Point(227, 52);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(87, 25);
            this.lbl_saldo.TabIndex = 11;
            this.lbl_saldo.Text = "R$0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Saldo:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 48);
            this.button3.TabIndex = 10;
            this.button3.Text = "Novo lançamento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(646, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 48);
            this.button4.TabIndex = 12;
            this.button4.Text = "Finalizar o Sistema";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(673, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Iago Fragnan - RM: 221059";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica do Totó";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_InserirPedido;
        private System.Windows.Forms.ListBox lstbox_pedidos;
        private System.Windows.Forms.TextBox txt_p_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_p_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_p_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_totalpedidos;
        private System.Windows.Forms.Button btn_InserirDespesa;
        private System.Windows.Forms.TextBox txt_d_valor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_d_despesa;
        private System.Windows.Forms.Label lbl_totaldespesa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstbox_despesa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
    }
}

