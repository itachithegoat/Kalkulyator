using System;
using System.Drawing;
using System.Windows.Forms;

namespace numberKalkulyator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNumberOneLabel = new Label();
            this.txtNumberOne = new TextBox();
            this.lblNumberTwoLabel = new Label();
            this.txtNumberTwo = new TextBox();
            this.lblCommandLabel = new Label();
            this.cmbCommand = new ComboBox();
            this.lblAnswerText = new Label();
            this.lblAnswerValue = new Label();
            this.btnResult = new Button();
            this.btnClear = new Button();
            this.SuspendLayout();
            // 
            // lblNumberOneLabel
            // 
            this.lblNumberOneLabel.AutoSize = true;
            this.lblNumberOneLabel.Location = new Point(12, 15);
            this.lblNumberOneLabel.Name = "lblNumberOneLabel";
            this.lblNumberOneLabel.Size = new Size(80, 15);
            this.lblNumberOneLabel.Text = "Number one";
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new Point(12, 35);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new Size(260, 23);
            this.txtNumberOne.Text = "0";
            // 
            // lblNumberTwoLabel
            // 
            this.lblNumberTwoLabel.AutoSize = true;
            this.lblNumberTwoLabel.Location = new Point(12, 70);
            this.lblNumberTwoLabel.Name = "lblNumberTwoLabel";
            this.lblNumberTwoLabel.Size = new Size(80, 15);
            this.lblNumberTwoLabel.Text = "Number two";
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new Point(12, 90);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new Size(260, 23);
            this.txtNumberTwo.Text = "0";
            // 
            // lblCommandLabel
            // 
            this.lblCommandLabel.AutoSize = true;
            this.lblCommandLabel.Location = new Point(12, 125);
            this.lblCommandLabel.Name = "lblCommandLabel";
            this.lblCommandLabel.Size = new Size(56, 15);
            this.lblCommandLabel.Text = "Command";
            // 
            // cmbCommand
            // 
            this.cmbCommand.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.cmbCommand.Location = new Point(12, 145);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new Size(260, 23);
            this.cmbCommand.SelectedIndex = -1;
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.AutoSize = true;
            this.lblAnswerText.Location = new Point(12, 185);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new Size(49, 15);
            this.lblAnswerText.Text = "Answer:";
            // 
            // lblAnswerValue
            // 
            this.lblAnswerValue.AutoSize = true;
            this.lblAnswerValue.Location = new Point(70, 185);
            this.lblAnswerValue.Name = "lblAnswerValue";
            this.lblAnswerValue.Size = new Size(13, 15);
            this.lblAnswerValue.Text = "0";
            // 
            // btnResult
            // 
            this.btnResult.Location = new Point(12, 215);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new Size(75, 23);
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new EventHandler(this.btnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(197, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(75, 23);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.lblNumberOneLabel);
            this.Controls.Add(this.txtNumberOne);
            this.Controls.Add(this.lblNumberTwoLabel);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.lblCommandLabel);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.lblAnswerText);
            this.Controls.Add(this.lblAnswerValue);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblNumberOneLabel;
        private TextBox txtNumberOne;
        private Label lblNumberTwoLabel;
        private TextBox txtNumberTwo;
        private Label lblCommandLabel;
        private ComboBox cmbCommand;
        private Label lblAnswerText;
        private Label lblAnswerValue;
        private Button btnResult;
        private Button btnClear;

        #endregion
    }
}
