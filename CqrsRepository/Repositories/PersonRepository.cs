using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cqrs.Domain.Contracts;
using Cqrs.Domain.Domain;
using MongoDB.Driver;

namespace CqrsRepository.Repositories
{
    public class PersonRepository:IPersonRepository
    {
       public async Task  InsertAsync(Person person, CancellationToken cancellation)
        {
            IMongoClient client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("CqrsSample");
            IMongoCollection<Person> collection = database.GetCollection<Person>("Person");
            await collection.InsertOneAsync(person, cancellationToken: cancellation ); // VER ANOTACAO NO BLOCO DE NOTAS - PASSAGEM DE PARAMETRO OPCIONAL,PASSA O (NOME DO PARAMETRO): " VALOR"

        }
    }
}
