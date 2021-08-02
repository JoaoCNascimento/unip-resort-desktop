
namespace GestaoUnipResort.Forms.Manutencoes
{
    partial class FormConsultarManutencoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewManutencao = new System.Windows.Forms.DataGridView();
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManutencao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManutencao
            // 
            this.dataGridViewManutencao.AllowUserToAddRows = false;
            this.dataGridViewManutencao.AllowUserToDeleteRows = false;
            this.dataGridViewManutencao.AllowUserToOrderColumns = true;
            this.dataGridViewManutencao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManutencao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewManutencao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewManutencao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridViewManutencao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewManutencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewManutencao.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewManutencao.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewManutencao.Location = new System.Drawing.Point(6, 275);
            this.dataGridViewManutencao.Name = "dataGridViewManutencao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewManutencao.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridViewManutencao.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewManutencao.ShowCellErrors = false;
            this.dataGridViewManutencao.ShowRowErrors = false;
            this.dataGridViewManutencao.Size = new System.Drawing.Size(829, 311);
            this.dataGridViewManutencao.TabIndex = 1;
            this.dataGridViewManutencao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManutencao_CellContentClick);
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbOrdenarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Título (Alfabética)",
            "Valor Crescente",
            "Valor Decrescente",
            "Data de início mais próxima",
            "Data de início menos próxima",
            "Data de término mais próxima",
            "Data de término menos próxima"});
            this.cbOrdenarPor.Location = new System.Drawing.Point(85, 185);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(217, 25);
            this.cbOrdenarPor.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ordenar por:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(26, 185);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 25);
            this.txtID.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "ID";
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
            this.btnPesquisar.Location = new System.Drawing.Point(325, 163);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 67);
            this.btnPesquisar.TabIndex = 65;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // FormConsultarManutencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(847, 598);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbOrdenarPor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewManutencao);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConsultarManutencoes";
            this.Text = "FormConsultarManutencoes";
            this.Load += new System.EventHandler(this.FormConsultarManutencoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManutencao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManutencao;
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnPesquisar;
    }
}