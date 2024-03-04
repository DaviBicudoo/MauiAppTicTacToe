namespace MauiAppTicTacToe
{
    public partial class MainPage : ContentPage
    {
        string turn = "O";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Button trigger = (Button)sender;

            trigger.IsEnabled = false;

            if(turn == "O")
            {
                trigger.Text = "O";
                turn = "X";
            } else
            {
                trigger.Text = "X";
                turn = "O";
            }
        }
    }
}
