
namespace gestion_com_2022.views.CommandeForm
{
    partial class CommandeDetailFrm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetoure = new System.Windows.Forms.Button();
            this.btnPayCommande = new System.Windows.Forms.Button();
            this.txtbTotalCmde = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvProduitsCmdes = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.grpBoxProduit = new System.Windows.Forms.GroupBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbCmdAdresse = new System.Windows.Forms.TextBox();
            this.txtbCmdNomComplet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCmdTel = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte_Com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduitsCmdes)).BeginInit();
            this.grpBoxProduit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnRetoure);
            this.groupBox2.Controls.Add(this.btnPayCommande);
            this.groupBox2.Controls.Add(this.txtbTotalCmde);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.grpBoxProduit);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 553);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details commande";
            // 
            // btnRetoure
            // 
            this.btnRetoure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnRetoure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetoure.ForeColor = System.Drawing.Color.White;
            this.btnRetoure.Location = new System.Drawing.Point(419, 519);
            this.btnRetoure.Name = "btnRetoure";
            this.btnRetoure.Size = new System.Drawing.Size(117, 32);
            this.btnRetoure.TabIndex = 27;
            this.btnRetoure.Text = "Retour";
            this.btnRetoure.UseVisualStyleBackColor = false;
            this.btnRetoure.Click += new System.EventHandler(this.btnRetoure_Click);
            // 
            // btnPayCommande
            // 
            this.btnPayCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPayCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayCommande.ForeColor = System.Drawing.Color.White;
            this.btnPayCommande.Location = new System.Drawing.Point(549, 519);
            this.btnPayCommande.Name = "btnPayCommande";
            this.btnPayCommande.Size = new System.Drawing.Size(117, 32);
            this.btnPayCommande.TabIndex = 14;
            this.btnPayCommande.Text = "Payer";
            this.btnPayCommande.UseVisualStyleBackColor = false;
            // 
            // txtbTotalCmde
            // 
            this.txtbTotalCmde.Enabled = false;
            this.txtbTotalCmde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTotalCmde.ForeColor = System.Drawing.Color.Red;
            this.txtbTotalCmde.Location = new System.Drawing.Point(97, 492);
            this.txtbTotalCmde.Name = "txtbTotalCmde";
            this.txtbTotalCmde.Size = new System.Drawing.Size(149, 29);
            this.txtbTotalCmde.TabIndex = 26;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvProduitsCmdes);
            this.groupBox5.Location = new System.Drawing.Point(19, 291);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(644, 183);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Produits Commandés";
            // 
            // dtgvProduitsCmdes
            // 
            this.dtgvProduitsCmdes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduitsCmdes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Libelle,
            this.Prix,
            this.Qte_Com,
            this.Montant});
            this.dtgvProduitsCmdes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProduitsCmdes.Location = new System.Drawing.Point(3, 22);
            this.dtgvProduitsCmdes.Name = "dtgvProduitsCmdes";
            this.dtgvProduitsCmdes.Size = new System.Drawing.Size(638, 158);
            this.dtgvProduitsCmdes.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total";
            // 
            // grpBoxProduit
            // 
            this.grpBoxProduit.Controls.Add(this.btnDate);
            this.grpBoxProduit.Controls.Add(this.btnStatus);
            this.grpBoxProduit.Location = new System.Drawing.Point(22, 140);
            this.grpBoxProduit.Name = "grpBoxProduit";
            this.grpBoxProduit.Size = new System.Drawing.Size(644, 147);
            this.grpBoxProduit.TabIndex = 20;
            this.grpBoxProduit.TabStop = false;
            this.grpBoxProduit.Text = "Données Commande";
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.ForeColor = System.Drawing.Color.White;
            this.btnDate.Location = new System.Drawing.Point(508, 25);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(117, 32);
            this.btnDate.TabIndex = 28;
            this.btnDate.Text = "12 - 14 - 2022";
            this.btnDate.UseVisualStyleBackColor = false;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(6, 25);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(117, 32);
            this.btnStatus.TabIndex = 27;
            this.btnStatus.Text = "En Attente";
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtbCmdAdresse);
            this.groupBox3.Controls.Add(this.txtbCmdNomComplet);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtbCmdTel);
            this.groupBox3.Location = new System.Drawing.Point(19, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 110);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Données Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nom et Prenom";
            // 
            // txtbCmdAdresse
            // 
            this.txtbCmdAdresse.Enabled = false;
            this.txtbCmdAdresse.Location = new System.Drawing.Point(400, 45);
            this.txtbCmdAdresse.Multiline = true;
            this.txtbCmdAdresse.Name = "txtbCmdAdresse";
            this.txtbCmdAdresse.Size = new System.Drawing.Size(228, 55);
            this.txtbCmdAdresse.TabIndex = 14;
            // 
            // txtbCmdNomComplet
            // 
            this.txtbCmdNomComplet.Enabled = false;
            this.txtbCmdNomComplet.Location = new System.Drawing.Point(162, 62);
            this.txtbCmdNomComplet.Name = "txtbCmdNomComplet";
            this.txtbCmdNomComplet.Size = new System.Drawing.Size(148, 26);
            this.txtbCmdNomComplet.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telephone";
            // 
            // txtbCmdTel
            // 
            this.txtbCmdTel.Location = new System.Drawing.Point(162, 27);
            this.txtbCmdTel.Name = "txtbCmdTel";
            this.txtbCmdTel.Size = new System.Drawing.Size(148, 26);
            this.txtbCmdTel.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Libelle
            // 
            this.Libelle.DataPropertyName = "produitLibelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "produitPrix";
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // Qte_Com
            // 
            this.Qte_Com.DataPropertyName = "Qte1";
            this.Qte_Com.HeaderText = "Quantité Commandée";
            this.Qte_Com.Name = "Qte_Com";
            this.Qte_Com.Width = 150;
            // 
            // Montant
            // 
            this.Montant.DataPropertyName = "produitMontant";
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.Width = 140;
            // 
            // CommandeDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 577);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommandeDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommandeDetailFrm";
            this.Load += new System.EventHandler(this.CommandeDetailFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduitsCmdes)).EndInit();
            this.grpBoxProduit.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPayCommande;
        private System.Windows.Forms.TextBox txtbTotalCmde;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvProduitsCmdes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpBoxProduit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbCmdAdresse;
        private System.Windows.Forms.TextBox txtbCmdNomComplet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCmdTel;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnRetoure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte_Com;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
    }
}