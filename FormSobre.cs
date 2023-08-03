namespace EditorTXT
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate(Application.StartupPath + @"sobre\index.html");
            Controls.Add(webBrowser);
        }
    }
}
