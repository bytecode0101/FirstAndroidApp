using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using App1.Models;
using System.IO;
using Android.Content.Res;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        List<Question> questions = new List<Question>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            LoadQuestions();


            DisplayNewQuestion();

            var button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                ValidateAnswer();
            };
        }

        /// <summary>
        /// Load questions from a file
        /// </summary>
        private void LoadQuestions()
        {
            var text = "";
            AssetManager assets = this.Assets;
            using (StreamReader sr = new StreamReader(assets.Open("Questions.txt")))
            {
                text = sr.ReadToEnd();
            }

            var questionTexts = text.Split(';');
            foreach (var qTxt in questionTexts)
            {
                var q = new Question();
                var parts = qTxt.Split(',');
                q.Text = parts[0];
                q.Answer = parts[1];
                questions.Add(q);
            }
        }

        /// <summary>
        /// Peak one question from the loaded ones 
        /// </summary>
        private void DisplayNewQuestion()
        {
            var question = SelectQuestion();
            var txtQuestion = FindViewById<TextView>(Resource.Id.txtQuestion);
            var txtAnswer = FindViewById<TextView>(Resource.Id.txtAnswer);
            txtQuestion.Text = question.Text;
            txtAnswer.Text = "";
        }

        /// <summary>
        /// Randomly selects a question
        /// </summary>
        /// <returns></returns>
        private Question SelectQuestion()
        {
            return questions[0];
        }

        /// <summary>
        /// Validates the answer
        /// </summary>
        private void ValidateAnswer()
        {
            var isValid = false;
            var txtAnswer = FindViewById<TextView>(Resource.Id.txtAnswer);

            if (isValid)
            {
                DisplayNewQuestion();
            }
            else
            {
                //TODO: show a message box with wrong answer
            }
        }
    }
}

