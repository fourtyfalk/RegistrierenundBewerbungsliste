using LoginSysten;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrierenundBewerbungsliste
{
    public partial class Anmelden : Form
    {
        Config dataBase = new Config();
        public Anmelden()
        {
            InitializeComponent();
            dataBase.Connect("benutzerliste");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.ExecuteSelect("SELECT * FROM `benutzer_info` where Benutzername='" + textBox1.Text + "' and Passwort ='" + textBox2.Text + "'");
            if (dataBase.Count() == 1)
            {
                MessageBox.Show("Glückwunsch du hast Schritt Eins geschafft!^^");
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort stimmen nicht! Versuche es nochmal!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrieren registrieren = new Registrieren();
            registrieren.Show();
        }
    }
}
