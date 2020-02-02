namespace LogementForm
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
            this.button5 = new System.Windows.Forms.Button();
            this.gestionParcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnParcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.tBSurfMaison = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBLoyer = new System.Windows.Forms.TextBox();
            this.lbxLogements = new System.Windows.Forms.ListBox();
            this.btSupprimeLogement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBIdLog = new System.Windows.Forms.TextBox();
            this.gpParc = new System.Windows.Forms.GroupBox();
            this.lListeParc = new System.Windows.Forms.Label();
            this.lNomParc = new System.Windows.Forms.Label();
            this.lbidParc = new System.Windows.Forms.Label();
            this.lbxParcs = new System.Windows.Forms.ListBox();
            this.cbParc = new System.Windows.Forms.ComboBox();
            this.btSupprimerParc = new System.Windows.Forms.Button();
            this.btAjoputerParc = new System.Windows.Forms.Button();
            this.txParcNom = new System.Windows.Forms.TextBox();
            this.txParcId = new System.Windows.Forms.TextBox();
            this.bubtAffecterLogement = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAjouterLogement = new System.Windows.Forms.Button();
            this.tBAdrLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBNbPieces = new System.Windows.Forms.TextBox();
            this.btSupprimeLocataire = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tBIdLoc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxLocataires = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAjouteLocataire = new System.Windows.Forms.Button();
            this.tBRevenuMensLoc = new System.Windows.Forms.TextBox();
            this.tBNomLoc = new System.Windows.Forms.TextBox();
            this.gpParc.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(748, 434);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 35);
            this.button5.TabIndex = 15;
            this.button5.Text = "Affecter Locataire";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // gestionParcToolStripMenuItem
            // 
            this.gestionParcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnParcToolStripMenuItem});
            this.gestionParcToolStripMenuItem.Name = "gestionParcToolStripMenuItem";
            this.gestionParcToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.gestionParcToolStripMenuItem.Text = "Gestion Parc";
            // 
            // ajouterUnParcToolStripMenuItem
            // 
            this.ajouterUnParcToolStripMenuItem.Name = "ajouterUnParcToolStripMenuItem";
            this.ajouterUnParcToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.ajouterUnParcToolStripMenuItem.Text = "Ajouter un parc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Surface Terrain";
            // 
            // tBSurfMaison
            // 
            this.tBSurfMaison.Location = new System.Drawing.Point(198, 241);
            this.tBSurfMaison.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBSurfMaison.Name = "tBSurfMaison";
            this.tBSurfMaison.Size = new System.Drawing.Size(148, 26);
            this.tBSurfMaison.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loyer";
            // 
            // tBLoyer
            // 
            this.tBLoyer.Location = new System.Drawing.Point(518, 141);
            this.tBLoyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBLoyer.Name = "tBLoyer";
            this.tBLoyer.Size = new System.Drawing.Size(148, 26);
            this.tBLoyer.TabIndex = 8;
            // 
            // lbxLogements
            // 
            this.lbxLogements.FormattingEnabled = true;
            this.lbxLogements.ItemHeight = 20;
            this.lbxLogements.Location = new System.Drawing.Point(735, 29);
            this.lbxLogements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxLogements.Name = "lbxLogements";
            this.lbxLogements.Size = new System.Drawing.Size(1370, 244);
            this.lbxLogements.TabIndex = 5;
            // 
            // btSupprimeLogement
            // 
            this.btSupprimeLogement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSupprimeLogement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSupprimeLogement.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSupprimeLogement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSupprimeLogement.Location = new System.Drawing.Point(518, 243);
            this.btSupprimeLogement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSupprimeLogement.Name = "btSupprimeLogement";
            this.btSupprimeLogement.Size = new System.Drawing.Size(148, 31);
            this.btSupprimeLogement.TabIndex = 11;
            this.btSupprimeLogement.Text = "&Supprimer";
            this.btSupprimeLogement.UseVisualStyleBackColor = true;
            this.btSupprimeLogement.Click += new System.EventHandler(this.btSupprimeLogement_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id Log";
            // 
            // tBIdLog
            // 
            this.tBIdLog.Location = new System.Drawing.Point(38, 141);
            this.tBIdLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBIdLog.Name = "tBIdLog";
            this.tBIdLog.Size = new System.Drawing.Size(148, 26);
            this.tBIdLog.TabIndex = 5;
            // 
            // gpParc
            // 
            this.gpParc.Controls.Add(this.lListeParc);
            this.gpParc.Controls.Add(this.lNomParc);
            this.gpParc.Controls.Add(this.lbidParc);
            this.gpParc.Controls.Add(this.lbxParcs);
            this.gpParc.Controls.Add(this.cbParc);
            this.gpParc.Controls.Add(this.btSupprimerParc);
            this.gpParc.Controls.Add(this.btAjoputerParc);
            this.gpParc.Controls.Add(this.txParcNom);
            this.gpParc.Controls.Add(this.txParcId);
            this.gpParc.Location = new System.Drawing.Point(12, 864);
            this.gpParc.Name = "gpParc";
            this.gpParc.Size = new System.Drawing.Size(2113, 375);
            this.gpParc.TabIndex = 17;
            this.gpParc.TabStop = false;
            this.gpParc.Text = "Gestion Parc";
            // 
            // lListeParc
            // 
            this.lListeParc.AutoSize = true;
            this.lListeParc.Location = new System.Drawing.Point(358, 44);
            this.lListeParc.Name = "lListeParc";
            this.lListeParc.Size = new System.Drawing.Size(117, 20);
            this.lListeParc.TabIndex = 17;
            this.lListeParc.Text = "Liste des Parcs";
            // 
            // lNomParc
            // 
            this.lNomParc.AutoSize = true;
            this.lNomParc.Location = new System.Drawing.Point(190, 44);
            this.lNomParc.Name = "lNomParc";
            this.lNomParc.Size = new System.Drawing.Size(42, 20);
            this.lNomParc.TabIndex = 16;
            this.lNomParc.Text = "Nom";
            // 
            // lbidParc
            // 
            this.lbidParc.AutoSize = true;
            this.lbidParc.Location = new System.Drawing.Point(30, 45);
            this.lbidParc.Name = "lbidParc";
            this.lbidParc.Size = new System.Drawing.Size(59, 20);
            this.lbidParc.TabIndex = 15;
            this.lbidParc.Text = "Id Parc";
            // 
            // lbxParcs
            // 
            this.lbxParcs.FormattingEnabled = true;
            this.lbxParcs.ItemHeight = 20;
            this.lbxParcs.Location = new System.Drawing.Point(727, 71);
            this.lbxParcs.Name = "lbxParcs";
            this.lbxParcs.Size = new System.Drawing.Size(1378, 264);
            this.lbxParcs.TabIndex = 14;
            // 
            // cbParc
            // 
            this.cbParc.FormattingEnabled = true;
            this.cbParc.Location = new System.Drawing.Point(358, 71);
            this.cbParc.Name = "cbParc";
            this.cbParc.Size = new System.Drawing.Size(308, 28);
            this.cbParc.TabIndex = 2;
            // 
            // btSupprimerParc
            // 
            this.btSupprimerParc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSupprimerParc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSupprimerParc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSupprimerParc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSupprimerParc.Location = new System.Drawing.Point(190, 133);
            this.btSupprimerParc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSupprimerParc.Name = "btSupprimerParc";
            this.btSupprimerParc.Size = new System.Drawing.Size(148, 31);
            this.btSupprimerParc.TabIndex = 4;
            this.btSupprimerParc.Text = "&Supprimer";
            this.btSupprimerParc.UseVisualStyleBackColor = true;
            this.btSupprimerParc.Click += new System.EventHandler(this.btSupprimerParc_Click);
            // 
            // btAjoputerParc
            // 
            this.btAjoputerParc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btAjoputerParc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAjoputerParc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAjoputerParc.Location = new System.Drawing.Point(30, 133);
            this.btAjoputerParc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAjoputerParc.Name = "btAjoputerParc";
            this.btAjoputerParc.Size = new System.Drawing.Size(148, 31);
            this.btAjoputerParc.TabIndex = 3;
            this.btAjoputerParc.Text = "&Ajouter";
            this.btAjoputerParc.UseVisualStyleBackColor = true;
            this.btAjoputerParc.Click += new System.EventHandler(this.btAjoputerParc_Click);
            // 
            // txParcNom
            // 
            this.txParcNom.Location = new System.Drawing.Point(190, 71);
            this.txParcNom.Name = "txParcNom";
            this.txParcNom.Size = new System.Drawing.Size(148, 26);
            this.txParcNom.TabIndex = 1;
            // 
            // txParcId
            // 
            this.txParcId.Location = new System.Drawing.Point(30, 71);
            this.txParcId.Name = "txParcId";
            this.txParcId.Size = new System.Drawing.Size(148, 26);
            this.txParcId.TabIndex = 0;
            // 
            // bubtAffecterLogement
            // 
            this.bubtAffecterLogement.Location = new System.Drawing.Point(739, 821);
            this.bubtAffecterLogement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bubtAffecterLogement.Name = "bubtAffecterLogement";
            this.bubtAffecterLogement.Size = new System.Drawing.Size(192, 35);
            this.bubtAffecterLogement.TabIndex = 18;
            this.bubtAffecterLogement.Text = "Affecter Logement";
            this.bubtAffecterLogement.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionParcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2172, 33);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre pieces";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adresse Log";
            // 
            // btAjouterLogement
            // 
            this.btAjouterLogement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btAjouterLogement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAjouterLogement.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAjouterLogement.Location = new System.Drawing.Point(354, 241);
            this.btAjouterLogement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAjouterLogement.Name = "btAjouterLogement";
            this.btAjouterLogement.Size = new System.Drawing.Size(148, 31);
            this.btAjouterLogement.TabIndex = 10;
            this.btAjouterLogement.Text = "&Ajouter";
            this.btAjouterLogement.UseVisualStyleBackColor = true;
            this.btAjouterLogement.Click += new System.EventHandler(this.btAjouterLogement_Click);
            // 
            // tBAdrLog
            // 
            this.tBAdrLog.Location = new System.Drawing.Point(198, 141);
            this.tBAdrLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBAdrLog.Name = "tBAdrLog";
            this.tBAdrLog.Size = new System.Drawing.Size(148, 26);
            this.tBAdrLog.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tBSurfMaison);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tBLoyer);
            this.groupBox2.Controls.Add(this.lbxLogements);
            this.groupBox2.Controls.Add(this.btSupprimeLogement);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tBIdLog);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btAjouterLogement);
            this.groupBox2.Controls.Add(this.tBNbPieces);
            this.groupBox2.Controls.Add(this.tBAdrLog);
            this.groupBox2.Location = new System.Drawing.Point(12, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(2113, 332);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestion Logements";
            // 
            // tBNbPieces
            // 
            this.tBNbPieces.Location = new System.Drawing.Point(354, 141);
            this.tBNbPieces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBNbPieces.Name = "tBNbPieces";
            this.tBNbPieces.Size = new System.Drawing.Size(148, 26);
            this.tBNbPieces.TabIndex = 7;
            // 
            // btSupprimeLocataire
            // 
            this.btSupprimeLocataire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSupprimeLocataire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSupprimeLocataire.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSupprimeLocataire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSupprimeLocataire.Location = new System.Drawing.Point(510, 255);
            this.btSupprimeLocataire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSupprimeLocataire.Name = "btSupprimeLocataire";
            this.btSupprimeLocataire.Size = new System.Drawing.Size(148, 31);
            this.btSupprimeLocataire.TabIndex = 4;
            this.btSupprimeLocataire.Text = "&Supprimer";
            this.btSupprimeLocataire.UseVisualStyleBackColor = true;
            this.btSupprimeLocataire.Click += new System.EventHandler(this.btSupprimeLocataire_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Id Loc";
            // 
            // tBIdLoc
            // 
            this.tBIdLoc.Location = new System.Drawing.Point(190, 186);
            this.tBIdLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBIdLoc.Name = "tBIdLoc";
            this.tBIdLoc.Size = new System.Drawing.Size(148, 26);
            this.tBIdLoc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSupprimeLocataire);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tBIdLoc);
            this.groupBox1.Controls.Add(this.lbxLocataires);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAjouteLocataire);
            this.groupBox1.Controls.Add(this.tBRevenuMensLoc);
            this.groupBox1.Controls.Add(this.tBNomLoc);
            this.groupBox1.Location = new System.Drawing.Point(20, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1553, 338);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion Hommes";
            // 
            // lbxLocataires
            // 
            this.lbxLocataires.FormattingEnabled = true;
            this.lbxLocataires.ItemHeight = 20;
            this.lbxLocataires.Location = new System.Drawing.Point(735, 42);
            this.lbxLocataires.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxLocataires.Name = "lbxLocataires";
            this.lbxLocataires.Size = new System.Drawing.Size(792, 244);
            this.lbxLocataires.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Revenu Mens Loc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Loc";
            // 
            // btAjouteLocataire
            // 
            this.btAjouteLocataire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btAjouteLocataire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAjouteLocataire.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAjouteLocataire.Location = new System.Drawing.Point(346, 255);
            this.btAjouteLocataire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAjouteLocataire.Name = "btAjouteLocataire";
            this.btAjouteLocataire.Size = new System.Drawing.Size(148, 31);
            this.btAjouteLocataire.TabIndex = 3;
            this.btAjouteLocataire.Text = "&Ajouter";
            this.btAjouteLocataire.UseVisualStyleBackColor = true;
            this.btAjouteLocataire.Click += new System.EventHandler(this.btAjouteLocataire_Click);
            // 
            // tBRevenuMensLoc
            // 
            this.tBRevenuMensLoc.Location = new System.Drawing.Point(510, 186);
            this.tBRevenuMensLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBRevenuMensLoc.Name = "tBRevenuMensLoc";
            this.tBRevenuMensLoc.Size = new System.Drawing.Size(148, 26);
            this.tBRevenuMensLoc.TabIndex = 2;
            // 
            // tBNomLoc
            // 
            this.tBNomLoc.Location = new System.Drawing.Point(346, 186);
            this.tBNomLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBNomLoc.Name = "tBNomLoc";
            this.tBNomLoc.Size = new System.Drawing.Size(148, 26);
            this.tBNomLoc.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2172, 1293);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gpParc);
            this.Controls.Add(this.bubtAffecterLogement);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpParc.ResumeLayout(false);
            this.gpParc.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem gestionParcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnParcToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBSurfMaison;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBLoyer;
        private System.Windows.Forms.ListBox lbxLogements;
        private System.Windows.Forms.Button btSupprimeLogement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBIdLog;
        private System.Windows.Forms.GroupBox gpParc;
        private System.Windows.Forms.Label lListeParc;
        private System.Windows.Forms.Label lNomParc;
        private System.Windows.Forms.Label lbidParc;
        private System.Windows.Forms.ListBox lbxParcs;
        private System.Windows.Forms.ComboBox cbParc;
        private System.Windows.Forms.Button btSupprimerParc;
        private System.Windows.Forms.Button btAjoputerParc;
        private System.Windows.Forms.TextBox txParcNom;
        private System.Windows.Forms.TextBox txParcId;
        private System.Windows.Forms.Button bubtAffecterLogement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAjouterLogement;
        private System.Windows.Forms.TextBox tBAdrLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBNbPieces;
        private System.Windows.Forms.Button btSupprimeLocataire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBIdLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxLocataires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAjouteLocataire;
        private System.Windows.Forms.TextBox tBRevenuMensLoc;
        private System.Windows.Forms.TextBox tBNomLoc;
    }
}

