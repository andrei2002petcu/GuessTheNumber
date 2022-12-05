namespace MauiWS1;

public partial class MainPage : ContentPage
{
    String s;

	public MainPage()
	{
		InitializeComponent();
	}

    private void entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        s = e.NewTextValue;
    }

    private void convert_btn_Clicked(object sender, EventArgs e)
    {
        double sum = 0;
        try
        {
            sum = Convert.ToDouble(s) * 4.92;
            display.Text = $"{sum:0.00} RON";
        }
        catch (FormatException)
        {
            display.Text = "Invalid format!";
        }
        
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("NewPage");
    }
}

