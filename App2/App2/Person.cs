using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App2
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string CarNumber { get; set; }

    }
}
