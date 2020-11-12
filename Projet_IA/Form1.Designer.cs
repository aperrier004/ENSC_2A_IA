namespace Projet_IA
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
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox_typeVent = new System.Windows.Forms.GroupBox();
            this.radioButton_c = new System.Windows.Forms.RadioButton();
            this.radioButton_b = new System.Windows.Forms.RadioButton();
            this.radioButton_a = new System.Windows.Forms.RadioButton();
            this.label_tpsTotalNav = new System.Windows.Forms.Label();
            this.textBox_tpsTotalNav = new System.Windows.Forms.TextBox();
            this.textBox_nbNoeuds = new System.Windows.Forms.TextBox();
            this.label_nbNoeuds = new System.Windows.Forms.Label();
            this.textBox_sommeNoeudsOF = new System.Windows.Forms.TextBox();
            this.label_sommeNoeudsOF = new System.Windows.Forms.Label();
            this.pictureBox_fondMarin = new System.Windows.Forms.PictureBox();
            this.label_consignePoint = new System.Windows.Forms.Label();
            this.label_ConsigneVent = new System.Windows.Forms.Label();
            this.label_feedback = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox_typeVent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fondMarin)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(91, 230);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 13;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox_typeVent
            // 
            this.groupBox_typeVent.Controls.Add(this.radioButton_c);
            this.groupBox_typeVent.Controls.Add(this.radioButton_b);
            this.groupBox_typeVent.Controls.Add(this.radioButton_a);
            this.groupBox_typeVent.Location = new System.Drawing.Point(578, 36);
            this.groupBox_typeVent.Name = "groupBox_typeVent";
            this.groupBox_typeVent.Size = new System.Drawing.Size(200, 137);
            this.groupBox_typeVent.TabIndex = 15;
            this.groupBox_typeVent.TabStop = false;
            this.groupBox_typeVent.Text = "Type de vent";
            this.groupBox_typeVent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton_c
            // 
            this.radioButton_c.AutoSize = true;
            this.radioButton_c.Location = new System.Drawing.Point(17, 88);
            this.radioButton_c.Name = "radioButton_c";
            this.radioButton_c.Size = new System.Drawing.Size(36, 21);
            this.radioButton_c.TabIndex = 2;
            this.radioButton_c.TabStop = true;
            this.radioButton_c.Text = "c";
            this.radioButton_c.UseVisualStyleBackColor = true;
            this.radioButton_c.CheckedChanged += new System.EventHandler(this.radioButton_c_CheckedChanged);
            // 
            // radioButton_b
            // 
            this.radioButton_b.AutoSize = true;
            this.radioButton_b.Location = new System.Drawing.Point(17, 61);
            this.radioButton_b.Name = "radioButton_b";
            this.radioButton_b.Size = new System.Drawing.Size(37, 21);
            this.radioButton_b.TabIndex = 1;
            this.radioButton_b.TabStop = true;
            this.radioButton_b.Text = "b";
            this.radioButton_b.UseVisualStyleBackColor = true;
            this.radioButton_b.CheckedChanged += new System.EventHandler(this.radioButton_b_CheckedChanged);
            // 
            // radioButton_a
            // 
            this.radioButton_a.AutoSize = true;
            this.radioButton_a.Location = new System.Drawing.Point(17, 34);
            this.radioButton_a.Name = "radioButton_a";
            this.radioButton_a.Size = new System.Drawing.Size(37, 21);
            this.radioButton_a.TabIndex = 0;
            this.radioButton_a.TabStop = true;
            this.radioButton_a.Text = "a";
            this.radioButton_a.UseVisualStyleBackColor = true;
            this.radioButton_a.CheckedChanged += new System.EventHandler(this.radioButton_a_CheckedChanged);
            this.radioButton_a.Click += new System.EventHandler(this.radioButton_a_Click);
            // 
            // label_tpsTotalNav
            // 
            this.label_tpsTotalNav.AutoSize = true;
            this.label_tpsTotalNav.Location = new System.Drawing.Point(27, 314);
            this.label_tpsTotalNav.Name = "label_tpsTotalNav";
            this.label_tpsTotalNav.Size = new System.Drawing.Size(179, 17);
            this.label_tpsTotalNav.TabIndex = 16;
            this.label_tpsTotalNav.Text = "Temps total de navigation :";
            // 
            // textBox_tpsTotalNav
            // 
            this.textBox_tpsTotalNav.Enabled = false;
            this.textBox_tpsTotalNav.Location = new System.Drawing.Point(66, 350);
            this.textBox_tpsTotalNav.Name = "textBox_tpsTotalNav";
            this.textBox_tpsTotalNav.Size = new System.Drawing.Size(100, 22);
            this.textBox_tpsTotalNav.TabIndex = 17;
            // 
            // textBox_nbNoeuds
            // 
            this.textBox_nbNoeuds.Enabled = false;
            this.textBox_nbNoeuds.Location = new System.Drawing.Point(66, 421);
            this.textBox_nbNoeuds.Name = "textBox_nbNoeuds";
            this.textBox_nbNoeuds.Size = new System.Drawing.Size(100, 22);
            this.textBox_nbNoeuds.TabIndex = 19;
            // 
            // label_nbNoeuds
            // 
            this.label_nbNoeuds.AutoSize = true;
            this.label_nbNoeuds.Location = new System.Drawing.Point(27, 389);
            this.label_nbNoeuds.Name = "label_nbNoeuds";
            this.label_nbNoeuds.Size = new System.Drawing.Size(258, 17);
            this.label_nbNoeuds.TabIndex = 18;
            this.label_nbNoeuds.Text = "Nombre des noeuds du chemin solution";
            // 
            // textBox_sommeNoeudsOF
            // 
            this.textBox_sommeNoeudsOF.Enabled = false;
            this.textBox_sommeNoeudsOF.Location = new System.Drawing.Point(66, 487);
            this.textBox_sommeNoeudsOF.Name = "textBox_sommeNoeudsOF";
            this.textBox_sommeNoeudsOF.Size = new System.Drawing.Size(100, 22);
            this.textBox_sommeNoeudsOF.TabIndex = 21;
            this.textBox_sommeNoeudsOF.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_sommeNoeudsOF
            // 
            this.label_sommeNoeudsOF.AutoSize = true;
            this.label_sommeNoeudsOF.Location = new System.Drawing.Point(27, 446);
            this.label_sommeNoeudsOF.Name = "label_sommeNoeudsOF";
            this.label_sommeNoeudsOF.Size = new System.Drawing.Size(317, 17);
            this.label_sommeNoeudsOF.TabIndex = 20;
            this.label_sommeNoeudsOF.Text = "Somme des noeuds des listes Ouverts et Fermés";
            this.label_sommeNoeudsOF.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox_fondMarin
            // 
            this.pictureBox_fondMarin.Image = global::Projet_IA.Properties.Resources.fond_marin1;
            this.pictureBox_fondMarin.Location = new System.Drawing.Point(434, 194);
            this.pictureBox_fondMarin.Name = "pictureBox_fondMarin";
            this.pictureBox_fondMarin.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_fondMarin.TabIndex = 12;
            this.pictureBox_fondMarin.TabStop = false;
            this.pictureBox_fondMarin.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox_fondMarin.DoubleClick += new System.EventHandler(this.pictureBox_fondMarin_DoubleClick);
            this.pictureBox_fondMarin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_fondMarin_MouseClick);
            this.pictureBox_fondMarin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_fondMarin_MouseDoubleClick);
            // 
            // label_consignePoint
            // 
            this.label_consignePoint.AutoSize = true;
            this.label_consignePoint.Location = new System.Drawing.Point(127, 49);
            this.label_consignePoint.Name = "label_consignePoint";
            this.label_consignePoint.Size = new System.Drawing.Size(440, 17);
            this.label_consignePoint.TabIndex = 22;
            this.label_consignePoint.Text = "Cliquez une seule fois sur l\'image pour paramétrer le point de départ";
            // 
            // label_ConsigneVent
            // 
            this.label_ConsigneVent.AutoSize = true;
            this.label_ConsigneVent.Location = new System.Drawing.Point(127, 112);
            this.label_ConsigneVent.Name = "label_ConsigneVent";
            this.label_ConsigneVent.Size = new System.Drawing.Size(191, 17);
            this.label_ConsigneVent.TabIndex = 23;
            this.label_ConsigneVent.Text = "Sélectionnez un type de vent";
            // 
            // label_feedback
            // 
            this.label_feedback.AutoSize = true;
            this.label_feedback.Location = new System.Drawing.Point(142, 156);
            this.label_feedback.Name = "label_feedback";
            this.label_feedback.Size = new System.Drawing.Size(0, 17);
            this.label_feedback.TabIndex = 24;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(211, 326);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label_feedback);
            this.Controls.Add(this.label_ConsigneVent);
            this.Controls.Add(this.label_consignePoint);
            this.Controls.Add(this.textBox_sommeNoeudsOF);
            this.Controls.Add(this.label_sommeNoeudsOF);
            this.Controls.Add(this.textBox_nbNoeuds);
            this.Controls.Add(this.label_nbNoeuds);
            this.Controls.Add(this.textBox_tpsTotalNav);
            this.Controls.Add(this.label_tpsTotalNav);
            this.Controls.Add(this.groupBox_typeVent);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox_fondMarin);
            this.Name = "Form1";
            this.Text = "Navigation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox_typeVent.ResumeLayout(false);
            this.groupBox_typeVent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fondMarin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_fondMarin;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox_typeVent;
        private System.Windows.Forms.RadioButton radioButton_c;
        private System.Windows.Forms.RadioButton radioButton_b;
        private System.Windows.Forms.RadioButton radioButton_a;
        private System.Windows.Forms.Label label_tpsTotalNav;
        private System.Windows.Forms.TextBox textBox_tpsTotalNav;
        private System.Windows.Forms.TextBox textBox_nbNoeuds;
        private System.Windows.Forms.Label label_nbNoeuds;
        private System.Windows.Forms.TextBox textBox_sommeNoeudsOF;
        private System.Windows.Forms.Label label_sommeNoeudsOF;
        private System.Windows.Forms.Label label_consignePoint;
        private System.Windows.Forms.Label label_ConsigneVent;
        private System.Windows.Forms.Label label_feedback;
        private System.Windows.Forms.TreeView treeView1;
    }
}

