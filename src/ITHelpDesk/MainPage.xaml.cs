using ITHelpDesk.Configuration;

using Microsoft.Extensions.Configuration;

namespace ITHelpDesk;

public partial class MainPage : ContentPage
{
	public MainPage(IConfiguration configuration)
	{
		InitializeComponent();

		var itSupportPhone = configuration.GetRequiredSection(nameof(ItSupportPhone))
			.Get<ItSupportPhone>();

		NumberEntry.Text = itSupportPhone.PhoneNumber;
	}

	private void RadButton_Clicked(object sender, EventArgs e)
	{
		var number = NumberEntry.Text;

		if (PhoneDialer.Default.IsSupported)
		{
			PhoneDialer.Default.Open(number);
		}
	}
}

