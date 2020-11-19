namespace Projet_IA
{
    partial class MainForm
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
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.textBox_xf = new System.Windows.Forms.TextBox();
            this.textBox_yf = new System.Windows.Forms.TextBox();
            this.label_x0 = new System.Windows.Forms.Label();
            this.label_y0 = new System.Windows.Forms.Label();
            this.label_xf = new System.Windows.Forms.Label();
            this.label_yf = new System.Windows.Forms.Label();
            this.label_consigneCoord = new System.Windows.Forms.Label();
            this.button_restart = new System.Windows.Forms.Button();
            this.groupBox_typeVent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fondMarin)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.SteelBlue;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(128, 355);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(98, 30);
            this.button_start.TabIndex = 13;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox_typeVent
            // 
            this.groupBox_typeVent.Controls.Add(this.radioButton_c);
            this.groupBox_typeVent.Controls.Add(this.radioButton_b);
            this.groupBox_typeVent.Controls.Add(this.radioButton_a);
            this.groupBox_typeVent.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_typeVent.Location = new System.Drawing.Point(650, 27);
            this.groupBox_typeVent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_typeVent.Name = "groupBox_typeVent";
            this.groupBox_typeVent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_typeVent.Size = new System.Drawing.Size(225, 180);
            this.groupBox_typeVent.TabIndex = 15;
            this.groupBox_typeVent.TabStop = false;
            this.groupBox_typeVent.Text = "Type de vent";
            this.groupBox_typeVent.Enter += new System.EventHandler(this.groupBox_typeVent_Enter);
            // 
            // radioButton_c
            // 
            this.radioButton_c.AutoSize = true;
            this.radioButton_c.Location = new System.Drawing.Point(19, 115);
            this.radioButton_c.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_c.Name = "radioButton_c";
            this.radioButton_c.Size = new System.Drawing.Size(43, 25);
            this.radioButton_c.TabIndex = 2;
            this.radioButton_c.TabStop = true;
            this.radioButton_c.Text = "c";
            this.radioButton_c.UseVisualStyleBackColor = true;
            this.radioButton_c.CheckedChanged += new System.EventHandler(this.radioButton_c_CheckedChanged);
            // 
            // radioButton_b
            // 
            this.radioButton_b.AutoSize = true;
            this.radioButton_b.Location = new System.Drawing.Point(19, 80);
            this.radioButton_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_b.Name = "radioButton_b";
            this.radioButton_b.Size = new System.Drawing.Size(44, 25);
            this.radioButton_b.TabIndex = 1;
            this.radioButton_b.TabStop = true;
            this.radioButton_b.Text = "b";
            this.radioButton_b.UseVisualStyleBackColor = true;
            this.radioButton_b.CheckedChanged += new System.EventHandler(this.radioButton_b_CheckedChanged);
            // 
            // radioButton_a
            // 
            this.radioButton_a.AutoSize = true;
            this.radioButton_a.Location = new System.Drawing.Point(19, 44);
            this.radioButton_a.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_a.Name = "radioButton_a";
            this.radioButton_a.Size = new System.Drawing.Size(44, 25);
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
            this.label_tpsTotalNav.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tpsTotalNav.Location = new System.Drawing.Point(81, 450);
            this.label_tpsTotalNav.Name = "label_tpsTotalNav";
            this.label_tpsTotalNav.Size = new System.Drawing.Size(286, 21);
            this.label_tpsTotalNav.TabIndex = 16;
            this.label_tpsTotalNav.Text = "Temps total de navigation (en heures) :";
            this.label_tpsTotalNav.Click += new System.EventHandler(this.label_tpsTotalNav_Click);
            // 
            // textBox_tpsTotalNav
            // 
            this.textBox_tpsTotalNav.Enabled = false;
            this.textBox_tpsTotalNav.Location = new System.Drawing.Point(386, 447);
            this.textBox_tpsTotalNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_tpsTotalNav.Name = "textBox_tpsTotalNav";
            this.textBox_tpsTotalNav.Size = new System.Drawing.Size(112, 29);
            this.textBox_tpsTotalNav.TabIndex = 17;
            // 
            // textBox_nbNoeuds
            // 
            this.textBox_nbNoeuds.Enabled = false;
            this.textBox_nbNoeuds.Location = new System.Drawing.Point(386, 515);
            this.textBox_nbNoeuds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_nbNoeuds.Name = "textBox_nbNoeuds";
            this.textBox_nbNoeuds.Size = new System.Drawing.Size(112, 29);
            this.textBox_nbNoeuds.TabIndex = 19;
            // 
            // label_nbNoeuds
            // 
            this.label_nbNoeuds.AutoSize = true;
            this.label_nbNoeuds.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbNoeuds.Location = new System.Drawing.Point(67, 517);
            this.label_nbNoeuds.Name = "label_nbNoeuds";
            this.label_nbNoeuds.Size = new System.Drawing.Size(298, 21);
            this.label_nbNoeuds.TabIndex = 18;
            this.label_nbNoeuds.Text = "Nombre des noeuds du chemin solution :";
            this.label_nbNoeuds.Click += new System.EventHandler(this.label_nbNoeuds_Click);
            // 
            // textBox_sommeNoeudsOF
            // 
            this.textBox_sommeNoeudsOF.Enabled = false;
            this.textBox_sommeNoeudsOF.Location = new System.Drawing.Point(386, 576);
            this.textBox_sommeNoeudsOF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_sommeNoeudsOF.Name = "textBox_sommeNoeudsOF";
            this.textBox_sommeNoeudsOF.Size = new System.Drawing.Size(112, 29);
            this.textBox_sommeNoeudsOF.TabIndex = 21;
            // 
            // label_sommeNoeudsOF
            // 
            this.label_sommeNoeudsOF.AutoSize = true;
            this.label_sommeNoeudsOF.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sommeNoeudsOF.Location = new System.Drawing.Point(8, 579);
            this.label_sommeNoeudsOF.Name = "label_sommeNoeudsOF";
            this.label_sommeNoeudsOF.Size = new System.Drawing.Size(359, 21);
            this.label_sommeNoeudsOF.TabIndex = 20;
            this.label_sommeNoeudsOF.Text = "Somme des noeuds des listes Ouverts et Fermés :";
            this.label_sommeNoeudsOF.Click += new System.EventHandler(this.label_sommeNoeudsOF_Click);
            // 
            // pictureBox_fondMarin
            // 
            this.pictureBox_fondMarin.Image = global::Projet_IA.Properties.Resources.fond_marin1;
            this.pictureBox_fondMarin.Location = new System.Drawing.Point(537, 241);
            this.pictureBox_fondMarin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_fondMarin.Name = "pictureBox_fondMarin";
            this.pictureBox_fondMarin.Size = new System.Drawing.Size(338, 394);
            this.pictureBox_fondMarin.TabIndex = 12;
            this.pictureBox_fondMarin.TabStop = false;
            this.pictureBox_fondMarin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_fondMarin_MouseClick);
            // 
            // label_consignePoint
            // 
            this.label_consignePoint.AutoSize = true;
            this.label_consignePoint.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_consignePoint.Location = new System.Drawing.Point(25, 78);
            this.label_consignePoint.Name = "label_consignePoint";
            this.label_consignePoint.Size = new System.Drawing.Size(510, 21);
            this.label_consignePoint.TabIndex = 22;
            this.label_consignePoint.Text = "Cliquez une seule fois sur l\'image pour paramétrer le point de départ ou";
            this.label_consignePoint.Click += new System.EventHandler(this.label_consignePoint_Click);
            // 
            // label_ConsigneVent
            // 
            this.label_ConsigneVent.AutoSize = true;
            this.label_ConsigneVent.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConsigneVent.Location = new System.Drawing.Point(25, 37);
            this.label_ConsigneVent.Name = "label_ConsigneVent";
            this.label_ConsigneVent.Size = new System.Drawing.Size(211, 21);
            this.label_ConsigneVent.TabIndex = 23;
            this.label_ConsigneVent.Text = "Sélectionnez un type de vent";
            this.label_ConsigneVent.Click += new System.EventHandler(this.label_ConsigneVent_Click);
            // 
            // label_feedback
            // 
            this.label_feedback.AutoSize = true;
            this.label_feedback.Location = new System.Drawing.Point(30, 157);
            this.label_feedback.Name = "label_feedback";
            this.label_feedback.Size = new System.Drawing.Size(0, 21);
            this.label_feedback.TabIndex = 24;
            // 
            // textBox_x0
            // 
            this.textBox_x0.Location = new System.Drawing.Point(112, 215);
            this.textBox_x0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(100, 29);
            this.textBox_x0.TabIndex = 25;
            this.textBox_x0.TextChanged += new System.EventHandler(this.textBox_x0_TextChanged);
            // 
            // textBox_y0
            // 
            this.textBox_y0.Location = new System.Drawing.Point(348, 215);
            this.textBox_y0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(100, 29);
            this.textBox_y0.TabIndex = 26;
            this.textBox_y0.TextChanged += new System.EventHandler(this.textBox_y0_TextChanged);
            // 
            // textBox_xf
            // 
            this.textBox_xf.Location = new System.Drawing.Point(112, 279);
            this.textBox_xf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_xf.Name = "textBox_xf";
            this.textBox_xf.Size = new System.Drawing.Size(100, 29);
            this.textBox_xf.TabIndex = 27;
            this.textBox_xf.TextChanged += new System.EventHandler(this.textBox_xf_TextChanged);
            // 
            // textBox_yf
            // 
            this.textBox_yf.Location = new System.Drawing.Point(348, 279);
            this.textBox_yf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_yf.Name = "textBox_yf";
            this.textBox_yf.Size = new System.Drawing.Size(100, 29);
            this.textBox_yf.TabIndex = 28;
            this.textBox_yf.TextChanged += new System.EventHandler(this.textBox_yf_TextChanged);
            // 
            // label_x0
            // 
            this.label_x0.AutoSize = true;
            this.label_x0.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x0.Location = new System.Drawing.Point(40, 215);
            this.label_x0.Name = "label_x0";
            this.label_x0.Size = new System.Drawing.Size(39, 21);
            this.label_x0.TabIndex = 29;
            this.label_x0.Text = "x0 : ";
            this.label_x0.Click += new System.EventHandler(this.label_x0_Click);
            // 
            // label_y0
            // 
            this.label_y0.AutoSize = true;
            this.label_y0.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_y0.Location = new System.Drawing.Point(291, 218);
            this.label_y0.Name = "label_y0";
            this.label_y0.Size = new System.Drawing.Size(39, 21);
            this.label_y0.TabIndex = 30;
            this.label_y0.Text = "y0 : ";
            this.label_y0.Click += new System.EventHandler(this.label_y0_Click);
            // 
            // label_xf
            // 
            this.label_xf.AutoSize = true;
            this.label_xf.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_xf.Location = new System.Drawing.Point(40, 283);
            this.label_xf.Name = "label_xf";
            this.label_xf.Size = new System.Drawing.Size(36, 21);
            this.label_xf.TabIndex = 31;
            this.label_xf.Text = "xf : ";
            this.label_xf.Click += new System.EventHandler(this.label_xf_Click);
            // 
            // label_yf
            // 
            this.label_yf.AutoSize = true;
            this.label_yf.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_yf.Location = new System.Drawing.Point(291, 286);
            this.label_yf.Name = "label_yf";
            this.label_yf.Size = new System.Drawing.Size(36, 21);
            this.label_yf.TabIndex = 32;
            this.label_yf.Text = "yf : ";
            this.label_yf.Click += new System.EventHandler(this.label_yf_Click);
            // 
            // label_consigneCoord
            // 
            this.label_consigneCoord.AutoSize = true;
            this.label_consigneCoord.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_consigneCoord.Location = new System.Drawing.Point(25, 117);
            this.label_consigneCoord.Name = "label_consigneCoord";
            this.label_consigneCoord.Size = new System.Drawing.Size(248, 21);
            this.label_consigneCoord.TabIndex = 33;
            this.label_consigneCoord.Text = "Entrez les coordonées en dessous";
            this.label_consigneCoord.Click += new System.EventHandler(this.label_consigneCoord_Click);
            // 
            // button_restart
            // 
            this.button_restart.BackColor = System.Drawing.Color.SteelBlue;
            this.button_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_restart.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_restart.ForeColor = System.Drawing.Color.White;
            this.button_restart.Location = new System.Drawing.Point(294, 355);
            this.button_restart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(98, 30);
            this.button_restart.TabIndex = 34;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = false;
            this.button_restart.Visible = false;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.label_consigneCoord);
            this.Controls.Add(this.label_yf);
            this.Controls.Add(this.label_xf);
            this.Controls.Add(this.label_y0);
            this.Controls.Add(this.label_x0);
            this.Controls.Add(this.textBox_yf);
            this.Controls.Add(this.textBox_xf);
            this.Controls.Add(this.textBox_y0);
            this.Controls.Add(this.textBox_x0);
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
            this.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Navigation";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
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
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.TextBox textBox_y0;
        private System.Windows.Forms.TextBox textBox_xf;
        private System.Windows.Forms.TextBox textBox_yf;
        private System.Windows.Forms.Label label_x0;
        private System.Windows.Forms.Label label_y0;
        private System.Windows.Forms.Label label_xf;
        private System.Windows.Forms.Label label_yf;
        private System.Windows.Forms.Label label_consigneCoord;
        private System.Windows.Forms.Button button_restart;
    }
}

