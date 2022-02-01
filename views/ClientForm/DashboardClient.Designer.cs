
namespace gestion_com_2022.views.ClientForm
{
    partial class DashboardClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnShowCart = new System.Windows.Forms.Button();
            this.btnshowOrders = new System.Windows.Forms.Button();
            this.btnShowProduit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnShowAccount);
            this.panel1.Controls.Add(this.btnShowCart);
            this.panel1.Controls.Add(this.btnshowOrders);
            this.panel1.Controls.Add(this.btnShowProduit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 577);
            this.panel1.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.Red;
            this.btnSignOut.Location = new System.Drawing.Point(0, 529);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(199, 48);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Se deconnexter";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowAccount.Location = new System.Drawing.Point(0, 288);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(199, 48);
            this.btnShowAccount.TabIndex = 2;
            this.btnShowAccount.Text = "Mes informations";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            this.btnShowAccount.Leave += new System.EventHandler(this.btnShowAccount_Leave);
            // 
            // btnShowCart
            // 
            this.btnShowCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowCart.Location = new System.Drawing.Point(0, 240);
            this.btnShowCart.Name = "btnShowCart";
            this.btnShowCart.Size = new System.Drawing.Size(199, 48);
            this.btnShowCart.TabIndex = 2;
            this.btnShowCart.Text = "Panier";
            this.btnShowCart.UseVisualStyleBackColor = true;
            this.btnShowCart.Click += new System.EventHandler(this.btnShowCart_Click);
            this.btnShowCart.Leave += new System.EventHandler(this.btnShowCart_Leave);
            // 
            // btnshowOrders
            // 
            this.btnshowOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnshowOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnshowOrders.Location = new System.Drawing.Point(0, 192);
            this.btnshowOrders.Name = "btnshowOrders";
            this.btnshowOrders.Size = new System.Drawing.Size(199, 48);
            this.btnshowOrders.TabIndex = 2;
            this.btnshowOrders.Text = "Mes commandes";
            this.btnshowOrders.UseVisualStyleBackColor = true;
            this.btnshowOrders.Click += new System.EventHandler(this.btnshowOrders_Click);
            this.btnshowOrders.Leave += new System.EventHandler(this.btnshowOrders_Leave);
            // 
            // btnShowProduit
            // 
            this.btnShowProduit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowProduit.Location = new System.Drawing.Point(0, 144);
            this.btnShowProduit.Name = "btnShowProduit";
            this.btnShowProduit.Size = new System.Drawing.Size(199, 48);
            this.btnShowProduit.TabIndex = 2;
            this.btnShowProduit.Text = "Les produits";
            this.btnShowProduit.UseVisualStyleBackColor = true;
            this.btnShowProduit.Click += new System.EventHandler(this.btnShowProduit_Click);
            this.btnShowProduit.Leave += new System.EventHandler(this.btnShowProduit_leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 144);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(58, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "une texte ici";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(57, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gato junior";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(199, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(752, 577);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // DashboardClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardClient";
            this.Load += new System.EventHandler(this.DashboardClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnShowCart;
        private System.Windows.Forms.Button btnshowOrders;
        private System.Windows.Forms.Button btnShowProduit;
        private System.Windows.Forms.Panel panelContent;
    }
}