namespace NewsLinker
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
            headingLabel = new Label();
            previousButton = new Button();
            nextButton = new Button();
            exitButton = new Button();
            stepsLabel = new Label();
            confirmationContainer = new Panel();
            confirmationLabel = new Label();
            personalInfoContainer = new Panel();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            contactDetailContainer = new Panel();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            topicOfInterestContainer = new Panel();
            topicOfInterestTextBox = new TextBox();
            topicOfInterestLabel = new Label();
            subscribeHeading = new Label();
            confirmationContainer.SuspendLayout();
            personalInfoContainer.SuspendLayout();
            contactDetailContainer.SuspendLayout();
            topicOfInterestContainer.SuspendLayout();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 27.8571434F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            headingLabel.ForeColor = Color.Orange;
            headingLabel.Location = new Point(563, 62);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(394, 87);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "NewsLinker";
            // 
            // previousButton
            // 
            previousButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            previousButton.Location = new Point(258, 702);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(147, 51);
            previousButton.TabIndex = 1;
            previousButton.Text = "Prev";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nextButton.Location = new Point(1099, 703);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(180, 50);
            nextButton.TabIndex = 2;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            exitButton.Location = new Point(1177, 174);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(102, 50);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // stepsLabel
            // 
            stepsLabel.AutoSize = true;
            stepsLabel.Font = new Font("Calibri", 14.1428576F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            stepsLabel.Location = new Point(278, 253);
            stepsLabel.Name = "stepsLabel";
            stepsLabel.Size = new Size(209, 40);
            stepsLabel.TabIndex = 4;
            stepsLabel.Text = "Steps Heading";
            // 
            // confirmationContainer
            // 
            confirmationContainer.Controls.Add(confirmationLabel);
            confirmationContainer.Location = new Point(455, 598);
            confirmationContainer.Name = "confirmationContainer";
            confirmationContainer.Size = new Size(600, 75);
            confirmationContainer.TabIndex = 9;
            // 
            // confirmationLabel
            // 
            confirmationLabel.AutoSize = true;
            confirmationLabel.Location = new Point(10, 22);
            confirmationLabel.Name = "confirmationLabel";
            confirmationLabel.Size = new Size(395, 30);
            confirmationLabel.TabIndex = 10;
            confirmationLabel.Text = "Please finish to confirm your subscription";
            // 
            // personalInfoContainer
            // 
            personalInfoContainer.Controls.Add(nameTextBox);
            personalInfoContainer.Controls.Add(nameLabel);
            personalInfoContainer.Location = new Point(455, 328);
            personalInfoContainer.Name = "personalInfoContainer";
            personalInfoContainer.Size = new Size(600, 75);
            personalInfoContainer.TabIndex = 11;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(140, 19);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(434, 35);
            nameTextBox.TabIndex = 11;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(35, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(69, 30);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name";
            // 
            // contactDetailContainer
            // 
            contactDetailContainer.Controls.Add(emailTextBox);
            contactDetailContainer.Controls.Add(emailLabel);
            contactDetailContainer.Location = new Point(457, 418);
            contactDetailContainer.Name = "contactDetailContainer";
            contactDetailContainer.Size = new Size(600, 75);
            contactDetailContainer.TabIndex = 12;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(140, 19);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(434, 35);
            emailTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(35, 22);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email";
            // 
            // topicOfInterestContainer
            // 
            topicOfInterestContainer.Controls.Add(topicOfInterestTextBox);
            topicOfInterestContainer.Controls.Add(topicOfInterestLabel);
            topicOfInterestContainer.Location = new Point(457, 507);
            topicOfInterestContainer.Name = "topicOfInterestContainer";
            topicOfInterestContainer.Size = new Size(600, 75);
            topicOfInterestContainer.TabIndex = 13;
            // 
            // topicOfInterestTextBox
            // 
            topicOfInterestTextBox.Location = new Point(262, 19);
            topicOfInterestTextBox.Name = "topicOfInterestTextBox";
            topicOfInterestTextBox.Size = new Size(321, 35);
            topicOfInterestTextBox.TabIndex = 11;
            // 
            // topicOfInterestLabel
            // 
            topicOfInterestLabel.AutoSize = true;
            topicOfInterestLabel.Location = new Point(13, 22);
            topicOfInterestLabel.Name = "topicOfInterestLabel";
            topicOfInterestLabel.Size = new Size(231, 30);
            topicOfInterestLabel.TabIndex = 10;
            topicOfInterestLabel.Text = "Preferred News Interest";
            // 
            // subscribeHeading
            // 
            subscribeHeading.AutoSize = true;
            subscribeHeading.Font = new Font("Calibri", 15.8571434F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            subscribeHeading.Location = new Point(231, 179);
            subscribeHeading.Name = "subscribeHeading";
            subscribeHeading.Size = new Size(507, 45);
            subscribeHeading.TabIndex = 14;
            subscribeHeading.Text = "Subscribe to News and Updates";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 904);
            Controls.Add(subscribeHeading);
            Controls.Add(topicOfInterestContainer);
            Controls.Add(confirmationContainer);
            Controls.Add(contactDetailContainer);
            Controls.Add(personalInfoContainer);
            Controls.Add(stepsLabel);
            Controls.Add(exitButton);
            Controls.Add(nextButton);
            Controls.Add(previousButton);
            Controls.Add(headingLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            confirmationContainer.ResumeLayout(false);
            confirmationContainer.PerformLayout();
            personalInfoContainer.ResumeLayout(false);
            personalInfoContainer.PerformLayout();
            contactDetailContainer.ResumeLayout(false);
            contactDetailContainer.PerformLayout();
            topicOfInterestContainer.ResumeLayout(false);
            topicOfInterestContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private Button previousButton;
        private Button nextButton;
        private Button exitButton;
        private Label stepsLabel;
        private Panel confirmationContainer;
        private Label confirmationLabel;
        private Panel personalInfoContainer;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Panel contactDetailContainer;
        private TextBox emailTextBox;
        private Label emailLabel;
        private Panel topicOfInterestContainer;
        private TextBox topicOfInterestTextBox;
        private Label topicOfInterestLabel;
        private Label subscribeHeading;
    }
}