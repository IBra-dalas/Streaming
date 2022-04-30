using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmail
{
    class Contact
    {
        Donnees d = new Donnees();
        public int numcontact { get => numcontact; set => numcontact = value; }
        public string nomcantact { get => nomcantact; set => nomcantact = value; }
        public byte[] photo { get => photo; set => photo = value; }

        public string PROC_SavePicture()
        {
            string fileStreamSavePicture = null;
            byte[] img;
            using (System.IO.FileStream fileStream = new FileStream(fileStreamSavePicture, FileMode.Open, FileAccess.Read))
            {
                img = new Byte[fileStream.Length];
                fileStream.Read(img, 0, (int)fileStream.Length);
            }

            d.cmd = new SqlCommand("SavePicture", d.Con)
            {
                CommandType = CommandType.StoredProcedure
            };

            using (SqlConnection conn = new SqlConnection())
            {
                d.cmd.CommandText = "PROC_SavePicture";
                d.cmd.Parameters.AddWithValue("@fileStreamSavePicture", fileStreamSavePicture);
                d.cmd.Parameters["@fileStreamSavePicture"].Direction = ParameterDirection.Output;
                d.cmd.Parameters.Add("@photo", SqlDbType.Image);
                d.cmd.Parameters["@photo"].Direction = ParameterDirection.Output;
             
                d.cmd.Parameters["@photo"].Value = img;
                d.Connecter();
                d.cmd.Connection = d.Con;

                d.cmd.ExecuteNonQuery();
            }


            return null;

            //BinaryReader binaryReader = new BinaryReader(fileStream);
            //img = binaryReader.ReadBytes((int)fileStream.Length);
            //fileStream.Close();
        }

    }
}
