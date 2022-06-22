namespace ProjWFDotNet23_05_2022
{
    partial class FrmImovel
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
            this.lblImovel = new System.Windows.Forms.Label();
            this.lblInf = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.lblNomeLoc = new System.Windows.Forms.Label();
            this.lblRGLoc = new System.Windows.Forms.Label();
            this.lblTelLoc = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.txbNomeLoc = new System.Windows.Forms.TextBox();
            this.txbRGLoc = new System.Windows.Forms.TextBox();
            this.txbTelLoc = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblCEPEnd = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbComp = new System.Windows.Forms.TextBox();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImovel
            // 
            this.lblImovel.AutoSize = true;
            this.lblImovel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImovel.Location = new System.Drawing.Point(376, 9);
            this.lblImovel.Name = "lblImovel";
            this.lblImovel.Size = new System.Drawing.Size(117, 37);
            this.lblImovel.TabIndex = 0;
            this.lblImovel.Text = "Imóvel";
            // 
            // lblInf
            // 
            this.lblInf.AutoSize = true;
            this.lblInf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInf.Location = new System.Drawing.Point(549, 82);
            this.lblInf.Name = "lblInf";
            this.lblInf.Size = new System.Drawing.Size(221, 22);
            this.lblInf.TabIndex = 1;
            this.lblInf.Text = "Informações do Imóvel";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(587, 117);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(192, 23);
            this.txbDesc.TabIndex = 2;
            // 
            // lblNomeLoc
            // 
            this.lblNomeLoc.AutoSize = true;
            this.lblNomeLoc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeLoc.Location = new System.Drawing.Point(34, 122);
            this.lblNomeLoc.Name = "lblNomeLoc";
            this.lblNomeLoc.Size = new System.Drawing.Size(61, 22);
            this.lblNomeLoc.TabIndex = 3;
            this.lblNomeLoc.Text = "Nome";
            this.lblNomeLoc.Click += new System.EventHandler(this.lblNomeLoc_Click);
            // 
            // lblRGLoc
            // 
            this.lblRGLoc.AutoSize = true;
            this.lblRGLoc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRGLoc.Location = new System.Drawing.Point(56, 164);
            this.lblRGLoc.Name = "lblRGLoc";
            this.lblRGLoc.Size = new System.Drawing.Size(39, 22);
            this.lblRGLoc.TabIndex = 4;
            this.lblRGLoc.Text = "RG";
            // 
            // lblTelLoc
            // 
            this.lblTelLoc.AutoSize = true;
            this.lblTelLoc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelLoc.Location = new System.Drawing.Point(12, 198);
            this.lblTelLoc.Name = "lblTelLoc";
            this.lblTelLoc.Size = new System.Drawing.Size(84, 22);
            this.lblTelLoc.TabIndex = 5;
            this.lblTelLoc.Text = "Telefone";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoc.Location = new System.Drawing.Point(12, 82);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(238, 22);
            this.lblLoc.TabIndex = 6;
            this.lblLoc.Text = "Informações do Locador";
            // 
            // txbNomeLoc
            // 
            this.txbNomeLoc.Location = new System.Drawing.Point(115, 121);
            this.txbNomeLoc.Name = "txbNomeLoc";
            this.txbNomeLoc.Size = new System.Drawing.Size(115, 23);
            this.txbNomeLoc.TabIndex = 7;
            this.txbNomeLoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbRGLoc
            // 
            this.txbRGLoc.Location = new System.Drawing.Point(115, 162);
            this.txbRGLoc.Name = "txbRGLoc";
            this.txbRGLoc.Size = new System.Drawing.Size(115, 23);
            this.txbRGLoc.TabIndex = 8;
            // 
            // txbTelLoc
            // 
            this.txbTelLoc.Location = new System.Drawing.Point(115, 198);
            this.txbTelLoc.Name = "txbTelLoc";
            this.txbTelLoc.Size = new System.Drawing.Size(115, 23);
            this.txbTelLoc.TabIndex = 9;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.Location = new System.Drawing.Point(323, 211);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(195, 22);
            this.lblEnd.TabIndex = 10;
            this.lblEnd.Text = "Endereço do Imóvel";
            // 
            // lblCEPEnd
            // 
            this.lblCEPEnd.AutoSize = true;
            this.lblCEPEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCEPEnd.Location = new System.Drawing.Point(323, 252);
            this.lblCEPEnd.Name = "lblCEPEnd";
            this.lblCEPEnd.Size = new System.Drawing.Size(50, 22);
            this.lblCEPEnd.TabIndex = 11;
            this.lblCEPEnd.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.Location = new System.Drawing.Point(313, 281);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(60, 22);
            this.lblBairro.TabIndex = 12;
            this.lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(296, 312);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(77, 22);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Número";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComp.Location = new System.Drawing.Point(243, 341);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(130, 22);
            this.lblComp.TabIndex = 14;
            this.lblComp.Text = "Complemento";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLog.Location = new System.Drawing.Point(265, 372);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(108, 22);
            this.lblLog.TabIndex = 15;
            this.lblLog.Text = "Logradouro";
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(379, 251);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(114, 23);
            this.txbCEP.TabIndex = 16;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(379, 280);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(114, 23);
            this.txbBairro.TabIndex = 17;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(379, 311);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(114, 23);
            this.txbNumero.TabIndex = 18;
            // 
            // txbComp
            // 
            this.txbComp.Location = new System.Drawing.Point(379, 340);
            this.txbComp.Name = "txbComp";
            this.txbComp.Size = new System.Drawing.Size(114, 23);
            this.txbComp.TabIndex = 19;
            // 
            // txbLog
            // 
            this.txbLog.Location = new System.Drawing.Point(379, 371);
            this.txbLog.Name = "txbLog";
            this.txbLog.Size = new System.Drawing.Size(114, 23);
            this.txbLog.TabIndex = 20;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(485, 118);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(96, 22);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "Descrição";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(636, 254);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 46);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(636, 325);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 48);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txbLog);
            this.Controls.Add(this.txbComp);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCEPEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txbTelLoc);
            this.Controls.Add(this.txbRGLoc);
            this.Controls.Add(this.txbNomeLoc);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblTelLoc);
            this.Controls.Add(this.lblRGLoc);
            this.Controls.Add(this.lblNomeLoc);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.lblInf);
            this.Controls.Add(this.lblImovel);
            this.Name = "FrmImovel";
            this.Text = "FrmImovel";
            this.Load += new System.EventHandler(this.FrmImovel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblImovel;
        private Label lblInf;
        private TextBox txbDesc;
        private Label lblNomeLoc;
        private Label lblRGLoc;
        private Label lblTelLoc;
        private Label lblLoc;
        private TextBox txbNomeLoc;
        private TextBox txbRGLoc;
        private TextBox txbTelLoc;
        private Label lblEnd;
        private Label lblCEPEnd;
        private Label lblBairro;
        private Label lblNumero;
        private Label lblComp;
        private Label lblLog;
        private TextBox txbCEP;
        private TextBox txbBairro;
        private TextBox txbNumero;
        private TextBox txbComp;
        private TextBox txbLog;
        private Label lblDesc;
        private Button btnSalvar;
        private Button btnLimpar;
    }
}