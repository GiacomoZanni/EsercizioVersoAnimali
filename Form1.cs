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
        }

        protected virtual void OnAnimaleStanco()
        {
            AnimaleStanco?.Invoke(this, EventArgs.Empty);
        }

        private void Cane_Click(object sender, EventArgs e)
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Canecheabbaia.wav");
            //player.Play();
            clickCane++;
            if (clickCane > 3)
            {
                AnimaleStanco += ImmagineCaneStanco;
                OnAnimaleStanco();
                clickCane = 0;
                AnimaleStanco -= ImmagineCaneStanco;
                Thread.Sleep(60000);
            }
        }

        private void Gatto_Click(object sender, EventArgs e)
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Gattochemiagola.wav");
            //player.Play();
            clickGatto++;
            if (clickGatto > 3)
            {
                AnimaleStanco += ImmagineGattoStanco;
                OnAnimaleStanco();
                clickGatto = 0;
                Thread.Sleep(60000);
                Gatto.Image = Image.FromFile("C:\\Users\\12999367\\source\\repos\\EsercizioVersoAnimali\\Immagini\\gatto.jpg");
            }
            AnimaleStanco -= ImmagineGattoStanco;
        }

        private void Mucca_Click(object sender, EventArgs e)
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Muccachemuggisce.wav");
            //player.Play();
            clickMucca++;
            if (clickMucca > 3)
            {
                AnimaleStanco += ImmagineMuccaStanca;
                OnAnimaleStanco();
                clickMucca = 0;
                AnimaleStanco -= ImmagineMuccaStanca;
                Thread.Sleep(60000);
            }
        }

        private void Capra_Click(object sender, EventArgs e)
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Utente\Downloads\Capracheurla.wav");
            //player.Play();
            clickCapra++;
            if (clickCapra > 3)
            {
                AnimaleStanco += ImmagineCapraStanca;
                OnAnimaleStanco();
                clickCapra = 0;
                AnimaleStanco -= ImmagineCapraStanca;
                Thread.Sleep(60000);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImmagineCaneStanco(object sender, EventArgs e)
        {
            Cane.Image = Image.FromFile("C:\\Users\\12999367\\source\\repos\\EsercizioVersoAnimali\\Immagini\\canechedorme.jpg");
        }

        private void ImmagineGattoStanco(object sender, EventArgs e)
        {
            Gatto.Image = Image.FromFile("C:\\Users\\12999367\\source\\repos\\EsercizioVersoAnimali\\Immagini\\gattochedorme.jfif");
        }

        private void ImmagineMuccaStanca(object sender, EventArgs e)
        {
            Mucca.Image = Image.FromFile("C:\\Users\\12999367\\source\\repos\\EsercizioVersoAnimali\\Immagini\\muccachedorme.jfif");
        }

        private void ImmagineCapraStanca(object sender, EventArgs e)
        {
            Capra.Image = Image.FromFile("C:\\Users\\12999367\\source\\repos\\EsercizioVersoAnimali\\Immagini\\caprachedorme.jfif");
        }
    }
}