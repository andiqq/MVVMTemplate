using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
// ReSharper disable InconsistentNaming

namespace MVVMTemplate;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private int count;
    
    [RelayCommand]
    private void OnCounterClicked()
    {
        Count++;
    } 
}