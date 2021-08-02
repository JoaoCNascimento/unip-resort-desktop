
using GestaoUnipResort;

namespace GestaoUnipResort.Forms.Manutencoes
{
    partial class FormAgendarManutencao
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
            this.radioBtnQuartos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnHotel = new System.Windows.Forms.RadioButton();
            this.radioBtnOutros = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxQuarto = new System.Windows.Forms.TextBox();
            this.textBoxAndar = new System.Windows.Forms.TextBox();
            this.labelQuarto = new System.Windows.Forms.Label();
            this.labelAndar = new System.Windows.Forms.Label();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.checkNotificar = new System.Windows.Forms.CheckBox();
            this.gbNotificar = new System.Windows.Forms.GroupBox();
            this.cbCargos = new System.Windows.Forms.ComboBox();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioApenas = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.txtDataTermino = new System.Windows.Forms.MaskedTextBox();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbNotificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnQuartos
            // 
            this.radioBtnQuartos.AutoSize = true;
            this.radioBtnQuartos.Location = new System.Drawing.Point(123, 37);
            this.radioBtnQuartos.Name = "radioBtnQuartos";
            this.radioBtnQuartos.Size = new System.Drawing.Size(67, 21);
            this.radioBtnQuartos.TabIndex = 0;
            this.radioBtnQuartos.Text = "Quarto";
            this.radioBtnQuartos.UseVisualStyleBackColor = true;
            this.radioBtnQuartos.CheckedChanged += new System.EventHandler(this.radioBtnQuartos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioBtnHotel);
            this.groupBox1.Controls.Add(this.radioBtnOutros);
            this.groupBox1.Controls.Add(this.radioBtnQuartos);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(116, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de manutenção";
            // 
            // radioBtnHotel
            // 
            this.radioBtnHotel.AutoSize = true;
            this.radioBtnHotel.Location = new System.Drawing.Point(31, 37);
            this.radioBtnHotel.Name = "radioBtnHotel";
            this.radioBtnHotel.Size = new System.Drawing.Size(57, 21);
            this.radioBtnHotel.TabIndex = 2;
            this.radioBtnHotel.Text = "Hotel";
            this.radioBtnHotel.UseVisualStyleBackColor = true;
            // 
            // radioBtnOutros
            // 
            this.radioBtnOutros.AutoSize = true;
            this.radioBtnOutros.Location = new System.Drawing.Point(227, 37);
            this.radioBtnOutros.Name = "radioBtnOutros";
            this.radioBtnOutros.Size = new System.Drawing.Size(66, 21);
            this.radioBtnOutros.TabIndex = 1;
            this.radioBtnOutros.Text = "Outros";
            this.radioBtnOutros.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.textBoxQuarto);
            this.panel1.Controls.Add(this.textBoxAndar);
            this.panel1.Controls.Add(this.labelQuarto);
            this.panel1.Controls.Add(this.labelAndar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.checkNotificar);
            this.panel1.Controls.Add(this.gbNotificar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxTitulo);
            this.panel1.Controls.Add(this.textBoxValor);
            this.panel1.Controls.Add(this.textBoxDescricao);
            this.panel1.Controls.Add(this.txtDataTermino);
            this.panel1.Controls.Add(this.txtDataInicio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(116, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 395);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxQuarto
            // 
            this.textBoxQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxQuarto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuarto.Location = new System.Drawing.Point(139, 284);
            this.textBoxQuarto.Name = "textBoxQuarto";
            this.textBoxQuarto.Size = new System.Drawing.Size(75, 25);
            this.textBoxQuarto.TabIndex = 91;
            this.textBoxQuarto.Visible = false;
            // 
            // textBoxAndar
            // 
            this.textBoxAndar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAndar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAndar.Location = new System.Drawing.Point(31, 284);
            this.textBoxAndar.Name = "textBoxAndar";
            this.textBoxAndar.Size = new System.Drawing.Size(62, 25);
            this.textBoxAndar.TabIndex = 90;
            this.textBoxAndar.Visible = false;
            // 
            // labelQuarto
            // 
            this.labelQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuarto.AutoSize = true;
            this.labelQuarto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuarto.ForeColor = System.Drawing.Color.White;
            this.labelQuarto.Location = new System.Drawing.Point(134, 264);
            this.labelQuarto.Name = "labelQuarto";
            this.labelQuarto.Size = new System.Drawing.Size(49, 17);
            this.labelQuarto.TabIndex = 89;
            this.labelQuarto.Text = "Quarto";
            this.labelQuarto.Visible = false;
            // 
            // labelAndar
            // 
            this.labelAndar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAndar.AutoSize = true;
            this.labelAndar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAndar.ForeColor = System.Drawing.Color.White;
            this.labelAndar.Location = new System.Drawing.Point(28, 264);
            this.labelAndar.Name = "labelAndar";
            this.labelAndar.Size = new System.Drawing.Size(43, 17);
            this.labelAndar.TabIndex = 88;
            this.labelAndar.Text = "Andar";
            this.labelAndar.Visible = false;
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
            this.btnSalvar.Location = new System.Drawing.Point(601, 326);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 69);
            this.btnSalvar.TabIndex = 87;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // checkNotificar
            // 
            this.checkNotificar.AutoSize = true;
            this.checkNotificar.ForeColor = System.Drawing.Color.White;
            this.checkNotificar.Location = new System.Drawing.Point(31, 326);
            this.checkNotificar.Name = "checkNotificar";
            this.checkNotificar.Size = new System.Drawing.Size(152, 21);
            this.checkNotificar.TabIndex = 15;
            this.checkNotificar.Text = "Notificar funcionários";
            this.checkNotificar.UseVisualStyleBackColor = true;
            this.checkNotificar.CheckedChanged += new System.EventHandler(this.checkNotificar_CheckedChanged);
            // 
            // gbNotificar
            // 
            this.gbNotificar.Controls.Add(this.cbCargos);
            this.gbNotificar.Controls.Add(this.radioTodos);
            this.gbNotificar.Controls.Add(this.radioApenas);
            this.gbNotificar.ForeColor = System.Drawing.Color.White;
            this.gbNotificar.Location = new System.Drawing.Point(339, 172);
            this.gbNotificar.Name = "gbNotificar";
            this.gbNotificar.Size = new System.Drawing.Size(242, 99);
            this.gbNotificar.TabIndex = 14;
            this.gbNotificar.TabStop = false;
            this.gbNotificar.Text = "Avisos";
            this.gbNotificar.Visible = false;
            // 
            // cbCargos
            // 
            this.cbCargos.FormattingEnabled = true;
            this.cbCargos.Location = new System.Drawing.Point(31, 54);
            this.cbCargos.Name = "cbCargos";
            this.cbCargos.Size = new System.Drawing.Size(182, 25);
            this.cbCargos.TabIndex = 11;
            this.cbCargos.ValueMember = "CARGO";
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.ForeColor = System.Drawing.Color.White;
            this.radioTodos.Location = new System.Drawing.Point(31, 27);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(62, 21);
            this.radioTodos.TabIndex = 13;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioApenas
            // 
            this.radioApenas.AutoSize = true;
            this.radioApenas.ForeColor = System.Drawing.Color.White;
            this.radioApenas.Location = new System.Drawing.Point(144, 27);
            this.radioApenas.Name = "radioApenas";
            this.radioApenas.Size = new System.Drawing.Size(69, 21);
            this.radioApenas.TabIndex = 12;
            this.radioApenas.Text = "Apenas";
            this.radioApenas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(31, 38);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(240, 25);
            this.textBoxTitulo.TabIndex = 9;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(339, 38);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 25);
            this.textBoxValor.TabIndex = 7;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(31, 115);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(244, 135);
            this.textBoxDescricao.TabIndex = 6;
            // 
            // txtDataTermino
            // 
            this.txtDataTermino.Location = new System.Drawing.Point(483, 115);
            this.txtDataTermino.Mask = "00/00/0000";
            this.txtDataTermino.Name = "txtDataTermino";
            this.txtDataTermino.Size = new System.Drawing.Size(100, 25);
            this.txtDataTermino.TabIndex = 5;
            this.txtDataTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataTermino.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(339, 115);
            this.txtDataInicio.Mask = "00/00/0000";
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(100, 25);
            this.txtDataInicio.TabIndex = 4;
            this.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(336, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor (Gastos)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Término";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Início";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // FormAgendarManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(840, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAgendarManutencao";
            this.Text = "FormAgendarManutencao";
            this.Load += new System.EventHandler(this.FormAgendarManutencao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbNotificar.ResumeLayout(false);
            this.gbNotificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnQuartos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnHotel;
        private System.Windows.Forms.RadioButton radioBtnOutros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.MaskedTextBox txtDataTermino;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCargos;
        private System.Windows.Forms.CheckBox checkNotificar;
        private System.Windows.Forms.GroupBox gbNotificar;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioApenas;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private System.Windows.Forms.TextBox textBoxQuarto;
        private System.Windows.Forms.TextBox textBoxAndar;
        private System.Windows.Forms.Label labelQuarto;
        private System.Windows.Forms.Label labelAndar;
    }
}