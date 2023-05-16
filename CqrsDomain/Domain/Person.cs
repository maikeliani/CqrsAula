using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Cqrs.Domain.Domain
{
        public class Person

        {
            public Person()
            {
                Id = Guid.NewGuid();
                CreatedAt = DateTime.Now;
                UpdatedAt = DateTime.Now;

            }


            public Guid Id { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public String Name { get; set; }
            public string CPF { get; set; }
            public string Email { get; set; }
            public DateTime DateBirth { get; set; }
        }

    }



