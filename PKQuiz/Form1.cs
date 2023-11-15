using System.Media;

namespace PKQuiz
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;
        public Form1()
        {
            InitializeComponent();
            Thread music = new Thread(musicExecution);
            music.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void musicExecution()
        {
            player = new SoundPlayer("E:\\Visual Studio\\Projects\\PKQuiz\\Gotta catch.wav");
            player.Load();
            player.Play();
        }
    }
}