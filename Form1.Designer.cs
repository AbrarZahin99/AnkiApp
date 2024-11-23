namespace AnkiApp
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
            buttonEditSelection = new Button();
            splitContainer1 = new SplitContainer();
            buttonAdd = new Button();
            richTextBox1 = new RichTextBox();
            labelSolution = new Label();
            panel2 = new Panel();
            labelProvideFeedback = new Label();
            radioButtonEasy = new RadioButton();
            radioButtonHard = new RadioButton();
            radioButtonMedium = new RadioButton();
            buttonReveal = new Button();
            buttonNextQuestion = new Button();
            labelScore = new Label();
            panel1 = new Panel();
            labelQuestion = new Label();
            radioButtonOption3 = new RadioButton();
            radioButtonOption0 = new RadioButton();
            radioButtonOption2 = new RadioButton();
            radioButtonOption1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEditSelection
            // 
            buttonEditSelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditSelection.Location = new Point(12, 12);
            buttonEditSelection.Name = "buttonEditSelection";
            buttonEditSelection.Size = new Size(113, 29);
            buttonEditSelection.TabIndex = 1;
            buttonEditSelection.Text = "Select letters";
            buttonEditSelection.UseVisualStyleBackColor = true;
            buttonEditSelection.Click += buttonEditSelection_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonAdd);
            splitContainer1.Panel1.Controls.Add(richTextBox1);
            splitContainer1.Panel1.Controls.Add(buttonEditSelection);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(labelSolution);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(buttonReveal);
            splitContainer1.Panel2.Controls.Add(buttonNextQuestion);
            splitContainer1.Panel2.Controls.Add(labelScore);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(803, 543);
            splitContainer1.SplitterDistance = 136;
            splitContainer1.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.Location = new Point(12, 502);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(113, 29);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add csv";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(12, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(113, 446);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // labelSolution
            // 
            labelSolution.AutoSize = true;
            labelSolution.Location = new Point(10, 243);
            labelSolution.Name = "labelSolution";
            labelSolution.Size = new Size(67, 20);
            labelSolution.TabIndex = 14;
            labelSolution.Text = "Solution:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(labelProvideFeedback);
            panel2.Controls.Add(radioButtonEasy);
            panel2.Controls.Add(radioButtonHard);
            panel2.Controls.Add(radioButtonMedium);
            panel2.Location = new Point(10, 368);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 125);
            panel2.TabIndex = 13;
            // 
            // labelProvideFeedback
            // 
            labelProvideFeedback.AutoSize = true;
            labelProvideFeedback.Location = new Point(3, 17);
            labelProvideFeedback.Name = "labelProvideFeedback";
            labelProvideFeedback.Size = new Size(399, 20);
            labelProvideFeedback.TabIndex = 9;
            labelProvideFeedback.Text = "Provide feedback here to customise future mcq generators:";
            // 
            // radioButtonEasy
            // 
            radioButtonEasy.AutoSize = true;
            radioButtonEasy.Location = new Point(3, 100);
            radioButtonEasy.Name = "radioButtonEasy";
            radioButtonEasy.Size = new Size(59, 24);
            radioButtonEasy.TabIndex = 12;
            radioButtonEasy.TabStop = true;
            radioButtonEasy.Text = "Easy";
            radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonHard
            // 
            radioButtonHard.AutoSize = true;
            radioButtonHard.Location = new Point(3, 40);
            radioButtonHard.Name = "radioButtonHard";
            radioButtonHard.Size = new Size(63, 24);
            radioButtonHard.TabIndex = 10;
            radioButtonHard.TabStop = true;
            radioButtonHard.Text = "Hard";
            radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            radioButtonMedium.AutoSize = true;
            radioButtonMedium.Location = new Point(3, 70);
            radioButtonMedium.Name = "radioButtonMedium";
            radioButtonMedium.Size = new Size(85, 24);
            radioButtonMedium.TabIndex = 11;
            radioButtonMedium.TabStop = true;
            radioButtonMedium.Text = "Medium";
            radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // buttonReveal
            // 
            buttonReveal.Location = new Point(10, 211);
            buttonReveal.Name = "buttonReveal";
            buttonReveal.Size = new Size(130, 29);
            buttonReveal.TabIndex = 8;
            buttonReveal.Text = "Reveal Answer";
            buttonReveal.UseVisualStyleBackColor = true;
            buttonReveal.Click += buttonReveal_Click;
            // 
            // buttonNextQuestion
            // 
            buttonNextQuestion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonNextQuestion.Location = new Point(10, 502);
            buttonNextQuestion.Name = "buttonNextQuestion";
            buttonNextQuestion.Size = new Size(94, 29);
            buttonNextQuestion.TabIndex = 7;
            buttonNextQuestion.Text = "Next";
            buttonNextQuestion.UseVisualStyleBackColor = true;
            buttonNextQuestion.Click += buttonNextQuestion_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(10, 16);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(49, 20);
            labelScore.TabIndex = 6;
            labelScore.Text = "Score:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(labelQuestion);
            panel1.Controls.Add(radioButtonOption3);
            panel1.Controls.Add(radioButtonOption0);
            panel1.Controls.Add(radioButtonOption2);
            panel1.Controls.Add(radioButtonOption1);
            panel1.Location = new Point(13, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 166);
            panel1.TabIndex = 5;
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(3, 7);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(101, 20);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "labelQuestion";
            // 
            // radioButtonOption3
            // 
            radioButtonOption3.AutoSize = true;
            radioButtonOption3.Location = new Point(3, 139);
            radioButtonOption3.Name = "radioButtonOption3";
            radioButtonOption3.Size = new Size(117, 24);
            radioButtonOption3.TabIndex = 4;
            radioButtonOption3.TabStop = true;
            radioButtonOption3.Text = "radioButton4";
            radioButtonOption3.UseVisualStyleBackColor = true;
            // 
            // radioButtonOption0
            // 
            radioButtonOption0.AutoSize = true;
            radioButtonOption0.Location = new Point(3, 49);
            radioButtonOption0.Name = "radioButtonOption0";
            radioButtonOption0.Size = new Size(117, 24);
            radioButtonOption0.TabIndex = 1;
            radioButtonOption0.TabStop = true;
            radioButtonOption0.Text = "radioButton1";
            radioButtonOption0.UseVisualStyleBackColor = true;
            // 
            // radioButtonOption2
            // 
            radioButtonOption2.AutoSize = true;
            radioButtonOption2.Location = new Point(3, 109);
            radioButtonOption2.Name = "radioButtonOption2";
            radioButtonOption2.Size = new Size(117, 24);
            radioButtonOption2.TabIndex = 3;
            radioButtonOption2.TabStop = true;
            radioButtonOption2.Text = "radioButton3";
            radioButtonOption2.UseVisualStyleBackColor = true;
            // 
            // radioButtonOption1
            // 
            radioButtonOption1.AutoSize = true;
            radioButtonOption1.Location = new Point(3, 79);
            radioButtonOption1.Name = "radioButtonOption1";
            radioButtonOption1.Size = new Size(117, 24);
            radioButtonOption1.TabIndex = 2;
            radioButtonOption1.TabStop = true;
            radioButtonOption1.Text = "radioButton2";
            radioButtonOption1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 543);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonEditSelection;
        private SplitContainer splitContainer1;
        private RichTextBox richTextBox1;
        private Button buttonAdd;
        private Label labelQuestion;
        private RadioButton radioButtonOption3;
        private RadioButton radioButtonOption2;
        private RadioButton radioButtonOption1;
        private RadioButton radioButtonOption0;
        private Panel panel1;
        private Label labelScore;
        private Button buttonNextQuestion;
        private Button buttonReveal;
        private Label labelProvideFeedback;
        private RadioButton radioButtonEasy;
        private RadioButton radioButtonMedium;
        private RadioButton radioButtonHard;
        private Panel panel2;
        private Label labelSolution;
    }
}
