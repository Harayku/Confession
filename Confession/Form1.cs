using System.Media;

namespace Confession
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_clickme_Click(object sender, EventArgs e)
        {
          
           SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "sadTrim.wav";
           soundPlayer.Play();
            btn_clickme.Hide();
            await Task.Delay(1000);
            label1.Text = "Once na nagkaroon ka ng crush";
            await Task.Delay(2500);
            label1.Text = "sa isang tao, confess it.";
            await Task.Delay(2500);
            label1.Text = "Huwag itago. Don't be afraid of rejections,";
            await Task.Delay(2500);
            label1.Text = "kasi lahat ng tao narereject naman talaga at some point.";
            await Task.Delay(2500);
            label1.Text = "Huwag mo solohin, let him/her know.";
            await Task.Delay(2500);
            label1.Text = "Nasa sakanya na yon kung paano niya iaccept";
            await Task.Delay(2500);
            label1.Text = "what matters most is that, malakas yung loob mo";
            await Task.Delay(2500);
            label1.Text = "to tell him/her about your feelings.";
            await Task.Delay(2500);
            label1.Text = "Hindi lang naman ikaw ang nagkakaganyan \nor nababaliw sa isang tao";
            await Task.Delay(3000);
            label1.Text = "Lahat tayo dumadaan sa stage na yan.";
            await Task.Delay(2500);
            label1.Text = "So amin amin din minsan malay mo may chance.";
            await Task.Delay(2500);
            label1.Text = "Be brave enough. Crush lang naman eh";
            await Task.Delay(2500);
            label1.Text = "Babae ka man o lalaki,";
            await Task.Delay(2500);
            label1.Text = "still andon parin dapat young braveness \nsa ganitong bagay";
            await Task.Delay(2500);
            label1.Text = "We are that matured enough para i-handle \nang ganitong situation";
            await Task.Delay(2500);
            label1.Text = "It's not even infatuation anymore.";
            await Task.Delay(3000);
            label1.Text = "G O O D L U C K  <3";
            await Task.Delay(3500);
            Application.Exit();
        }
    }
}
