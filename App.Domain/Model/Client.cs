using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Model
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
