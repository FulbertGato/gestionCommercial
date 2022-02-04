
namespace gestion_com_2022.views.ClientForm
{
    partial class PaiementFrm
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
            this.btn = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRefpaiement = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMontantReel = new System.Windows.Forms.Label();
            this.textTpe = new System.Windows.Forms.TextBox();
            this.textReferencePaiement = new System.Windows.Forms.TextBox();
            this.textMontantDu = new System.Windows.Forms.TextBox();
            this.textMontantPayer = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(645, 52);
            this.btn.TabIndex = 3;
            this.btn.Text = "BOUTIQUE NASA  PAIEMENT";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(26, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(77, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type paiement";
            // 
            // lblRefpaiement
            // 
            this.lblRefpaiement.AutoSize = true;
            this.lblRefpaiement.Location = new System.Drawing.Point(329, 86);
            this.lblRefpaiement.Name = "lblRefpaiement";
            this.lblRefpaiement.Size = new System.Drawing.Size(103, 13);
            this.lblRefpaiement.TabIndex = 5;
            this.lblRefpaiement.Text = "Référence paiement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Montant payer ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // lblMontantReel
            // 
            this.lblMontantReel.AutoSize = true;
            this.lblMontantReel.Location = new System.Drawing.Point(26, 175);
            this.lblMontantReel.Name = "lblMontantReel";
            this.lblMontantReel.Size = new System.Drawing.Size(71, 13);
            this.lblMontantReel.TabIndex = 8;
            this.lblMontantReel.Text = "Montant Réél";
            // 
            // textTpe
            // 
            this.textTpe.Location = new System.Drawing.Point(29, 102);
            this.textTpe.Multiline = true;
            this.textTpe.Name = "textTpe";
            this.textTpe.Size = new System.Drawing.Size(243, 50);
            this.textTpe.TabIndex = 9;
            // 
            // textReferencePaiement
            // 
            this.textReferencePaiement.Location = new System.Drawing.Point(332, 102);
            this.textReferencePaiement.Multiline = true;
            this.textReferencePaiement.Name = "textReferencePaiement";
            this.textReferencePaiement.Size = new System.Drawing.Size(243, 50);
            this.textReferencePaiement.TabIndex = 10;
            // 
            // textMontantDu
            // 
            this.textMontantDu.Location = new System.Drawing.Point(29, 198);
            this.textMontantDu.Multiline = true;
            this.textMontantDu.Name = "textMontantDu";
            this.textMontantDu.ReadOnly = true;
            this.textMontantDu.Size = new System.Drawing.Size(243, 50);
            this.textMontantDu.TabIndex = 11;
            // 
            // textMontantPayer
            // 
            this.textMontantPayer.Location = new System.Drawing.Point(332, 198);
            this.textMontantPayer.Multiline = true;
            this.textMontantPayer.Name = "textMontantPayer";
            this.textMontantPayer.Size = new System.Drawing.Size(243, 50);
            this.textMontantPayer.TabIndex = 12;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(29, 264);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(546, 60);
            this.btnEnregistrer.TabIndex = 15;
            this.btnEnregistrer.Text = "Enregistrer paiement";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // PaiementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 368);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.textMontantPayer);
            this.Controls.Add(this.textMontantDu);
            this.Controls.Add(this.textReferencePaiement);
            this.Controls.Add(this.textTpe);
            this.Controls.Add(this.lblMontantReel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRefpaiement);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaiementFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaiementFrm";
            this.Load += new System.EventHandler(this.PaiementFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRefpaiement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMontantReel;
        private System.Windows.Forms.TextBox textTpe;
        private System.Windows.Forms.TextBox textReferencePaiement;
        private System.Windows.Forms.TextBox textMontantDu;
        private System.Windows.Forms.TextBox textMontantPayer;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}