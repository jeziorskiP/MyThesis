using App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Aplication.Client
{
    public class GetClients
    {
        private ApplicationDbContext _dbContext;

        public GetClients(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ClientViewModel> Do() => _dbContext.Clients.ToList().Select(x => new ClientViewModel
        
               {        Name = x.Name,
                        Surname = x.Surname,
                        BirthDate = x.BirthDate,
                        Age = x.Age,
                        City = x.City
                }
            );

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
    }*/
}