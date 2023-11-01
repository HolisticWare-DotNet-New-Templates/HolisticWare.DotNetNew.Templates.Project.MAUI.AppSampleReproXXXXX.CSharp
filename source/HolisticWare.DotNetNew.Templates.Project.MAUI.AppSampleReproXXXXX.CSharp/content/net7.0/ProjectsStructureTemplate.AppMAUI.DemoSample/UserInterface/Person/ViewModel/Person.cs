using System.ComponentModel;

namespace AppMAUI.DemoSample.UserInterface.ViewModels.MAUI.Simple;

public partial class 
                                        Person
                                        :
                                        INotifyPropertyChanged
{
    
    #region                             INotifyPropertyChanged
    public event 
        PropertyChangedEventHandler
                                        PropertyChanged;

    public
        void
                                        OnPropertyChanged
                                        (
                                            [System.Runtime.CompilerServices.CallerMemberName] 
                                            string name = ""
                                        )
                                        =>
                                        PropertyChanged?.Invoke
                                                            (
                                                                this, 
                                                                new PropertyChangedEventArgs(name)
                                                            );

    #endregion                          INotifyPropertyChanged
}
