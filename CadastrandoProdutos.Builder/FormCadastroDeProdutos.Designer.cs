namespace CadastrandoProdutos.Builder
{
    partial class FormCadastroDeProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOriginadoDoCadastro = new System.Windows.Forms.Button();
            this.btnImportacaoDeProdutos = new System.Windows.Forms.Button();
            this.btnNotaDeEntrada = new System.Windows.Forms.Button();
            this.txtDescricaoDoProdutoCriado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNotaDeEntrada);
            this.groupBox1.Controls.Add(this.btnImportacaoDeProdutos);
            this.groupBox1.Controls.Add(this.btnOriginadoDoCadastro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar produtos pela origem:";
            // 
            // btnOriginadoDoCadastro
            // 
            this.btnOriginadoDoCadastro.Location = new System.Drawing.Point(6, 19);
            this.btnOriginadoDoCadastro.Name = "btnOriginadoDoCadastro";
            this.btnOriginadoDoCadastro.Size = new System.Drawing.Size(209, 52);
            this.btnOriginadoDoCadastro.TabIndex = 0;
            this.btnOriginadoDoCadastro.Text = "Cadastro";
            this.btnOriginadoDoCadastro.UseVisualStyleBackColor = true;
            this.btnOriginadoDoCadastro.Click += new System.EventHandler(this.btnOriginadoDoCadastro_Click);
            // 
            // btnImportacaoDeProdutos
            // 
            this.btnImportacaoDeProdutos.Location = new System.Drawing.Point(6, 97);
            this.btnImportacaoDeProdutos.Name = "btnImportacaoDeProdutos";
            this.btnImportacaoDeProdutos.Size = new System.Drawing.Size(209, 52);
            this.btnImportacaoDeProdutos.TabIndex = 1;
            this.btnImportacaoDeProdutos.Text = "Importação de Produtos";
            this.btnImportacaoDeProdutos.UseVisualStyleBackColor = true;
            this.btnImportacaoDeProdutos.Click += new System.EventHandler(this.btnImportacaoDeProdutos_Click);
            // 
            // btnNotaDeEntrada
            // 
            this.btnNotaDeEntrada.Location = new System.Drawing.Point(6, 173);
            this.btnNotaDeEntrada.Name = "btnNotaDeEntrada";
            this.btnNotaDeEntrada.Size = new System.Drawing.Size(209, 52);
            this.btnNotaDeEntrada.TabIndex = 2;
            this.btnNotaDeEntrada.Text = "Nota de Entrada";
            this.btnNotaDeEntrada.UseVisualStyleBackColor = true;
            this.btnNotaDeEntrada.Click += new System.EventHandler(this.btnNotaDeEntrada_Click);
            // 
            // txtDescricaoDoProdutoCriado
            // 
            this.txtDescricaoDoProdutoCriado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDoProdutoCriado.Location = new System.Drawing.Point(254, 12);
            this.txtDescricaoDoProdutoCriado.Multiline = true;
            this.txtDescricaoDoProdutoCriado.Name = "txtDescricaoDoProdutoCriado";
            this.txtDescricaoDoProdutoCriado.ReadOnly = true;
            this.txtDescricaoDoProdutoCriado.Size = new System.Drawing.Size(234, 246);
            this.txtDescricaoDoProdutoCriado.TabIndex = 1;
            // 
            // FormCadastroDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 270);
            this.Controls.Add(this.txtDescricaoDoProdutoCriado);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Produtos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNotaDeEntrada;
        private System.Windows.Forms.Button btnImportacaoDeProdutos;
        private System.Windows.Forms.Button btnOriginadoDoCadastro;
        private System.Windows.Forms.TextBox txtDescricaoDoProdutoCriado;
    }
}

