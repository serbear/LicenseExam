using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LicenseExam
{
    internal static class Program
    {
        public static readonly string[] RightAnswers =
        {
            "b", "d", "a", "a", "c", "a", "b", "a", "c", "d", "b", "c", "d",
            "a", "d", "c", "c", "b", "d", "a"
        };

        public static List<int> RightAnswerCounter { get; } = new List<int>();
        public static List<int> WrongAnswerCounter { get; } = new List<int>();
        public static int PassCount => 15;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void CheckFileIntegrity(string fileText)
        {
            // Amount of answers.
            if (fileText.Length != 20)
            {
                throw new NotEnoughAnswers();
            }

            // There are must be just letter in answer sequence.
            if (fileText.Any(char.IsDigit))
            {
                throw new InvalidAnswerSymbols();
            }
        }

        public static void CheckAnswers(string fileText)
        {
            for (var i = RightAnswers.Length - 1; i >= 0; i--)
            {
                if (fileText[i].ToString().Equals(RightAnswers[i]))
                {
                    RightAnswerCounter.Add(i + 1);
                }
                else
                {
                    WrongAnswerCounter.Add(i + 1);
                }
            }
        }

        public static void ClearData()
        {
            WrongAnswerCounter.Clear();
            RightAnswerCounter.Clear();
        }

        public static bool IsPassed()
        {
            return RightAnswerCounter.Count >= PassCount;
        }
    }
}