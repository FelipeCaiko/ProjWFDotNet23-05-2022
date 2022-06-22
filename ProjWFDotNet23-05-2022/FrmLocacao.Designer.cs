namespace ProjWFDotNet23_05_2022
{
    partial class FrmLocacao
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
            this.lblLocacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblIdClie = new System.Windows.Forms.Label();
            this.lblIdImovel = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.cboImovel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLocacao
            // 
            this.lblLocacao.AutoSize = true;
            this.lblLocacao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocacao.Location = new System.Drawing.Point(343, 9);
            this.lblLocacao.Name = "lblLocacao";
            this.lblLocacao.Size = new System.Drawing.Size(110, 29);
            this.lblLocacao.TabIndex = 0;
            this.lblLocacao.Text = "Locação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(117, 81);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(111, 24);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descrição";
            // 
            // lblIdClie
            // 
            this.lblIdClie.AutoSize = true;
            this.lblIdClie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdClie.Location = new System.Drawing.Point(91, 148);
            this.lblIdClie.Name = "lblIdClie";
            this.lblIdClie.Size = new System.Drawing.Size(137, 24);
            this.lblIdClie.TabIndex = 3;
            this.lblIdClie.Text = "ID do Cliente";
            // 
            // lblIdImovel
            // 
            this.lblIdImovel.AutoSize = true;
            this.lblIdImovel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdImovel.Location = new System.Drawing.Point(93, 209);
            this.lblIdImovel.Name = "lblIdImovel";
            this.lblIdImovel.Size = new System.Drawing.Size(135, 24);
            this.lblIdImovel.TabIndex = 4;
            this.lblIdImovel.Text = "ID do Imóvel";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(634, 151);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 38);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(634, 209);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 36);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(234, 81);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(289, 23);
            this.txtDesc.TabIndex = 7;
            // 
            // cbocliente
            // 
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(234, 152);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(289, 23);
            this.cbocliente.TabIndex = 10;
            // 
            // cboImovel
            // 
            this.cboImovel.FormattingEnabled = true;
            this.cboImovel.Location = new System.Drawing.Point(234, 209);
            this.cboImovel.Name = "cboImovel";
            this.cboImovel.Size = new System.Drawing.Size(289, 23);
            this.cboImovel.TabIndex = 11;
            this.cboImovel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboImovel);
            this.Controls.Add(this.cbocliente);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblIdImovel);
            this.Controls.Add(this.lblIdClie);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLocacao);
            this.Name = "FrmLocacao";
            this.Text = "FrmLocacao";
            this.Load += new System.EventHandler(this.FrmLocacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLocacao;
        private Label label1;
        private Label lblDesc;
        private Label lblIdClie;
        private Label lblIdImovel;
        private Button btnSalvar;
        private Button btnLimpar;
        private TextBox txtDesc;
        private ComboBox cbocliente;
        private ComboBox cboImovel;
    }
}