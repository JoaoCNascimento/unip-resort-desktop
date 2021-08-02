
namespace GestaoUnipResort.Forms.Relatorios
{
    partial class FormRelatorios
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
            this.btnRelatorioGeral = new FontAwesome.Sharp.IconButton();
            this.btnFinanças = new FontAwesome.Sharp.IconButton();
            this.btnRelatorioQuartos = new FontAwesome.Sharp.IconButton();
            this.btnDesempenhoFunc = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnRelatorioGeral
            // 
            this.btnRelatorioGeral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorioGeral.FlatAppearance.BorderSize = 0;
            this.btnRelatorioGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioGeral.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioGeral.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnRelatorioGeral.IconColor = System.Drawing.Color.White;
            this.btnRelatorioGeral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatorioGeral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioGeral.Location = new System.Drawing.Point(251, 97);
            this.btnRelatorioGeral.Name = "btnRelatorioGeral";
            this.btnRelatorioGeral.Size = new System.Drawing.Size(370, 94);
            this.btnRelatorioGeral.TabIndex = 0;
            this.btnRelatorioGeral.Text = "Relatório Geral";
            this.btnRelatorioGeral.UseVisualStyleBackColor = true;
            // 
            // btnFinanças
            // 
            this.btnFinanças.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinanças.FlatAppearance.BorderSize = 0;
            this.btnFinanças.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanças.ForeColor = System.Drawing.Color.White;
            this.btnFinanças.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnFinanças.IconColor = System.Drawing.Color.White;
            this.btnFinanças.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinanças.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanças.Location = new System.Drawing.Point(251, 197);
            this.btnFinanças.Name = "btnFinanças";
            this.btnFinanças.Size = new System.Drawing.Size(370, 94);
            this.btnFinanças.TabIndex = 1;
            this.btnFinanças.Text = "Finanças";
            this.btnFinanças.UseVisualStyleBackColor = true;
            // 
            // btnRelatorioQuartos
            // 
            this.btnRelatorioQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorioQuartos.FlatAppearance.BorderSize = 0;
            this.btnRelatorioQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioQuartos.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioQuartos.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnRelatorioQuartos.IconColor = System.Drawing.Color.White;
            this.btnRelatorioQuartos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatorioQuartos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioQuartos.Location = new System.Drawing.Point(251, 297);
            this.btnRelatorioQuartos.Name = "btnRelatorioQuartos";
            this.btnRelatorioQuartos.Size = new System.Drawing.Size(370, 94);
            this.btnRelatorioQuartos.TabIndex = 2;
            this.btnRelatorioQuartos.Text = "Ocupação de quartos";
            this.btnRelatorioQuartos.UseVisualStyleBackColor = true;
            // 
            // btnDesempenhoFunc
            // 
            this.btnDesempenhoFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesempenhoFunc.FlatAppearance.BorderSize = 0;
            this.btnDesempenhoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesempenhoFunc.ForeColor = System.Drawing.Color.White;
            this.btnDesempenhoFunc.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnDesempenhoFunc.IconColor = System.Drawing.Color.White;
            this.btnDesempenhoFunc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesempenhoFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesempenhoFunc.Location = new System.Drawing.Point(251, 397);
            this.btnDesempenhoFunc.Name = "btnDesempenhoFunc";
            this.btnDesempenhoFunc.Size = new System.Drawing.Size(370, 94);
            this.btnDesempenhoFunc.TabIndex = 3;
            this.btnDesempenhoFunc.Text = "Desempenho de funcionários";
            this.btnDesempenhoFunc.UseVisualStyleBackColor = true;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(901, 630);
            this.Controls.Add(this.btnDesempenhoFunc);
            this.Controls.Add(this.btnRelatorioQuartos);
            this.Controls.Add(this.btnFinanças);
            this.Controls.Add(this.btnRelatorioGeral);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRelatorioGeral;
        private FontAwesome.Sharp.IconButton btnFinanças;
        private FontAwesome.Sharp.IconButton btnRelatorioQuartos;
        private FontAwesome.Sharp.IconButton btnDesempenhoFunc;
    }
}