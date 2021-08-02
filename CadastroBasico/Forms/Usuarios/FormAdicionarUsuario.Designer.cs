
namespace GestaoUnipResort.Forms.Usuarios
{
    partial class FormAdicionarUsuario
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
            this.gbChecks = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkFuncionarios = new System.Windows.Forms.CheckBox();
            this.checkQuartos = new System.Windows.Forms.CheckBox();
            this.checkRelatorios = new System.Windows.Forms.CheckBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.checkManutencao = new System.Windows.Forms.CheckBox();
            this.checkUsuarios = new System.Windows.Forms.CheckBox();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.btnLimpar = new FontAwesome.Sharp.IconButton();
            this.gbChecks.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChecks
            // 
            this.gbChecks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbChecks.Controls.Add(this.checkTodos);
            this.gbChecks.Controls.Add(this.checkUsuarios);
            this.gbChecks.Controls.Add(this.checkManutencao);
            this.gbChecks.Controls.Add(this.checkEmail);
            this.gbChecks.Controls.Add(this.checkRelatorios);
            this.gbChecks.Controls.Add(this.checkQuartos);
            this.gbChecks.Controls.Add(this.checkFuncionarios);
            this.gbChecks.ForeColor = System.Drawing.Color.White;
            this.gbChecks.Location = new System.Drawing.Point(193, 284);
            this.gbChecks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbChecks.Name = "gbChecks";
            this.gbChecks.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbChecks.Size = new System.Drawing.Size(422, 128);
            this.gbChecks.TabIndex = 0;
            this.gbChecks.TabStop = false;
            this.gbChecks.Text = "Controle de acesso";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(306, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 25);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(306, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 25);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome de usuário";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // checkFuncionarios
            // 
            this.checkFuncionarios.AutoSize = true;
            this.checkFuncionarios.Location = new System.Drawing.Point(46, 61);
            this.checkFuncionarios.Name = "checkFuncionarios";
            this.checkFuncionarios.Size = new System.Drawing.Size(100, 21);
            this.checkFuncionarios.TabIndex = 0;
            this.checkFuncionarios.Text = "Funcionários";
            this.checkFuncionarios.UseVisualStyleBackColor = true;
            // 
            // checkQuartos
            // 
            this.checkQuartos.AutoSize = true;
            this.checkQuartos.Location = new System.Drawing.Point(175, 61);
            this.checkQuartos.Name = "checkQuartos";
            this.checkQuartos.Size = new System.Drawing.Size(74, 21);
            this.checkQuartos.TabIndex = 1;
            this.checkQuartos.Text = "Quartos";
            this.checkQuartos.UseVisualStyleBackColor = true;
            // 
            // checkRelatorios
            // 
            this.checkRelatorios.AutoSize = true;
            this.checkRelatorios.Location = new System.Drawing.Point(174, 88);
            this.checkRelatorios.Name = "checkRelatorios";
            this.checkRelatorios.Size = new System.Drawing.Size(86, 21);
            this.checkRelatorios.TabIndex = 2;
            this.checkRelatorios.Text = "Relatórios";
            this.checkRelatorios.UseVisualStyleBackColor = true;
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(300, 61);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(58, 21);
            this.checkEmail.TabIndex = 3;
            this.checkEmail.Text = "Email";
            this.checkEmail.UseVisualStyleBackColor = true;
            // 
            // checkManutencao
            // 
            this.checkManutencao.AutoSize = true;
            this.checkManutencao.Location = new System.Drawing.Point(46, 88);
            this.checkManutencao.Name = "checkManutencao";
            this.checkManutencao.Size = new System.Drawing.Size(99, 21);
            this.checkManutencao.TabIndex = 4;
            this.checkManutencao.Text = "Manutenção";
            this.checkManutencao.UseVisualStyleBackColor = true;
            // 
            // checkUsuarios
            // 
            this.checkUsuarios.AutoSize = true;
            this.checkUsuarios.Location = new System.Drawing.Point(299, 88);
            this.checkUsuarios.Name = "checkUsuarios";
            this.checkUsuarios.Size = new System.Drawing.Size(78, 21);
            this.checkUsuarios.TabIndex = 5;
            this.checkUsuarios.Text = "Usuários";
            this.checkUsuarios.UseVisualStyleBackColor = true;
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.Location = new System.Drawing.Point(46, 34);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(63, 21);
            this.checkTodos.TabIndex = 6;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
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
            this.btnSalvar.Location = new System.Drawing.Point(668, 532);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 69);
            this.btnSalvar.TabIndex = 87;
            this.btnSalvar.UseVisualStyleBackColor = false;
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
            this.btnLimpar.Location = new System.Drawing.Point(737, 532);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(69, 69);
            this.btnLimpar.TabIndex = 88;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // FormAdicionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(840, 640);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbChecks);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdicionarUsuario";
            this.Text = "FormAdicionarUsuario";
            this.gbChecks.ResumeLayout(false);
            this.gbChecks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChecks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.CheckBox checkUsuarios;
        private System.Windows.Forms.CheckBox checkManutencao;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.CheckBox checkRelatorios;
        private System.Windows.Forms.CheckBox checkQuartos;
        private System.Windows.Forms.CheckBox checkFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private FontAwesome.Sharp.IconButton btnLimpar;
    }
}