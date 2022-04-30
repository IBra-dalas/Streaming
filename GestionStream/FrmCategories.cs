using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Security.Principal;

namespace GestionEmail
{
    public partial class FrmCategories : Form
    {
        string role;
        public FrmCategories(string LocalRole)
        {
            InitializeComponent();
            LbStatus.Text = LocalRole;
            role = LocalRole;
        }
        public FrmCategories()
        {
            InitializeComponent();
            
        }

        Donnees d = new Donnees();
        private Interfaces interf = new Interfaces();
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionDonneesDataSet.Contact'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.contactTableAdapter.Fill(this.gestionDonneesDataSet.Contact);

            // chemin d'accès au serveur pour ouvrir la base de données
            // ouvrir la base de données
















                    d.RemplirGrid("Categorie", dgvCategorie);
            

        }

        private void BtrModifier_Click(object sender, EventArgs e)
        {
            if (txrnumcat != null)
            {
                tbcCategorie.SelectedTab = tbcMiseAjour;
                interf.AfficheForme(pnlMiseAjour, dgvCategorie);
                
                //txtnumcat.Text = dgvCategorie.SelectedRows[0].Cells["numcat"].Value.ToString();
                //txtnomcat.Text = dgvCategorie.SelectedRows[0].Cells["nomcat"].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Try again");
            }
                
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtrQuitter_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {

            if (d.NbreLignes("numcat", "Categorie", int.Parse(dgvCategorie.SelectedRows[0].Cells["numcat"].Value.ToString()))>0)
            {

            
                d.cmd.CommandText = "UPDATE Categorie SET numcat =" + int.Parse(txtnumcat.Text)+", nomcat='" + txtnomcat.Text + "'WHERE numcat ="+ int.Parse(dgvCategorie.SelectedRows[0].Cells["numcat"].Value.ToString());
                //exécuter la commande ne retourne pas de valeur
                d.cmd.ExecuteNonQuery();
                d.Deconnecter();
                MessageBox.Show("Modification éffectué avec succes");
                d.RemplirGrid("Categorie", dgvCategorie);
                interf.ViderForme(pnlMiseAjour);
                interf.ViderForme(pnlMiseAjour);
            }
            //if (d.NbreLignes("numcat", "Categorie", int.Parse(txtnumcat.Text)) > 0)
            //{
            //    MessageBox.Show("Le numéro de Catégorie " + int.Parse(txtnumcat.Text) + " Existe déjà");

            //}
            //else
            //{
            //    d.cmd.CommandText = "INSERT INTO Categorie (numcat, nomcat) VALUES (" + int.Parse(txtnumcat.Text) + " ,'" + txtnomcat.Text + "')";
            //    //exécuter la commande ne retourne pas de valeur
            //    d.cmd.ExecuteNonQuery();
            //    d.Deconnecter();
            //    MessageBox.Show("Ajout éffectué avec succes");
            //}


            ////  d.AfficheForme(pnlAffichage, dgvCategorie);
            ////tbcCategorie.SelectedTab = tbcMiseAjour;
            ////interf.AfficheForme(pnlMiseAjour, dgvCategorie);
            //d.Connecter();
            //d.cmd.Connection = d.Con;
            //d.cmd.CommandText = "UPDATE INTO Categorie (nomcat) VALUES ('" + txtnomcat.Text + "') WHERE numcat = '" + int.Parse(txtnumcat.Text) + "'";
            //d.cmd.ExecuteNonQuery();
            //d.Deconnecter();
            //MessageBox.Show("Modification effectuée avec succes");
        }
        Interfaces Interf = new Interfaces();
        private void BnNouveau_Click(object sender, EventArgs e)
        {
            //interf.ViderForme(pnlMiseAjour);
            Donnees d = new Donnees();
            d.Connecter();
            d.cmd.Connection = d.Con;
            d.cmd.CommandText = "INSERT INTO Categorie (numcat, nomcat) VALUES (" + int.Parse(txtnumcat.Text) + " ,'" + txtnomcat.Text + "')";
            if(d.cmd.CommandText !=null)
            {
                d.cmd.ExecuteNonQuery();//exécuter la commande ne retourne pas de valeur
                d.Deconnecter();
                MessageBox.Show("Ajout éffectué avec succes");
            }
            else
            {
                MessageBox.Show("try again with values ", d.cmd.CommandText);
            }
            
           
        }

        private void BtrNouveau_Click(object sender, EventArgs e)
        {
            //interf.ViderForme(pnlMiseAjour);

            //interf.AfficheForme(pnlMiseAjour, dgvCategorie);
            //interf.AfficheForme(pnlMiseAjour, dgvCategorie);
            tbcCategorie.SelectedTab = tbcMiseAjour;
           
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
             
            if(d.NbreLignes("numcat","Categorie", int.Parse(txtnumcat.Text))>0)
            {
                MessageBox.Show("Le numéro de Catégorie " + int.Parse(txtnumcat.Text) + " Existe déjà");

            }
            else
            { 
                d.cmd.CommandText = "INSERT INTO Categorie (numcat, nomcat) VALUES (" + int.Parse(txtnumcat.Text) + " ,'" + txtnomcat.Text + "')";
                //exécuter la commande ne retourne pas de valeur
                d.cmd.ExecuteNonQuery();
                d.Deconnecter();
                MessageBox.Show("Ajout éffectué avec succes");
                d.RemplirGrid("Categorie", dgvCategorie);
            }
            


        }

        private void BtrActualiser_Click(object sender, EventArgs e)
        {
            //d.Connecter();
            //d.cmd.Connection = d.Con;
            //d.cmd.CommandText = "SELECT * FROM Categorie";
            //d.cmd.ExecuteNonQuery();
            //d.Deconnecter();
            d.RemplirGrid("Categorie", dgvCategorie);
        }

        private void BtrAjouter_Click(object sender, EventArgs e)
        {
            
            if(d.NbreLignes("numcat","Categorie", int.Parse(txtnumcat.Text))>0)
            {
                MessageBox.Show("Le numéro de Catégorie " +int.Parse(txrnumcat.Text) +"Existe déjà");

            }
            else
            { 
                d.cmd.CommandText = "INSERT INTO Categorie (numcat, nomcat) VALUES (" + int.Parse(txrnumcat.Text) + " ,'" + txrnomcat.Text + "')";
                //exécuter la commande ne retourne pas de valeur
                d.cmd.ExecuteNonQuery();
                d.Deconnecter();
                MessageBox.Show("Ajout éffectué avec succes");
                d.RemplirGrid("Categorie", dgvCategorie);
            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            interf.ViderForme(pnlMiseAjour);
        }

        private void BtrSupprimer_Click(object sender, EventArgs e)
        {
            if (d.NbreLignes("numcat", "Categorie", int.Parse(dgvCategorie.SelectedRows[0].Cells["numcat"].Value.ToString())) > 0)
            {


                d.cmd.CommandText = "DELETE FROM Categorie WHERE numcat =" + int.Parse(dgvCategorie.SelectedRows[0].Cells["numcat"].Value.ToString());
                //exécuter la commande ne retourne pas de valeur
                d.cmd.ExecuteNonQuery();
                d.Deconnecter();
                MessageBox.Show("Suppression éffectué avec succes");
                d.RemplirGrid("Categorie", dgvCategorie);
                interf.ViderForme(pnlMiseAjour);
            }

        }

        private void BtnSpprimer_Click(object sender, EventArgs e)
        {
            // if (d.NbreLignes("numcat", "Categorie", int.Parse(dgvCategorie.SelectedRows[0].Cells["numcat"].Value.ToString())) > 0)
            //{

                d.Connecter();
                d.cmd.Connection = d.Con;
           
                d.cmd.CommandText = "DELETE FROM Categorie WHERE numcat =" + int.Parse(txtnumcat.Text);
                //exécuter la commande ne retourne pas de valeur
                d.cmd.ExecuteNonQuery();
                d.Deconnecter();
                MessageBox.Show("Suppression éffectué avec succes");
                d.RemplirGrid("Categorie", dgvCategorie);
                interf.ViderForme(pnlMiseAjour);
           // }
        }

        private void BtnAjoterProc_Click(object sender, EventArgs e)
        {
            Categorie cat = new Categorie
            {
                Numcat = int.Parse(txtnumcat.Text),
                Nomcat = txtnomcat.Text
            };
            if (cat.INSERT_CATEGORIE() == "1")
            {
                MessageBox.Show("Categorie ajoutée avec success");
            }
            else
                MessageBox.Show("Erreur");

            

        }

        private void ContactBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            
            FrmContact frmContact = new FrmContact(role);
            frmContact.Show();
            FrmContact.ActiveForm.FindForm();
            if(frmContact.Visible==true)
            {
                BtnContact.Enabled = new WindowsPrincipal(WindowsIdentity.GetCurrent())
                                   .IsInRole(WindowsBuiltInRole.Administrator);
                this.Hide();
                

            }
           
        }

        private void LbStatus_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
