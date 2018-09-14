namespace Votacao
{
    partial class ResultadoForm
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
            this.btnGerarResultados = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeral = new System.Windows.Forms.TabPage();
            this.grdGeral = new System.Windows.Forms.DataGridView();
            this.tpSexo = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdSexoTotalizador = new System.Windows.Forms.DataGridView();
            this.grdSexoDetalhe = new System.Windows.Forms.DataGridView();
            this.tbSala = new System.Windows.Forms.TabPage();
            this.gbTotalizadorVotos = new System.Windows.Forms.GroupBox();
            this.lblNulos = new System.Windows.Forms.Label();
            this.lblBrancos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grdSalaTotalizador = new System.Windows.Forms.DataGridView();
            this.grdSalaDetalhe = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGeral)).BeginInit();
            this.tpSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSexoTotalizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSexoDetalhe)).BeginInit();
            this.tbSala.SuspendLayout();
            this.gbTotalizadorVotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaTotalizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarResultados
            // 
            this.btnGerarResultados.Location = new System.Drawing.Point(12, 12);
            this.btnGerarResultados.Name = "btnGerarResultados";
            this.btnGerarResultados.Size = new System.Drawing.Size(128, 35);
            this.btnGerarResultados.TabIndex = 0;
            this.btnGerarResultados.Text = "Gerar Resultados";
            this.btnGerarResultados.UseVisualStyleBackColor = true;
            this.btnGerarResultados.Click += new System.EventHandler(this.btnGerarResultados_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(146, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(137, 12);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Carregando Votos... Aguarde ...";
            this.lblStatus.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGeral);
            this.tabControl1.Controls.Add(this.tpSexo);
            this.tabControl1.Controls.Add(this.tbSala);
            this.tabControl1.Location = new System.Drawing.Point(11, 161);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 329);
            this.tabControl1.TabIndex = 5;
            // 
            // tpGeral
            // 
            this.tpGeral.Controls.Add(this.grdGeral);
            this.tpGeral.Location = new System.Drawing.Point(4, 22);
            this.tpGeral.Name = "tpGeral";
            this.tpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeral.Size = new System.Drawing.Size(937, 303);
            this.tpGeral.TabIndex = 0;
            this.tpGeral.Text = "Geral";
            this.tpGeral.UseVisualStyleBackColor = true;
            // 
            // grdGeral
            // 
            this.grdGeral.AllowUserToAddRows = false;
            this.grdGeral.AllowUserToDeleteRows = false;
            this.grdGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGeral.Location = new System.Drawing.Point(9, 6);
            this.grdGeral.Name = "grdGeral";
            this.grdGeral.ReadOnly = true;
            this.grdGeral.Size = new System.Drawing.Size(922, 289);
            this.grdGeral.TabIndex = 5;
            // 
            // tpSexo
            // 
            this.tpSexo.Controls.Add(this.label6);
            this.tpSexo.Controls.Add(this.label5);
            this.tpSexo.Controls.Add(this.grdSexoTotalizador);
            this.tpSexo.Controls.Add(this.grdSexoDetalhe);
            this.tpSexo.Location = new System.Drawing.Point(4, 22);
            this.tpSexo.Name = "tpSexo";
            this.tpSexo.Padding = new System.Windows.Forms.Padding(3);
            this.tpSexo.Size = new System.Drawing.Size(937, 303);
            this.tpSexo.TabIndex = 1;
            this.tpSexo.Text = "Sexo";
            this.tpSexo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Detalhe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Totalizador:";
            // 
            // grdSexoTotalizador
            // 
            this.grdSexoTotalizador.AllowUserToAddRows = false;
            this.grdSexoTotalizador.AllowUserToDeleteRows = false;
            this.grdSexoTotalizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSexoTotalizador.Location = new System.Drawing.Point(7, 19);
            this.grdSexoTotalizador.Name = "grdSexoTotalizador";
            this.grdSexoTotalizador.ReadOnly = true;
            this.grdSexoTotalizador.Size = new System.Drawing.Size(924, 88);
            this.grdSexoTotalizador.TabIndex = 7;
            // 
            // grdSexoDetalhe
            // 
            this.grdSexoDetalhe.AllowUserToAddRows = false;
            this.grdSexoDetalhe.AllowUserToDeleteRows = false;
            this.grdSexoDetalhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSexoDetalhe.Location = new System.Drawing.Point(7, 126);
            this.grdSexoDetalhe.Name = "grdSexoDetalhe";
            this.grdSexoDetalhe.ReadOnly = true;
            this.grdSexoDetalhe.Size = new System.Drawing.Size(924, 170);
            this.grdSexoDetalhe.TabIndex = 6;
            // 
            // tbSala
            // 
            this.tbSala.Controls.Add(this.label7);
            this.tbSala.Controls.Add(this.label8);
            this.tbSala.Controls.Add(this.grdSalaTotalizador);
            this.tbSala.Controls.Add(this.grdSalaDetalhe);
            this.tbSala.Location = new System.Drawing.Point(4, 22);
            this.tbSala.Name = "tbSala";
            this.tbSala.Padding = new System.Windows.Forms.Padding(3);
            this.tbSala.Size = new System.Drawing.Size(937, 303);
            this.tbSala.TabIndex = 2;
            this.tbSala.Text = "Sala";
            this.tbSala.UseVisualStyleBackColor = true;
            // 
            // gbTotalizadorVotos
            // 
            this.gbTotalizadorVotos.Controls.Add(this.lblNulos);
            this.gbTotalizadorVotos.Controls.Add(this.lblBrancos);
            this.gbTotalizadorVotos.Controls.Add(this.lblTotal);
            this.gbTotalizadorVotos.Controls.Add(this.label4);
            this.gbTotalizadorVotos.Controls.Add(this.lblValidos);
            this.gbTotalizadorVotos.Controls.Add(this.label3);
            this.gbTotalizadorVotos.Controls.Add(this.label2);
            this.gbTotalizadorVotos.Controls.Add(this.label1);
            this.gbTotalizadorVotos.Location = new System.Drawing.Point(11, 58);
            this.gbTotalizadorVotos.Name = "gbTotalizadorVotos";
            this.gbTotalizadorVotos.Size = new System.Drawing.Size(941, 97);
            this.gbTotalizadorVotos.TabIndex = 7;
            this.gbTotalizadorVotos.TabStop = false;
            this.gbTotalizadorVotos.Text = "Total de Votos:";
            // 
            // lblNulos
            // 
            this.lblNulos.AutoSize = true;
            this.lblNulos.Location = new System.Drawing.Point(78, 70);
            this.lblNulos.Name = "lblNulos";
            this.lblNulos.Size = new System.Drawing.Size(0, 13);
            this.lblNulos.TabIndex = 7;
            // 
            // lblBrancos
            // 
            this.lblBrancos.AutoSize = true;
            this.lblBrancos.Location = new System.Drawing.Point(78, 45);
            this.lblBrancos.Name = "lblBrancos";
            this.lblBrancos.Size = new System.Drawing.Size(0, 13);
            this.lblBrancos.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(332, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // lblValidos
            // 
            this.lblValidos.AutoSize = true;
            this.lblValidos.Location = new System.Drawing.Point(78, 20);
            this.lblValidos.Name = "lblValidos";
            this.lblValidos.Size = new System.Drawing.Size(0, 13);
            this.lblValidos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nulos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brancos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válidos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Detalhe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Totalizador:";
            // 
            // grdSalaTotalizador
            // 
            this.grdSalaTotalizador.AllowUserToAddRows = false;
            this.grdSalaTotalizador.AllowUserToDeleteRows = false;
            this.grdSalaTotalizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaTotalizador.Location = new System.Drawing.Point(8, 21);
            this.grdSalaTotalizador.Name = "grdSalaTotalizador";
            this.grdSalaTotalizador.ReadOnly = true;
            this.grdSalaTotalizador.Size = new System.Drawing.Size(924, 88);
            this.grdSalaTotalizador.TabIndex = 11;
            // 
            // grdSalaDetalhe
            // 
            this.grdSalaDetalhe.AllowUserToAddRows = false;
            this.grdSalaDetalhe.AllowUserToDeleteRows = false;
            this.grdSalaDetalhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaDetalhe.Location = new System.Drawing.Point(8, 128);
            this.grdSalaDetalhe.Name = "grdSalaDetalhe";
            this.grdSalaDetalhe.ReadOnly = true;
            this.grdSalaDetalhe.Size = new System.Drawing.Size(924, 170);
            this.grdSalaDetalhe.TabIndex = 10;
            // 
            // ResultadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 502);
            this.Controls.Add(this.gbTotalizadorVotos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGerarResultados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.tabControl1.ResumeLayout(false);
            this.tpGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGeral)).EndInit();
            this.tpSexo.ResumeLayout(false);
            this.tpSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSexoTotalizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSexoDetalhe)).EndInit();
            this.tbSala.ResumeLayout(false);
            this.tbSala.PerformLayout();
            this.gbTotalizadorVotos.ResumeLayout(false);
            this.gbTotalizadorVotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaTotalizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarResultados;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeral;
        private System.Windows.Forms.DataGridView grdGeral;
        private System.Windows.Forms.TabPage tpSexo;
        private System.Windows.Forms.GroupBox gbTotalizadorVotos;
        private System.Windows.Forms.Label lblNulos;
        private System.Windows.Forms.Label lblBrancos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSexoDetalhe;
        private System.Windows.Forms.TabPage tbSala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdSexoTotalizador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grdSalaTotalizador;
        private System.Windows.Forms.DataGridView grdSalaDetalhe;
    }
}