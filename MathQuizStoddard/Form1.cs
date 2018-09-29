﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizStoddard
{
  public partial class QuizForm : Form
  {
    // Create a Random object called randomizer to generate random numbers.
    Random randomizer = new Random();

    //These integers store numbers for the addition problem
    int addend1;
    int addend2;

    //Keep track of seconds
    int timeLeft;

    public QuizForm()
    {
      InitializeComponent();
    }

    //Start the quiz by filling in values and start the timer
    public void StartTheQuiz()
    {
      //Fill in the addition problem with random numbers 0-50
      addend1 = randomizer.Next(51);
      addend2 = randomizer.Next(51);

      //Convert the addition numbers to strings
      plusLeftLabel.Text = addend1.ToString();
      plusRightLabel.Text = addend2.ToString();

      //Set the sum to default 0 when started
      sum.Value = 0;

      //Set the timer color to black if it is still red
      timeLabel.ForeColor = Color.Black;
      
      //Start the timer
      timeLeft = 30;
      timeLabel.Text = "30 seconds";
      quizTimer.Start();
    }

    //Check the answers of the quiz
    private bool CheckTheAnswer()
    {
      if (addend1 + addend2 == sum.Value)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private void startButton_Click(object sender, EventArgs e)
    {
      StartTheQuiz();
      startButton.Enabled = false;

      startButton.Text = "Quiz in Progress";
      startButton.ForeColor = Color.DimGray;
      startButton.BackColor = Color.LightGray;
    }

    private void quizTimer_Tick(object sender, EventArgs e)
    {
      if (CheckTheAnswer())
      {
        //The answers are true then the answers are right and show sucess message.
        quizTimer.Stop();
        MessageBox.Show("You got all the answers right with " + timeLeft + " seconds to spare!", "Congratulations!");

        startButton.Enabled = true;

        startButton.Text = "Start the Quiz";
        startButton.ForeColor = Color.CornflowerBlue;
        startButton.BackColor = Color.WhiteSmoke;
      }
      else if (timeLeft > 0)
      {
        //Display the new time in the time left label
        timeLeft--;
        timeLabel.Text = timeLeft + " seconds";

        if (timeLeft <= 5)
        {
          timeLabel.ForeColor = Color.Red;
        }
      }
      else
      {
        //Out of time stop the timer, display message, and fill in values
        quizTimer.Stop();
        timeLabel.Text = "Time's up!";
        MessageBox.Show("You didn't finish in time", "Sorry!");
        sum.Value = addend1 + addend2;

        startButton.Enabled = true;

        startButton.Text = "Start the Quiz";
        startButton.ForeColor = Color.CornflowerBlue;
        startButton.BackColor = Color.WhiteSmoke;
      }
    }

    private void answer_Enter(object sender, EventArgs e)
    {
      //Select the whole answer in the NumbericUpDown control
      NumericUpDown answerBox = sender as NumericUpDown;

      if(answerBox != null)
      {
        int lengthOfAnswer = answerBox.Value.ToString().Length;
        answerBox.Select(0, lengthOfAnswer);
      }
    }
  }
}
