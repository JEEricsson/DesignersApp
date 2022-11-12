using System;
using CommunityToolkit.Mvvm.Input;
using DesignApp.MVVM.Models;
using DesignApp.MVVM.Views;

namespace DesignApp.MVVM.ViewModels
{
    public partial class AddDesignerViewModel : BaseViewModel
    {
        public Designer Designer { get; set; } = new Designer();




        [RelayCommand]
        async Task Save()
        {
            App.DesignerService.SaveItem(Designer);
            await Shell.Current.DisplayAlert("Info", App.DesignerService.StatusMessage, "OK");
            await Shell.Current.Navigation.PopToRootAsync();
        }



    }





}


