namespace PKQuiz
{
    public partial class Form2 : Form
    {
        private int vidasRestantes = 3;
        private int acertos = 0;
        private int questionIndex = 0;
        private Image[] images = { Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Gengar.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Squirtle.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Charizard.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Dewgong.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Kabutops.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Arbok.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Pikachu.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Wigglytuff.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Weezing.png"),
                                   Image.FromFile("E:\\Visual Studio\\Projects\\PKQuiz\\Hitmonlee.png") };


        private string[][] options = { new[] { "Charizard", "Gengar", "Electrode", "Kabutops" },
                                       new[] { "Squirtle", "Blastoise", "Mew", "Lapras"},
                                       new[] { "Dragonite", "Xerneas", "Charizard", "Gyarados"},
                                       new[] { "Nidoran", "Clefairy", "Poliwag", "Dewgong"},
                                       new[] { "Kabutops", "Machop", "Cubone", "Kangaskhan"},
                                       new[] { "Horsea", "Seaking", "Pinsir", "Arbok"},
                                       new[] {"Jolteon", "Zapdos", "Pikachu", "Electrode"},
                                       new[] {"Jigglypuff", "Venomat", "Lickitung", "Wigglytuff"},
                                       new[] {"Jinx", "Weezing", "Ariados", "Scyther"},
                                       new[] {"Hitmonlee", "Hitmochan", "Onix", "Golem"} };
        private int[] correctAnswers = { 1,0,2,3,0,3,2,3,1,0 };
        private PictureBox[] lifePictureBoxes;

        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = images[questionIndex];
            button1.Text = options[questionIndex][0];
            button2.Text = options[questionIndex][1];
            button3.Text = options[questionIndex][2];
            button4.Text = options[questionIndex][3];
            lifePictureBoxes = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4 };
            UploadLifeImages();
        }

        private void UploadLifeImages()
        {
            for (int i = 0; i < lifePictureBoxes.Length; i++)
            {
                lifePictureBoxes[i].Visible = i < vidasRestantes;
            }
            if (vidasRestantes == 0)
            {
                MessageBox.Show($"Você perdeu! Desempenho: {acertos} de {images.Length}");
                questionIndex = 0;
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }

        }
        private void CheckAnswer(int SelectedAnswer)
        {
            if (SelectedAnswer == correctAnswers[questionIndex])
            {
                acertos++;
                MessageBox.Show("Você acertou!");
            }
            else
            {
                vidasRestantes--;
                MessageBox.Show("ERROU!");
                UploadLifeImages();
            }

            questionIndex++;

            if (questionIndex < images.Length)
            {
                LoadQuestion();
            }
            else
            {
                MessageBox.Show($"Quiz Concluído! Pontuação: {acertos} de {images.Length}");
                this.Close();
            }
        }

        private void LoadQuestion()
        {
            pictureBox1.Image = images[questionIndex];
            button1.Text = options[questionIndex][0];
            button2.Text = options[questionIndex][1];
            button3.Text = options[questionIndex][2];
            button4.Text = options[questionIndex][3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
