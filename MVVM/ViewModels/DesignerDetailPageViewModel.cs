using System;
using CommunityToolkit.Mvvm.ComponentModel;
using DesignApp.MVVM.Models;


namespace DesignApp.MVVM.ViewModels
{
    [QueryProperty(nameof(Designer), "Designer")]
    public partial class DesignerDetailPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        Designer designer;



        public DesignerDetailPageViewModel()
        {

        }


    }
}

