namespace AnkiApp
{
    partial class FeedbackForm
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
            label1 = new Label();
            radioButtonHard = new RadioButton();
            radioButtonMedium = new RadioButton();
            radioButtonEasy = new RadioButton();
            buttonCancel = new Button();
            buttonOk = new Button();
            label2 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(399, 20);
            label1.TabIndex = 0;
            label1.Text = "Provide feedback here to customise future mcq generators:";
            // 
            // radioButtonHard
            // 
            radioButtonHard.AutoSize = true;
            radioButtonHard.Location = new Point(12, 52);
            radioButtonHard.Name = "radioButtonHard";
            radioButtonHard.Size = new Size(63, 24);
            radioButtonHard.TabIndex = 1;
            radioButtonHard.TabStop = true;
            radioButtonHard.Text = "Hard";
            radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            radioButtonMedium.AutoSize = true;
            radioButtonMedium.Location = new Point(12, 82);
            radioButtonMedium.Name = "radioButtonMedium";
            radioButtonMedium.Size = new Size(85, 24);
            radioButtonMedium.TabIndex = 2;
            radioButtonMedium.TabStop = true;
            radioButtonMedium.Text = "Medium";
            radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            radioButtonEasy.AutoSize = true;
            radioButtonEasy.Location = new Point(12, 112);
            radioButtonEasy.Name = "radioButtonEasy";
            radioButtonEasy.Size = new Size(59, 24);
            radioButtonEasy.TabIndex = 3;
            radioButtonEasy.TabStop = true;
            radioButtonEasy.Text = "Easy";
            radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(347, 168);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Location = new Point(247, 168);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 6;
            label2.Text = "Correct answer is: ";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FeedbackForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(453, 209);
            Controls.Add(label2);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(radioButtonEasy);
            Controls.Add(radioButtonMedium);
            Controls.Add(radioButtonHard);
            Controls.Add(label1);
            Name = "FeedbackForm";
            Text = "FeedbackForm";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButtonHard;
        private RadioButton radioButtonMedium;
        private RadioButton radioButtonEasy;
        private Button buttonCancel;
        private Button buttonOk;
        private Label label2;
        private FileSystemWatcher fileSystemWatcher1;
    }
}