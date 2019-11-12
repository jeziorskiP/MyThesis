using App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Aplication.Client
{
    public class DeleteClient
    {
        private ApplicationDbContext dbContext;
        public DeleteClient(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task Do(int ID)
        {
            var client = dbContext.Clients.FirstOrDefault(x => x.ID == ID);
            dbContext.Remove(client);
            await dbContext.SaveChangesAsync();
        }
    }



}
