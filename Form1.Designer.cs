namespace ProjetIP
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbIP1 = new System.Windows.Forms.TextBox();
            this.tbIP2 = new System.Windows.Forms.TextBox();
            this.tbIP3 = new System.Windows.Forms.TextBox();
            this.tbIP4 = new System.Windows.Forms.TextBox();
            this.tbCIDR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDetailIP = new System.Windows.Forms.Button();
            this.lbReseau = new System.Windows.Forms.Label();
            this.lbDiffusion = new System.Windows.Forms.Label();
            this.lbPlage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMasque = new System.Windows.Forms.Label();
            this.lbHote = new System.Windows.Forms.Label();
            this.lbErreur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIP1
            // 
            this.tbIP1.Location = new System.Drawing.Point(41, 22);
            this.tbIP1.MaxLength = 3;
            this.tbIP1.Name = "tbIP1";
            this.tbIP1.Size = new System.Drawing.Size(33, 20);
            this.tbIP1.TabIndex = 1;
            // 
            // tbIP2
            // 
            this.tbIP2.Location = new System.Drawing.Point(80, 22);
            this.tbIP2.MaxLength = 3;
            this.tbIP2.Name = "tbIP2";
            this.tbIP2.Size = new System.Drawing.Size(33, 20);
            this.tbIP2.TabIndex = 2;
            // 
            // tbIP3
            // 
            this.tbIP3.Location = new System.Drawing.Point(119, 22);
            this.tbIP3.MaxLength = 3;
            this.tbIP3.Name = "tbIP3";
            this.tbIP3.Size = new System.Drawing.Size(33, 20);
            this.tbIP3.TabIndex = 3;
            // 
            // tbIP4
            // 
            this.tbIP4.Location = new System.Drawing.Point(158, 22);
            this.tbIP4.MaxLength = 3;
            this.tbIP4.Name = "tbIP4";
            this.tbIP4.Size = new System.Drawing.Size(33, 20);
            this.tbIP4.TabIndex = 4;
            // 
            // tbCIDR
            // 
            this.tbCIDR.Location = new System.Drawing.Point(218, 22);
            this.tbCIDR.MaxLength = 2;
            this.tbCIDR.Name = "tbCIDR";
            this.tbCIDR.Size = new System.Drawing.Size(33, 20);
            this.tbCIDR.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // btDetailIP
            // 
            this.btDetailIP.Location = new System.Drawing.Point(278, 13);
            this.btDetailIP.Name = "btDetailIP";
            this.btDetailIP.Size = new System.Drawing.Size(91, 36);
            this.btDetailIP.TabIndex = 7;
            this.btDetailIP.Text = "Détails IP";
            this.btDetailIP.UseVisualStyleBackColor = true;
            this.btDetailIP.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbReseau
            // 
            this.lbReseau.AutoSize = true;
            this.lbReseau.Location = new System.Drawing.Point(12, 105);
            this.lbReseau.Name = "lbReseau";
            this.lbReseau.Size = new System.Drawing.Size(50, 13);
            this.lbReseau.TabIndex = 8;
            this.lbReseau.Text = "@réseau";
            // 
            // lbDiffusion
            // 
            this.lbDiffusion.AutoSize = true;
            this.lbDiffusion.Location = new System.Drawing.Point(12, 128);
            this.lbDiffusion.Name = "lbDiffusion";
            this.lbDiffusion.Size = new System.Drawing.Size(57, 13);
            this.lbDiffusion.TabIndex = 9;
            this.lbDiffusion.Text = "@diffusion";
            // 
            // lbPlage
            // 
            this.lbPlage.AutoSize = true;
            this.lbPlage.Location = new System.Drawing.Point(12, 152);
            this.lbPlage.Name = "lbPlage";
            this.lbPlage.Size = new System.Drawing.Size(44, 13);
            this.lbPlage.TabIndex = 10;
            this.lbPlage.Text = "@plage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "IP :";
            // 
            // lbMasque
            // 
            this.lbMasque.AutoSize = true;
            this.lbMasque.Location = new System.Drawing.Point(12, 81);
            this.lbMasque.Name = "lbMasque";
            this.lbMasque.Size = new System.Drawing.Size(44, 13);
            this.lbMasque.TabIndex = 12;
            this.lbMasque.Text = "masque";
            // 
            // lbHote
            // 
            this.lbHote.AutoSize = true;
            this.lbHote.Location = new System.Drawing.Point(12, 174);
            this.lbHote.Name = "lbHote";
            this.lbHote.Size = new System.Drawing.Size(28, 13);
            this.lbHote.TabIndex = 13;
            this.lbHote.Text = "hote";
            // 
            // lbErreur
            // 
            this.lbErreur.AutoSize = true;
            this.lbErreur.Location = new System.Drawing.Point(35, 53);
            this.lbErreur.Name = "lbErreur";
            this.lbErreur.Size = new System.Drawing.Size(0, 13);
            this.lbErreur.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "CIDR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbErreur);
            this.Controls.Add(this.lbHote);
            this.Controls.Add(this.lbMasque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPlage);
            this.Controls.Add(this.lbDiffusion);
            this.Controls.Add(this.lbReseau);
            this.Controls.Add(this.btDetailIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCIDR);
            this.Controls.Add(this.tbIP4);
            this.Controls.Add(this.tbIP3);
            this.Controls.Add(this.tbIP2);
            this.Controls.Add(this.tbIP1);
            this.Name = "Form1";
            this.Text = "IP analyser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP1;
        private System.Windows.Forms.TextBox tbIP2;
        private System.Windows.Forms.TextBox tbIP3;
        private System.Windows.Forms.TextBox tbIP4;
        private System.Windows.Forms.TextBox tbCIDR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDetailIP;
        private System.Windows.Forms.Label lbReseau;
        private System.Windows.Forms.Label lbDiffusion;
        private System.Windows.Forms.Label lbPlage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMasque;
        private System.Windows.Forms.Label lbHote;
        private System.Windows.Forms.Label lbErreur;
        private System.Windows.Forms.Label label2;
    }
}

