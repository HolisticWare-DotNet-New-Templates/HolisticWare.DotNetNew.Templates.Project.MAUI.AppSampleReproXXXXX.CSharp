namespace AppMAUI.DemoSample;

public partial class 
										AppShell
										:
										Shell
{
	public 
										AppShell
										(											
										)
	{
		InitializeComponent();

		Routing.RegisterRoute
					(
						"person", 
						typeof(UserInterface.Person.View.Page)
					);
		Routing.RegisterRoute
					(
						"datetime", 
						typeof(UserInterface.DateTime.View.Page)
					);
		Routing.RegisterRoute
					(
						"clock", 
						typeof(UserInterface.Clock.View.Page)
					);
		Routing.RegisterRoute
					(
						"biorythm", 
						typeof(UserInterface.Clock.View.Page)
					);
		Routing.RegisterRoute
					(
						"max_load_1rm", 
						typeof(UserInterface.Clock.View.Page)
					);
					

		return;
	}
}
