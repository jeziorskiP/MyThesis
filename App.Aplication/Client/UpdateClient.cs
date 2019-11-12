using App.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Aplication.Client
{
    public class UpdateClient
    {
        private ApplicationDbContext dbContext;

        public UpdateClient(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task Do(ClientViewModel viewModel)
        {
            await dbContext.SaveChangesAsync();
        }
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
