using System.Media;

namespace EsercizioVersoAnimali
{
    public partial class Form1 : Form
    {
        int clickCane = 0;
        int clickGatto = 0;
        int clickMucca = 0;
        int clickCapra = 0;
        public event EventHandler<EventArgs> AnimaleStanco;

        public Form1()
        {
            InitializeComponent();
            AnimaleStanco += ImmagineCaneStanco;
            AnimaleStanco += ImmagineGattoStanco;
            AnimaleStanco += ImmagineMuccaStanca;
            AnimaleStanco += ImmagineCapraStanca;
        }

        protected virtual void OnAnimaleStanco()
        {
            AnimaleStanco?.Invoke(this, EventArgs.Empty);
        }

        private void Cane_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Canecheabbaia.wav");
            player.Play();
            clickCane++;
            if (clickCane > 3)
            {
                OnAnimaleStanco();
                clickCane = 0;
            }
        }

        private void Gatto_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Gattochemiagola.wav");
            player.Play();
            clickGatto++;
            if (clickGatto > 3)
            {
                OnAnimaleStanco();
                clickGatto = 0;
            }
        }

        private void Mucca_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Muccachemuggisce.wav");
            player.Play();
            clickMucca++;
            if (clickMucca > 3)
            {
                OnAnimaleStanco();
                clickMucca = 0;
            }
        }

        private void Capra_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Capracheurla.wav");
            player.Play();
            clickCapra++;
            if (clickCapra > 3)
            {
                OnAnimaleStanco();
                clickCapra = 0;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImmagineCaneStanco(object sender, EventArgs e)
        {

        }

        private void ImmagineGattoStanco(object sender, EventArgs e)
        {

        }

        private void ImmagineMuccaStanca(object sender, EventArgs e)
        {

        }

        private void ImmagineCapraStanca(object sender, EventArgs e)
        {

        }
    }
}