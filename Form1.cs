using System.Media;

namespace EsercizioVersoAnimali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cane_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Canecheabbaia.wav");
            player.Play();
        }

        private void Gatto_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Gattochemiagola.wav");
            player.Play();
        }

        private void Mucca_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Muccachemuggisce.wav");
            player.Play();
        }

        private void Capra_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Capracheurla.wav");
            player.Play();
        }
    }
}