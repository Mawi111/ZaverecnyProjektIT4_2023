namespace Projekt_Koukal
{
    public partial class Form1 : Form
    {
        private User User { get; set; }
        public Form parentForm;
        
        public void Show(Form parentForm)
        {
            this.parentForm = parentForm;
            Show();
        }
        public Form1(User user)
        {
            User = user;
            InitializeComponent();
            lblUser.Text = User.Username;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

    }
}