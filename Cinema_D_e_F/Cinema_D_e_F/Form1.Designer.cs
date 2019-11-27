namespace Cinema_D_e_F
{
    partial class Painel_de_vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel_de_vendas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcadeira = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnormal = new System.Windows.Forms.RadioButton();
            this.bttmeiaa = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btt_compra = new System.Windows.Forms.Button();
            this.btt_cadeira = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.bttreserva = new System.Windows.Forms.RadioButton();
            this.bttadeira_2 = new System.Windows.Forms.Button();
            this.bttcadeira_3 = new System.Windows.Forms.Button();
            this.btt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadeira";
            // 
            // txtcadeira
            // 
            this.txtcadeira.Enabled = false;
            this.txtcadeira.Location = new System.Drawing.Point(71, 13);
            this.txtcadeira.Name = "txtcadeira";
            this.txtcadeira.Size = new System.Drawing.Size(32, 20);
            this.txtcadeira.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Ingresso";
            // 
            // bttnormal
            // 
            this.bttnormal.AutoSize = true;
            this.bttnormal.Location = new System.Drawing.Point(17, 82);
            this.bttnormal.Name = "bttnormal";
            this.bttnormal.Size = new System.Drawing.Size(58, 17);
            this.bttnormal.TabIndex = 4;
            this.bttnormal.TabStop = true;
            this.bttnormal.Text = "Normal";
            this.bttnormal.UseVisualStyleBackColor = true;
            // 
            // bttmeiaa
            // 
            this.bttmeiaa.AutoSize = true;
            this.bttmeiaa.Location = new System.Drawing.Point(17, 105);
            this.bttmeiaa.Name = "bttmeiaa";
            this.bttmeiaa.Size = new System.Drawing.Size(88, 17);
            this.bttmeiaa.TabIndex = 5;
            this.bttmeiaa.TabStop = true;
            this.bttmeiaa.Text = "Meia-Entrada";
            this.bttmeiaa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Ingresso";
            // 
            // btt_compra
            // 
            this.btt_compra.Location = new System.Drawing.Point(130, 216);
            this.btt_compra.Name = "btt_compra";
            this.btt_compra.Size = new System.Drawing.Size(142, 23);
            this.btt_compra.TabIndex = 9;
            this.btt_compra.Text = "Concluir Compra";
            this.btt_compra.UseVisualStyleBackColor = true;
            this.btt_compra.Click += new System.EventHandler(this.btt_compra_Click);
            // 
            // btt_cadeira
            // 
            this.btt_cadeira.Location = new System.Drawing.Point(109, 13);
            this.btt_cadeira.Name = "btt_cadeira";
            this.btt_cadeira.Size = new System.Drawing.Size(53, 21);
            this.btt_cadeira.TabIndex = 11;
            this.btt_cadeira.Text = "Sala 1";
            this.btt_cadeira.UseVisualStyleBackColor = true;
            this.btt_cadeira.Click += new System.EventHandler(this.btt_cadeira_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.AutoCompleteCustomSource.AddRange(new string[] {
            ",00"});
            this.txtresultado.Location = new System.Drawing.Point(109, 170);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(53, 20);
            this.txtresultado.TabIndex = 12;
            // 
            // bttreserva
            // 
            this.bttreserva.AutoSize = true;
            this.bttreserva.Location = new System.Drawing.Point(17, 129);
            this.bttreserva.Name = "bttreserva";
            this.bttreserva.Size = new System.Drawing.Size(65, 17);
            this.bttreserva.TabIndex = 13;
            this.bttreserva.TabStop = true;
            this.bttreserva.Text = "Reserva";
            this.bttreserva.UseVisualStyleBackColor = true;
            // 
            // bttadeira_2
            // 
            this.bttadeira_2.Location = new System.Drawing.Point(109, 40);
            this.bttadeira_2.Name = "bttadeira_2";
            this.bttadeira_2.Size = new System.Drawing.Size(53, 21);
            this.bttadeira_2.TabIndex = 14;
            this.bttadeira_2.Text = "Sala 2";
            this.bttadeira_2.UseVisualStyleBackColor = true;
            this.bttadeira_2.Click += new System.EventHandler(this.bttadeira_2_Click);
            // 
            // bttcadeira_3
            // 
            this.bttcadeira_3.Location = new System.Drawing.Point(109, 67);
            this.bttcadeira_3.Name = "bttcadeira_3";
            this.bttcadeira_3.Size = new System.Drawing.Size(53, 21);
            this.bttcadeira_3.TabIndex = 15;
            this.bttcadeira_3.Text = "Sala 3";
            this.bttcadeira_3.UseVisualStyleBackColor = true;
            this.bttcadeira_3.Click += new System.EventHandler(this.bttcadeira_3_Click);
            // 
            // btt_cancel
            // 
            this.btt_cancel.Location = new System.Drawing.Point(28, 216);
            this.btt_cancel.Name = "btt_cancel";
            this.btt_cancel.Size = new System.Drawing.Size(75, 23);
            this.btt_cancel.TabIndex = 16;
            this.btt_cancel.Text = "Cancelar";
            this.btt_cancel.UseVisualStyleBackColor = true;
            this.btt_cancel.Click += new System.EventHandler(this.btt_cancel_Click);
            // 
            // Painel_de_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btt_cancel);
            this.Controls.Add(this.bttcadeira_3);
            this.Controls.Add(this.bttadeira_2);
            this.Controls.Add(this.bttreserva);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btt_cadeira);
            this.Controls.Add(this.btt_compra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttmeiaa);
            this.Controls.Add(this.bttnormal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcadeira);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Painel_de_vendas";
            this.Text = "Painel de Vendas";
            this.Load += new System.EventHandler(this.Painel_de_vendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcadeira;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton bttnormal;
        private System.Windows.Forms.RadioButton bttmeiaa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btt_compra;
        private System.Windows.Forms.Button btt_cadeira;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.RadioButton bttreserva;
        private System.Windows.Forms.Button bttadeira_2;
        private System.Windows.Forms.Button bttcadeira_3;
        private System.Windows.Forms.Button btt_cancel;
    }
}

