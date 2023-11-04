namespace AppMAUI.DemoSample;

public partial class 
										MainPage 
										: 
										ContentPage
{

	public 
										MainPage
										(											
										)
	{
		InitializeComponent();

		return;
	}

	private async
		void 
										OnClicked_Person
										(
											object sender, 
											EventArgs e
										)
	{
		/*

		*/
		// await Shell.Current.GoToAsync("//person");	// global route cannot be the only one
		await Shell.Current.GoToAsync("person");		// non global

		SemanticScreenReader.Announce(button_person.Text);

		return;
	}

	private async
		void 
										OnClicked_DateTime
										(
											object sender, 
											EventArgs e
										)
	{
		/*

		*/
		// await Shell.Current.GoToAsync("//person");	// global route cannot be the only one
		await Shell.Current.GoToAsync("datetime");		// non global

		SemanticScreenReader.Announce(button_datetime.Text);

		return;
	}

	private async
		void 
										OnClicked_Clock
										(
											object sender, 
											EventArgs e
										)
	{
		/*

		*/
		// await Shell.Current.GoToAsync("//person");	// global route cannot be the only one
		await Shell.Current.GoToAsync("clock");			// non global

		SemanticScreenReader.Announce(button_clock.Text);

		return;
	}

	private async
		void 
										OnClicked_BioRythm
										(
											object sender, 
											EventArgs e
										)
	{
		/*

		*/
		// await Shell.Current.GoToAsync("//person");	// global route cannot be the only one
		await Shell.Current.GoToAsync("biorythm");			// non global

		SemanticScreenReader.Announce(button_biorythm.Text);

		return;
	}

	private async
		void 
										OnClicked_MaxLoad1RM
										(
											object sender, 
											EventArgs e
										)
	{
		/*

		*/
		// await Shell.Current.GoToAsync("//person");	// global route cannot be the only one
		await Shell.Current.GoToAsync("max_load_1rm");			// non global

		SemanticScreenReader.Announce(button_max_load_1rm.Text);

		return;
	}
}

