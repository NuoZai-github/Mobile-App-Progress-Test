namespace PT_Mobile_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ReadLess_Tapped(object sender, EventArgs e)
        {
            BioExpander.IsExpanded = false;
        }
    }
}