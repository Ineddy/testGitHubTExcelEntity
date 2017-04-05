namespace Texcel_TabControl
{
    partial class creerJeu
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
            this.lblJeu = new System.Windows.Forms.Label();
            this.lblDeveloppeur = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.lblClasseAge = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPlateforme = new System.Windows.Forms.Label();
            this.btnAjouterJeu = new System.Windows.Forms.Button();
            this.dgvPlateforme = new System.Windows.Forms.DataGridView();
            this.dgvNoPlateforme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNomPlateformes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTypePlateformes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumeroSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGenre = new System.Windows.Forms.DataGridView();
            this.dgvNoGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescriptionGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClassification = new System.Windows.Forms.DataGridView();
            this.dgvNoClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescriptionClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbConfigurationJeu = new System.Windows.Forms.RichTextBox();
            this.rtbDescriptionJeu = new System.Windows.Forms.RichTextBox();
            this.txtDeveloppeurJeu = new System.Windows.Forms.TextBox();
            this.txtNomJeu = new System.Windows.Forms.TextBox();
            this.dgvTheme = new System.Windows.Forms.DataGridView();
            this.dgvNoTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescriptionTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTheme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlateforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJeu
            // 
            this.lblJeu.AutoSize = true;
            this.lblJeu.Location = new System.Drawing.Point(40, 26);
            this.lblJeu.Name = "lblJeu";
            this.lblJeu.Size = new System.Drawing.Size(31, 17);
            this.lblJeu.TabIndex = 0;
            this.lblJeu.Text = "Jeu";
            // 
            // lblDeveloppeur
            // 
            this.lblDeveloppeur.AutoSize = true;
            this.lblDeveloppeur.Location = new System.Drawing.Point(40, 73);
            this.lblDeveloppeur.Name = "lblDeveloppeur";
            this.lblDeveloppeur.Size = new System.Drawing.Size(93, 17);
            this.lblDeveloppeur.TabIndex = 2;
            this.lblDeveloppeur.Text = "Développeur ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(40, 113);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(40, 214);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(92, 17);
            this.lblConfig.TabIndex = 9;
            this.lblConfig.Text = "Configuration";
            // 
            // lblClasseAge
            // 
            this.lblClasseAge.AutoSize = true;
            this.lblClasseAge.Location = new System.Drawing.Point(40, 318);
            this.lblClasseAge.Name = "lblClasseAge";
            this.lblClasseAge.Size = new System.Drawing.Size(82, 17);
            this.lblClasseAge.TabIndex = 11;
            this.lblClasseAge.Text = "Classe age ";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(40, 446);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(52, 17);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Genre ";
            // 
            // lblPlateforme
            // 
            this.lblPlateforme.AutoSize = true;
            this.lblPlateforme.Location = new System.Drawing.Point(40, 577);
            this.lblPlateforme.Name = "lblPlateforme";
            this.lblPlateforme.Size = new System.Drawing.Size(76, 17);
            this.lblPlateforme.TabIndex = 15;
            this.lblPlateforme.Text = "Plateforme";
            // 
            // btnAjouterJeu
            // 
            this.btnAjouterJeu.Location = new System.Drawing.Point(680, 916);
            this.btnAjouterJeu.Name = "btnAjouterJeu";
            this.btnAjouterJeu.Size = new System.Drawing.Size(75, 31);
            this.btnAjouterJeu.TabIndex = 17;
            this.btnAjouterJeu.Text = "Ajouter";
            this.btnAjouterJeu.UseVisualStyleBackColor = true;
            this.btnAjouterJeu.Click += new System.EventHandler(this.btnAjouterJeu_Click);
            // 
            // dgvPlateforme
            // 
            this.dgvPlateforme.AllowUserToAddRows = false;
            this.dgvPlateforme.AllowUserToDeleteRows = false;
            this.dgvPlateforme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPlateforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlateforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNoPlateforme,
            this.dgvNomPlateformes,
            this.dgvTypePlateformes,
            this.dgvNumeroSE});
            this.dgvPlateforme.Location = new System.Drawing.Point(368, 577);
            this.dgvPlateforme.Name = "dgvPlateforme";
            this.dgvPlateforme.RowHeadersWidth = 40;
            this.dgvPlateforme.RowTemplate.Height = 24;
            this.dgvPlateforme.Size = new System.Drawing.Size(387, 118);
            this.dgvPlateforme.TabIndex = 29;
            // 
            // dgvNoPlateforme
            // 
            this.dgvNoPlateforme.HeaderText = "No";
            this.dgvNoPlateforme.Name = "dgvNoPlateforme";
            // 
            // dgvNomPlateformes
            // 
            this.dgvNomPlateformes.FillWeight = 1F;
            this.dgvNomPlateformes.HeaderText = "Nom";
            this.dgvNomPlateformes.Name = "dgvNomPlateformes";
            this.dgvNomPlateformes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNomPlateformes.Width = 170;
            // 
            // dgvTypePlateformes
            // 
            this.dgvTypePlateformes.HeaderText = "Type";
            this.dgvTypePlateformes.Name = "dgvTypePlateformes";
            this.dgvTypePlateformes.Width = 170;
            // 
            // dgvNumeroSE
            // 
            this.dgvNumeroSE.HeaderText = "Numero OS";
            this.dgvNumeroSE.Name = "dgvNumeroSE";
            // 
            // dgvGenre
            // 
            this.dgvGenre.AllowUserToAddRows = false;
            this.dgvGenre.AllowUserToDeleteRows = false;
            this.dgvGenre.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNoGenre,
            this.dgvDescriptionGenre});
            this.dgvGenre.Location = new System.Drawing.Point(368, 446);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.RowHeadersWidth = 40;
            this.dgvGenre.RowTemplate.Height = 24;
            this.dgvGenre.Size = new System.Drawing.Size(387, 115);
            this.dgvGenre.TabIndex = 28;
            // 
            // dgvNoGenre
            // 
            this.dgvNoGenre.HeaderText = "No";
            this.dgvNoGenre.Name = "dgvNoGenre";
            // 
            // dgvDescriptionGenre
            // 
            this.dgvDescriptionGenre.HeaderText = "description";
            this.dgvDescriptionGenre.Name = "dgvDescriptionGenre";
            // 
            // dgvClassification
            // 
            this.dgvClassification.AllowUserToAddRows = false;
            this.dgvClassification.AllowUserToDeleteRows = false;
            this.dgvClassification.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClassification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNoClassification,
            this.dgvDescriptionClassification});
            this.dgvClassification.Location = new System.Drawing.Point(368, 318);
            this.dgvClassification.Name = "dgvClassification";
            this.dgvClassification.RowHeadersWidth = 40;
            this.dgvClassification.RowTemplate.Height = 24;
            this.dgvClassification.Size = new System.Drawing.Size(387, 115);
            this.dgvClassification.TabIndex = 27;
            // 
            // dgvNoClassification
            // 
            this.dgvNoClassification.HeaderText = "No";
            this.dgvNoClassification.Name = "dgvNoClassification";
            // 
            // dgvDescriptionClassification
            // 
            this.dgvDescriptionClassification.HeaderText = "description";
            this.dgvDescriptionClassification.Name = "dgvDescriptionClassification";
            // 
            // rtbConfigurationJeu
            // 
            this.rtbConfigurationJeu.Location = new System.Drawing.Point(368, 214);
            this.rtbConfigurationJeu.Name = "rtbConfigurationJeu";
            this.rtbConfigurationJeu.Size = new System.Drawing.Size(387, 87);
            this.rtbConfigurationJeu.TabIndex = 26;
            this.rtbConfigurationJeu.Text = "";
            // 
            // rtbDescriptionJeu
            // 
            this.rtbDescriptionJeu.Location = new System.Drawing.Point(368, 110);
            this.rtbDescriptionJeu.Name = "rtbDescriptionJeu";
            this.rtbDescriptionJeu.Size = new System.Drawing.Size(387, 80);
            this.rtbDescriptionJeu.TabIndex = 25;
            this.rtbDescriptionJeu.Text = "";
            // 
            // txtDeveloppeurJeu
            // 
            this.txtDeveloppeurJeu.Location = new System.Drawing.Point(368, 73);
            this.txtDeveloppeurJeu.Name = "txtDeveloppeurJeu";
            this.txtDeveloppeurJeu.Size = new System.Drawing.Size(387, 22);
            this.txtDeveloppeurJeu.TabIndex = 24;
            // 
            // txtNomJeu
            // 
            this.txtNomJeu.Location = new System.Drawing.Point(368, 26);
            this.txtNomJeu.Name = "txtNomJeu";
            this.txtNomJeu.Size = new System.Drawing.Size(387, 22);
            this.txtNomJeu.TabIndex = 23;
            // 
            // dgvTheme
            // 
            this.dgvTheme.AllowUserToAddRows = false;
            this.dgvTheme.AllowUserToDeleteRows = false;
            this.dgvTheme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNoTheme,
            this.dgvDescriptionTheme});
            this.dgvTheme.Location = new System.Drawing.Point(368, 747);
            this.dgvTheme.Name = "dgvTheme";
            this.dgvTheme.RowHeadersWidth = 40;
            this.dgvTheme.RowTemplate.Height = 24;
            this.dgvTheme.Size = new System.Drawing.Size(387, 115);
            this.dgvTheme.TabIndex = 30;
            // 
            // dgvNoTheme
            // 
            this.dgvNoTheme.HeaderText = "No";
            this.dgvNoTheme.Name = "dgvNoTheme";
            // 
            // dgvDescriptionTheme
            // 
            this.dgvDescriptionTheme.HeaderText = "description";
            this.dgvDescriptionTheme.Name = "dgvDescriptionTheme";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(40, 747);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(52, 17);
            this.lblTheme.TabIndex = 31;
            this.lblTheme.Text = "Theme";
            // 
            // creerJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 959);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.dgvTheme);
            this.Controls.Add(this.dgvPlateforme);
            this.Controls.Add(this.dgvGenre);
            this.Controls.Add(this.dgvClassification);
            this.Controls.Add(this.rtbConfigurationJeu);
            this.Controls.Add(this.rtbDescriptionJeu);
            this.Controls.Add(this.txtDeveloppeurJeu);
            this.Controls.Add(this.txtNomJeu);
            this.Controls.Add(this.btnAjouterJeu);
            this.Controls.Add(this.lblPlateforme);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblClasseAge);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDeveloppeur);
            this.Controls.Add(this.lblJeu);
            this.Name = "creerJeu";
            this.Text = "Ajouter un jeu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlateforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJeu;
        private System.Windows.Forms.Label lblDeveloppeur;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label lblClasseAge;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPlateforme;
        private System.Windows.Forms.Button btnAjouterJeu;
        private System.Windows.Forms.DataGridView dgvPlateforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNoPlateforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomPlateformes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTypePlateformes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroSE;
        private System.Windows.Forms.DataGridView dgvGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNoGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescriptionGenre;
        private System.Windows.Forms.DataGridView dgvClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNoClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescriptionClassification;
        private System.Windows.Forms.RichTextBox rtbConfigurationJeu;
        private System.Windows.Forms.RichTextBox rtbDescriptionJeu;
        private System.Windows.Forms.TextBox txtDeveloppeurJeu;
        private System.Windows.Forms.TextBox txtNomJeu;
        private System.Windows.Forms.DataGridView dgvTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNoTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescriptionTheme;
        private System.Windows.Forms.Label lblTheme;
    }
}