using App.Aplication.Client;
using App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Aplication.Clients
{
    public class GetClient
    {
        private ApplicationDbContext _dbContext;

        public GetClient(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ClientViewModel Do(int id) => _dbContext.Clients.Where(x => x.ID == id).Select(x => new ClientViewModel
        {
            Name = x.Name,
            Surname = x.Surname,
            BirthDate = x.BirthDate,
            Age = x.Age,
            City = x.City
        }
            ).FirstOrDefault();

    }
    /*
    public class ClientViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    */
}