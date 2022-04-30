using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmail
{
    public class Interfaces
    {
        private Donnees d = new Donnees();
       


        public void AfficheForme(Panel p, DataGridView dg)
        {
            

            // tbcCategorie.SelectedTab = tbcMiseAjour;

            foreach (Control ctl in p.Controls)
            {
                try
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        ctl.Text = dg.SelectedRows[0].Cells[ctl.Name.Substring(3)].Value.ToString();

                    }
                }
                catch (Exception ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Veillez selctionner au moins une ligne", ArgumentOutOfRangeException.HelpLink);
                   
                   




                }
            }

            

        }

        public void ViderForme(Panel p)
        {
            //tbcCategorie.SelectedTab = tbcMiseAjour;

            foreach (Control ctl in p.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    ctl.Text = "";
                }
            }
         
        }

        public void ViderGroup(GroupBox groupBox)
        {
            foreach (Control ctlgroup in groupBox.Controls)
            {
                if(ctlgroup.GetType() == typeof(TextBox))
                {
                    ctlgroup.Text = "";
                }
            }
        }





    }
}
