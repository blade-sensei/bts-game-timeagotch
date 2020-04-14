﻿namespace Time_Agotchi
{
    partial class BrasDeFer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrasDeFer));
            this.progressBarPersoMain = new System.Windows.Forms.ProgressBar();
            this.progressBarAdversaire = new System.Windows.Forms.ProgressBar();
            this.lbTempsJoueur = new System.Windows.Forms.Label();
            this.lbTempsAdversaire = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGo = new System.Windows.Forms.Button();
            this.lbAnnonce = new System.Windows.Forms.Label();
            this.timerMainJeu = new System.Windows.Forms.Timer(this.components);
            this.timerGestionnaireJeu = new System.Windows.Forms.Timer(this.components);
            this.btQuitter = new System.Windows.Forms.Button();
            this.lbHelp = new System.Windows.Forms.Label();
            this.richTbHelp = new System.Windows.Forms.RichTextBox();
            this.lbNomAdversaire = new System.Windows.Forms.Label();
            this.lbPersoMain = new System.Windows.Forms.Label();
            this.pbFourthReponse = new System.Windows.Forms.PictureBox();
            this.pbThirdReponse = new System.Windows.Forms.PictureBox();
            this.pbSecondReponse = new System.Windows.Forms.PictureBox();
            this.pbFirstReponse = new System.Windows.Forms.PictureBox();
            this.pbFourthArrow = new System.Windows.Forms.PictureBox();
            this.pbThridArrow = new System.Windows.Forms.PictureBox();
            this.pbSecondArrow = new System.Windows.Forms.PictureBox();
            this.pbFirstArrow = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourthReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourthArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThridArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarPersoMain
            // 
            this.progressBarPersoMain.ForeColor = System.Drawing.Color.SpringGreen;
            resources.ApplyResources(this.progressBarPersoMain, "progressBarPersoMain");
            this.progressBarPersoMain.Maximum = 50;
            this.progressBarPersoMain.Name = "progressBarPersoMain";
            // 
            // progressBarAdversaire
            // 
            this.progressBarAdversaire.ForeColor = System.Drawing.Color.SpringGreen;
            resources.ApplyResources(this.progressBarAdversaire, "progressBarAdversaire");
            this.progressBarAdversaire.Maximum = 50;
            this.progressBarAdversaire.Name = "progressBarAdversaire";
            // 
            // lbTempsJoueur
            // 
            resources.ApplyResources(this.lbTempsJoueur, "lbTempsJoueur");
            this.lbTempsJoueur.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbTempsJoueur.Name = "lbTempsJoueur";
            // 
            // lbTempsAdversaire
            // 
            resources.ApplyResources(this.lbTempsAdversaire, "lbTempsAdversaire");
            this.lbTempsAdversaire.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbTempsAdversaire.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbTempsAdversaire.Name = "lbTempsAdversaire";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Name = "label1";
            // 
            // btGo
            // 
            this.btGo.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btGo, "btGo");
            this.btGo.ForeColor = System.Drawing.Color.SpringGreen;
            this.btGo.Name = "btGo";
            this.btGo.UseVisualStyleBackColor = false;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // lbAnnonce
            // 
            resources.ApplyResources(this.lbAnnonce, "lbAnnonce");
            this.lbAnnonce.Name = "lbAnnonce";
            // 
            // timerMainJeu
            // 
            this.timerMainJeu.Tick += new System.EventHandler(this.timerMainJeu_Tick);
            // 
            // timerGestionnaireJeu
            // 
            this.timerGestionnaireJeu.Tick += new System.EventHandler(this.timerGestionnaireJeu_Tick);
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btQuitter, "btQuitter");
            this.btQuitter.ForeColor = System.Drawing.Color.SpringGreen;
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lbHelp
            // 
            resources.ApplyResources(this.lbHelp, "lbHelp");
            this.lbHelp.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.MouseLeave += new System.EventHandler(this.lbHelp_MouseLeave);
            this.lbHelp.MouseHover += new System.EventHandler(this.lbHelp_MouseHover);
            // 
            // richTbHelp
            // 
            this.richTbHelp.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.richTbHelp, "richTbHelp");
            this.richTbHelp.ForeColor = System.Drawing.Color.SpringGreen;
            this.richTbHelp.Name = "richTbHelp";
            // 
            // lbNomAdversaire
            // 
            resources.ApplyResources(this.lbNomAdversaire, "lbNomAdversaire");
            this.lbNomAdversaire.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbNomAdversaire.Name = "lbNomAdversaire";
            // 
            // lbPersoMain
            // 
            resources.ApplyResources(this.lbPersoMain, "lbPersoMain");
            this.lbPersoMain.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbPersoMain.Name = "lbPersoMain";
            // 
            // pbFourthReponse
            // 
            resources.ApplyResources(this.pbFourthReponse, "pbFourthReponse");
            this.pbFourthReponse.Name = "pbFourthReponse";
            this.pbFourthReponse.TabStop = false;
            // 
            // pbThirdReponse
            // 
            resources.ApplyResources(this.pbThirdReponse, "pbThirdReponse");
            this.pbThirdReponse.Name = "pbThirdReponse";
            this.pbThirdReponse.TabStop = false;
            // 
            // pbSecondReponse
            // 
            resources.ApplyResources(this.pbSecondReponse, "pbSecondReponse");
            this.pbSecondReponse.Name = "pbSecondReponse";
            this.pbSecondReponse.TabStop = false;
            // 
            // pbFirstReponse
            // 
            resources.ApplyResources(this.pbFirstReponse, "pbFirstReponse");
            this.pbFirstReponse.Name = "pbFirstReponse";
            this.pbFirstReponse.TabStop = false;
            // 
            // pbFourthArrow
            // 
            resources.ApplyResources(this.pbFourthArrow, "pbFourthArrow");
            this.pbFourthArrow.Name = "pbFourthArrow";
            this.pbFourthArrow.TabStop = false;
            // 
            // pbThridArrow
            // 
            resources.ApplyResources(this.pbThridArrow, "pbThridArrow");
            this.pbThridArrow.Name = "pbThridArrow";
            this.pbThridArrow.TabStop = false;
            // 
            // pbSecondArrow
            // 
            resources.ApplyResources(this.pbSecondArrow, "pbSecondArrow");
            this.pbSecondArrow.Name = "pbSecondArrow";
            this.pbSecondArrow.TabStop = false;
            // 
            // pbFirstArrow
            // 
            resources.ApplyResources(this.pbFirstArrow, "pbFirstArrow");
            this.pbFirstArrow.Name = "pbFirstArrow";
            this.pbFirstArrow.TabStop = false;
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.Image = global::Time_Agotchi.Properties.Resources.brasDeFer;
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            // 
            // BrasDeFer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.lbPersoMain);
            this.Controls.Add(this.lbNomAdversaire);
            this.Controls.Add(this.richTbHelp);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.pbFourthReponse);
            this.Controls.Add(this.pbThirdReponse);
            this.Controls.Add(this.pbSecondReponse);
            this.Controls.Add(this.pbFirstReponse);
            this.Controls.Add(this.lbAnnonce);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.pbFourthArrow);
            this.Controls.Add(this.pbThridArrow);
            this.Controls.Add(this.pbSecondArrow);
            this.Controls.Add(this.pbFirstArrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lbTempsAdversaire);
            this.Controls.Add(this.lbTempsJoueur);
            this.Controls.Add(this.progressBarAdversaire);
            this.Controls.Add(this.progressBarPersoMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrasDeFer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrasDeFer_FormClosed);
            this.Load += new System.EventHandler(this.BrasDeFer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFourthReponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdReponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondReponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstReponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourthArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThridArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarPersoMain;
        private System.Windows.Forms.ProgressBar progressBarAdversaire;
        private System.Windows.Forms.Label lbTempsJoueur;
        private System.Windows.Forms.Label lbTempsAdversaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFirstArrow;
        private System.Windows.Forms.PictureBox pbSecondArrow;
        private System.Windows.Forms.PictureBox pbThridArrow;
        private System.Windows.Forms.PictureBox pbFourthArrow;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Label lbAnnonce;
        private System.Windows.Forms.PictureBox pbFirstReponse;
        private System.Windows.Forms.PictureBox pbSecondReponse;
        private System.Windows.Forms.PictureBox pbThirdReponse;
        private System.Windows.Forms.PictureBox pbFourthReponse;
        private System.Windows.Forms.Timer timerMainJeu;
        private System.Windows.Forms.Timer timerGestionnaireJeu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.RichTextBox richTbHelp;
        private System.Windows.Forms.Label lbNomAdversaire;
        private System.Windows.Forms.Label lbPersoMain;
    }
}