namespace Votacao
{
    partial class UrnaForm
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
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.btnIniciarVotacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.gbVoto = new System.Windows.Forms.GroupBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNomeCandidato = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVoto = new System.Windows.Forms.Label();
            this.pictureBoxCandidato = new System.Windows.Forms.PictureBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnCorrige = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbFim = new System.Windows.Forms.GroupBox();
            this.lblFim = new System.Windows.Forms.Label();
            this.gbInicio.SuspendLayout();
            this.gbVoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandidato)).BeginInit();
            this.gbFim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.Controls.Add(this.btnIniciarVotacao);
            this.gbInicio.Controls.Add(this.label1);
            this.gbInicio.Controls.Add(this.cmbSexo);
            this.gbInicio.Location = new System.Drawing.Point(12, 445);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(695, 415);
            this.gbInicio.TabIndex = 3;
            this.gbInicio.TabStop = false;
            // 
            // btnIniciarVotacao
            // 
            this.btnIniciarVotacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarVotacao.Location = new System.Drawing.Point(525, 294);
            this.btnIniciarVotacao.Name = "btnIniciarVotacao";
            this.btnIniciarVotacao.Size = new System.Drawing.Size(137, 34);
            this.btnIniciarVotacao.TabIndex = 5;
            this.btnIniciarVotacao.Text = "Próximo";
            this.btnIniciarVotacao.UseVisualStyleBackColor = true;
            this.btnIniciarVotacao.Click += new System.EventHandler(this.btnIniciarVotacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "",
            "Feminino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(88, 183);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(574, 28);
            this.cmbSexo.TabIndex = 3;
            // 
            // gbVoto
            // 
            this.gbVoto.Controls.Add(this.lblPartido);
            this.gbVoto.Controls.Add(this.label7);
            this.gbVoto.Controls.Add(this.lblVice);
            this.gbVoto.Controls.Add(this.label6);
            this.gbVoto.Controls.Add(this.lblNomeCandidato);
            this.gbVoto.Controls.Add(this.label4);
            this.gbVoto.Controls.Add(this.txtNumero);
            this.gbVoto.Controls.Add(this.label3);
            this.gbVoto.Controls.Add(this.lblVoto);
            this.gbVoto.Controls.Add(this.pictureBoxCandidato);
            this.gbVoto.Controls.Add(this.btnBranco);
            this.gbVoto.Controls.Add(this.btnCorrige);
            this.gbVoto.Controls.Add(this.btnConfirmar);
            this.gbVoto.Location = new System.Drawing.Point(12, 8);
            this.gbVoto.Name = "gbVoto";
            this.gbVoto.Size = new System.Drawing.Size(695, 415);
            this.gbVoto.TabIndex = 5;
            this.gbVoto.TabStop = false;
            // 
            // lblPartido
            // 
            this.lblPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Location = new System.Drawing.Point(8, 324);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(362, 23);
            this.lblPartido.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Partido:";
            // 
            // lblVice
            // 
            this.lblVice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVice.Location = new System.Drawing.Point(8, 244);
            this.lblVice.Name = "lblVice";
            this.lblVice.Size = new System.Drawing.Size(377, 23);
            this.lblVice.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vice:";
            // 
            // lblNomeCandidato
            // 
            this.lblNomeCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCandidato.Location = new System.Drawing.Point(8, 164);
            this.lblNomeCandidato.Name = "lblNomeCandidato";
            this.lblNomeCandidato.Size = new System.Drawing.Size(377, 23);
            this.lblNomeCandidato.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(88, 59);
            this.txtNumero.MaxLength = 2;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 35);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número:";
            // 
            // lblVoto
            // 
            this.lblVoto.AutoSize = true;
            this.lblVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoto.Location = new System.Drawing.Point(8, 16);
            this.lblVoto.Name = "lblVoto";
            this.lblVoto.Size = new System.Drawing.Size(98, 24);
            this.lblVoto.TabIndex = 9;
            this.lblVoto.Text = "Seu voto:";
            // 
            // pictureBoxCandidato
            // 
            this.pictureBoxCandidato.Location = new System.Drawing.Point(391, 19);
            this.pictureBoxCandidato.Name = "pictureBoxCandidato";
            this.pictureBoxCandidato.Size = new System.Drawing.Size(298, 297);
            this.pictureBoxCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCandidato.TabIndex = 8;
            this.pictureBoxCandidato.TabStop = false;
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.Color.White;
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.ForeColor = System.Drawing.Color.Black;
            this.btnBranco.Location = new System.Drawing.Point(260, 369);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(125, 40);
            this.btnBranco.TabIndex = 7;
            this.btnBranco.Text = "BRANCO";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCorrige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrige.Location = new System.Drawing.Point(391, 369);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(125, 40);
            this.btnCorrige.TabIndex = 6;
            this.btnCorrige.Text = "CORRIGE";
            this.btnCorrige.UseVisualStyleBackColor = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(520, 342);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(169, 67);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "CONFIRMA";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbFim
            // 
            this.gbFim.Controls.Add(this.lblFim);
            this.gbFim.Location = new System.Drawing.Point(18, 429);
            this.gbFim.Name = "gbFim";
            this.gbFim.Size = new System.Drawing.Size(695, 415);
            this.gbFim.TabIndex = 6;
            this.gbFim.TabStop = false;
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.Location = new System.Drawing.Point(279, 171);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(145, 73);
            this.lblFim.TabIndex = 0;
            this.lblFim.Text = "FIM";
            // 
            // UrnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 433);
            this.Controls.Add(this.gbFim);
            this.Controls.Add(this.gbInicio);
            this.Controls.Add(this.gbVoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna";
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            this.gbVoto.ResumeLayout(false);
            this.gbVoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandidato)).EndInit();
            this.gbFim.ResumeLayout(false);
            this.gbFim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Button btnIniciarVotacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.GroupBox gbVoto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbFim;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnCorrige;
        private System.Windows.Forms.Label lblVice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNomeCandidato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVoto;
        private System.Windows.Forms.PictureBox pictureBoxCandidato;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label label7;
    }
}