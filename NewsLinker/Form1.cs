using System.Diagnostics;

namespace NewsLinker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // array to store steps
        string[] steps = {
            "Step 1: Personal Information",
            "Step 2: Contact Detail",
            "Step 3: Preferences",
            "Step 4: Confirmation"
        };
        public int currentStep = 0;

        private void UpdateUI()
        {
            stepsLabel.Text = steps[currentStep]; // Update Steps Heading from array
            // inputTextBox.Text = ""; // Clear previous input

            // Show/hide controls based on current step
            personalInfoContainer.Visible = false;
            contactDetailContainer.Visible = false;
            topicOfInterestContainer.Visible = false;
            confirmationContainer.Visible = false;

            // Debug.WriteLine("Current Step: " + currentStep);


            // Show the panel corresponding to the current step
            switch (currentStep)
            {
                case 0:
                    personalInfoContainer.Visible = true;
                    break;
                case 1:
                    contactDetailContainer.Visible = true;
                    break;
                case 2:
                    topicOfInterestContainer.Visible = true;
                    break;
                case 3:
                    confirmationContainer.Visible = true;
                    break;
                default:
                    // Handle an invalid step if needed
                    break;
            }

            previousButton.Enabled = currentStep > 0;
            nextButton.Enabled = currentStep < steps.Length;

            if (currentStep == steps.Length - 1)
            {
                // Final step, customize as needed
                nextButton.Text = "Finish";
            }
            else
            {
                nextButton.Text = "Next";
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                UpdateUI();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentStep < steps.Length - 1)
            {
                currentStep++;
                UpdateUI();
            }
            else
            {
                // Handle finish button click (e.g., save data)
                MessageBox.Show("Registration completed!");
                Close(); // Close the application
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUI(); // Initialize the UI
        }
    }
}
