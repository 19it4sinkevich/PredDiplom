using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Entities.Models
{
    public class Book
    {
        [Column("BookId")]
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
