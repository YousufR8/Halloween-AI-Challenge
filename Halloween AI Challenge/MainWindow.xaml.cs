using System;
using System.Windows;

namespace JokeApp
{
    public partial class MainWindow : Window
    {
        private readonly string[] jokes =
        {
            "Why don't scientists trust atoms? Because they make up everything!",
            "Did you hear about the mathematician who's afraid of negative numbers? He'll stop at nothing to avoid them!",
            "Why did the computer go to therapy? Because it had too many bytes of emotional baggage!",
            "Why did the scarecrow win an award? Because he was outstanding in his field!",
            "What do you call fake spaghetti? An impasta!"
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnTellJokeButtonClick(object sender, RoutedEventArgs e)
        {
            TellJoke();
        }

        private void TellJoke()
        {
            Random random = new Random();
            int jokeIndex = random.Next(jokes.Length);

            jokeTextBlock.Text = jokes[jokeIndex];
        }
    }
}
