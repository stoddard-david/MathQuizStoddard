using System;
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
    }

    private void startButton_Click(object sender, EventArgs e)
    {
      StartTheQuiz();
      startButton.Enabled = false;
      startButton.Text = "Quiz in Progress";
      startButton.ForeColor = Color.DimGray;
      startButton.BackColor = Color.LightGray;
    }
  }
}
