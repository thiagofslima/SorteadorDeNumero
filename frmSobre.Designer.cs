namespace SorteadorDeNumero
{
    partial class frmSobre
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llbLinkedIn = new System.Windows.Forms.LinkLabel();
            this.llbGitHub = new System.Windows.Forms.LinkLabel();
            this.llbEmail = new System.Windows.Forms.LinkLabel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desenvolvido por Thiago Lima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contatos:";
            // 
            // llbLinkedIn
            // 
            this.llbLinkedIn.AutoSize = true;
            this.llbLinkedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLinkedIn.Location = new System.Drawing.Point(117, 126);
            this.llbLinkedIn.Name = "llbLinkedIn";
            this.llbLinkedIn.Size = new System.Drawing.Size(83, 17);
            this.llbLinkedIn.TabIndex = 4;
            this.llbLinkedIn.TabStop = true;
            this.llbLinkedIn.Text = "thiagofslima";
            this.llbLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLinkedIn_LinkClicked);
            // 
            // llbGitHub
            // 
            this.llbGitHub.AutoSize = true;
            this.llbGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGitHub.Location = new System.Drawing.Point(117, 169);
            this.llbGitHub.Name = "llbGitHub";
            this.llbGitHub.Size = new System.Drawing.Size(83, 17);
            this.llbGitHub.TabIndex = 5;
            this.llbGitHub.TabStop = true;
            this.llbGitHub.Text = "thiagofslima";
            this.llbGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGitHub_LinkClicked);
            // 
            // llbEmail
            // 
            this.llbEmail.AutoSize = true;
            this.llbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbEmail.Location = new System.Drawing.Point(117, 210);
            this.llbEmail.Name = "llbEmail";
            this.llbEmail.Size = new System.Drawing.Size(160, 17);
            this.llbEmail.TabIndex = 5;
            this.llbEmail.TabStop = true;
            this.llbEmail.Text = "thiagofslima@gmail.com";
            this.llbEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEmail_LinkClicked);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(105, 292);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::SorteadorDeNumero.Properties.Resources.email_32;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(8, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "E-mail:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::SorteadorDeNumero.Properties.Resources.github_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(8, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "GitHub:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::SorteadorDeNumero.Properties.Resources.linkedin_32;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "LinkedIn:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 334);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.llbEmail);
            this.Controls.Add(this.llbGitHub);
            this.Controls.Add(this.llbLinkedIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llbLinkedIn;
        private System.Windows.Forms.LinkLabel llbGitHub;
        private System.Windows.Forms.LinkLabel llbEmail;
        private System.Windows.Forms.Button btnFechar;
    }
}