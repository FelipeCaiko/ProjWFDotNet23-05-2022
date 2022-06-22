namespace ProjWFDotNet23_05_2022
{
    partial class FrmConsultaImovel
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
            this.dgvImovel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImovel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImovel
            // 
            this.dgvImovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImovel.Location = new System.Drawing.Point(12, 12);
            this.dgvImovel.Name = "dgvImovel";
            this.dgvImovel.RowTemplate.Height = 25;
            this.dgvImovel.Size = new System.Drawing.Size(776, 426);
            this.dgvImovel.TabIndex = 0;
            // 
            // FrmConsultaImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvImovel);
            this.Name = "FrmConsultaImovel";
            this.Text = "FrmConsultaImovel";
            this.Load += new System.EventHandler(this.FrmConsultaImovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImovel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvImovel;
    }
}