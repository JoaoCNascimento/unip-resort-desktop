
using GestaoUnipResort;

namespace GestaoUnipResort.Forms.Quartos
{
    partial class FormAdicionarQuarto
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
            this.components = new System.ComponentModel.Container();
            this.textBoxQuarto = new System.Windows.Forms.TextBox();
            this.textBoxAndar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxQuarto = new System.Windows.Forms.PictureBox();
            this.btnSelecionarImagem = new FontAwesome.Sharp.IconButton();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.btnLimpar = new FontAwesome.Sharp.IconButton();
            this.tipBtnSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.tipBtnLimpar = new System.Windows.Forms.ToolTip(this.components);
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQuarto
            // 
            this.textBoxQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxQuarto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuarto.Location = new System.Drawing.Point(558, 288);
            this.textBoxQuarto.Name = "textBoxQuarto";
            this.textBoxQuarto.Size = new System.Drawing.Size(79, 25);
            this.textBoxQuarto.TabIndex = 24;
            // 
            // textBoxAndar
            // 
            this.textBoxAndar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAndar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAndar.Location = new System.Drawing.Point(450, 288);
            this.textBoxAndar.Name = "textBoxAndar";
            this.textBoxAndar.Size = new System.Drawing.Size(62, 25);
            this.textBoxAndar.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(543, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quarto";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(438, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Andar";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(670, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxValor.Enabled = false;
            this.textBoxValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(684, 288);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(62, 25);
            this.textBoxValor.TabIndex = 19;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(450, 132);
            this.textBoxDescricao.MaxLength = 250;
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(296, 116);
            this.textBoxDescricao.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(438, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(438, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categoria";
            // 
            // pboxQuarto
            // 
            this.pboxQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxQuarto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxQuarto.ErrorImage = null;
            this.pboxQuarto.InitialImage = null;
            this.pboxQuarto.Location = new System.Drawing.Point(12, 41);
            this.pboxQuarto.Name = "pboxQuarto";
            this.pboxQuarto.Size = new System.Drawing.Size(400, 251);
            this.pboxQuarto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxQuarto.TabIndex = 13;
            this.pboxQuarto.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelecionarImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSelecionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarImagem.FlatAppearance.BorderSize = 0;
            this.btnSelecionarImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSelecionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarImagem.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarImagem.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnSelecionarImagem.IconColor = System.Drawing.Color.White;
            this.btnSelecionarImagem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelecionarImagem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(103, 298);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(231, 48);
            this.btnSelecionarImagem.TabIndex = 25;
            this.btnSelecionarImagem.Text = "Selecionar Imagem";
            this.btnSelecionarImagem.UseVisualStyleBackColor = false;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvar.IconColor = System.Drawing.Color.White;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.Location = new System.Drawing.Point(615, 388);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 69);
            this.btnSalvar.TabIndex = 87;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpar.IconColor = System.Drawing.Color.White;
            this.btnLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.Location = new System.Drawing.Point(684, 388);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(69, 69);
            this.btnLimpar.TabIndex = 88;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // tipBtnSalvar
            // 
            this.tipBtnSalvar.BackColor = System.Drawing.Color.White;
            this.tipBtnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tipBtnSalvar.ToolTipTitle = "Salvar";
            // 
            // tipBtnLimpar
            // 
            this.tipBtnLimpar.ToolTipTitle = "Limpar Campos";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(450, 60);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(296, 25);
            this.cbCategoria.TabIndex = 89;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // FormAdicionarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(796, 464);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.textBoxQuarto);
            this.Controls.Add(this.textBoxAndar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxQuarto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdicionarQuarto";
            this.Text = "FormAdicionarQuarto";
            ((System.ComponentModel.ISupportInitialize)(this.pboxQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuarto;
        private System.Windows.Forms.TextBox textBoxAndar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxQuarto;
        private FontAwesome.Sharp.IconButton btnSelecionarImagem;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private FontAwesome.Sharp.IconButton btnLimpar;
        private System.Windows.Forms.ToolTip tipBtnSalvar;
        private System.Windows.Forms.ToolTip tipBtnLimpar;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}