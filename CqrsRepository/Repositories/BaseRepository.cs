using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CqrsRepository.Repositories
{
    public class BaseRepository
    {
        public BaseRepository()
        {
            IMongoClient client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("CqrsSample");
            //var collection = 
        }
    }
}
