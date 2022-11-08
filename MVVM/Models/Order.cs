using System;
using DesignApp.Abstractions;
using SQLite;

namespace DesignApp.MVVM.Models
{
    [Table("Orders")]
    public class Order : BaseModel
    {

        public int DesignerId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

