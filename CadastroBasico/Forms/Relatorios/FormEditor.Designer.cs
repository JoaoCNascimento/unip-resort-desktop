
namespace GestaoUnipResort.Forms.Relatorios
{
    partial class FormEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBold = new FontAwesome.Sharp.IconButton();
            this.btnItalic = new FontAwesome.Sharp.IconButton();
            this.btnUnderline = new FontAwesome.Sharp.IconButton();
            this.btnUpper = new FontAwesome.Sharp.IconButton();
            this.btnLower = new FontAwesome.Sharp.IconButton();
            this.btnAlLeft = new FontAwesome.Sharp.IconButton();
            this.btnAlCenter = new FontAwesome.Sharp.IconButton();
            this.btnAlJustify = new FontAwesome.Sharp.IconButton();
            this.btnAlRight = new FontAwesome.Sharp.IconButton();
            this.btnColar = new FontAwesome.Sharp.IconButton();
            this.btnCopiar = new FontAwesome.Sharp.IconButton();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.richTxtTexto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(863, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.DropDownClosed += new System.EventHandler(this.arquivoToolStripMenuItem_DropDownClosed);
            this.arquivoToolStripMenuItem.DropDownOpened += new System.EventHandler(this.arquivoToolStripMenuItem_DropDownOpened);
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voltarToolStripMenuItem.Text = "Voltar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.formatarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 25);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fontes";
            // 
            // btnBold
            // 
            this.btnBold.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBold.FlatAppearance.BorderSize = 0;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.IconChar = FontAwesome.Sharp.IconChar.Bold;
            this.btnBold.IconColor = System.Drawing.Color.White;
            this.btnBold.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBold.IconSize = 36;
            this.btnBold.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBold.Location = new System.Drawing.Point(416, 42);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(38, 39);
            this.btnBold.TabIndex = 7;
            this.btnBold.UseVisualStyleBackColor = true;
            // 
            // btnItalic
            // 
            this.btnItalic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnItalic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItalic.FlatAppearance.BorderSize = 0;
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.IconChar = FontAwesome.Sharp.IconChar.Italic;
            this.btnItalic.IconColor = System.Drawing.Color.White;
            this.btnItalic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnItalic.IconSize = 36;
            this.btnItalic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItalic.Location = new System.Drawing.Point(460, 42);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(38, 39);
            this.btnItalic.TabIndex = 8;
            this.btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnUnderline
            // 
            this.btnUnderline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUnderline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnderline.FlatAppearance.BorderSize = 0;
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.IconChar = FontAwesome.Sharp.IconChar.Underline;
            this.btnUnderline.IconColor = System.Drawing.Color.White;
            this.btnUnderline.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUnderline.IconSize = 36;
            this.btnUnderline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnderline.Location = new System.Drawing.Point(504, 42);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(38, 39);
            this.btnUnderline.TabIndex = 9;
            this.btnUnderline.UseVisualStyleBackColor = true;
            // 
            // btnUpper
            // 
            this.btnUpper.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpper.FlatAppearance.BorderSize = 0;
            this.btnUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpper.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnUpper.IconColor = System.Drawing.Color.White;
            this.btnUpper.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpper.IconSize = 36;
            this.btnUpper.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpper.Location = new System.Drawing.Point(548, 42);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(38, 39);
            this.btnUpper.TabIndex = 10;
            this.btnUpper.UseVisualStyleBackColor = true;
            // 
            // btnLower
            // 
            this.btnLower.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLower.FlatAppearance.BorderSize = 0;
            this.btnLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLower.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnLower.IconColor = System.Drawing.Color.White;
            this.btnLower.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLower.IconSize = 36;
            this.btnLower.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLower.Location = new System.Drawing.Point(592, 42);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(38, 39);
            this.btnLower.TabIndex = 11;
            this.btnLower.UseVisualStyleBackColor = true;
            // 
            // btnAlLeft
            // 
            this.btnAlLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlLeft.FlatAppearance.BorderSize = 0;
            this.btnAlLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlLeft.IconChar = FontAwesome.Sharp.IconChar.AlignLeft;
            this.btnAlLeft.IconColor = System.Drawing.Color.White;
            this.btnAlLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlLeft.IconSize = 36;
            this.btnAlLeft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlLeft.Location = new System.Drawing.Point(667, 42);
            this.btnAlLeft.Name = "btnAlLeft";
            this.btnAlLeft.Size = new System.Drawing.Size(38, 39);
            this.btnAlLeft.TabIndex = 12;
            this.btnAlLeft.UseVisualStyleBackColor = true;
            // 
            // btnAlCenter
            // 
            this.btnAlCenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlCenter.FlatAppearance.BorderSize = 0;
            this.btnAlCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlCenter.IconChar = FontAwesome.Sharp.IconChar.AlignCenter;
            this.btnAlCenter.IconColor = System.Drawing.Color.White;
            this.btnAlCenter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlCenter.IconSize = 36;
            this.btnAlCenter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlCenter.Location = new System.Drawing.Point(711, 42);
            this.btnAlCenter.Name = "btnAlCenter";
            this.btnAlCenter.Size = new System.Drawing.Size(38, 39);
            this.btnAlCenter.TabIndex = 13;
            this.btnAlCenter.UseVisualStyleBackColor = true;
            // 
            // btnAlJustify
            // 
            this.btnAlJustify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlJustify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlJustify.FlatAppearance.BorderSize = 0;
            this.btnAlJustify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlJustify.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnAlJustify.IconColor = System.Drawing.Color.White;
            this.btnAlJustify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlJustify.IconSize = 36;
            this.btnAlJustify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlJustify.Location = new System.Drawing.Point(800, 42);
            this.btnAlJustify.Name = "btnAlJustify";
            this.btnAlJustify.Size = new System.Drawing.Size(38, 39);
            this.btnAlJustify.TabIndex = 15;
            this.btnAlJustify.UseVisualStyleBackColor = true;
            // 
            // btnAlRight
            // 
            this.btnAlRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlRight.FlatAppearance.BorderSize = 0;
            this.btnAlRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlRight.IconChar = FontAwesome.Sharp.IconChar.AlignRight;
            this.btnAlRight.IconColor = System.Drawing.Color.White;
            this.btnAlRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlRight.IconSize = 36;
            this.btnAlRight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlRight.Location = new System.Drawing.Point(756, 42);
            this.btnAlRight.Name = "btnAlRight";
            this.btnAlRight.Size = new System.Drawing.Size(38, 39);
            this.btnAlRight.TabIndex = 14;
            this.btnAlRight.UseVisualStyleBackColor = true;
            // 
            // btnColar
            // 
            this.btnColar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnColar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColar.FlatAppearance.BorderSize = 0;
            this.btnColar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColar.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.btnColar.IconColor = System.Drawing.Color.White;
            this.btnColar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColar.IconSize = 36;
            this.btnColar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColar.Location = new System.Drawing.Point(119, 42);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(38, 39);
            this.btnColar.TabIndex = 18;
            this.btnColar.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.FlatAppearance.BorderSize = 0;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopiar.IconColor = System.Drawing.Color.White;
            this.btnCopiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopiar.IconSize = 36;
            this.btnCopiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopiar.Location = new System.Drawing.Point(75, 42);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(38, 39);
            this.btnCopiar.TabIndex = 17;
            this.btnCopiar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvar.IconColor = System.Drawing.Color.White;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 36;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(31, 42);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(38, 39);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // richTxtTexto
            // 
            this.richTxtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTxtTexto.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.richTxtTexto.Location = new System.Drawing.Point(12, 102);
            this.richTxtTexto.MaximumSize = new System.Drawing.Size(1000, 1200);
            this.richTxtTexto.MinimumSize = new System.Drawing.Size(600, 800);
            this.richTxtTexto.Name = "richTxtTexto";
            this.richTxtTexto.Size = new System.Drawing.Size(833, 800);
            this.richTxtTexto.TabIndex = 19;
            this.richTxtTexto.Text = "";
            this.richTxtTexto.TextChanged += new System.EventHandler(this.richTxtTexto_TextChanged);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(863, 637);
            this.Controls.Add(this.richTxtTexto);
            this.Controls.Add(this.btnColar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlJustify);
            this.Controls.Add(this.btnAlRight);
            this.Controls.Add(this.btnAlCenter);
            this.Controls.Add(this.btnAlLeft);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEditor";
            this.Text = "FormEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBold;
        private FontAwesome.Sharp.IconButton btnItalic;
        private FontAwesome.Sharp.IconButton btnUnderline;
        private FontAwesome.Sharp.IconButton btnUpper;
        private FontAwesome.Sharp.IconButton btnLower;
        private FontAwesome.Sharp.IconButton btnAlLeft;
        private FontAwesome.Sharp.IconButton btnAlCenter;
        private FontAwesome.Sharp.IconButton btnAlJustify;
        private FontAwesome.Sharp.IconButton btnAlRight;
        private FontAwesome.Sharp.IconButton btnColar;
        private FontAwesome.Sharp.IconButton btnCopiar;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private System.Windows.Forms.RichTextBox richTxtTexto;
    }
}