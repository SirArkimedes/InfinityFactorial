/************************************************************/
/*                                                          */
/*  Course: CIS 350 -- Data Structures                      */
/*                                                          */
/*  Project: Ch16Smp1 - Infinity Factorial.csprj            */
/*                                                          */
/*  Source File: Ch16Smp1 - Infinity Factorial.cs           */
/*                                                          */
/*  Programmer: Andrew Robinson                             */
/*                                                          */
/*  Purpose: Iterative calculation of n!.                   */
/*           With only a limitation of memory size.         */
/*                                                          */
/*  Classes: 1. Ch16Smp1Form : Form                         */
/*           2. Ch16Smp1App                                 */
/*                                                          */
/************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibETextBox;

/************************************************************/
/*  Begin namespace Ch16Smp1                                */
/************************************************************/
namespace Ch16Smp1
{

  /************************************************************/
  /*  1. Begin main form class Ch16Smp1Form : Form            */
  /************************************************************/
  public class Ch16Smp1Form : Form
  {
    private Button quitButton;
    private ETextBox valueETextBox;
    private Label valueLabel;
    private Label factorialLabel;
    private Button calculateButton;
    private Label memorySizeLabel;
    private Label memorySizeDisplay;
    private TextBox displayTextBox;
    private List<uint> result;

    public Ch16Smp1Form()
    {
      InitializeComponent();
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ch16Smp1Form));
      this.valueETextBox = new LibETextBox.ETextBox();
      this.valueLabel = new System.Windows.Forms.Label();
      this.factorialLabel = new System.Windows.Forms.Label();
      this.calculateButton = new System.Windows.Forms.Button();
      this.quitButton = new System.Windows.Forms.Button();
      this.memorySizeLabel = new System.Windows.Forms.Label();
      this.memorySizeDisplay = new System.Windows.Forms.Label();
      this.displayTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // valueETextBox
      // 
      this.valueETextBox.Location = new System.Drawing.Point(146, 32);
      this.valueETextBox.Name = "valueETextBox";
      this.valueETextBox.Size = new System.Drawing.Size(40, 23);
      this.valueETextBox.TabIndex = 0;
      this.valueETextBox.TextChanged += new System.EventHandler(this.valueETextBox_TextChanged);
      // 
      // valueLabel
      // 
      this.valueLabel.Location = new System.Drawing.Point(146, 8);
      this.valueLabel.Name = "valueLabel";
      this.valueLabel.Size = new System.Drawing.Size(40, 20);
      this.valueLabel.TabIndex = 1;
      this.valueLabel.Text = "n";
      this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // factorialLabel
      // 
      this.factorialLabel.Location = new System.Drawing.Point(124, 64);
      this.factorialLabel.Name = "factorialLabel";
      this.factorialLabel.Size = new System.Drawing.Size(84, 20);
      this.factorialLabel.TabIndex = 3;
      this.factorialLabel.Text = "n!";
      this.factorialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // calculateButton
      // 
      this.calculateButton.Location = new System.Drawing.Point(85, 498);
      this.calculateButton.Name = "calculateButton";
      this.calculateButton.Size = new System.Drawing.Size(75, 22);
      this.calculateButton.TabIndex = 4;
      this.calculateButton.Text = "Calculate";
      this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
      // 
      // quitButton
      // 
      this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.quitButton.Location = new System.Drawing.Point(173, 498);
      this.quitButton.Name = "quitButton";
      this.quitButton.Size = new System.Drawing.Size(75, 22);
      this.quitButton.TabIndex = 5;
      this.quitButton.Text = "Quit";
      this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
      // 
      // memorySizeLabel
      // 
      this.memorySizeLabel.AutoSize = true;
      this.memorySizeLabel.Location = new System.Drawing.Point(89, 525);
      this.memorySizeLabel.Name = "memorySizeLabel";
      this.memorySizeLabel.Size = new System.Drawing.Size(159, 15);
      this.memorySizeLabel.TabIndex = 6;
      this.memorySizeLabel.Text = "Memory Size of array (bytes)";
      // 
      // memorySizeDisplay
      // 
      this.memorySizeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.memorySizeDisplay.Location = new System.Drawing.Point(12, 546);
      this.memorySizeDisplay.Name = "memorySizeDisplay";
      this.memorySizeDisplay.Size = new System.Drawing.Size(309, 22);
      this.memorySizeDisplay.TabIndex = 7;
      this.memorySizeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // displayTextBox
      // 
      this.displayTextBox.Location = new System.Drawing.Point(12, 87);
      this.displayTextBox.Multiline = true;
      this.displayTextBox.Name = "displayTextBox";
      this.displayTextBox.ReadOnly = true;
      this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.displayTextBox.Size = new System.Drawing.Size(309, 405);
      this.displayTextBox.TabIndex = 8;
      this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // Ch16Smp1Form
      // 
      this.AcceptButton = this.calculateButton;
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      this.CancelButton = this.quitButton;
      this.ClientSize = new System.Drawing.Size(333, 579);
      this.Controls.Add(this.displayTextBox);
      this.Controls.Add(this.memorySizeDisplay);
      this.Controls.Add(this.memorySizeLabel);
      this.Controls.Add(this.quitButton);
      this.Controls.Add(this.calculateButton);
      this.Controls.Add(this.factorialLabel);
      this.Controls.Add(this.valueLabel);
      this.Controls.Add(this.valueETextBox);
      this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Ch16Smp1Form";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ch16Smp1 – Iterative Factorial";
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    /************************************************************/
    /*  Message Handlers                                        */
    /************************************************************/
    private void calculateButton_Click(object sender, System.EventArgs e)
    {
      uint n;

      if (valueETextBox.ReadUInt(out n))
      {
        result = new List<uint>();
        result.Add(1);

        Factorial(n);
        displayTextBox.Text = PrintList();

        int size = sizeof(uint) * result.Count;
        memorySizeDisplay.Text = string.Format("{0}", size);

        valueETextBox.SelectAll();
        valueETextBox.Select();
      }
    }

    private void valueETextBox_TextChanged(object sender, EventArgs e)
    {
      displayTextBox.Text = "";
    }

    private void quitButton_Click(object sender, System.EventArgs e)
    {
      Application.Exit();
    }

    /************************************************************/
    /*  Auxiallary Methods                                      */
    /************************************************************/
    private void Factorial(uint n)
    {
      while (n >= 2)
      {
        Multiply(n);
        n--;
      }
    }

    private void Multiply(uint times)
    {
      for (int i = 0; i < result.Count; i++)
        result[i] *= times;

      moveValues();
    }

    private void moveValues()
    {
      for (int i = 0; i < result.Count; i++)
      {
        uint value = result[i];

        if (value > 99999 && value / 100000 > 0)
          moveHundredThousandsPlace(i);
        if (value > 9999 && value / 10000 > 0)
          moveTenThousandsPlace(i);
        if (value > 999 && value / 1000 > 0)
          moveThousandsPlace(i);
        if (value > 99 && value / 100 > 0)
          moveHundredsPlace(i);
        if (value > 9 && value / 10 > 0)
          moveTensPlace(i);

        result[i] %= 10;
      }
    }

    private void moveTensPlace(int i)
    {
      expandIfNeededForI(i + 1);
      result[i + 1] += (result[i] % 100 - result[i] % 10) / 10;
    }

    private void moveHundredsPlace(int i)
    {
      expandIfNeededForI(i + 2);
      result[i + 2] += (result[i] % 1000 - result[i] % 100) / 100;
    }

    private void moveThousandsPlace(int i)
    {
      expandIfNeededForI(i + 3);
      result[i + 3] += (result[i] % 10000 - result[i] % 1000) / 1000;
    }

    private void moveTenThousandsPlace(int i)
    {
      expandIfNeededForI(i + 4);
      result[i + 4] += (result[i] % 100000 - result[i] % 10000) / 10000;
    }

    private void moveHundredThousandsPlace(int i)
    {
      expandIfNeededForI(i + 5);
      result[i + 5] += (result[i] % 1000000 - result[i] % 100000) / 100000;
    }

    private void expandIfNeededForI(int i)
    {
      if (result.Count <= i)
        for (int valueToExpandBy = i - result.Count; i > 0; i--)
          result.Add(0);
    }

    private string PrintList()
    {
      string value = "";

      uint max = 0;

      for (int i = result.Count - 1; i >= 0; i--)
        if (result[i] != 0 || max != 0)
        {
          value += result[i];
          if (result[i] > max)
            max = result[i];
        }

      string valueWithCommas = "";
      for (int i = value.Length - 1; i >= 0; i--)
        if (i % 3 == 0 && i != 0)
        {
          valueWithCommas += value[value.Length - 1 - i];
          valueWithCommas += ",";
        }
        else
          valueWithCommas += value[value.Length - 1 - i];

      return valueWithCommas;
    }

  }  // End main form class Ch16Smp1Form

  /************************************************************/
  /*  2. Begin application class Ch16Smp1App                  */
  /************************************************************/
  public class Ch16Smp1App
  {
    static void Main()
    {
      Application.Run(new Ch16Smp1Form());
    }
  }  // End application class Ch16Smp1App

}  // End namespace Ch16Smp1
