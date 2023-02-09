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

        private async void AuthenticationForm_Load(object sender, EventArgs e)
        {
            Program.RunnedForms.Add(this);
            ServerCommunicator.AddConnectionLabel(connectToServerStatusLabel);
            Task.Run(ServerCommunicator.CheckConnectionToServer);
            Task.Run(ServerCommunicator.ReceiveResponses);
            Task.Run(ServerCommunicator.HandleResponses);
            Task.Run(ServerCommunicator.SendRequests);
        }

        private void signInButton_Click(object sender, EventArgs e)
        {

        }

        

        private void AuthenticationForm_Shown(object sender, EventArgs e)
        {

        }

        private void AuthenticationForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}