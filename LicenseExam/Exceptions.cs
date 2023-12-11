using System;

namespace LicenseExam
{
    public class NotEnoughAnswers : Exception
    {
        public override string Message =>
            "Invalid result file.\nNot enough answers.";
    }

    public class InvalidAnswerSymbols : Exception
    {
        public override string Message =>
            "Invalid result file.\nThere are must be only letters in answer sequence.";
    }
}