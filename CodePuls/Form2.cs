using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace CodePuls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            //initialisation du component + definition d'un evenement clavier
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //definis la taille de la fenetre en plein écran 
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_POSITIVE);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //definition du script a exectuter
                string progToRun = "C:\\Dev\\testPuls\\CodePuls\\try.py";
                char[] spliter = { '\r' };

                //permet de lancer python (python necessaire sur la machine)
                Process proc = new Process();
                proc.StartInfo.FileName = "python.exe";
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false;

                //indique le script qui vas etre lancer
                proc.StartInfo.Arguments = string.Concat(progToRun);
                proc.Start();
                Application.Exit();
            }
            if(e.KeyCode == Keys.Right)
            {
                //cache la fenetre active et ouvre la fenetre principale
                /*this.Hide();*/
                var home = new Form1();
                home.Closed += (s, args) => this.Close();
                home.Show();
                this.Close();
            }
        }

    }
}
