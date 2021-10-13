namespace memoire
{
    partial class ajouter_vendeur
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
            this.panel_ajout_vend = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.text_type_vend = new System.Windows.Forms.TextBox();
            this.btn_anuuler_ajout_fourn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_username_vend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_mdp_vend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_nom_vend = new System.Windows.Forms.TextBox();
            this.panel_ajout_vend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ajout_vend
            // 
            this.panel_ajout_vend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_ajout_vend.Controls.Add(this.label1);
            this.panel_ajout_vend.Controls.Add(this.text_type_vend);
            this.panel_ajout_vend.Controls.Add(this.btn_anuuler_ajout_fourn);
            this.panel_ajout_vend.Controls.Add(this.label2);
            this.panel_ajout_vend.Controls.Add(this.pictureBox2);
            this.panel_ajout_vend.Controls.Add(this.label5);
            this.panel_ajout_vend.Controls.Add(this.text_username_vend);
            this.panel_ajout_vend.Controls.Add(this.label4);
            this.panel_ajout_vend.Controls.Add(this.text_mdp_vend);
            this.panel_ajout_vend.Controls.Add(this.label3);
            this.panel_ajout_vend.Controls.Add(this.text_nom_vend);
            this.panel_ajout_vend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ajout_vend.Location = new System.Drawing.Point(0, 0);
            this.panel_ajout_vend.Name = "panel_ajout_vend";
            this.panel_ajout_vend.Size = new System.Drawing.Size(1122, 648);
            this.panel_ajout_vend.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(110, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "type:";
            // 
            // text_type_vend
            // 
            this.text_type_vend.BackColor = System.Drawing.Color.Teal;
            this.text_type_vend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_type_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_type_vend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_type_vend.Location = new System.Drawing.Point(387, 433);
            this.text_type_vend.Name = "text_type_vend";
            this.text_type_vend.Size = new System.Drawing.Size(244, 37);
            this.text_type_vend.TabIndex = 31;
            // 
            // btn_anuuler_ajout_fourn
            // 
            this.btn_anuuler_ajout_fourn.BackColor = System.Drawing.Color.Teal;
            this.btn_anuuler_ajout_fourn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anuuler_ajout_fourn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anuuler_ajout_fourn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_anuuler_ajout_fourn.Location = new System.Drawing.Point(707, 508);
            this.btn_anuuler_ajout_fourn.Name = "btn_anuuler_ajout_fourn";
            this.btn_anuuler_ajout_fourn.Size = new System.Drawing.Size(381, 67);
            this.btn_anuuler_ajout_fourn.TabIndex = 30;
            this.btn_anuuler_ajout_fourn.Text = "retour";
            this.btn_anuuler_ajout_fourn.UseVisualStyleBackColor = false;
            this.btn_anuuler_ajout_fourn.Click += new System.EventHandler(this.btn_anuuler_ajout_fourn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(727, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 47);
            this.label2.TabIndex = 29;
            this.label2.Text = "ajouter employé:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::memoire.Properties.Resources.person_ajout;
            this.pictureBox2.Location = new System.Drawing.Point(707, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(110, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "username:";
            // 
            // text_username_vend
            // 
            this.text_username_vend.BackColor = System.Drawing.Color.Teal;
            this.text_username_vend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_username_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_username_vend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_username_vend.Location = new System.Drawing.Point(387, 158);
            this.text_username_vend.Name = "text_username_vend";
            this.text_username_vend.Size = new System.Drawing.Size(244, 37);
            this.text_username_vend.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(110, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 37);
            this.label4.TabIndex = 21;
            this.label4.Text = "mot de passe:";
            // 
            // text_mdp_vend
            // 
            this.text_mdp_vend.BackColor = System.Drawing.Color.Teal;
            this.text_mdp_vend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_mdp_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mdp_vend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_mdp_vend.Location = new System.Drawing.Point(387, 251);
            this.text_mdp_vend.Name = "text_mdp_vend";
            this.text_mdp_vend.Size = new System.Drawing.Size(244, 37);
            this.text_mdp_vend.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(110, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "nom:";
            // 
            // text_nom_vend
            // 
            this.text_nom_vend.BackColor = System.Drawing.Color.Teal;
            this.text_nom_vend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_nom_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nom_vend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_nom_vend.Location = new System.Drawing.Point(387, 344);
            this.text_nom_vend.Name = "text_nom_vend";
            this.text_nom_vend.Size = new System.Drawing.Size(244, 37);
            this.text_nom_vend.TabIndex = 18;
            // 
            // ajouter_vendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 648);
            this.Controls.Add(this.panel_ajout_vend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ajouter_vendeur";
            this.Text = "ajouter_vendeur";
            this.panel_ajout_vend.ResumeLayout(false);
            this.panel_ajout_vend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_ajout_vend;
        public System.Windows.Forms.Button btn_anuuler_ajout_fourn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox text_username_vend;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox text_mdp_vend;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox text_nom_vend;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox text_type_vend;
    }
}