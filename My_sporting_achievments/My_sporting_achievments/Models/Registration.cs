using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_sporting_achievments.Models
{
    public class Registration
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
