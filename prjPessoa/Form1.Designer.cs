namespace prjPessoa
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereço = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.ValidarCPF = new System.Windows.Forms.Button();
            this.lbResposta = new System.Windows.Forms.Label();
            this.lbResposta2 = new System.Windows.Forms.Label();
            this.btnValidarCNPJ = new System.Windows.Forms.Button();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereçoEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE O CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE O ENDEREÇO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIGITE O NOME:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(38, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(38, 90);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(162, 20);
            this.txtEndereço.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(38, 144);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(162, 20);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ValidarCPF
            // 
            this.ValidarCPF.BackColor = System.Drawing.Color.White;
            this.ValidarCPF.ForeColor = System.Drawing.Color.Black;
            this.ValidarCPF.Location = new System.Drawing.Point(111, 204);
            this.ValidarCPF.Name = "ValidarCPF";
            this.ValidarCPF.Size = new System.Drawing.Size(141, 60);
            this.ValidarCPF.TabIndex = 6;
            this.ValidarCPF.Text = "VALIDAR CPF";
            this.ValidarCPF.UseVisualStyleBackColor = false;
            this.ValidarCPF.Click += new System.EventHandler(this.ValidarCPF_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.Lime;
            this.lbResposta.Location = new System.Drawing.Point(58, 291);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(261, 56);
            this.lbResposta.TabIndex = 7;
            this.lbResposta.Text = "RESPOSTA";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResposta2
            // 
            this.lbResposta2.BackColor = System.Drawing.Color.Lime;
            this.lbResposta2.Location = new System.Drawing.Point(410, 309);
            this.lbResposta2.Name = "lbResposta2";
            this.lbResposta2.Size = new System.Drawing.Size(261, 56);
            this.lbResposta2.TabIndex = 15;
            this.lbResposta2.Text = "RESPOSTA";
            this.lbResposta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValidarCNPJ
            // 
            this.btnValidarCNPJ.BackColor = System.Drawing.Color.White;
            this.btnValidarCNPJ.ForeColor = System.Drawing.Color.Black;
            this.btnValidarCNPJ.Location = new System.Drawing.Point(459, 229);
            this.btnValidarCNPJ.Name = "btnValidarCNPJ";
            this.btnValidarCNPJ.Size = new System.Drawing.Size(141, 60);
            this.btnValidarCNPJ.TabIndex = 14;
            this.btnValidarCNPJ.Text = "VALIDAR CNPJ";
            this.btnValidarCNPJ.UseVisualStyleBackColor = false;
            this.btnValidarCNPJ.Click += new System.EventHandler(this.btnValidarCNPJ_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(438, 187);
            this.txtCnpj.Mask = "99,999,999/9999-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(162, 20);
            this.txtCnpj.TabIndex = 13;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereçoEmpresa
            // 
            this.txtEndereçoEmpresa.Location = new System.Drawing.Point(438, 121);
            this.txtEndereçoEmpresa.Name = "txtEndereçoEmpresa";
            this.txtEndereçoEmpresa.Size = new System.Drawing.Size(162, 20);
            this.txtEndereçoEmpresa.TabIndex = 12;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(438, 71);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(162, 20);
            this.txtNomeEmpresa.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DIGITE O NOME DA EMPRESA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DIGITE O ENDEREÇO DA EMPRESA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "DIGITE O CNPJ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 383);
            this.Controls.Add(this.lbResposta2);
            this.Controls.Add(this.btnValidarCNPJ);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtEndereçoEmpresa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.ValidarCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "VALIDADOR DE DOCUMENTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtEndereço;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button ValidarCPF;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Label lbResposta2;
        private System.Windows.Forms.Button btnValidarCNPJ;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtEndereçoEmpresa;
        private System.Windows.Forms.MaskedTextBox txtNomeEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

