namespace MauiAppHotel.Views;

public partial class ContrataçãodaHospedagem : ContentPage
{
	public ContrataçãodaHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContratada());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new SobreHospedagem());
		}
		catch (Exception ex)
		{
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
