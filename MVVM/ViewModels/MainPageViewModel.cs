using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DesignApp.MVVM.Models;
using DesignApp.MVVM.Views;

namespace DesignApp.MVVM.ViewModels
{

    public partial class MainPageViewModel : BaseViewModel
    {

        public ObservableCollection<Designer> Designers { get; set; } = new();

        public MainPageViewModel()
        {

            GetItems().Wait();
        }


        [RelayCommand]
        async Task GoToDetailPage(Designer designer)
        {
            if (designer == null) return;
            await Shell.Current.GoToAsync(nameof(DesignerDetailPage), true, new Dictionary<string, object>
            {
                {nameof(Designer), designer }
            });

        }

        [RelayCommand]
        async Task AddDesigner()
        {
            await Shell.Current.GoToAsync(nameof(AddDesignerPage));
        }
        [RelayCommand]
        async Task GetItems()
        {
            try
            {
                if (Designers.Any()) Designers.Clear();
                var designers = App.DesignerService.GetItems();
                Designers = new ObservableCollection<Designer>(designers);
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", "Failed to retriev data", "OK");
            }


        }


    }
}

