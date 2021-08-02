
namespace GestaoUnipResort.Forms.Quartos
{
    partial class FormConsultarQuartos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dataGridViewQuartos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbOrdenarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarPor.ForeColor = System.Drawing.Color.Black;
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "ID Crescente",
            "ID Decrescente",
            "Valor Crescente",
            "Valor Decrescente",
            "Andar Crescente",
            "Andar Decrescente",
            "Status Disponível",
            "Status Indisponível"});
            this.cbOrdenarPor.Location = new System.Drawing.Point(80, 196);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(217, 25);
            this.cbOrdenarPor.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ordenar por:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.OldLace;
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisar.IconColor = System.Drawing.Color.White;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(570, 174);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 67);
            this.btnPesquisar.TabIndex = 65;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(21, 196);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 25);
            this.txtID.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(322, 196);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(198, 25);
            this.cbCategoria.TabIndex = 70;
            // 
            // dataGridViewQuartos
            // 
            this.dataGridViewQuartos.AllowUserToAddRows = false;
            this.dataGridViewQuartos.AllowUserToDeleteRows = false;
            this.dataGridViewQuartos.AllowUserToOrderColumns = true;
            this.dataGridViewQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewQuartos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewQuartos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridViewQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuartos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewQuartos.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewQuartos.Location = new System.Drawing.Point(11, 275);
            this.dataGridViewQuartos.Name = "dataGridViewQuartos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuartos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridViewQuartos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewQuartos.ShowCellErrors = false;
            this.dataGridViewQuartos.ShowRowErrors = false;
            this.dataGridViewQuartos.Size = new System.Drawing.Size(824, 311);
            this.dataGridViewQuartos.TabIndex = 71;
            this.dataGridViewQuartos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuartos_CellContentClick_1);
            // 
            // FormConsultarQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(847, 598);
            this.Controls.Add(this.dataGridViewQuartos);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbOrdenarPor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConsultarQuartos";
            this.Text = "FormConsultarQuartos";
            this.Load += new System.EventHandler(this.FormConsultarQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DataGridView dataGridViewQuartos;
    }
}