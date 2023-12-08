using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseExam
{
    public partial class Form1 : Form
    {
        private readonly string[] _rightAnswers =
        {
            "b", "d", "a", "a", "c", "a", "b", "a", "c", "d", "b", "c", "d",
            "a", "d", "c", "c", "b", "d", "a"
        };

        private readonly List<int> _rightAnswerCounter = new List<int>();
        private readonly List<int> _wrongAnswerCounter = new List<int>();
        private const int PassCount = 15;
        private const string ResultPassText = "PASS";
        private const string ResultFailText = "FAIL";
        private const string RightAnsewersText = "Right";
        private const string WrongAnsewersText = "Wrong";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (ofdLoadResults.ShowDialog() == DialogResult.Cancel)
                return;


            var filename = ofdLoadResults.FileName;
            var fileText = System.IO.File.ReadAllText(filename).Trim();

            // todo: check result file integrity.

            // Amount of answers.
            if (fileText.Length != 20)
            {
                MessageBox.Show("Invalid result file.\nNot enough answers.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // There are must be just letter in answer sequence.
            if (fileText.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "Invalid result file.\nThere are must be only letters in answer sequence.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Clear controls.


            _wrongAnswerCounter.Clear();
            _rightAnswerCounter.Clear();
            lbRightAnswers.DataSource = null;
            lbWrongAnswers.DataSource = null;

            lblResult.Text = "";
            lblResult.BackColor = SystemColors.Control;

            gbRightAnswers.Text = $@"{RightAnsewersText}:";
            gbWrongAnswers.Text = $@"{WrongAnsewersText}:";


            // Check answers.
            for (var i = _rightAnswers.Length - 1; i >= 0; i--)
            {
                if (fileText[i].ToString().Equals(_rightAnswers[i]))
                {
                    _rightAnswerCounter.Add(i + 1);
                }
                else
                {
                    _wrongAnswerCounter.Add(i + 1);
                }
            }

            // Show result.

            if (_rightAnswerCounter.Count >= PassCount)
            {
                lblResult.Text = ResultPassText;
                lblResult.BackColor = Color.Green;
            }
            else
            {
                lblResult.Text = ResultFailText;
                lblResult.BackColor = Color.Red;
            }

            gbRightAnswers.Text =
                $@"{RightAnsewersText} ({_rightAnswerCounter.Count}):";
            gbWrongAnswers.Text =
                $@"{WrongAnsewersText} ({_wrongAnswerCounter.Count}):";

            // Fill lists.

            lbRightAnswers.DataSource = _rightAnswerCounter;
            lbWrongAnswers.DataSource = _wrongAnswerCounter;
        }
    }
}