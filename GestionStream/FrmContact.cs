using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------
using System.IO;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Drawing.Imaging;
using System.Threading;
using System.Media;
using Microsoft.DirectX.AudioVideoPlayback;
using Microsoft.DirectX;
using ConsignmentShopLibrary;

namespace GestionEmail
{
    public partial class FrmContact : Form
    {
        private string CheminDoc = "";
        private object m_image;
        private Byte[] m_barImage;
        private Video video;
        private string[] videoPath;
        private string foderPath = @"D:\usb dELL\Document\Doc Perso\Mes Projets\GestionEmail\GestionEmail\Video";
        private Size formSize;
        private Size pnlSize;
        private string path;
        //-------------------------------------------

        Video vdo;

        public string mode = "play";
        public string PlayingPosition, Duration;
        Donnees d = new Donnees();
        Contact contact = new Contact();

        //espace vente
        private Store store = new Store();
       
        private List<Item> shoppingCartData = new List<Item>();

        private BindingSource itemsBindingSource = new BindingSource();

        private BindingSource cartBinding = new BindingSource();
        //-----------------------------------------

        public FrmContact(string role)
        {
            InitializeComponent();
            LbStatus.Text = role;
            //charger la liste des vendeurs
            SetupDataVente();

            itemsBindingSource.DataSource = store.Items;
            itemListbox.DataSource = itemsBindingSource;
            itemListbox.DisplayMember = "Display";
            itemListbox.ValueMember = "Display";

            cartBinding.DataSource = shopingCartLabel;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            //shoppingCartListbox.ValueMember = "Display";

        }

        //esoace de vente


        private void SetupDataVente()
        {
            //store.Vendors = new List<Vendor>();
          
            store.Vendors.Add(new Vendor()
            {
                FirstName = "Diallo",
                LastName = "Mamadou"

            });

            store.Vendors.Add(new Vendor()
            {
                FirstName = "Bill",
                LastName = "Smith"

            });

            store.Items.Add(new Item()
            {
                Title = "Text1",
                Description = "Diallo Kingston",
                Price = 4.50M,
                Owner = store.Vendors[0]

            });
            store.Items.Add(new Item()
            {
                Title = "Text2",
                Description = "Smith",
                Price = 14.50M,
                Owner = store.Vendors[1]

            });
            store.Items.Add(new Item()
            {
                Title = "Text3",
                Description = "Diallo Kingston",
                Price = 7.50M,
                Owner = store.Vendors[0]

            });
            store.Items.Add(new Item()
            {
                Title = "Text4",
                Description = "Smith",
                Price = 8.50M,
                Owner = store.Vendors[1]

            });

            store.Name = "Seconds are Better";
        }

       

        public int SelectedIndex { get; set; } 

        private void FrmContact_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionDonneesDataSet.Contact'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.contactTableAdapter.Fill(this.gestionDonneesDataSet.Contact);
           /* formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(pnlVideo.Width, pnlVideo.Height);
            videoPath = Directory.GetFiles(foderPath, "*.mp4");
            if(videoPath != null)
            {
                foreach (string newPath in videoPath)
                {
                    string newVideo = newPath.Replace(foderPath, string.Empty);
                    newVideo = newVideo.Replace(".mp4", string.Empty);
                    LstVideo.Items.Add(newPath);
                  

                   
                }
            }*/
/*
            *//*LstVideo.SelectedIndex = SelectedIndex;*/
            //void LstVideo_SelectesIndexChanged(object senders, EventArgs ex)
            //{
            //    try
            //    {
            //        video.Stop();
            //        video.Dispose();
            //    }
            //    catch
            //    {

            //    }
            //    int index = LstVideo.SelectedIndex;
            //    SelectedIndex = index;
            //    video = new Video(videoPath[index], false)
            //    {
            //        Owner = pnlVideo
            //    };
            //    pnlVideo.Size = pnlSize;
            //    video.Play();
            //    TmVideo.Enabled = false;

            //    video.Ending += Video_Encoding;
            //    LbDocument.Text = LstVideo.Text;



            //}

        }

        private void Video_Encoding(object senders, EventArgs ex)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        NextVideo();
                    }));
                }
            });
        }

        private void NextVideo()
        {
           /* int index = LstVideo.SelectedIndex;
            index++;
            if(index > videoPath.Length - 1)
            {
                index = 0;
                SelectedIndex = index;
                LstVideo.SelectedIndex = index;
            }*/
        }

        private void _dataViewImage_cellcontentClick(object sender, DataGridViewCellEventArgs ex)
        {
            
            

        }
        private void FrmContact_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
           
        }

        private void BtnParcourir_Click(object sender, EventArgs e)
        {


            try
            {
                OpenFileDialog TryOpen = new OpenFileDialog
                {
                    Title = " Selectionner une photo "
                };
                if (TryOpen.ShowDialog() == DialogResult.OK)
                {
                   /* PicBoxImage.ImageLocation = TryOpen.FileName;
                    CheminDoc = TryOpen.FileName;*/
                }
                string maString = TryOpen.FileName;
                FileInfo InfoImage = new FileInfo(maString);
                this.m_image = InfoImage.Length;
                FileStream fileStream = new FileStream(maString, FileMode.Open, FileAccess.Read, FileShare.Read);
                m_barImage = new byte[Convert.ToInt32(this.m_image)];
                int iBytesRead = fileStream.Read(m_barImage, 0, Convert.ToInt32(this.m_image));
                fileStream.Close();
            }
            catch (Exception Exc)
            {

                MessageBox.Show(Exc.Message);
            }
        }

        private void BtnRetourCategorie_Click(object sender, EventArgs e)
        {
            FrmCategories frmCat = new FrmCategories();
            frmCat.Show();
            if (frmCat.Visible == true)
            {
                this.Hide();
            }
           

        }
        
        private void BtnEnregistrerContact_Click(object sender, EventArgs e)
        {

            try
            {
                d.Connecter();
                d.cmd.Connection = d.Con;
                if (d.cmd.Parameters.Count == 0)
                {
                    d.cmd.CommandText = "INSERT INTO Contact (numcontact,nomcontact,photo) VALUES(@numcontact,@nomcontact,@photo)";
                    d.cmd.Parameters.Add("@numcontact", SqlDbType.Int, 4);
                    d.cmd.Parameters.Add("@nomcontact", SqlDbType.VarChar, 50);
                    d.cmd.Parameters.Add("@photo", SqlDbType.Image);
                }
                /*d.cmd.Parameters["@numcontact"].Value = TxtNuContact.Text;
                d.cmd.Parameters["@nomcontact"].Value = TxtNomContact.Text;
                d.cmd.Parameters["@photo"].Value = m_barImage;*/

                int leResultat = d.cmd.ExecuteNonQuery();
                MessageBox.Show(Convert.ToString(leResultat));
            }
            catch (Exception Exc)
            {

                MessageBox.Show(Exc.Message);
            }
            finally
            {
                this.d.cmd.Clone();
            }





            //byte[] img = null;
            //
            //BinaryReader binaryReader = new BinaryReader(fileStream);
            //img = binaryReader.ReadBytes((int)fileStream.Length);
            //fileStream.Close();
            //d.Connecter();
            //d.cmd.Connection = d.Con;
            //d.cmd.CommandText = "INSERT INTO Contact (numcontact, nomcontact, photo) VALUES ('" + int.Parse(TxtNuContact.Text) + "','" + TxtNomContact + "' ,@img)";
            //d.cmd.Parameters.Add(new SqlParameter("@img", img));

            //d.cmd.ExecuteNonQuery();
            //MessageBox.Show("Ajout effectué avec success");
            //d.Deconnecter();

        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmCategories frmCat = new FrmCategories();
            frmCat.Show();
            if (frmCat.Visible == true)
            {
                this.Hide();
            }

        }

        private void BtnParcourContact_Click(object sender, EventArgs e)
        {

           /* if (vdo != null)
            {
                vdo.Stop();
                TmVideo.Stop();
                BtnPlay.BackgroundImage = GestionEmail.Properties.Resources.foret_dalaba;
                trackVolume.Value = 0;

            }*/
            OpenFileDialog openFilDialog = new OpenFileDialog();
            openFilDialog.ShowDialog();
            openFilDialog.Title = "Select video file..";
            openFilDialog.InitialDirectory = Application.StartupPath;
            openFilDialog.DefaultExt = ".avi";
            openFilDialog.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3|All Files|*.*";
           /* if (openFilDialog.FileName != "")
            {
                FrmContact.ActiveForm.Text = openFilDialog.FileName + " - Anand Media Player";
                vdo = new Video(openFilDialog.FileName)
                {
                    Owner = pnlVideo
                };
                formSize = new Size(this.Width, this.Height);
                pnlSize = new Size(pnlVideo.Width, pnlVideo.Height);
                Duration = CalculateTime(vdo.Duration);
                PlayingPosition = "0:00:00";
                LblVideoPosition.Text = PlayingPosition + "/" + Duration;

                trackVolume.Minimum = 0;
                trackVolume.Maximum = Convert.ToInt32(vdo.Duration);
            }*/

            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "All Files Video (*.mp4)|*.mp4|Audio Files (*.mp3)|*.mp3"
            };


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;

            }
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    CheminDoc = dialog.FileName;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

      

        private void BtnPause_Click(object sender, EventArgs e)
        {

          /*  vdo.Stop();
            TmVideo.Stop();
            BtnPlay.BackgroundImage = Properties.Resources.foret_dalaba;
            trackVolume.Value = 0;*/

            //if (video.Paused)
            //{
            //    video.Play();
            //    TmVideo.Enabled = false;
            //    BtnPlay.Text = "PLAY";
            //}
            //else if (video.Playing)
            //{
            //    video.Pause();
            //    TmVideo.Enabled = true;
            //    BtnPause.Text = "PAUSE";
            //}
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            NextVideo();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            PreviousVideo();
        }

        private void PreviousVideo()
        {
          /*  int index = LstVideo.SelectedIndex;
            index--;
            if(index == - 1)
            {
                index = videoPath.Length - 1;
                SelectedIndex = index;
                LstVideo.SelectedIndex = index;
            }*/
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (vdo != null)
            {
               /* if (vdo.Playing)
                {
                    vdo.Pause();
                    TmVideo.Stop();
                    BtnPlay.BackgroundImage = Properties.Resources.foret_dalaba;
                }
                else
                {
                    vdo.Play();
                    TmVideo.Start();

                    BtnPlay.BackgroundImage = Properties.Resources.foret_dalaba;
                }*/
            }

            //int index = LstVideo.SelectedIndex;

            //if (videoPath != null)
            //{
            //    foreach (string newPath in videoPath)
            //    {
            //        string newVideo = newPath.Replace(foderPath, string.Empty);
            //        newVideo = newVideo.Replace(".mp4", string.Empty);
            //        LstVideo.Items.Add(newPath);

            //        video = new Video(videoPath[index], false)
            //        {
            //            Owner = pnlVideo
            //        };
            //        video.Play();


            //    }
            //}



        }

        
        private void BtnFullScreem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            video.Owner = this;
        }

        private void LstVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                video.Stop();
                video.Dispose();
            }
            catch
            {

            }
            //int index = LstVideo.SelectedIndex;
            //SelectedIndex = index;

            //  video = new Video(videoPath[index], false);
            //video.Open(videoPath[index]);

            //video.Owner = pnlVideo;
            //pnlVideo.Size = pnlSize;
            //video.Play();
            //TmVideo.Enabled = true;
            //BtnPlay.Text = "PAUSE";
            //video.Ending += Video_Encoding;
            //LblVideo.Text = LstVideo.Text;
        }

        private void FrmContact_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
               /* FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                this.Size = formSize;
                video.Owner = pnlVideo;
                pnlVideo.Size = pnlSize;*/
            }
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            if (vdo != null)
            {
                vdo.Audio.Volume = CalculateVolume();
            }
        }

        private void BtnVolume_Click(object sender, EventArgs e)
        {

        }

        private void TmVideo_Tick(object sender, EventArgs e)
        {
            PlayingPosition = CalculateTime(vdo.CurrentPosition);
           /* LblVideoPosition.Text = PlayingPosition + "/" + Duration;

            if (vdo.CurrentPosition >= vdo.Duration)
            {
                TmVideo.Stop();
                Duration = CalculateTime(vdo.Duration);
                PlayingPosition = "0:00:00";
                LblVideoPosition.Text = PlayingPosition + "/" + Duration;
                vdo.Stop();
                BtnPlay.BackgroundImage = GestionEmail.Properties.Resources.foret_dalaba;
                trackVolume.Value = 0;
            }
            else
                trackVolume.Value += 1;*/

        }

        public int CalculateVolume()
        {
            /* switch (trackVolume.Value)
             {
                 case 1:
                     return -1500;
                 case 2:
                     return -1000;
                 case 3:
                     return -700;
                 case 4:
                     return -600;
                 case 5:
                     return -500;
                 case 6:
                     return -400;
                 case 7:
                     return -300;
                 case 8:
                     return -200;
                 case 9:
                     return -100;
                 case 10:
                     return 0;
                 default:
                     return -10000;
             }*/
            return -10000;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnChoosefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TxtBrowse.Text = openFileDialog.FileName;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            WinPlayer.URL = TxtBrowse.Text;
            WinPlayer.Ctlcontrols.play();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            WinPlayer.Ctlcontrols.stop();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void purchaseItem_Click(object sender, EventArgs e)
        {
            //figure
            //copy
            //do we remove
            Item selectedItem = (Item)itemListbox.SelectedItem;
            shoppingCartData.Add(selectedItem);


        }

        private void makePurchase_Click(object sender, EventArgs e)
        {

        }

        public string CalculateTime(double Time)
        {
            string mm, ss, CalculatedTime;
            int h, m, s, T;

            Time = Math.Round(Time);
            T = Convert.ToInt32(Time);

            h = (T / 3600);
            T = T % 3600;
            m = (T / 60);
            s = T % 60;

            if (m < 10)
                mm = string.Format("0{0}", m);
            else
                mm = m.ToString();
            if (s < 10)
                ss = string.Format("0{0}", s);
            else
                ss = s.ToString();

            CalculatedTime = string.Format("{0}:{1}:{2}", h, mm, ss);

            return CalculatedTime;
        }

    }
}
