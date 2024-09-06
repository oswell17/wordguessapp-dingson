namespace wordguessapp_dingson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] words = new[] {"Lumpia","Adobo","Ube","Pancit Bihon",
                                "Sisig","Sinigang","Rice","Milktea",};
        int index = 0, score = 0;
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkword();
            if (index < words.Length - 1)
            {
                index++;
                displayWord();
            }


        }

        private void button_start_Click(object sender, EventArgs e)
        {
            index = 0;
            score = 0;
            label_result.Text = "Result";
            label_result.BackColor = Color.Peru;
            label_score.Text = "00";
            displayWord();
            button_next.Enabled = true;
            button_start.Enabled = false;


        }
        // this section create a function to display the words
        public void displayWord()
        {
            int pos1 = random.Next(words[index].Length);
            int pos2 = random.Next(words[index].Length);
            int pos3 = random.Next(words[index].Length);

            string word = words[index];

            word = word.Remove(pos1, 1).Insert(pos1, "?");
            word = word.Remove(pos2, 1).Insert(pos2, "?");
            word = word.Remove(pos3, 1).Insert(pos3, "?");

            label_word.Text = word;
        }
        //this section check if guess is correct

        public void checkword()
        {
            if (textBox_guess.Text.Equals(words[index]))
            {
                label_result.Text = "Correct";
                label_result.BackColor = Color.Green;
                score++;

            }
            else
            {
                label_result.Text = "Wrong";
                label_result.BackColor = Color.Red;

            }
            if (index == words.Length - 1)
            {
                button_start.Enabled = true;
                button_next.Enabled = false;
            }
            textBox_guess.Text = "";
            label_score.Text = score.ToString() + " / " + words.Length.ToString();
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_result_Click(object sender, EventArgs e)
        {

        }

        private void label_totalresult_Click(object sender, EventArgs e)
        {
            label_totalresult.Text = "Total Score: " + score.ToString();
            
        }

        private void label_word_Click(object sender, EventArgs e)
        {
        
        }
    }
}
