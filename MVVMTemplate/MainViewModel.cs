using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
// ReSharper disable InconsistentNaming

namespace MVVMTemplate;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private int count;
    
    partial void OnCountChanged(int value)
    {
        CountString = value switch
        {
            0 => "No clicks yet",
            1 => "Clicked once",
            2 => "Clicked twice",
            _ => $"Clicked {value} times!"
        };
    }

    [ObservableProperty]
    private string countString = "No clicks yet";
    
    [RelayCommand]
    private void OnCounterClicked()
    {
        Count++;
    } 
}