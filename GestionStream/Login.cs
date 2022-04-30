using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------------------------
using System.Data.SqlClient;

namespace GestionEmail
{
    public partial class Login : Form
    {
         private void Login_Load(object sender, EventArgs e)
        {
            
        }
       private Donnees d = new Donnees();
        private Interfaces interf = new Interfaces();
        public Login()
        {
            InitializeComponent();
            TxtPassword.PasswordChar = '*';
            TxtPassword.MaxLength = 20;

        }

     
        //private void BtnReset_Click()
        //{
        //    interf.ViderForme(PnlLogin);
           
        //}

        //private void BtnValider_Click(object sender, EventArgs e)
        //{
        //    d.Connecter();
        //    d.cmd.Connection = d.Con;
        //    SqlDataAdapter SqlDataAd = new SqlDataAdapter("Select role From Login Where IdLogin='" + TxtLogin.Text + "' AND Password='" + TxtPassword.Text + "'",d.Con);
        //    DataTable MadataTable = new DataTable();
        //    SqlDataAd.Fill(MadataTable);
        //    if (MadataTable.Rows.Count == 1)
        //    {
        //        this.Hide();

        //        var x = MadataTable.Rows[0][0].ToString();

        //        FrmCategories frmCategories = new FrmCategories(x);
        //        frmCategories.Show();
        //        //((Form)FrmCategories).Controls['LbStatus'].Text = MadataTable.Rows[0][0].ToString();
        //    }
        //    else
        //    {

        //        MessageBox.Show("Veillez revoir votre login ou mot de passe");
        //        interf.ViderForme(PnlLogin);
        //    }
            
        //}

       

        

        private void BtnValider_Click(object sender, EventArgs e)
        {

            d.Connecter();
            d.cmd.Connection = d.Con;
            SqlDataAdapter SqlDataAd = new SqlDataAdapter("Select role From Login Where IdLogin='" + TxtLogin.Text + "' AND Password='" + TxtPassword.Text + "'", d.Con);
            DataTable MadataTable = new DataTable();
            SqlDataAd.Fill(MadataTable);
            if (MadataTable.Rows.Count == 1)
            {
                this.Hide();

                var x = MadataTable.Rows[0][0].ToString();
               
                if(x.TrimEnd() == "Admin")
                {
                    FrmCategories frmCategories = new FrmCategories(x);
                    frmCategories.Show();
                }
                else
                {
                    FrmContact frmContact = new FrmContact(x);
                    MessageBox.Show("Utilisateur connecté : " + x.TrimEnd());
                    frmContact.Show();
                }
                
                //((Form)FrmCategories).Controls['LbStatus'].Text = MadataTable.Rows[0][0].ToString();
            }
            else
            {

                MessageBox.Show("Veillez revoir votre login ou mot de passe");
                interf.ViderGroup(GroupeBoxArea);
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            interf.ViderGroup(GroupeBoxArea);


        }
    }
}
