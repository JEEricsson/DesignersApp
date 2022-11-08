using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using CommunityToolkit.Mvvm.ComponentModel;
using DesignApp.MVVM.Models;

namespace DesignApp.MVVM.ViewModels
{

    public class MainPageViewModel : BaseViewModel
    {

        public ObservableCollection<Designer> Designers { get; set; }
        //Designers.CollectionChanged += Designers_CollectionChanged;
        public MainPageViewModel()
        {

            GetItems();


        }


        private void GetItems()
        {
            var designers = App.DesignerService.GetItems();
            Designers = new ObservableCollection<Designer>(designers);

        }


    }
}

