namespace Cinema_D_e_F
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.btt_ent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Usuario";
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(108, 9);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(100, 20);
            this.loginTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(108, 31);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.PasswordChar = '*';
            this.senhaTxt.Size = new System.Drawing.Size(100, 20);
            this.senhaTxt.TabIndex = 3;
            // 
            // btt_ent
            // 
            this.btt_ent.Location = new System.Drawing.Point(214, 7);
            this.btt_ent.Name = "btt_ent";
            this.btt_ent.Size = new System.Drawing.Size(71, 23);
            this.btt_ent.TabIndex = 4;
            this.btt_ent.Text = "ENTRAR";
            this.btt_ent.UseVisualStyleBackColor = true;
            this.btt_ent.Click += new System.EventHandler(this.btt_ent_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 60);
            this.Controls.Add(this.btt_ent);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Button btt_ent;
    }
}