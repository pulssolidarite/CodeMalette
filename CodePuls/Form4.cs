using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace CodePuls
{
    public partial class Form4 : Form
    {

        //definition de variables qui seront utiles pour lancer la video
        private Video video;
        private Video video2;
        private string[] videoPaths;
        private readonly string folderPath = @"C:\Dev\testPuls\CodePuls";
        private int selectedIndex = 0;
        private int selectedIndex2 = 1;
        private Size pnlSize;
        private Size pnlPlaySize;

        public Form4()
        {
            //initialisation du component + definition d'un evenement clavier
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form4_KeyDown);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //definis la taille de la fenetre en plein écran 
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_NEGATIVE);

            tmrThumb.Interval = (1000) * (2);
            tmrThumb.Enabled = true;

            pnlSize = new Size(pnlVideo.Width, pnlVideo.Height);
            pnlPlaySize = new Size(pnlPlay.Width, pnlPlay.Height);

            //definis la taille de la fenetre en plein écran fenetré
            /*this.WindowState = FormWindowState.Maximized;*/
            //recherche tous les fichier avec l'extension .wmv present dans le dossier donné
            videoPaths = Directory.GetFiles(folderPath, "*.wmv");

            //si une video ou des videos sont trouvées la premiere est lancée
            if (videoPaths != null)
            {
                //joue la premiere vidéo trouvé sur le panel le plus en avant
                video = new Video(videoPaths[selectedIndex], false)
                {
                    Owner = pnlPlay
                };
                pnlPlay.Size = pnlPlaySize;
                video.Play();
                tmrVideo.Enabled = true;

                //place la deuxieme vidéo sur le panel en arriere plan du carousel
                video2 = new Video(videoPaths[selectedIndex2], false)
                {
                    Owner = pnlVideo
                };
                pnlVideo.Size = pnlSize;
                video.Audio.Volume = -10000;
                video2.Play();
                tmrThumb.Start();
                //fonction qui permet l'affichage des point en dessous du carousel
                ManageCarousel();

            }
        }


        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                //Arrete totalements les video et retour a la fenetre d'accueil
                video.Stop();
                video.Dispose();
                video2.Stop();
                video2.Dispose();
                var home = new Form1();
                home.Closed += (s, args) => this.Close();
                home.Show();
                this.Close();
  
            }
            if(e.KeyCode == Keys.Right)
            {
                //arrete toutes les vidéos
                video.Stop();
                video2.Stop();

                //changement de selectIndex et selectIndex 2 pour le changement de vidéo
                selectedIndex++;
                if(selectedIndex > 1)
                {
                    selectedIndex = 0;
                }
                selectedIndex2--;
                if(selectedIndex2 < 0)
                {
                    selectedIndex2 = 1;
                }

                //actualise la vidéo qui est jouée
                if (videoPaths != null)
                {
                    //joue la premiere vidéo trouvé sur le panel le plus en avant
                    video = new Video(videoPaths[selectedIndex], false)
                    {
                        Owner = pnlPlay
                    };
                    pnlPlay.Size = pnlPlaySize;
                    video.Play();
                    tmrVideo.Enabled = true;

                    //place la deuxieme vidéo sur le panel en arriere plan du carousel
                    video2 = new Video(videoPaths[selectedIndex2], false)
                    {
                        Owner = pnlVideo
                    };
                    pnlVideo.Size = pnlSize;
                    video.Audio.Volume = -10000;
                    video2.Play();
                    tmrThumb.Start();
                    ManageCarousel();

                }
            }
        }

        

        private void TmrThumb_Tick(object sender, EventArgs e)
        {
            //permet de voir un apperçu de la video pour ne pas avoir une ecran noir
            tmrThumb.Stop();
            video2.Pause();
        }

        private void ManageCarousel()
        {
            Task.Factory.StartNew(() =>
            {
                if (selectedIndex == 0)
                {
                    carousel1.BackgroundImage = Properties.Resources.grand_cercle;
                    carousel2.BackgroundImage = Properties.Resources.petit_cercle;
                }
                if (selectedIndex == 1)
                {
                    carousel1.BackgroundImage = Properties.Resources.petit_cercle;
                    carousel2.BackgroundImage = Properties.Resources.grand_cercle;
                }
            });
        }

        


    }
}
