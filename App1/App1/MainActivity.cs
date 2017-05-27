using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using App1.Models;

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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Peak one question from the loaded ones 
        /// </summary>
        private void DisplayNewQuestion()
        {
            var question = SelectQuestion();
            var txtQuestion = FindViewById<TextView>(Resource.Id.txtQuestion);
        }

        /// <summary>
        /// Randomly selects a question
        /// </summary>
        /// <returns></returns>
        private Question SelectQuestion()
        {
            throw new NotImplementedException();
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

