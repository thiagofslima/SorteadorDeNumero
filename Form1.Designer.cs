﻿namespace SorteadorDeNumero
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSortear = new System.Windows.Forms.Button();
            this.nudInicial = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFinal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnumSorteado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSortear
            // 
            this.btnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(75, 266);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(135, 45);
            this.btnSortear.TabIndex = 2;
            this.btnSortear.Text = "SORTEAR";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // nudInicial
            // 
            this.nudInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInicial.Location = new System.Drawing.Point(102, 99);
            this.nudInicial.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudInicial.Name = "nudInicial";
            this.nudInicial.Size = new System.Drawing.Size(80, 30);
            this.nudInicial.TabIndex = 0;
            this.nudInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Final";
            // 
            // nudFinal
            // 
            this.nudFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFinal.Location = new System.Drawing.Point(102, 173);
            this.nudFinal.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudFinal.Name = "nudFinal";
            this.nudFinal.Size = new System.Drawing.Size(80, 30);
            this.nudFinal.TabIndex = 1;
            this.nudFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "SORTEADOR DE NÚMERO";
            // 
            // lblnumSorteado
            // 
            this.lblnumSorteado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumSorteado.ForeColor = System.Drawing.Color.Red;
            this.lblnumSorteado.Location = new System.Drawing.Point(75, 213);
            this.lblnumSorteado.Name = "lblnumSorteado";
            this.lblnumSorteado.Size = new System.Drawing.Size(135, 50);
            this.lblnumSorteado.TabIndex = 4;
            this.lblnumSorteado.Text = "-";
            this.lblnumSorteado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSortear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 334);
            this.Controls.Add(this.lblnumSorteado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFinal);
            this.Controls.Add(this.nudInicial);
            this.Controls.Add(this.btnSortear);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteador de Número";
            ((System.ComponentModel.ISupportInitialize)(this.nudInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.NumericUpDown nudInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnumSorteado;
    }
}

