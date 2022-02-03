
namespace gestion_com_2022.views.ClientForm
{
    partial class ClientCommandeList
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
            this.dtgvCommande = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCommande
            // 
            this.dtgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.REFERENCE,
            this.DATE,
            this.MONTANT,
            this.ETAT,
            this.ADDRESSE});
            this.dtgvCommande.Location = new System.Drawing.Point(24, 25);
            this.dtgvCommande.Name = "dtgvCommande";
            this.dtgvCommande.Size = new System.Drawing.Size(704, 484);
            this.dtgvCommande.TabIndex = 1;
            this.dtgvCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCommande_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // REFERENCE
            // 
            this.REFERENCE.DataPropertyName = "Numero";
            this.REFERENCE.HeaderText = "REFERENCE";
            this.REFERENCE.Name = "REFERENCE";
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "Date";
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            // 
            // MONTANT
            // 
            this.MONTANT.DataPropertyName = "Montant";
            this.MONTANT.HeaderText = "MONTANT";
            this.MONTANT.Name = "MONTANT";
            // 
            // ETAT
            // 
            this.ETAT.DataPropertyName = "Etat";
            this.ETAT.HeaderText = "ETAT";
            this.ETAT.Name = "ETAT";
            // 
            // ADDRESSE
            // 
            this.ADDRESSE.DataPropertyName = "AdresseLivraison";
            this.ADDRESSE.HeaderText = "ADDRESSE";
            this.ADDRESSE.Name = "ADDRESSE";
            // 
            // ClientCommandeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 577);
            this.Controls.Add(this.dtgvCommande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientCommandeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientCommandeList";
            this.Load += new System.EventHandler(this.ClientCommandeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESSE;
    }
}