namespace Votacao
{
    partial class MainForm
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
            this.pnlAcoes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumSala = new System.Windows.Forms.TextBox();
            this.btnIniciarUrna = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.pnlAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcoes
            // 
            this.pnlAcoes.Controls.Add(this.label1);
            this.pnlAcoes.Controls.Add(this.btnResultados);
            this.pnlAcoes.Controls.Add(this.txtNumSala);
            this.pnlAcoes.Controls.Add(this.btnIniciarUrna);
            this.pnlAcoes.Location = new System.Drawing.Point(12, 12);
            this.pnlAcoes.Name = "pnlAcoes";
            this.pnlAcoes.Size = new System.Drawing.Size(343, 239);
            this.pnlAcoes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número Sala";
            // 
            // txtNumSala
            // 
            this.txtNumSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSala.Location = new System.Drawing.Point(40, 66);
            this.txtNumSala.MaxLength = 4;
            this.txtNumSala.Name = "txtNumSala";
            this.txtNumSala.Size = new System.Drawing.Size(97, 26);
            this.txtNumSala.TabIndex = 0;
            // 
            // btnIniciarUrna
            // 
            this.btnIniciarUrna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarUrna.Location = new System.Drawing.Point(40, 98);
            this.btnIniciarUrna.Name = "btnIniciarUrna";
            this.btnIniciarUrna.Size = new System.Drawing.Size(249, 42);
            this.btnIniciarUrna.TabIndex = 1;
            this.btnIniciarUrna.Text = "Iniciar Urna";
            this.btnIniciarUrna.UseVisualStyleBackColor = true;
            this.btnIniciarUrna.Click += new System.EventHandler(this.btnIniciarUrna_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(40, 167);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(249, 42);
            this.btnResultados.TabIndex = 0;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 263);
            this.Controls.Add(this.pnlAcoes);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação";
            this.pnlAcoes.ResumeLayout(false);
            this.pnlAcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumSala;
        private System.Windows.Forms.Button btnIniciarUrna;
        private System.Windows.Forms.Button btnResultados;
    }
}

