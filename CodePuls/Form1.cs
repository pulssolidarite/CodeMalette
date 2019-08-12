using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;


namespace CodePuls
{
    public partial class Form1 : Form
    {
        FormCollection fc = Application.OpenForms;

        public Form1()
        {
            //initialisation du component + definition d'un evenement clavier
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {
            //definis la taille de la fenetre en plein écran 
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            MessageBox.Show(Environment.CurrentDirectory);

            foreach (Form frm in fc)
            {
                if (frm.Name == "Form4")
                {
                    //lance une animation si le dernier form ouvert etait le form4
                    WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_POSITIVE);
                }
                if(frm.Name == "Form2")
                {
                    //lance une animation si le dernier form ouvert etait le form2
                    WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_NEGATIVE);
                }
            }

        }


         private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                //cache la fenetre active
                //ouvre la fenetre de choix du jeu lorsqu'on appuis sur la fleche de droite
                
                var gameChoice = new Form2();
                gameChoice.Show();
            }
            if (e.KeyCode == Keys.Right)
            {
                //cache la fenetre active
                //ouvre la fenetre de video lors de l'appuis sur la touche droite
                
                var videoPlayer = new Form4();
                videoPlayer.Show();
            }
        }

    }
}
