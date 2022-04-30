using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionEmail
{
    class Categorie
    {
        Donnees d = new Donnees();
        
        private int numcat;
        private string nomcat;
        //public int numcat
        //{
        //    get { return numcat; }
        //    set { numcat = value; }
        //}
        //public string nomcat
        //{
        //    get { return nomcat; }
        //    set { nomcat = value; }
        //}

        public int Numcat { get => numcat; set => numcat = value; }
        public string Nomcat { get => nomcat; set => nomcat = value; }

        public string INSERT_CATEGORIE ()
        {
            d.Connecter();
            d.cmd.Parameters.Clear();
            d.cmd.CommandText = "PROC_INSERT_CATEGORIE";
            d.cmd.CommandType = CommandType.StoredProcedure;
            d.cmd.Parameters.Add("@numcat", SqlDbType.BigInt).Value = numcat;
            d.cmd.Parameters.Add("@nomcat", SqlDbType.NVarChar, 10).Value = nomcat;
            SqlParameter ok = new SqlParameter("ok", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output //redirection 
            };  //Parametre de sortie
            d.cmd.Parameters.Add(ok);
            d.cmd.Connection = d.Con;
            d.cmd.ExecuteNonQuery();
            d.Deconnecter();
            return ok.Value.ToString();
        }

    }
}
