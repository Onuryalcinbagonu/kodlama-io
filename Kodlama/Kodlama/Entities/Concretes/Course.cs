using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.Entities.Concretes
{
    public class Course:BaseEntity<Guid>
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }
        public Guid InstractorId { get; set; }

    }
}
