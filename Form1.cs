using CsvHelper;
using CsvHelper.Configuration;
using System.Diagnostics;
using System.Text.Json;

namespace AnkiApp
{
    public enum QuestionOption
    {
        First,
        Second,
        Third,
        Fourth
    }

    public enum DifficultyOption
    {
        Hard,
        Medium,
        Easy
    }

    public partial class Form1 : Form
    {
        public const string DeckName = "Default1";
        private readonly string LocalStoragePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\VhApp\LocalStorage.json";
        private readonly AnkiService _ankiService = new();
        private long? _currentCardId = null;
        private bool _solutionShown = true;
        private int _correctAnswersCount = 0;
        private int _questionsCount = 0;
        private QuestionOption _correctAnswer;
        private Dictionary<QuestionOption, RadioButton> _questionToRadioButtons;
        private Dictionary<DifficultyOption, RadioButton> _difficultyToRadioButtons;
        public Form1()
        {
            InitializeComponent();
            _questionToRadioButtons = new()
            {
                { QuestionOption.First, radioButtonOption0 },
                { QuestionOption.Second, radioButtonOption1 },
                { QuestionOption.Third, radioButtonOption2 },
                { QuestionOption.Fourth, radioButtonOption3 }
            };

            StartAnkiInBackground();

            GetCurrentScore();
            GenerateQuestion();
        }

        private void StartAnkiInBackground()
        {
            var localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var alreadyRunning = 
                Process
                .GetProcessesByName("Anki")
                .Any();
            var startInfo = new ProcessStartInfo
            {
                FileName = @$"{localAppDataPath}\Programs\Anki\anki.exe",
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            var process = new Process
            {
                StartInfo = startInfo
            };
            labelScore.Text = $"Score:{_correctAnswersCount}/{_questionsCount}";
            process.Start();
        }

        private void GetCurrentScore()
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(LocalStoragePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(LocalStoragePath));
                }
                if(!File.Exists(LocalStoragePath)) 
                {
                    File.Create(LocalStoragePath);
                }
                var text = File.ReadAllText(LocalStoragePath);
                var scores = JsonSerializer.Deserialize<SessionInfo>(text);
                _correctAnswersCount = scores.ScoreCorrect;
                _questionsCount = scores.ScoreTotalCount;
            }
            catch{ }
        }

        private void buttonEditSelection_Click(object sender, EventArgs e)
        {
            var makeSelectionForm = new MakeSelectionsForm();
            if (makeSelectionForm.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = makeSelectionForm.SelectedItems;
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                await _ankiService.DeleteAndCreateDeck(DeckName);
                var cards = ReadCsvFile(fileDialog.FileName);
                await _ankiService.AddNotesAsync(DeckName, cards);
            }
        }

        private async void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            GenerateQuestion();
        }

        public async void GenerateQuestion()
        {
            buttonNextQuestion.Enabled = false;
            var random = new Random(DateTime.Now.Millisecond);
            await UpdateDifficulty();

            var cardIds = await _ankiService.FindCards(DeckName, richTextBox1.Text);
            Shuffle(cardIds, random);
            if (cardIds is null)
                return;
            var pos = random.Next(0, 4);
            var cardDetails = await _ankiService.GetCardsDetails(cardIds.Take(4).ToList());
            int i = 0;
            foreach (var mapping in _questionToRadioButtons)
            {
                var answer = $"{Encryption.Decrypt(cardDetails[i]["fields"]["Back"]["value"].ToString())}";

                if (i == pos)
                {
                    _currentCardId = cardIds[i];
                    labelQuestion.Text = $"{Encryption.Decrypt(cardDetails[i]["fields"]["Front"]["value"].ToString())}";
                    labelSolution.Text = answer;
                    mapping.Value.Text = answer;
                    _correctAnswer = mapping.Key;
                }
                else
                {
                    mapping.Value.Text = answer;
                }
                i++;
            }
            labelSolution.Visible = false;
            _solutionShown = false;
            buttonNextQuestion.Enabled = true;
        }

        // Read CSV file into a list of Card objects
        public static List<Card> ReadCsvFile(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture));
            return new List<Card>(csv.GetRecords<Card>());
        }

        private void buttonReveal_Click(object sender, EventArgs e)
        {
            var correctAnswerSelected = false;
            foreach(var mapping in _questionToRadioButtons)
            {
                if(mapping.Key == _correctAnswer && mapping.Value.Checked)
                    correctAnswerSelected = true;
            }
            if (!_solutionShown)
            {
                _solutionShown = true;
                _questionsCount++;
                if (correctAnswerSelected)
                    _correctAnswersCount++;
            }
            labelSolution.Visible = true;
            labelScore.Text = $"Score:{_correctAnswersCount}/{_questionsCount}";
            UpdateScore();
        }

        private void UpdateScore()
        {
            var sessionInfo = new SessionInfo { ScoreCorrect = _correctAnswersCount, ScoreTotalCount = _questionsCount };
            var serialized = JsonSerializer.Serialize(sessionInfo);
            File.WriteAllText(LocalStoragePath, serialized);
        }

        private async Task UpdateDifficulty()
        {
            if (_currentCardId is null)
                return;

            if (radioButtonEasy.Checked)
            {
                await _ankiService.SubmitReview(_currentCardId.Value, 4);
            }
            else if (radioButtonMedium.Checked)
            {
                await _ankiService.SubmitReview(_currentCardId.Value, 3);
            }
            else if (radioButtonHard.Checked)
            {
                await _ankiService.SubmitReview(_currentCardId.Value, 2);
            }
        }

        public static void Shuffle<T>(IList<T> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
