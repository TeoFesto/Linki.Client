using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linki.Client
{
    public partial class SignUpForm : Form, INavigable
    {
        public SignUpForm(Form previousForm)
        {
            PreviousForm = previousForm;
            InitializeComponent();
        }

        public Form PreviousForm { get; set; }

        private void previousFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }
    }
}
