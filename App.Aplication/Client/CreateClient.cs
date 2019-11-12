using App.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Aplication.Client
{
    public class CreateClient
    {
        private ApplicationDbContext _dbContext;
        public CreateClient(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Do(ClientViewModel viewModel)
        {
            _ = _dbContext.Clients.Add(new Domain.Model.Client
            {
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                BirthDate = viewModel.BirthDate,
                Age = viewModel.Age,
                City = viewModel.City
            });

            await _dbContext.SaveChangesAsync();
        }
    }

    public class ClientViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
