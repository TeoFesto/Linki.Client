namespace Linki.Client
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(this);
            signUpForm.Show();
            this.Hide();
        }

        private void AuthenticationForm_Load(object sender, EventArgs e)
        {
            Program.ConnectToServer(connectToServerStatusLabel);
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}