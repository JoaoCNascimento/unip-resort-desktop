
namespace GestaoUnipResort.Forms.Emails
{
    partial class FormEmailFuncionario
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
            this.cbEmails = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEnviarTodos = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviar = new FontAwesome.Sharp.IconButton();
            this.btnSelecionarImagem = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEmails
            // 
            this.cbEmails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEmails.Enabled = false;
            this.cbEmails.FormattingEnabled = true;
            this.cbEmails.Location = new System.Drawing.Point(528, 363);
            this.cbEmails.Name = "cbEmails";
            this.cbEmails.Size = new System.Drawing.Size(256, 25);
            this.cbEmails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // checkEnviarTodos
            // 
            this.checkEnviarTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkEnviarTodos.AutoSize = true;
            this.checkEnviarTodos.Checked = true;
            this.checkEnviarTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEnviarTodos.ForeColor = System.Drawing.Color.White;
            this.checkEnviarTodos.Location = new System.Drawing.Point(528, 394);
            this.checkEnviarTodos.Name = "checkEnviarTodos";
            this.checkEnviarTodos.Size = new System.Drawing.Size(131, 21);
            this.checkEnviarTodos.TabIndex = 2;
            this.checkEnviarTodos.Text = "Enviar para todos";
            this.checkEnviarTodos.UseVisualStyleBackColor = true;
            this.checkEnviarTodos.CheckedChanged += new System.EventHandler(this.checkEnviarTodos_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(51, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 248);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Título";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(528, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 25);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(528, 167);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 140);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(516, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Assunto";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.IconChar = FontAwesome.Sharp.IconChar.EnvelopeSquare;
            this.btnEnviar.IconColor = System.Drawing.Color.White;
            this.btnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnviar.IconSize = 60;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEnviar.Location = new System.Drawing.Point(625, 543);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(216, 62);
            this.btnEnviar.TabIndex = 87;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
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
            this.btnSelecionarImagem.Location = new System.Drawing.Point(138, 325);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(231, 48);
            this.btnSelecionarImagem.TabIndex = 88;
            this.btnSelecionarImagem.Text = "Selecionar Imagem";
            this.btnSelecionarImagem.UseVisualStyleBackColor = false;
            // 
            // FormEmailFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(863, 637);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkEnviarTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmails);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEmailFuncionario";
            this.Text = "FormEmailFuncionario";
            this.Load += new System.EventHandler(this.FormEmailFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEnviarTodos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnEnviar;
        private FontAwesome.Sharp.IconButton btnSelecionarImagem;
    }
}