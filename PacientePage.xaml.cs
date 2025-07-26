namespace MauiApp1.Pages;


public partial class PacientePage : ContentPage
{
    public PacientePage()
    {
        InitializeComponent();
        BindingContext = new SignosVitalesViewModel();
    }
}
