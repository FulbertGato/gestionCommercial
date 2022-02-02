
namespace gestion_com_2022.views.ClientForm
{
    partial class AccountInformation
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
            this.panelinformations = new System.Windows.Forms.Panel();
            this.soldeBtn = new System.Windows.Forms.Button();
            this.updateInfosBtn = new System.Windows.Forms.Button();
            this.textAddresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomComplet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panelinformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelinformations
            // 
            this.panelinformations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelinformations.Controls.Add(this.labelError);
            this.panelinformations.Controls.Add(this.soldeBtn);
            this.panelinformations.Controls.Add(this.updateInfosBtn);
            this.panelinformations.Controls.Add(this.textAddresse);
            this.panelinformations.Controls.Add(this.label4);
            this.panelinformations.Controls.Add(this.textTelephone);
            this.panelinformations.Controls.Add(this.label3);
            this.panelinformations.Controls.Add(this.textEmail);
            this.panelinformations.Controls.Add(this.label2);
            this.panelinformations.Controls.Add(this.textNomComplet);
            this.panelinformations.Controls.Add(this.label1);
            this.panelinformations.Controls.Add(this.labelText);
            this.panelinformations.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelinformations.Location = new System.Drawing.Point(0, 0);
            this.panelinformations.Name = "panelinformations";
            this.panelinformations.Size = new System.Drawing.Size(344, 577);
            this.panelinformations.TabIndex = 0;
            this.panelinformations.UseWaitCursor = true;
            // 
            // soldeBtn
            // 
            this.soldeBtn.BackColor = System.Drawing.Color.Gray;
            this.soldeBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.soldeBtn.FlatAppearance.BorderSize = 0;
            this.soldeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldeBtn.ForeColor = System.Drawing.Color.White;
            this.soldeBtn.Location = new System.Drawing.Point(6, 82);
            this.soldeBtn.Name = "soldeBtn";
            this.soldeBtn.Size = new System.Drawing.Size(147, 45);
            this.soldeBtn.TabIndex = 7;
            this.soldeBtn.Text = "Solde : 100000";
            this.soldeBtn.UseVisualStyleBackColor = false;
            this.soldeBtn.UseWaitCursor = true;
            // 
            // updateInfosBtn
            // 
            this.updateInfosBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.updateInfosBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.updateInfosBtn.FlatAppearance.BorderSize = 0;
            this.updateInfosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateInfosBtn.ForeColor = System.Drawing.Color.White;
            this.updateInfosBtn.Location = new System.Drawing.Point(6, 498);
            this.updateInfosBtn.Name = "updateInfosBtn";
            this.updateInfosBtn.Size = new System.Drawing.Size(329, 35);
            this.updateInfosBtn.TabIndex = 6;
            this.updateInfosBtn.Text = "Mettre a jour";
            this.updateInfosBtn.UseVisualStyleBackColor = false;
            this.updateInfosBtn.UseWaitCursor = true;
            this.updateInfosBtn.Click += new System.EventHandler(this.updateInformation);
            // 
            // textAddresse
            // 
            this.textAddresse.Location = new System.Drawing.Point(3, 441);
            this.textAddresse.Multiline = true;
            this.textAddresse.Name = "textAddresse";
            this.textAddresse.Size = new System.Drawing.Size(332, 36);
            this.textAddresse.TabIndex = 2;
            this.textAddresse.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Addresse";
            this.label4.UseWaitCursor = true;
            // 
            // textTelephone
            // 
            this.textTelephone.Location = new System.Drawing.Point(3, 377);
            this.textTelephone.Multiline = true;
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(326, 36);
            this.textTelephone.TabIndex = 2;
            this.textTelephone.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Téléphone";
            this.label3.UseWaitCursor = true;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(3, 312);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(326, 36);
            this.textEmail.TabIndex = 2;
            this.textEmail.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.UseWaitCursor = true;
            // 
            // textNomComplet
            // 
            this.textNomComplet.Location = new System.Drawing.Point(3, 248);
            this.textNomComplet.Multiline = true;
            this.textNomComplet.Name = "textNomComplet";
            this.textNomComplet.Size = new System.Drawing.Size(326, 36);
            this.textNomComplet.TabIndex = 2;
            this.textNomComplet.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Complet";
            this.label1.UseWaitCursor = true;
            // 
            // labelText
            // 
            this.labelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelText.Location = new System.Drawing.Point(3, 3);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(338, 73);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Mes informations personnelles";
            this.labelText.UseVisualStyleBackColor = false;
            this.labelText.UseWaitCursor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(22, 189);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(254, 27);
            this.labelError.TabIndex = 15;
            this.labelError.Text = "Verifier votre saisie";
            // 
            // AccountInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 577);
            this.Controls.Add(this.panelinformations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountInformation";
            this.Load += new System.EventHandler(this.AccountInformation_Load);
            this.panelinformations.ResumeLayout(false);
            this.panelinformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinformations;
        private System.Windows.Forms.Button labelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomComplet;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAddresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateInfosBtn;
        private System.Windows.Forms.Button soldeBtn;
        private System.Windows.Forms.Label labelError;
    }
}