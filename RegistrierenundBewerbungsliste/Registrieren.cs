using LoginSysten;
using System.Windows.Forms;

namespace RegistrierenundBewerbungsliste
{
    public partial class Registrieren : Form
    {
        Config dataBase = new Config();
        public Registrieren()
        {
            InitializeComponent();
            dataBase.Connect("benutzerliste");
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Anmelden anmelden = new Anmelden();
            anmelden.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                dataBase.Execute("INSERT INTO `user_info` (`ID`, `Benutzername`, `Passwort`, `Passwort Wiederholen`, `E-Mail Adresse`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', " + textBox4.Text + ");");
                this.Close();
            }
            else
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein! Bitte wiederhole den Vorgang!");
            }
        }
    }
}
