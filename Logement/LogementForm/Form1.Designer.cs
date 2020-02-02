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
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBIdLog = new System.Windows.Forms.TextBox();
            this.gpParc = new System.Windows.Forms.GroupBox();
            this.lListeParc = new System.Windows.Forms.Label();
            this.lNomParc = new System.Windows.Forms.Label();
            this.lbidParc = new System.Windows.Forms.Label();
            this.lbxParcs = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bubtAffecterLogement = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tBAdrLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBNbPieces = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tBIdLoc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxLocataires = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lbxLogements.Size = new System.Drawing.Size(800, 244);
            this.lbxLogements.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(518, 243);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "&Supprimer";
            this.button3.UseVisualStyleBackColor = true;
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
            this.gpParc.Controls.Add(this.comboBox1);
            this.gpParc.Controls.Add(this.button7);
            this.gpParc.Controls.Add(this.button6);
            this.gpParc.Controls.Add(this.textBox2);
            this.gpParc.Controls.Add(this.textBox1);
            this.gpParc.Location = new System.Drawing.Point(12, 864);
            this.gpParc.Name = "gpParc";
            this.gpParc.Size = new System.Drawing.Size(1553, 375);
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
            this.lbxParcs.Size = new System.Drawing.Size(800, 264);
            this.lbxParcs.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(358, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(190, 133);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 31);
            this.button7.TabIndex = 4;
            this.button7.Text = "&Supprimer";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(30, 133);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 31);
            this.button6.TabIndex = 3;
            this.button6.Text = "&Ajouter";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(1830, 33);
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
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(354, 241);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 31);
            this.button4.TabIndex = 10;
            this.button4.Text = "&Ajouter";
            this.button4.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tBIdLog);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.tBNbPieces);
            this.groupBox2.Controls.Add(this.tBAdrLog);
            this.groupBox2.Location = new System.Drawing.Point(12, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1561, 332);
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
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(510, 255);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Supprimer";
            this.button2.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tBIdLoc);
            this.groupBox1.Controls.Add(this.lbxLocataires);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(346, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Ajouter";
            this.button1.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(1830, 1286);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gpParc);
            this.Controls.Add(this.bubtAffecterLogement);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBIdLog;
        private System.Windows.Forms.GroupBox gpParc;
        private System.Windows.Forms.Label lListeParc;
        private System.Windows.Forms.Label lNomParc;
        private System.Windows.Forms.Label lbidParc;
        private System.Windows.Forms.ListBox lbxParcs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bubtAffecterLogement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tBAdrLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBNbPieces;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBIdLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxLocataires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBRevenuMensLoc;
        private System.Windows.Forms.TextBox tBNomLoc;
    }
}

