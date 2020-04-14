﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Agotchi
{
    public partial class VolDuTemps : Form
    {
        public VolDuTemps()
        {
            InitializeComponent();
        }

        private void btRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            //On ferme la page VolDuTemps.cs
        }

        private void cBVolDuTemps_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cBVolDuTemps.SelectedItem.ToString()){
                case "Tama":
                    btVolDuTemps.Enabled = true;
                    pbAdversaire.Image = Properties.Resources.Fille1;
                    break;
                case "Got":
                    btVolDuTemps.Enabled = true;
                    pbAdversaire.Image = Properties.Resources.Méchant1;
                    break;
                case "Chi":
                    btVolDuTemps.Enabled = true;
                    pbAdversaire.Image = Properties.Resources.Méchant2;
                    break;
                case "":
                    btVolDuTemps.Enabled = false;
                    pbAdversaire.Image = Properties.Resources.Qui;
                    break;
            }
            //Selon le nom de la personne selectionnée dans la comboBox, on change l'image de l'adversaire
        }

        private void btVolDuTemps_Click(object sender, EventArgs e)
        {

            if (cBVolDuTemps.SelectedItem == null)
                return;
            Random rnd = new Random();
            int chanceReussite;
            infoDuVol.Visible = true;

            switch (cBVolDuTemps.SelectedItem.ToString())
            {
                // Pour Tama, La chance est de 1/2, On peut gagner 1minute ou perdre 2minutes.
                case "Tama":
                    chanceReussite = Convert.ToInt32(rnd.Next(1, 100));
                    if (chanceReussite >= 50)
                    {
                        if (Donnees.GetPersos()[3].GetTemps().GetMinute() < 3)
                        {
                            Donnees.GetPersos()[0].GetTemps().ajouterMinute(Donnees.GetPersos()[1].GetTemps().GetMinute());
                            Donnees.GetPersos()[0].GetTemps().ajouterSeconde(Donnees.GetPersos()[1].GetTemps().GetSeconde());
                            Donnees.GetPersos()[1].GetTemps().SetMinute(0);
                            Donnees.GetPersos()[1].GetTemps().SetSeconde(0);

                            infoDuVol.Text = "Vous avez tué Tama";
                        }
                        else
                        {
                            Donnees.GetPersos()[0].GetTemps().ajouterMinute(1);
                            Donnees.GetPersos()[1].GetTemps().retirerMinute(1);
                            infoDuVol.Text = "Vous avez gagné 1 minute";
                        }
                    }
                    else
                    {
                        
                            Donnees.GetPersos()[1].GetTemps().ajouterMinute(2);
                            Donnees.GetPersos()[0].GetTemps().retirerMinute(2);
                            infoDuVol.Text = "Vous avez perdu 2 minutes";
                        
                    }

                    if (Donnees.GetPersos()[1].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[1].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[1].GetTemps().GetSeconde() == 0)
                    {
                        cBVolDuTemps.SelectedItem = "";
                        cBVolDuTemps.Items.Remove("Tama");
                        MessageBox.Show("Vous avez tué cette personne en lui volant tout son temps.");
                        infoDuVol.Text = "";
                        pbAdversaire.Image = Properties.Resources.Qui;
                    }

                    break;

                // Pour Got, La chance est de 10%, On peut gagner 10 minutes ou perdre 1 minute.
                case "Got":
                    chanceReussite = Convert.ToInt32(rnd.Next(1, 100));
                    if (chanceReussite >= 90)
                    {
                        if (Donnees.GetPersos()[3].GetTemps().GetMinute() < 3)
                        {
                            Donnees.GetPersos()[0].GetTemps().ajouterMinute(Donnees.GetPersos()[2].GetTemps().GetMinute());
                            Donnees.GetPersos()[0].GetTemps().ajouterSeconde(Donnees.GetPersos()[2].GetTemps().GetSeconde());
                            Donnees.GetPersos()[2].GetTemps().SetMinute(0);
                            Donnees.GetPersos()[2].GetTemps().SetSeconde(0);

                            infoDuVol.Text = "Vous avez tué Got";
                        }
                        else
                        {
                            Donnees.GetPersos()[0].GetTemps().ajouterMinute(10);
                            Donnees.GetPersos()[2].GetTemps().retirerMinute(10);
                            infoDuVol.Text = "Vous avez gagné 10 minutes";
                        }
                    }
                    else
                    {
                        
                            Donnees.GetPersos()[2].GetTemps().ajouterMinute(1);
                            Donnees.GetPersos()[0].GetTemps().retirerMinute(1);
                            infoDuVol.Text = "Vous avez perdu 1 minute";
                        
                    }
                    if (Donnees.GetPersos()[2].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[2].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[2].GetTemps().GetSeconde() == 0)
                    {
                        cBVolDuTemps.SelectedItem = "";
                        cBVolDuTemps.Items.Remove("Got");
                        MessageBox.Show("Vous avez tué cette personne en lui volant tout son temps.");
                        infoDuVol.Text = "";
                        pbAdversaire.Image = Properties.Resources.Qui;
                    }
                    break;
                
                // Pour Chi, La chance est de 30%, On peut gagner 3 minutes ou perdre 1 minutes.
                case "Chi":
                    chanceReussite = Convert.ToInt32(rnd.Next(1, 100));
                    if (chanceReussite >= 30)
                    {
                        if (Donnees.GetPersos()[3].GetTemps().GetMinute() < 3)
                        {
                            Donnees.GetPersos()[0].GetTemps().ajouterMinute(Donnees.GetPersos()[3].GetTemps().GetMinute());
                            Donnees.GetPersos()[0].GetTemps().ajouterSeconde(Donnees.GetPersos()[3].GetTemps().GetSeconde());
                            Donnees.GetPersos()[3].GetTemps().SetMinute(0);
                            Donnees.GetPersos()[3].GetTemps().SetSeconde(0);

                            infoDuVol.Text = "Vous avez tué Chi";
                        }
                        else
                        {
                            Donnees.GetPersos()[0].GetTemps().ajouterMinute(3);
                            Donnees.GetPersos()[3].GetTemps().retirerMinute(3);
                            infoDuVol.Text = "Vous avez gagné 3 minutes";
                        }
                    }
                    else
                    {
                            Donnees.GetPersos()[3].GetTemps().ajouterMinute(1);
                            Donnees.GetPersos()[0].GetTemps().retirerMinute(1);
                            infoDuVol.Text = "Vous avez perdu 1 minute";
                    }
                    if (Donnees.GetPersos()[3].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[3].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[3].GetTemps().GetSeconde() == 0)
                    {
                        cBVolDuTemps.SelectedItem = "";
                        cBVolDuTemps.Items.Remove("Chi");
                        MessageBox.Show("Vous avez tué cette personne en lui volant tout son temps.");
                        infoDuVol.Text = "";
                        pbAdversaire.Image = Properties.Resources.Qui;
                    }
                    break;
            }
        }

        private void VerifVivant_Tick(object sender, EventArgs e)
        {
            if (Donnees.GetPersos()[1].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[1].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[1].GetTemps().GetSeconde() == 0)
            {
                cBVolDuTemps.Items.Remove("Tama");
            }
            if (Donnees.GetPersos()[2].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[2].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[2].GetTemps().GetSeconde() == 0)
            {
                cBVolDuTemps.Items.Remove("Got");
            }
            if (Donnees.GetPersos()[3].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[3].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[3].GetTemps().GetSeconde() == 0)
            {
                cBVolDuTemps.Items.Remove("Chi");
            }
        
        }

        private void VolDuTemps_Load(object sender, EventArgs e)
        {
            cBVolDuTemps.Items.Add("Tama");
            cBVolDuTemps.Items.Add("Got");
            cBVolDuTemps.Items.Add("Chi");

            if (cBVolDuTemps.Items.Count == 0)
            {
                lbTousMorts.Visible = true;
                lbInfoVol.Visible = false;
                cBVolDuTemps.Enabled = false;
                btVolDuTemps.Enabled = false;
            }

            }

    }
}
