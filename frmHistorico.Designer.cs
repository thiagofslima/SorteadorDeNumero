namespace SorteadorDeNumero
{
    partial class frmHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorico));
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.btnLimparHistorico = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.SystemColors.Control;
            this.txtHistorico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(3, 2);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(279, 297);
            this.txtHistorico.TabIndex = 0;
            // 
            // btnLimparHistorico
            // 
            this.btnLimparHistorico.Location = new System.Drawing.Point(12, 305);
            this.btnLimparHistorico.Name = "btnLimparHistorico";
            this.btnLimparHistorico.Size = new System.Drawing.Size(106, 23);
            this.btnLimparHistorico.TabIndex = 1;
            this.btnLimparHistorico.Text = "Limpar Histórico";
            this.btnLimparHistorico.UseVisualStyleBackColor = true;
            this.btnLimparHistorico.Click += new System.EventHandler(this.btnLimparHistorico_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(166, 305);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 334);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimparHistorico);
            this.Controls.Add(this.txtHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Button btnLimparHistorico;
        private System.Windows.Forms.Button btnFechar;
    }
}