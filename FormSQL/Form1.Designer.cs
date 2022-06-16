namespace FormSQL
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
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbidade = new System.Windows.Forms.TextBox();
            this.tbcpf = new System.Windows.Forms.TextBox();
            this.tbend = new System.Windows.Forms.TextBox();
            this.tbbairro = new System.Windows.Forms.TextBox();
            this.tbcep = new System.Windows.Forms.TextBox();
            this.tbcidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btsalvar = new System.Windows.Forms.Button();
            this.Cidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(95, 12);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(166, 20);
            this.tbnome.TabIndex = 0;
            // 
            // tbidade
            // 
            this.tbidade.Location = new System.Drawing.Point(95, 49);
            this.tbidade.Name = "tbidade";
            this.tbidade.Size = new System.Drawing.Size(166, 20);
            this.tbidade.TabIndex = 1;
            // 
            // tbcpf
            // 
            this.tbcpf.Location = new System.Drawing.Point(95, 90);
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(166, 20);
            this.tbcpf.TabIndex = 2;
            // 
            // tbend
            // 
            this.tbend.Location = new System.Drawing.Point(95, 125);
            this.tbend.Name = "tbend";
            this.tbend.Size = new System.Drawing.Size(166, 20);
            this.tbend.TabIndex = 3;
            // 
            // tbbairro
            // 
            this.tbbairro.Location = new System.Drawing.Point(95, 160);
            this.tbbairro.Name = "tbbairro";
            this.tbbairro.Size = new System.Drawing.Size(166, 20);
            this.tbbairro.TabIndex = 4;
            // 
            // tbcep
            // 
            this.tbcep.Location = new System.Drawing.Point(95, 196);
            this.tbcep.Name = "tbcep";
            this.tbcep.Size = new System.Drawing.Size(166, 20);
            this.tbcep.TabIndex = 5;
            // 
            // tbcidade
            // 
            this.tbcidade.Location = new System.Drawing.Point(95, 235);
            this.tbcidade.Name = "tbcidade";
            this.tbcidade.Size = new System.Drawing.Size(166, 20);
            this.tbcidade.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CEP";
            // 
            // btsalvar
            // 
            this.btsalvar.Location = new System.Drawing.Point(157, 292);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(104, 30);
            this.btsalvar.TabIndex = 13;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(49, 238);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(40, 13);
            this.Cidade.TabIndex = 14;
            this.Cidade.Text = "Cidade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 334);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcidade);
            this.Controls.Add(this.tbcep);
            this.Controls.Add(this.tbbairro);
            this.Controls.Add(this.tbend);
            this.Controls.Add(this.tbcpf);
            this.Controls.Add(this.tbidade);
            this.Controls.Add(this.tbnome);
            this.Name = "Form1";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbidade;
        private System.Windows.Forms.TextBox tbcpf;
        private System.Windows.Forms.TextBox tbend;
        private System.Windows.Forms.TextBox tbbairro;
        private System.Windows.Forms.TextBox tbcep;
        private System.Windows.Forms.TextBox tbcidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Label Cidade;
    }
}

