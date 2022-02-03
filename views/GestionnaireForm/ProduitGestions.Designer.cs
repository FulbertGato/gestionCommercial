
namespace gestion_com_2022.views.GestionnaireForm
{
    partial class ProduitGestions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSeuilStock = new System.Windows.Forms.Label();
            this.textSeuilStock = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddCat = new System.Windows.Forms.Button();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.txtbPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.txtbLibelle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvProduits = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteSeuile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelSeuilStock);
            this.groupBox1.Controls.Add(this.textSeuilStock);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.buttonAddCat);
            this.groupBox1.Controls.Add(this.textDescription);
            this.groupBox1.Controls.Add(this.btnUploadImage);
            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.cboCategorie);
            this.groupBox1.Controls.Add(this.labelCategorie);
            this.groupBox1.Controls.Add(this.labelPrix);
            this.groupBox1.Controls.Add(this.txtbPrix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.labelLibelle);
            this.groupBox1.Controls.Add(this.txtbLibelle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 816);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau ¨Produit";
            // 
            // labelSeuilStock
            // 
            this.labelSeuilStock.AutoSize = true;
            this.labelSeuilStock.Location = new System.Drawing.Point(32, 286);
            this.labelSeuilStock.Name = "labelSeuilStock";
            this.labelSeuilStock.Size = new System.Drawing.Size(89, 20);
            this.labelSeuilStock.TabIndex = 20;
            this.labelSeuilStock.Text = "Seuil Stock";
            // 
            // textSeuilStock
            // 
            this.textSeuilStock.Location = new System.Drawing.Point(36, 322);
            this.textSeuilStock.Name = "textSeuilStock";
            this.textSeuilStock.Size = new System.Drawing.Size(289, 26);
            this.textSeuilStock.TabIndex = 19;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(28, 416);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(89, 20);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description";
            // 
            // buttonAddCat
            // 
            this.buttonAddCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(122)))), ((int)(((byte)(139)))));
            this.buttonAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCat.ForeColor = System.Drawing.Color.White;
            this.buttonAddCat.Location = new System.Drawing.Point(275, 559);
            this.buttonAddCat.Name = "buttonAddCat";
            this.buttonAddCat.Size = new System.Drawing.Size(75, 32);
            this.buttonAddCat.TabIndex = 17;
            this.buttonAddCat.Text = "ADD";
            this.buttonAddCat.UseVisualStyleBackColor = false;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(23, 453);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(327, 71);
            this.textDescription.TabIndex = 16;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnUploadImage.Location = new System.Drawing.Point(128, 143);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(100, 32);
            this.btnUploadImage.TabIndex = 13;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(106, 25);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(153, 112);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 12;
            this.picAvatar.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(297, 606);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 32);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(208, 606);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 32);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(122)))), ((int)(((byte)(139)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(115, 606);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnAnnuler.Location = new System.Drawing.Point(22, 606);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 32);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(22, 562);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(247, 28);
            this.cboCategorie.TabIndex = 7;
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Location = new System.Drawing.Point(19, 527);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(78, 20);
            this.labelCategorie.TabIndex = 6;
            this.labelCategorie.Text = "Categorie";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(32, 351);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(34, 20);
            this.labelPrix.TabIndex = 5;
            this.labelPrix.Text = "Prix";
            // 
            // txtbPrix
            // 
            this.txtbPrix.Location = new System.Drawing.Point(36, 374);
            this.txtbPrix.Name = "txtbPrix";
            this.txtbPrix.Size = new System.Drawing.Size(289, 26);
            this.txtbPrix.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(34, 257);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(289, 26);
            this.txtStock.TabIndex = 2;
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Location = new System.Drawing.Point(28, 175);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(54, 20);
            this.labelLibelle.TabIndex = 1;
            this.labelLibelle.Text = "Libelle";
            // 
            // txtbLibelle
            // 
            this.txtbLibelle.Location = new System.Drawing.Point(33, 202);
            this.txtbLibelle.Name = "txtbLibelle";
            this.txtbLibelle.Size = new System.Drawing.Size(289, 26);
            this.txtbLibelle.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dtgvProduits);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(407, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 802);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des Produits";
            // 
            // dtgvProduits
            // 
            this.dtgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Libelle,
            this.Nom_Prenom,
            this.Login,
            this.Role,
            this.QteSeuile,
            this.Categorie});
            this.dtgvProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProduits.Location = new System.Drawing.Point(3, 22);
            this.dtgvProduits.Name = "dtgvProduits";
            this.dtgvProduits.Size = new System.Drawing.Size(674, 777);
            this.dtgvProduits.TabIndex = 0;
            this.dtgvProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.choixProduit);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Nom_Prenom
            // 
            this.Nom_Prenom.DataPropertyName = "Code";
            this.Nom_Prenom.HeaderText = "Reference";
            this.Nom_Prenom.Name = "Nom_Prenom";
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Prix";
            this.Login.HeaderText = "Prix";
            this.Login.Name = "Login";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Stock";
            this.Role.HeaderText = "QteStock";
            this.Role.Name = "Role";
            // 
            // QteSeuile
            // 
            this.QteSeuile.DataPropertyName = "SeuilStock";
            this.QteSeuile.HeaderText = "Qte seuile";
            this.QteSeuile.Name = "QteSeuile";
            // 
            // Categorie
            // 
            this.Categorie.DataPropertyName = "Description";
            this.Categorie.HeaderText = "Description";
            this.Categorie.Name = "Categorie";
            this.Categorie.Width = 110;
            // 
            // ProduitGestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 840);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduitGestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProduitGestions";
            this.Load += new System.EventHandler(this.ProduitGestions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox txtbPrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.TextBox txtbLibelle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAddCat;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label labelSeuilStock;
        private System.Windows.Forms.TextBox textSeuilStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvProduits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteSeuile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
    }
}