
namespace gestion_com_2022.views.ProductForm.component
{
    partial class productWidget
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productWidget));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.imgImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblProduitname = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.imgImage);
            this.bunifuPanel1.Controls.Add(this.lblPrix);
            this.bunifuPanel1.Controls.Add(this.lblProduitname);
            this.bunifuPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(379, 206);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // imgImage
            // 
            this.imgImage.AllowFocused = false;
            this.imgImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgImage.AutoSizeHeight = true;
            this.imgImage.BorderRadius = 50;
            this.imgImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgImage.Image = ((System.Drawing.Image)(resources.GetObject("imgImage.Image")));
            this.imgImage.IsCircle = false;
            this.imgImage.Location = new System.Drawing.Point(267, 52);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(101, 101);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImage.TabIndex = 2;
            this.imgImage.TabStop = false;
            this.imgImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.imgImage.Click += new System.EventHandler(this.imgImage_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrix.AutoSize = true;
            this.lblPrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrix.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.lblPrix.Location = new System.Drawing.Point(13, 153);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(131, 37);
            this.lblPrix.TabIndex = 1;
            this.lblPrix.Text = "5000 CFA";
            // 
            // lblProduitname
            // 
            this.lblProduitname.AutoSize = true;
            this.lblProduitname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProduitname.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduitname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.lblProduitname.Location = new System.Drawing.Point(15, 10);
            this.lblProduitname.Name = "lblProduitname";
            this.lblProduitname.Size = new System.Drawing.Size(144, 25);
            this.lblProduitname.TabIndex = 0;
            this.lblProduitname.Text = "Faire à repasser";
            // 
            // productWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "productWidget";
            this.Size = new System.Drawing.Size(382, 206);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Bunifu.UI.WinForms.BunifuPictureBox imgImage;
        public System.Windows.Forms.Label lblPrix;
        public System.Windows.Forms.Label lblProduitname;
    }
}
