namespace ITHelpDesk;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void RadButton_Clicked(object sender, EventArgs e)
	{
		//https://docs.telerik.com/devtools/maui/get-started/install-nuget?_ga=2.30423935.1770633938.1665677395-1774374380.1553538507&_gl=1*w06kmc*_ga*MTc3NDM3NDM4MC4xNTUzNTM4NTA3*_ga_9JSNBCSF54*MTY2NTc2MzQyNy4yLjEuMTY2NTc2NDQwMC4wLjAuMA..
		var number = NumberEntry.Text;

		if (PhoneDialer.Default.IsSupported)
		{
			PhoneDialer.Default.Open(number);
		}

		SemanticScreenReader.Announce("yo");
	}
}

