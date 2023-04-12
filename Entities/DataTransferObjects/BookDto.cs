using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string IBAN { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Athor { get; set; }
        public string Description { get; set; }
        public string TimeOfIssue { get; set; }
        public string TimeOfReturn { get; set; }

    }

}
