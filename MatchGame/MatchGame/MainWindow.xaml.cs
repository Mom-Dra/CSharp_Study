using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private int tenthsOfSecondsElapsed;
        private int matchesFound;

        private TextBlock lastTextBlockClicked;
        private bool findingMatch = false;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;  
            SetUpGame();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ++tenthsOfSecondsElapsed;
            TimeTextBlock.Text = (tenthsOfSecondsElapsed / 10f).ToString("0.0s");

            if(matchesFound == 8)
            {
                timer.Stop();
                TimeTextBlock.Text = TimeTextBlock.Text + " - Play again?";
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "☠", "☠",
                "🐀", "🐀",
                "👻", "👻",
                "🐬", "🐬",
                "🦚", "🦚",
                "🦄", "🦄",
                "🦔", "🦔",
                "🦍", "🦍"
            };

            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if(!textBlock.Name.Equals("TimeTextBlock"))
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(animalEmoji.Count);
                    string nextemoji = animalEmoji[index];
                    textBlock.Text = nextemoji;
                    animalEmoji.RemoveAt(index);
                }
            }

            timer.Start();
            tenthsOfSecondsElapsed = 0;
            matchesFound = 0;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                ++matchesFound;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetUpGame();
            }
        }
    }
}