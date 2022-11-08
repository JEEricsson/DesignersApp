using System;
using CommunityToolkit.Mvvm.ComponentModel;
using DesignApp.Abstractions;
using SQLite;

namespace DesignApp.MVVM.Models
{

    public class Designer : BaseModel
    {


        public string Name { get; set; }

        public string Title { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string ShortDescription { get; set; }
    }
}

