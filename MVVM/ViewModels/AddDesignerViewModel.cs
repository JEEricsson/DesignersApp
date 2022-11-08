using System;
using CommunityToolkit.Mvvm.Input;
using DesignApp.MVVM.Models;
using DesignApp.MVVM.Views;

namespace DesignApp.MVVM.ViewModels
{
    public partial class AddDesignerViewModel : BaseViewModel
    {
        public Designer Designer { get; set; } = new Designer();


        public string SaveDesigner()
        {

            App.DesignerService.SaveItem(Designer);
            return App.DesignerService.StatusMessage;

        }

    }





}


