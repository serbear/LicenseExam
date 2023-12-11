using System;
using System.Drawing;
using System.Windows.Forms;

namespace LicenseExam
{
    public partial class Form1 : Form
    {
        private const string ResultPassText = "PASS";
        private const string ResultFailText = "FAIL";
        private const string RightAnswersText = "Right";
        private const string WrongAnswersText = "Wrong";


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
            // Load data from the file.
            var fileText = GetAnswers();
            if (fileText == null) return;

            //check result file integrity.
            try
            {
                Program.CheckFileIntegrity(fileText);
            }
            catch (Exception ex) when (ex is NotEnoughAnswers ||
                                       ex is InvalidAnswerSymbols)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Clear controls and data.
            Program.ClearData();
            ClearControls();

            Program.CheckAnswers(fileText);

            ShowResults();
        }

        private void ShowResults()
        {
            if (Program.IsPassed())
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
                $@"{RightAnswersText} ({Program.RightAnswerCounter.Count}):";
            gbWrongAnswers.Text =
                $@"{WrongAnswersText} ({Program.WrongAnswerCounter.Count}):";

            // Fill lists.
            lbRightAnswers.DataSource = Program.RightAnswerCounter;
            lbWrongAnswers.DataSource = Program.WrongAnswerCounter;
        }

        private string GetAnswers()
        {
            if (ofdLoadResults.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }

            var filename = ofdLoadResults.FileName;
            return System.IO.File.ReadAllText(filename).Trim();
        }

        private void ClearControls()
        {
            lbRightAnswers.DataSource = null;
            lbWrongAnswers.DataSource = null;

            lblResult.Text = "";
            lblResult.BackColor = SystemColors.Control;

            gbRightAnswers.Text = $@"{RightAnswersText}:";
            gbWrongAnswers.Text = $@"{WrongAnswersText}:";
        }
    }
}