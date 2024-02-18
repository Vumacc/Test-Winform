using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int number = 0;
        private int currentIndex = 0;
        private string[] buttonTexts = { "Try again", "Are you sure?", "Think about this", "Go ahead then", "Really???", "C'mon think about it", "Are you REALLY sure?", "Fine then...", "Loading..." };

        public void errorLol()
        {
            MessageBox.Show("An error occurred!", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }
        public void ClaimErrorLol()
        {
            MessageBox.Show("An unexpected error has occured whilst retrieving a discount code from our database. Please try again later.", "Cannot retrieve discount code", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AccountDeletionErrorLol()
        {
            MessageBox.Show("An unexpected error has occured during account deletion process. Please try again later.", "Could not delete account", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MustHaveStuffErrorLol()
        {
            MessageBox.Show("To delete your account you must explain why you have left. Enter details in the textbox!", "Must have reason for deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UncheckedErrorLol()
        {
            MessageBox.Show("Cannot continue without doing the Captcha!", "Must complete Captcha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ULTRAUncheckedErrorLol()
        {
            MessageBox.Show("Captcha was not completed, closing program...", "Captcha not complete", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://example.com";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReturn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteAccountClicked(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text);
            button1.Text = buttonTexts[currentIndex];
            currentIndex = (currentIndex + 1) % buttonTexts.Length;

            if (!button1.Enabled)
            {
                MustHaveStuffErrorLol();
            }

            if (checkBox1.Checked)
            {
                if (button1.Text == "Loading...")
                {
                    Thread.Sleep(500);
                    AccountDeletionErrorLol();
                    this.Close();
                }
            }
            else
            {
                switch (currentIndex)
                {
                    case 2:
                        UncheckedErrorLol();
                        return;

                    case 3:
                        UncheckedErrorLol();
                        return;

                    case 4:
                        UncheckedErrorLol();
                        return;

                    case 5:
                        UncheckedErrorLol();
                        return;

                    case 6:
                        UncheckedErrorLol();
                        return;

                    case 7:
                        UncheckedErrorLol();
                        return;

                    case 8:
                        ULTRAUncheckedErrorLol();
                        this.Close();
                        return;
                }
            }
        }

        private void btnReturnClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClaimClicked(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            Cursor = Cursors.WaitCursor;
            Thread.Sleep(2000);
            ClaimErrorLol();
            Cursor = Cursors.Default;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool containsLetters = textBox1.Text.Any(char.IsLetter);
            button1.Enabled = containsLetters;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://example.com";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
