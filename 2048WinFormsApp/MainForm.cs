
namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private const int labelSize = 100;
        private const int padding = 6;
        private const int startX = 10;
        private const int startY = 100;

        private static Random random = new Random();

        private int fieldSize = 4;
        private int lastFieldSize;
        private int scoreValue = 0;
        private int bestScoreValue = 0;
        private int emptyLabelsNumbersCount;
        private Label[,] labelsField;
        private User user;
        private FieldSizeForm fieldSizeForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserNameForm userNameForm = new UserNameForm();
            userNameForm.ShowDialog();
            user = new User(userNameForm.Name);
            StartGame();
        }

        private void StartGame()
        {
            InitField();
            GenerateNumber();
            ShowScore();
            CalculateBestScore();
            ShowBestScore();
        }

        private void CalculateBestScore()
        {
            var users = ResultStorage.Get();
            if (users.Count == 0)
            {
                return;
            }

            bestScoreValue = users.Max(value => value.ScoreValue);
            ShowBestScore();
        }

        private void ShowBestScore()
        {
            bestScoreValueLabel.Text = Math.Max(scoreValue, bestScoreValue).ToString();
        }

        private void ShowScore()
        {
            scoreValueLabel.Text = scoreValue.ToString();
        }

        public void InitField()
        {
            ClientSize = new Size(startX + (labelSize + padding) * fieldSize, startY + (labelSize + padding) * fieldSize);
            labelsField = new Label[fieldSize, fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    var newLabel = CreateLable(i, j);
                    Controls.Add(newLabel);
                    labelsField[i, j] = newLabel;
                }
            }
        }

        private static string RandomNumber()
        {
            int procentRandomValue = random.Next(1, 100);
            if (procentRandomValue < 25)
            {
                return "4";
            }
            else
            {
                return "2";
            }
        }

        private void GenerateNumber()
        {

            var emptyLabelsNumbers = new List<int> { };
            var labelsNumber = 0;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    labelsNumber++;
                    if (labelsField[i, j].Text == String.Empty)
                    {
                        emptyLabelsNumbers.Add(labelsNumber);
                    }
                }
            }

            emptyLabelsNumbersCount = emptyLabelsNumbers.Count;

            if (emptyLabelsNumbers.Count > 0)
            {
                var randomEmptyLabelIndex = random.Next(emptyLabelsNumbers.Count);
                var randomEmptyLabelNumber = emptyLabelsNumbers[randomEmptyLabelIndex] - 1;
                var rowIndex = randomEmptyLabelNumber / fieldSize;
                var columnIndex = randomEmptyLabelNumber % fieldSize;
                labelsField[rowIndex, columnIndex].Text = RandomNumber();
            }
        }

        private void IsEndGame()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsField[i, j].Text == "2048")
                    {
                        MessageBox.Show($"ПОБЕДА!\nВы набрали {scoreValue} очков!");
                        user.ScoreValue = scoreValue;
                        ResultStorage.Append(user);
                        lastFieldSize = fieldSize;
                        RestartGame();
                        break;
                    }
                }
            }

            if (emptyLabelsNumbersCount == 0)
            {
                bool flag1 = true;
                bool flag2 = true;
                for (int i = 0; i < fieldSize - 1 && flag1; i++)
                {
                    for (int j = 0; j < fieldSize - 1; j++)
                    {
                        if (labelsField[i, j].Text == labelsField[i + 1, j].Text || labelsField[i, j].Text == labelsField[i, j + 1].Text)
                        {
                            flag1 = false;
                            flag2 = false;
                            break;
                        }
                    }
                }
                for (int i = fieldSize - 1; i > fieldSize - 2 && flag2; i--)
                {
                    for (int j = fieldSize - 1; j > 0; j--)
                    {
                        if (labelsField[i, j].Text == labelsField[i - 1, j].Text || labelsField[i, j].Text == labelsField[i, j - 1].Text)
                        {
                            flag2 = false;
                            break;
                        }
                    }
                }

                if (flag1 == true && flag2 == true)
                {
                    MessageBox.Show($"КОНЕЦ ИГРЫ!\nВы набрали {scoreValue} очков!");
                    user.ScoreValue = scoreValue;
                    ResultStorage.Append(user);
                    lastFieldSize = fieldSize;
                    RestartGame();
                }
            }
        }

        private Label CreateLable(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.ControlDark;
            label.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(labelSize, labelSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = startX + indexColumn * (labelSize + padding);
            int y = startY + indexRow * (labelSize + padding);
            label.Location = new Point(x, y);

            label.TextChanged += Label_TextChanged;
            return label;
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            var label = (Label)sender;
            switch (label.Text)
            {
                case "": label.BackColor = SystemColors.ControlDark;break;
                case "2": label.BackColor = Color.FromArgb(211, 211, 203); break;
                case "4": label.BackColor = Color.FromArgb(187, 255, 187); break;
                case "8": label.BackColor = Color.FromArgb(255, 255, 157); break;
                case "16": label.BackColor = Color.FromArgb(177, 237, 234); break;
                case "32": label.BackColor = Color.FromArgb(172, 197, 242); break;
                case "64": label.BackColor = Color.FromArgb(174, 169, 245); break;
                case "128": label.BackColor = Color.FromArgb(107, 237, 120); break;
                case "256": label.BackColor = Color.FromArgb(97, 150, 248); break;
                case "516": label.BackColor = Color.FromArgb(211, 95, 250); break;
                case "1024": label.BackColor = Color.FromArgb(223, 142, 6); break;
                case "2048": label.BackColor = Color.FromArgb(234, 35, 0); break;
            }
        }

        private void RightKey()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = fieldSize - 1; j >= 0; j--)
                {
                    if (labelsField[i, j].Text != String.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsField[i, k].Text != String.Empty)
                            {
                                if (labelsField[i, j].Text == (labelsField[i, k].Text))
                                {
                                    var number = int.Parse(labelsField[i, j].Text);
                                    labelsField[i, j].Text = (number * 2).ToString();
                                    labelsField[i, k].Text = String.Empty;
                                    scoreValue += number * 2;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = fieldSize - 1; j >= 0; j--)
                {
                    if (labelsField[i, j].Text == String.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsField[i, k].Text != String.Empty)
                            {
                                labelsField[i, j].Text = labelsField[i, k].Text;
                                labelsField[i, k].Text = String.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
            IsEndGame();
            ShowScore();
            ShowBestScore();
        }

        private void LeftKey()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsField[i, j].Text != String.Empty)
                    {
                        for (int k = j + 1; k < fieldSize; k++)
                        {
                            if (labelsField[i, k].Text != String.Empty)
                            {
                                if (labelsField[i, j].Text == (labelsField[i, k].Text))
                                {
                                    var number = int.Parse(labelsField[i, j].Text);
                                    labelsField[i, j].Text = (number * 2).ToString();
                                    labelsField[i, k].Text = String.Empty;
                                    scoreValue += number * 2;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsField[i, j].Text == String.Empty)
                    {
                        for (int k = j + 1; k < fieldSize; k++)
                        {
                            if (labelsField[i, k].Text != String.Empty)
                            {
                                labelsField[i, j].Text = labelsField[i, k].Text;
                                labelsField[i, k].Text = String.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
            IsEndGame();
            ShowScore();
            ShowBestScore();
        }

        private void UpKey()
        {
            for (int j = 0; j < fieldSize; j++)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    if (labelsField[i, j].Text != String.Empty)
                    {
                        for (int k = i + 1; k < fieldSize; k++)
                        {
                            if (labelsField[k, j].Text != String.Empty)
                            {
                                if (labelsField[i, j].Text == (labelsField[k, j].Text))
                                {
                                    var number = int.Parse(labelsField[i, j].Text);
                                    labelsField[i, j].Text = (number * 2).ToString();
                                    labelsField[k, j].Text = String.Empty;
                                    scoreValue += number * 2;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < fieldSize; j++)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    if (labelsField[i, j].Text == String.Empty)
                    {
                        for (int k = i + 1; k < fieldSize; k++)
                        {
                            if (labelsField[k, j].Text != String.Empty)
                            {
                                labelsField[i, j].Text = labelsField[k, j].Text;
                                labelsField[k, j].Text = String.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
            IsEndGame();
            ShowScore();
            ShowBestScore();
        }

        private void DownKey()
        {
            for (int j = 0; j < fieldSize; j++)
            {
                for (int i = fieldSize - 1; i >= 0; i--)
                {
                    if (labelsField[i, j].Text != String.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsField[k, j].Text != String.Empty)
                            {
                                if (labelsField[i, j].Text == (labelsField[k, j].Text))
                                {
                                    var number = int.Parse(labelsField[i, j].Text);
                                    labelsField[i, j].Text = (number * 2).ToString();
                                    labelsField[k, j].Text = String.Empty;
                                    scoreValue += number * 2;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < fieldSize; j++)
            {
                for (int i = fieldSize - 1; i >= 0; i--)
                {
                    if (labelsField[i, j].Text == String.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsField[k, j].Text != String.Empty)
                            {
                                labelsField[i, j].Text = labelsField[k, j].Text;
                                labelsField[k, j].Text = String.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
            IsEndGame();
            ShowScore();
            ShowBestScore();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                RightKey();
            }

            if (e.KeyCode == Keys.Left)
            {
                LeftKey();
            }

            if (e.KeyCode == Keys.Up)
            {
                UpKey();
            }

            if (e.KeyCode == Keys.Down)
            {
                DownKey();
            }
        }

        public void RestartGame()
        {
            for (int i = 0; i < lastFieldSize; i++)
            {
                for (int j = 0; j < lastFieldSize; j++)
                {
                    Controls.Remove(labelsField[i,j]);
                }
            }
            scoreValue = 0;
            StartGame();
        }

        public void DetermineFielsdSize(List<RadioButton> radioButtons)
        {
            foreach (var radioButton in radioButtons)
            {
                if(radioButton.Checked)
                {
                    fieldSize = Convert.ToInt32(radioButton.Text[0].ToString());
                    break;
                }
            }
        }

        private void newGameToolStripButton_Click(object sender, EventArgs e)
        {
            lastFieldSize = fieldSize;
            RestartGame();
        }

        private void gsmeRulesToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("КАК ИГРАТЬ:\nИспользуйте стрелки на клавиатуре, чтобы перемещать плитки. Когда две плитки с одинаковыми цифрами соприкасаются, они сливаются в одну!");
        }

        private void resultsToolStripButton_Click(object sender, EventArgs e)
        {
            new ResultsForm().Show();
        }

        private void settingsToolStripButton_Click(object sender, EventArgs e)
        {
            lastFieldSize = fieldSize;
            fieldSizeForm = new FieldSizeForm();
            fieldSizeForm.ShowDialog();
            DetermineFielsdSize(fieldSizeForm.RadioButtons);
            RestartGame();
        }

        private void gameExitToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}