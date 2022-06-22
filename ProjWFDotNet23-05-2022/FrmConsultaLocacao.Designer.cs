namespace ProjWFDotNet23_05_2022
{
    partial class FrmConsultaLocacao
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
            this.dgvLocacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocacao
            // 
            this.dgvLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocacao.Location = new System.Drawing.Point(12, 12);
            this.dgvLocacao.Name = "dgvLocacao";
            this.dgvLocacao.RowTemplate.Height = 25;
            this.dgvLocacao.Size = new System.Drawing.Size(776, 396);
            this.dgvLocacao.TabIndex = 0;
            // 
            // FrmConsultaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLocacao);
            this.Name = "FrmConsultaLocacao";
            this.Text = "FrmConsultaLocacao";
            this.Load += new System.EventHandler(this.FrmConsultaLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvLocacao;
    }
}