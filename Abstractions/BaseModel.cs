using System;
using SQLite;

namespace DesignApp.Abstractions
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}

