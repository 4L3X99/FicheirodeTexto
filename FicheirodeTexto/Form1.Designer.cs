﻿
namespace FicheirodeTexto
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtCouteudo = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(9, 28);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(128, 36);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Selecionar Ficheiro";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtCouteudo
            // 
            this.txtCouteudo.Location = new System.Drawing.Point(9, 69);
            this.txtCouteudo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCouteudo.Multiline = true;
            this.txtCouteudo.Name = "txtCouteudo";
            this.txtCouteudo.Size = new System.Drawing.Size(263, 247);
            this.txtCouteudo.TabIndex = 2;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(142, 28);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(129, 36);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(324, 28);
            this.btnContar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(129, 36);
            this.btnContar.TabIndex = 4;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(275, 69);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuant.Multiline = true;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(215, 247);
            this.txtQuant.TabIndex = 5;
            this.txtQuant.TextChanged += new System.EventHandler(this.txtQuant_TextChanged);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(156, 328);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(115, 33);
            this.btnsalvar.TabIndex = 6;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(360, 328);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 33);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 377);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtCouteudo);
            this.Controls.Add(this.btnAbrir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtCouteudo;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSair;
    }
}

