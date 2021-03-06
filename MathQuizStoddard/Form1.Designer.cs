﻿namespace MathQuizStoddard
{
  partial class QuizForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
      this.timeLabel = new System.Windows.Forms.Label();
      this.timeLeftText = new System.Windows.Forms.Label();
      this.plusLeftLabel = new System.Windows.Forms.Label();
      this.plusSign = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.plusRightLabel = new System.Windows.Forms.Label();
      this.plusEqual = new System.Windows.Forms.Label();
      this.sum = new System.Windows.Forms.NumericUpDown();
      this.difference = new System.Windows.Forms.NumericUpDown();
      this.minusEqual = new System.Windows.Forms.Label();
      this.minusRightLabel = new System.Windows.Forms.Label();
      this.minusSign = new System.Windows.Forms.Label();
      this.minusLeftLabel = new System.Windows.Forms.Label();
      this.product = new System.Windows.Forms.NumericUpDown();
      this.timesEqual = new System.Windows.Forms.Label();
      this.timesRightLabel = new System.Windows.Forms.Label();
      this.timesSign = new System.Windows.Forms.Label();
      this.timesLeftLabel = new System.Windows.Forms.Label();
      this.quotient = new System.Windows.Forms.NumericUpDown();
      this.dividedEqual = new System.Windows.Forms.Label();
      this.dividedRightLabel = new System.Windows.Forms.Label();
      this.dividedSign = new System.Windows.Forms.Label();
      this.dividedLeftLabel = new System.Windows.Forms.Label();
      this.startButton = new System.Windows.Forms.Button();
      this.quizTimer = new System.Windows.Forms.Timer(this.components);
      this.todayLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
      this.SuspendLayout();
      // 
      // timeLabel
      // 
      this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.timeLabel.Location = new System.Drawing.Point(221, 52);
      this.timeLabel.Name = "timeLabel";
      this.timeLabel.Size = new System.Drawing.Size(200, 30);
      this.timeLabel.TabIndex = 0;
      // 
      // timeLeftText
      // 
      this.timeLeftText.AutoSize = true;
      this.timeLeftText.BackColor = System.Drawing.Color.Transparent;
      this.timeLeftText.Location = new System.Drawing.Point(94, 57);
      this.timeLeftText.Name = "timeLeftText";
      this.timeLeftText.Size = new System.Drawing.Size(121, 25);
      this.timeLeftText.TabIndex = 1;
      this.timeLeftText.Text = "Time Left:";
      // 
      // plusLeftLabel
      // 
      this.plusLeftLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plusLeftLabel.Location = new System.Drawing.Point(57, 91);
      this.plusLeftLabel.Name = "plusLeftLabel";
      this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
      this.plusLeftLabel.TabIndex = 2;
      this.plusLeftLabel.Text = "?";
      this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // plusSign
      // 
      this.plusSign.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plusSign.Location = new System.Drawing.Point(123, 91);
      this.plusSign.Name = "plusSign";
      this.plusSign.Size = new System.Drawing.Size(60, 50);
      this.plusSign.TabIndex = 3;
      this.plusSign.Text = "+";
      this.plusSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 6;
      // 
      // plusRightLabel
      // 
      this.plusRightLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plusRightLabel.Location = new System.Drawing.Point(189, 91);
      this.plusRightLabel.Name = "plusRightLabel";
      this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
      this.plusRightLabel.TabIndex = 4;
      this.plusRightLabel.Text = "?";
      this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // plusEqual
      // 
      this.plusEqual.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.plusEqual.Location = new System.Drawing.Point(255, 91);
      this.plusEqual.Name = "plusEqual";
      this.plusEqual.Size = new System.Drawing.Size(60, 50);
      this.plusEqual.TabIndex = 5;
      this.plusEqual.Text = "=";
      this.plusEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // sum
      // 
      this.sum.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sum.Location = new System.Drawing.Point(321, 100);
      this.sum.Name = "sum";
      this.sum.Size = new System.Drawing.Size(100, 37);
      this.sum.TabIndex = 2;
      this.sum.ValueChanged += new System.EventHandler(this.check_Add);
      this.sum.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // difference
      // 
      this.difference.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.difference.Location = new System.Drawing.Point(321, 150);
      this.difference.Name = "difference";
      this.difference.Size = new System.Drawing.Size(100, 37);
      this.difference.TabIndex = 3;
      this.difference.ValueChanged += new System.EventHandler(this.check_Minus);
      this.difference.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // minusEqual
      // 
      this.minusEqual.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.minusEqual.Location = new System.Drawing.Point(255, 141);
      this.minusEqual.Name = "minusEqual";
      this.minusEqual.Size = new System.Drawing.Size(60, 50);
      this.minusEqual.TabIndex = 11;
      this.minusEqual.Text = "=";
      this.minusEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // minusRightLabel
      // 
      this.minusRightLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.minusRightLabel.Location = new System.Drawing.Point(189, 141);
      this.minusRightLabel.Name = "minusRightLabel";
      this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
      this.minusRightLabel.TabIndex = 10;
      this.minusRightLabel.Text = "?";
      this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // minusSign
      // 
      this.minusSign.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.minusSign.Location = new System.Drawing.Point(123, 141);
      this.minusSign.Name = "minusSign";
      this.minusSign.Size = new System.Drawing.Size(60, 50);
      this.minusSign.TabIndex = 9;
      this.minusSign.Text = "-";
      this.minusSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // minusLeftLabel
      // 
      this.minusLeftLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.minusLeftLabel.Location = new System.Drawing.Point(57, 141);
      this.minusLeftLabel.Name = "minusLeftLabel";
      this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
      this.minusLeftLabel.TabIndex = 8;
      this.minusLeftLabel.Text = "?";
      this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // product
      // 
      this.product.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.product.Location = new System.Drawing.Point(321, 200);
      this.product.Name = "product";
      this.product.Size = new System.Drawing.Size(100, 37);
      this.product.TabIndex = 4;
      this.product.ValueChanged += new System.EventHandler(this.check_Times);
      this.product.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // timesEqual
      // 
      this.timesEqual.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timesEqual.Location = new System.Drawing.Point(255, 191);
      this.timesEqual.Name = "timesEqual";
      this.timesEqual.Size = new System.Drawing.Size(60, 50);
      this.timesEqual.TabIndex = 16;
      this.timesEqual.Text = "=";
      this.timesEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // timesRightLabel
      // 
      this.timesRightLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timesRightLabel.Location = new System.Drawing.Point(189, 191);
      this.timesRightLabel.Name = "timesRightLabel";
      this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
      this.timesRightLabel.TabIndex = 15;
      this.timesRightLabel.Text = "?";
      this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // timesSign
      // 
      this.timesSign.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timesSign.Location = new System.Drawing.Point(123, 191);
      this.timesSign.Name = "timesSign";
      this.timesSign.Size = new System.Drawing.Size(60, 50);
      this.timesSign.TabIndex = 14;
      this.timesSign.Text = "×";
      this.timesSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // timesLeftLabel
      // 
      this.timesLeftLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timesLeftLabel.Location = new System.Drawing.Point(57, 191);
      this.timesLeftLabel.Name = "timesLeftLabel";
      this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
      this.timesLeftLabel.TabIndex = 13;
      this.timesLeftLabel.Text = "?";
      this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // quotient
      // 
      this.quotient.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.quotient.Location = new System.Drawing.Point(321, 250);
      this.quotient.Name = "quotient";
      this.quotient.Size = new System.Drawing.Size(100, 37);
      this.quotient.TabIndex = 5;
      this.quotient.ValueChanged += new System.EventHandler(this.check_Divide);
      this.quotient.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // dividedEqual
      // 
      this.dividedEqual.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dividedEqual.Location = new System.Drawing.Point(255, 241);
      this.dividedEqual.Name = "dividedEqual";
      this.dividedEqual.Size = new System.Drawing.Size(60, 50);
      this.dividedEqual.TabIndex = 21;
      this.dividedEqual.Text = "=";
      this.dividedEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dividedRightLabel
      // 
      this.dividedRightLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dividedRightLabel.Location = new System.Drawing.Point(189, 241);
      this.dividedRightLabel.Name = "dividedRightLabel";
      this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
      this.dividedRightLabel.TabIndex = 20;
      this.dividedRightLabel.Text = "?";
      this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dividedSign
      // 
      this.dividedSign.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dividedSign.Location = new System.Drawing.Point(123, 241);
      this.dividedSign.Name = "dividedSign";
      this.dividedSign.Size = new System.Drawing.Size(60, 50);
      this.dividedSign.TabIndex = 19;
      this.dividedSign.Text = "÷";
      this.dividedSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dividedLeftLabel
      // 
      this.dividedLeftLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dividedLeftLabel.Location = new System.Drawing.Point(57, 241);
      this.dividedLeftLabel.Name = "dividedLeftLabel";
      this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
      this.dividedLeftLabel.TabIndex = 18;
      this.dividedLeftLabel.Text = "?";
      this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // startButton
      // 
      this.startButton.AutoSize = true;
      this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.startButton.FlatAppearance.BorderSize = 2;
      this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.startButton.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startButton.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.startButton.Location = new System.Drawing.Point(155, 320);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(176, 37);
      this.startButton.TabIndex = 1;
      this.startButton.Text = "Start the Quiz";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // quizTimer
      // 
      this.quizTimer.Interval = 1000;
      this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick);
      // 
      // todayLabel
      // 
      this.todayLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.todayLabel.Location = new System.Drawing.Point(12, 4);
      this.todayLabel.Name = "todayLabel";
      this.todayLabel.Size = new System.Drawing.Size(456, 25);
      this.todayLabel.TabIndex = 22;
      this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // QuizForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(480, 382);
      this.Controls.Add(this.todayLabel);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.quotient);
      this.Controls.Add(this.dividedEqual);
      this.Controls.Add(this.dividedRightLabel);
      this.Controls.Add(this.dividedSign);
      this.Controls.Add(this.dividedLeftLabel);
      this.Controls.Add(this.product);
      this.Controls.Add(this.timesEqual);
      this.Controls.Add(this.timesRightLabel);
      this.Controls.Add(this.timesSign);
      this.Controls.Add(this.timesLeftLabel);
      this.Controls.Add(this.difference);
      this.Controls.Add(this.minusEqual);
      this.Controls.Add(this.minusRightLabel);
      this.Controls.Add(this.minusSign);
      this.Controls.Add(this.minusLeftLabel);
      this.Controls.Add(this.sum);
      this.Controls.Add(this.plusEqual);
      this.Controls.Add(this.plusRightLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.plusSign);
      this.Controls.Add(this.plusLeftLabel);
      this.Controls.Add(this.timeLeftText);
      this.Controls.Add(this.timeLabel);
      this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "QuizForm";
      this.Text = "David Stoddard Math Quiz";
      ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label timeLabel;
    private System.Windows.Forms.Label timeLeftText;
    private System.Windows.Forms.Label plusLeftLabel;
    private System.Windows.Forms.Label plusSign;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label plusRightLabel;
    private System.Windows.Forms.Label plusEqual;
    private System.Windows.Forms.NumericUpDown sum;
    private System.Windows.Forms.NumericUpDown difference;
    private System.Windows.Forms.Label minusEqual;
    private System.Windows.Forms.Label minusRightLabel;
    private System.Windows.Forms.Label minusSign;
    private System.Windows.Forms.Label minusLeftLabel;
    private System.Windows.Forms.NumericUpDown product;
    private System.Windows.Forms.Label timesEqual;
    private System.Windows.Forms.Label timesRightLabel;
    private System.Windows.Forms.Label timesSign;
    private System.Windows.Forms.Label timesLeftLabel;
    private System.Windows.Forms.NumericUpDown quotient;
    private System.Windows.Forms.Label dividedEqual;
    private System.Windows.Forms.Label dividedRightLabel;
    private System.Windows.Forms.Label dividedSign;
    private System.Windows.Forms.Label dividedLeftLabel;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Timer quizTimer;
    private System.Windows.Forms.Label todayLabel;
  }
}

